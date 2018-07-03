using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Rep
{
    class CLS_REP
    {
        #region var
        public int Rep_ID;
        public string Name;
        public string Content;
        public int Row_Count;
        public bool Row_Index;
        public int Font_Size;
        public string Rep_View;
        public int User_ID;
        public DataTable Rep_D;
        #endregion

        public DataTable Select(string txt)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable rep = new DataTable();
            rep = DAL.Selectrep(txt);

            return rep;
        }
        public DataTable Select_Rep_Info(string Column_Name, string Data_Type)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Column_Name", SqlDbType.NVarChar, 30);
            param[0].Value = Column_Name;

            param[1] = new SqlParameter("@Data_Type", SqlDbType.VarChar, 10);
            param[1].Value = Data_Type;

            DataTable rep = new DataTable();
            rep = DAL.SelectData("Rep_Info", param);

            return rep;
        }

        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Rep_Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Content", SqlDbType.NVarChar,500);
            param[1].Value = Content;

            param[2] = new SqlParameter("@Row_Count", SqlDbType.Int);
            param[2].Value = Row_Count;

            param[3] = new SqlParameter("@Row_Index", SqlDbType.Bit);
            param[3].Value = Row_Index;

            param[4] = new SqlParameter("@Font_Size", SqlDbType.Int);
            param[4].Value = Font_Size;

            param[5] = new SqlParameter("@Rep_View", SqlDbType.NVarChar,15);
            param[5].Value = Rep_View;

            param[6] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[6].Value = User_ID;

            param[7] = new SqlParameter("@Rep_D", SqlDbType.Structured);
            param[7].Value = Rep_D;

            string F;
            F = DAL.ExecuteCommand("Rep_Insert", param);

            DAL.Close();

            return F;
        }
        public DataTable Select_Rep(string Rep_Name)
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable rep = new DataTable();
            rep = DAL.Selectrep(Rep_Name);

            return rep;
        }
        public string Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Rep_ID", SqlDbType.Int);
            param[0].Value = Rep_ID;

            string F;
            F = DAL.ExecuteCommand("Rep_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
