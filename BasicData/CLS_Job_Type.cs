using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_Job_Type
    {
        public DataTable Job_Type_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Job_Type = new DataTable();
            Job_Type = DAL.SelectData("Sp_Job_Type_Select", null);

            return Job_Type;
        }

        public string Job_Type_Insert(
             string Job_Type_Name
           , int User_ID
           )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Job_Type_Name", SqlDbType.NVarChar, 50);
            param[0].Value = Job_Type_Name;

            param[1] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[1].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Job_Type_Insert", param);

            DAL.Close();

            return F;
        }

        public string Job_Type_Update(
             int Job_Type_ID
           , string Job_Type_Name
           , int User_ID
            )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Job_Type_ID", SqlDbType.Int);
            param[0].Value = Job_Type_ID;

            param[1] = new SqlParameter("@Job_Type_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Job_Type_Name;

            param[2] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[2].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Job_Type_Update", param);

            DAL.Close();

            return F;
        }

        public string Job_Type_Delete(string Job_Type_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Job_Type_ID", SqlDbType.NVarChar, 50);
            param[0].Value = Job_Type_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Job_Type_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
