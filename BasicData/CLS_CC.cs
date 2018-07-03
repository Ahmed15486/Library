using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_CC
    {
        #region var
        public string CC_ID;
        public string CC_Name;
        public string Parent_ID;
        public int CC_Level;
        public string Branche;
        public bool CC1;
        public bool CC2;
        public string Notes;
        public int User_ID;
        #endregion
            
        public DataTable Select()
        {
            var DAL = new DAL.DAL();

            var CC = new DataTable();
            CC = DAL.SelectData("CC_Select", null);

            return CC;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@CC_Name", SqlDbType.NVarChar, 50);
            param[0].Value = CC_Name;

            param[1] = new SqlParameter("@Parent_ID", SqlDbType.VarChar);
            param[1].Value = Parent_ID;

            param[2] = new SqlParameter("@CC_Level", SqlDbType.Int);
            param[2].Value = CC_Level;

            param[3] = new SqlParameter("@Branche", SqlDbType.VarChar,3);
            param[3].Value = Branche;

            param[4] = new SqlParameter("@CC1", SqlDbType.Bit);
            param[4].Value = CC1;

            param[5] = new SqlParameter("@CC2", SqlDbType.Bit);
            param[5].Value = CC2;

            param[6] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[6].Value = Notes;

            param[7] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[7].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("CC_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@CC_ID", SqlDbType.VarChar);
            param[0].Value = CC_ID;

            param[1] = new SqlParameter("@CC_Name", SqlDbType.NVarChar, 50);
            param[1].Value = CC_Name;

            param[2] = new SqlParameter("@Branche", SqlDbType.VarChar, 3);
            param[2].Value = Branche;

            param[3] = new SqlParameter("@CC1", SqlDbType.Bit);
            param[3].Value = CC1;

            param[4] = new SqlParameter("@CC2", SqlDbType.Bit);
            param[4].Value = CC2;

            param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param[5].Value = Notes;

            param[6] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[6].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("CC_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string CC_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CC_ID", SqlDbType.VarChar);
            param[0].Value = CC_ID;

            string F;
            F = DAL.ExecuteCommand("CC_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
