using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_ACC
    {
        #region var
        public string ACC_ID;
        public string ACC_Name;
        public string Enm;
        public string CC1;
        public bool CC1_Group;
        public string CC2;
        public bool CC2_Group;
        public string Notes;
        public int ACC_Proper_ID;
        public string Parent_ID;
        public int Sheet;
        public string Sheet_Parent;
        public int ACC_Level;
        public int User_ID;
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable ACC = new DataTable();
            ACC = DAL.SelectData("ACC_Select", null);

            return ACC;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@ACC_Name", SqlDbType.NVarChar, 50);
            param[0].Value = ACC_Name;

            param[1] = new SqlParameter("@Enm", SqlDbType.NVarChar, 50);
            param[1].Value = Enm;

            param[2] = new SqlParameter("@CC1", SqlDbType.VarChar, 50);
            param[2].Value = CC1;

            param[3] = new SqlParameter("@CC1_Group", SqlDbType.Bit);
            param[3].Value = CC1_Group;

            param[4] = new SqlParameter("@CC2", SqlDbType.VarChar, 50);
            param[4].Value = CC2;

            param[5] = new SqlParameter("@CC2_Group", SqlDbType.Bit);
            param[5].Value = CC2_Group;

            param[6] = new SqlParameter("@Parent_ID", SqlDbType.VarChar, 50);
            param[6].Value = Parent_ID;

            param[7] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
            param[7].Value = Notes;

            param[8] = new SqlParameter("@ACC_Proper_ID", SqlDbType.Int);
            param[8].Value = ACC_Proper_ID;

            param[9] = new SqlParameter("@Sheet", SqlDbType.Int);
            param[9].Value = Sheet;

            param[10] = new SqlParameter("@Sheet_Parent", SqlDbType.VarChar, 50);
            param[10].Value = Sheet_Parent;

            param[11] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[11].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("ACC_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@ACC_ID", SqlDbType.VarChar, 50);
            param[0].Value = ACC_ID;

            param[1] = new SqlParameter("@Enm", SqlDbType.NVarChar, 50);
            param[1].Value = Enm;

            param[2] = new SqlParameter("@CC1", SqlDbType.VarChar, 50);
            param[2].Value = CC1;

            param[3] = new SqlParameter("@CC1_Group", SqlDbType.Bit);
            param[3].Value = CC1_Group;

            param[4] = new SqlParameter("@CC2", SqlDbType.VarChar, 50);
            param[4].Value = CC2;

            param[5] = new SqlParameter("@CC2_Group", SqlDbType.Bit);
            param[5].Value = CC2_Group;

            param[6] = new SqlParameter("@ACC_Name", SqlDbType.NVarChar, 50);
            param[6].Value = ACC_Name;

            param[7] = new SqlParameter("@Parent_ID", SqlDbType.VarChar, 50);
            param[7].Value = Parent_ID;

            param[8] = new SqlParameter("@ACC_Proper_ID", SqlDbType.Int);
            param[8].Value = ACC_Proper_ID;

            param[9] = new SqlParameter("@Sheet", SqlDbType.Int);
            param[9].Value = Sheet;

            param[10] = new SqlParameter("@Sheet_Parent", SqlDbType.VarChar, 50);
            param[10].Value = Sheet_Parent;

            param[11] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
            param[11].Value = Notes;

            param[12] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[12].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("ACC_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string ACC_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ACC_ID", SqlDbType.VarChar, 50);
            param[0].Value = ACC_ID;

            string F;
            F = DAL.ExecuteCommand("ACC_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
