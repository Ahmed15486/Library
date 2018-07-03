using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_SalRe
    {
        #region Var
        // Head var
        public string Branche_ID;
        public int Store_ID;
        public string CC1_ID;
        public string CC2_ID;
        public int User_ID;

        public string Bill_ID;
        public string Cust_ID;
        public int B_Type;
        public DateTime SalRe_Date;
        public string SalRe_OSalRe;
        public string Notes;
        public int Currency;
        public decimal Currency_Rate;
        public decimal Total;
        public decimal Total_Dis_Rate;
        public decimal Total_Dis_Value;
        public decimal Net;
        public decimal Total_SP;
        public DataTable dt_IO;
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Open = new DataTable();
            Open = DAL.SelectData("SalRe_Select", null);

            return Open;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[0].Value = Branche_ID;

            param[1] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[1].Value = Store_ID;

            param[2] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[2].Value = CC1_ID;

            param[3] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[3].Value = CC2_ID;

            param[4] = new SqlParameter("@Cust_ID", SqlDbType.NVarChar, 50);
            param[4].Value = Cust_ID;

            param[5] = new SqlParameter("@SalRe_B_Type", SqlDbType.Int);
            param[5].Value = B_Type;

            param[6] = new SqlParameter("@SalRe_Date", SqlDbType.DateTime);
            param[6].Value = SalRe_Date;

            param[7] = new SqlParameter("@SalRe_OSalRe", SqlDbType.VarChar, 50);
            param[7].Value = SalRe_OSalRe;

            param[8] = new SqlParameter("@SalRe_Notes", SqlDbType.NVarChar, 50);
            param[8].Value = Notes;

            param[9] = new SqlParameter("@Currency", SqlDbType.Int);
            param[9].Value = Currency;

            param[10] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[10].Value = Currency_Rate;

            param[11] = new SqlParameter("@SalRe_Total", SqlDbType.Decimal);
            param[11].Value = Total;

            param[12] = new SqlParameter("@SalRe_Total_Dis_Rate", SqlDbType.Decimal);
            param[12].Value = Total_Dis_Rate;

            param[13] = new SqlParameter("@SalRe_Total_Dis_Value", SqlDbType.Decimal);
            param[13].Value = Total_Dis_Value;

            param[14] = new SqlParameter("@SalRe_Net", SqlDbType.Decimal);
            param[14].Value = Net;

            param[15] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[15].Value = User_ID;

            param[16] = new SqlParameter("@dt_SalRe_IO", SqlDbType.Structured);
            param[16].Value = dt_IO;

            string F;
            F = DAL.ExecuteCommand("SalRe_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[18];

            param[0] = new SqlParameter("@SalRe_ID", SqlDbType.VarChar, 10);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[1].Value = Branche_ID;

            param[2] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[2].Value = Store_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@Cust_ID", SqlDbType.NVarChar, 50);
            param[5].Value = Cust_ID;

            param[6] = new SqlParameter("@SalRe_B_Type", SqlDbType.Int);
            param[6].Value = B_Type;

            param[7] = new SqlParameter("@SalRe_Date", SqlDbType.DateTime);
            param[7].Value = SalRe_Date;

            param[8] = new SqlParameter("@Currency", SqlDbType.Int);
            param[8].Value = Currency;

            param[9] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[9].Value = Currency_Rate;

            param[10] = new SqlParameter("@SalRe_OSalRe", SqlDbType.VarChar, 50);
            param[10].Value = SalRe_OSalRe;

            param[11] = new SqlParameter("@SalRe_Notes", SqlDbType.NVarChar, 50);
            param[11].Value = Notes;

            param[12] = new SqlParameter("@SalRe_Total", SqlDbType.Decimal);
            param[12].Value = Total;

            param[13] = new SqlParameter("@SalRe_Total_Dis_Rate", SqlDbType.Decimal);
            param[13].Value = Total_Dis_Rate;

            param[14] = new SqlParameter("@SalRe_Total_Dis_Value", SqlDbType.Decimal);
            param[14].Value = Total_Dis_Value;

            param[15] = new SqlParameter("@SalRe_Net", SqlDbType.Decimal);
            param[15].Value = Net;

            param[16] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[16].Value = User_ID;

            param[17] = new SqlParameter("@dt_SalRe_IO", SqlDbType.Structured);
            param[17].Value = dt_IO;

            string F;
            F = DAL.ExecuteCommand("SalRe_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SalRe_ID", SqlDbType.VarChar, 10);
            param[0].Value = Bill_ID;

            string F;
            F = DAL.ExecuteCommand("SalRe_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
