using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Money_Out
    {
        #region var
        public string Money_Out_ID;
        public string Jor_ID;
        public DateTime Money_Out_Date;
        public int Pay_Type;
        public string ACC_ID;
        public decimal Value;
        public string Notes;
        public string Branche_ID;
        public int Store_ID;
        public int CC1_ID;
        public int CC2_ID;
        public int User_ID;
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Money_Out = new DataTable();
            Money_Out = DAL.SelectData("Money_Out_Select", null);

            return Money_Out;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Money_Out_Date", SqlDbType.DateTime);
            param[0].Value = Money_Out_Date;

            param[1] = new SqlParameter("@Pay_Type", SqlDbType.Int);
            param[1].Value = Pay_Type;

            param[2] = new SqlParameter("@ACC_ID", SqlDbType.NVarChar, 50);
            param[2].Value = ACC_ID;

            param[3] = new SqlParameter("@Value", SqlDbType.Decimal);
            param[3].Value = Value;

            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
            param[4].Value = Notes;

            param[5] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[5].Value = Branche_ID;

            param[6] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[6].Value = Store_ID;

            param[7] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[7].Value = CC1_ID;

            param[8] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[8].Value = CC2_ID;

            param[9] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[9].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Money_Out_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Money_Out_ID", SqlDbType.VarChar,10);
            param[0].Value = Money_Out_ID;

            param[1] = new SqlParameter("@Money_Out_Date", SqlDbType.DateTime);
            param[1].Value = Money_Out_Date;

            param[2] = new SqlParameter("@Pay_Type", SqlDbType.Int);
            param[2].Value = Pay_Type;

            param[3] = new SqlParameter("@ACC_ID", SqlDbType.NVarChar, 50);
            param[3].Value = ACC_ID;

            param[4] = new SqlParameter("@Value", SqlDbType.Decimal);
            param[4].Value = Value;

            param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
            param[5].Value = Notes;

            param[6] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[6].Value = Branche_ID;

            param[7] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[7].Value = Store_ID;

            param[8] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[8].Value = CC1_ID;

            param[9] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[9].Value = CC2_ID;

            param[10] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[10].Value = User_ID;

            string F;
            F = DAL.ExecuteCommand("Money_Out_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Money_Out_ID", SqlDbType.VarChar, 10);
            param[0].Value = Money_Out_ID;

            string F;
            F = DAL.ExecuteCommand("Money_Out_Delete", param);

            DAL.Close();

            return F;
        }

    }
}
