using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DAL
{
    class DAL
    {
        SqlConnection sqlconnection;

        // This Constractor Inisialize The connection object
        public DAL()
        {
            if (Properties.Settings.Default.Mode == "Windows")
            {           	
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=True");
            }
            else
            {          	            	            	
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=False; User ID="+
                                                      Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password);
            }
        }

        // Method to open the connecton
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();

                if (sqlconnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection currently {0} when it should be open.","Data Access Open",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
        }

        // Method to close the connecton
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        public DataSet Select_ALL(string stord_procedure)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stord_procedure;
                sqlcmd.Connection = sqlconnection;

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return ds;
        }
        public DataSet Select_ALL(string stord_procedure, SqlParameter[] param)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stord_procedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return ds;
        }

        // Method To Read Data From Database
        public DataTable SelectData(string stord_procedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stord_procedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);              
                da.Fill(dt);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return dt;
        }

        public DataTable Selectrep(string txt)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = txt;
            sqlcmd.Connection = sqlconnection;

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // Method To Insert, Update and Delete Data From Database
        public string ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            string s;
            try
            {             
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }

                foreach (IDataParameter p in sqlcmd.Parameters)
                {
                    if (p.Value == null) p.Value = DBNull.Value;
                }
                s = (string)sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExecuteCommand", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                s = "!" + ex.Message;
            }
            return s;
        }      
    }
}
