using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Jor
    {
        #region var
        public string Jor_ID;
        public DateTime Date;
        public string Notes;
        public bool ALL_Branches;
        public string Branche_ID;
        public string CC1_ID;
        public string CC2_ID;
        public int User_ID;
        public int Currency;
        public decimal Currency_Rate;
        public int Jor_Type;
        public DataTable dt_Jor_D;
        #endregion

        public string Jor_Close()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;

            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
            param[1].Value = Notes;

            param[2] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[2].Value = Branche_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[5].Value = User_ID;

            param[6] = new SqlParameter("@Currency", SqlDbType.Int);
            param[6].Value = Currency;

            param[7] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[7].Value = Currency_Rate;

            param[8] = new SqlParameter("@ALL_Branches", SqlDbType.Bit);
            param[8].Value = ALL_Branches;

            string F;
            F = DAL.ExecuteCommand("Jor_Close", param);

            DAL.Close();

            return F;
        }
        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Jor_Select", null);

            return dt;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;

            param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
            param[1].Value = Notes;

            param[2] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[2].Value = Branche_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.VarChar,50);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.VarChar,50);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[5].Value = User_ID;

            param[6] = new SqlParameter("@Currency", SqlDbType.Int);
            param[6].Value = Currency;

            param[7] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[7].Value = Currency_Rate;

            param[8] = new SqlParameter("@Jor_Type", SqlDbType.Int);
            param[8].Value = Jor_Type;

            param[9] = new SqlParameter("@dt_Jor_D", SqlDbType.Structured);
            param[9].Value = dt_Jor_D;

            string F;
            F = DAL.ExecuteCommand("Jor_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Jor_ID", SqlDbType.VarChar,10);
            param[0].Value = Jor_ID;

            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
            param[2].Value = Notes;

            param[3] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[3].Value = Branche_ID;

            param[4] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[4].Value = CC1_ID;

            param[5] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[5].Value = CC2_ID;

            param[6] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[6].Value = User_ID;

            param[7] = new SqlParameter("@Currency", SqlDbType.Int);
            param[7].Value = Currency;

            param[8] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[8].Value = Currency_Rate;

            param[9] = new SqlParameter("@Jor_Type", SqlDbType.Int);
            param[9].Value = Jor_Type;

            param[10] = new SqlParameter("@dt_Jor_D", SqlDbType.Structured);
            param[10].Value = dt_Jor_D;

            string F;
            F = DAL.ExecuteCommand("Jor_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_ID", SqlDbType.VarChar,10);
            param[0].Value = Jor_ID;

            string F;
            F = DAL.ExecuteCommand("Jor_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
