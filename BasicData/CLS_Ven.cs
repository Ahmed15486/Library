using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_Ven
    {
        #region var
        public string ID;
        public string Name;
        public string Address;
        public string Mobile;
        public string Phone;
        public string Notes;
        public string Ven_ACC;
        public int User_ID;
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Ven = new DataTable();
            Ven = DAL.SelectData("Ven_Select", null);

            return Ven;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Ven_Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Ven_Address", SqlDbType.NVarChar, 50);
            param[1].Value = Address;

            param[2] = new SqlParameter("@Ven_Mobile", SqlDbType.VarChar, 20);
            param[2].Value = Mobile;

            param[3] = new SqlParameter("@Ven_Phone", SqlDbType.VarChar, 20);
            param[3].Value = Phone;

            param[4] = new SqlParameter("@Ven_Notes", SqlDbType.NVarChar, 50);
            param[4].Value = Notes;

            param[5] = new SqlParameter("@Ven_ACC", SqlDbType.VarChar, 50);
            param[5].Value = Ven_ACC;

            param[6] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[6].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Ven_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Ven_ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Ven_Name", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Ven_Address", SqlDbType.NVarChar, 50);
            param[2].Value = Address;

            param[3] = new SqlParameter("@Ven_Mobile", SqlDbType.VarChar, 20);
            param[3].Value = Mobile;

            param[4] = new SqlParameter("@Ven_Phone", SqlDbType.VarChar, 20);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Ven_Notes", SqlDbType.NVarChar, 50);
            param[5].Value = Notes;

            param[6] = new SqlParameter("@Ven_ACC", SqlDbType.VarChar, 50);
            param[6].Value = Ven_ACC;

            param[7] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[7].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Ven_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Ven_ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            string F;
            F = DAL.ExecuteCommand("Ven_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
