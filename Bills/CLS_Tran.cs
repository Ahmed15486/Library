using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Tran
    {
        #region var
        public string Branche_ID;
        public int Store_ID;
        public int CC1_ID;
        public int CC2_ID;
        public int User_ID;
        public string Tran_ID;
        public DateTime Tran_Date;
        public string To_Branche;
        public int To_Store;
        public int Emp_ID;
        public string Tran_Notes;
        public decimal Tran_Total_CPrice;
        public decimal Tran_Total_PPrice;
        public DataTable dt_IO;
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Tran = new DataTable();
            Tran = DAL.SelectData("Tran_Select", null);

            return Tran;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[0].Value = Branche_ID;

            param[1] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[1].Value = Store_ID;

            param[2] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[2].Value = CC1_ID;

            param[3] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[3].Value = CC2_ID;

            param[4] = new SqlParameter("@Tran_Date", SqlDbType.DateTime);
            param[4].Value = Tran_Date;

            param[5] = new SqlParameter("@To_Branche", SqlDbType.VarChar, 3);
            param[5].Value = To_Branche;

            param[6] = new SqlParameter("@To_Store", SqlDbType.Int);
            param[6].Value = To_Store;

            param[7] = new SqlParameter("@Emp_ID", SqlDbType.NVarChar, 50);
            param[7].Value = Emp_ID;

            param[8] = new SqlParameter("@Tran_Notes", SqlDbType.NVarChar, 50);
            param[8].Value = Tran_Notes;

            param[9] = new SqlParameter("@Tran_Total_CPrice", SqlDbType.Decimal);
            param[9].Value = Tran_Total_CPrice;

            param[10] = new SqlParameter("@Tran_Total_PPrice", SqlDbType.Decimal);
            param[10].Value = Tran_Total_PPrice;

            param[11] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[11].Value = User_ID;

            param[12] = new SqlParameter("@dt_IO", SqlDbType.Structured);
            param[12].Value = dt_IO;

            string F;
            F = DAL.ExecuteCommand("Tran_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@Tran_ID", SqlDbType.VarChar, 10);
            param[0].Value = Tran_ID;

            param[1] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[1].Value = Branche_ID;

            param[2] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[2].Value = Store_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@Tran_Date", SqlDbType.DateTime);
            param[5].Value = Tran_Date;

            param[6] = new SqlParameter("@To_Branche", SqlDbType.VarChar, 3);
            param[6].Value = To_Branche;

            param[7] = new SqlParameter("@To_Store", SqlDbType.Int);
            param[7].Value = To_Store;

            param[8] = new SqlParameter("@Emp_ID", SqlDbType.NVarChar, 50);
            param[8].Value = Emp_ID;

            param[9] = new SqlParameter("@Tran_Notes", SqlDbType.NVarChar, 50);
            param[9].Value = Tran_Notes;

            param[10] = new SqlParameter("@Tran_Total_CPrice", SqlDbType.Decimal);
            param[10].Value = Tran_Total_CPrice;

            param[11] = new SqlParameter("@Tran_Total_PPrice", SqlDbType.Decimal);
            param[11].Value = Tran_Total_PPrice;

            param[12] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[12].Value = User_ID;

            param[13] = new SqlParameter("@dt_IO", SqlDbType.Structured);
            param[13].Value = dt_IO;

            string F;
            F = DAL.ExecuteCommand("Tran_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string Tran_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Tran_ID", SqlDbType.VarChar, 10);
            param[0].Value = Tran_ID;

            string F;
            F = DAL.ExecuteCommand("Tran_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
