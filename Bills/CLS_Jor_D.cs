using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Jor_D
    {
        public DataTable Jor_D_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Jor_D_Select", null);

            return dt;
        }

        public DataTable Jor_D_Select_LastJor_D(int Jor_D_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_D_ID", SqlDbType.Int);
            param[0].Value = Jor_D_ID;

            DataTable Open = new DataTable();
            Open = DAL.SelectData("Jor_D_Select_LastJor_D", param);

            return Open;
        }

        public DataTable Jor_D_Select_LastIO(int Jor_D_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_D_ID", SqlDbType.Int);
            param[0].Value = Jor_D_ID;

            DataTable Open = new DataTable();
            Open = DAL.SelectData("Jor_D_Select_LastIO", param);

            return Open;
        }

        public string Jor_D_Insert(
             int Branche_ID
           , int Store_ID
           , int CC1_ID
           , int CC2_ID
           , string Ven_ID
           , string Jor_D_B_Type
           , string Jor_D_Jor_D_No
           , DateTime Jor_D_Jor_D_Date
           , DateTime Jor_D_Date
           , string Jor_D_Notes
           , decimal Jor_D_Total
           , decimal Jor_D_Total_Dis_Rate
           , decimal Jor_D_Total_Dis_Value
           , decimal Jor_D_Net
           , decimal Jor_D_Total_SPrice
           , int User_ID
           , DataTable dt_Items
            )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@Branche_ID", SqlDbType.Int);
            param[0].Value = Branche_ID;

            param[1] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[1].Value = Store_ID;

            param[2] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[2].Value = CC1_ID;

            param[3] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[3].Value = CC2_ID;

            param[4] = new SqlParameter("@Ven_ID", SqlDbType.NVarChar, 50);
            param[4].Value = Ven_ID;

            param[5] = new SqlParameter("@Jor_D_B_Type", SqlDbType.NVarChar, 50);
            param[5].Value = Jor_D_B_Type;

            param[6] = new SqlParameter("@Jor_D_Jor_D_No", SqlDbType.NVarChar, 50);
            param[6].Value = Jor_D_Jor_D_No;

            param[7] = new SqlParameter("@Jor_D_Jor_D_Date", SqlDbType.DateTime);
            param[7].Value = Jor_D_Jor_D_Date;

            param[8] = new SqlParameter("@Jor_D_Date", SqlDbType.DateTime);
            param[8].Value = Jor_D_Date;

            param[9] = new SqlParameter("@Jor_D_Notes", SqlDbType.NVarChar, 50);
            param[9].Value = Jor_D_Notes;

            param[10] = new SqlParameter("@Jor_D_Total", SqlDbType.Decimal);
            param[10].Value = Jor_D_Total;

            param[11] = new SqlParameter("@Jor_D_Total_Dis_Rate", SqlDbType.Decimal);
            param[11].Value = Jor_D_Total_Dis_Rate;

            param[12] = new SqlParameter("@Jor_D_Total_Dis_Value", SqlDbType.Decimal);
            param[12].Value = Jor_D_Total_Dis_Value;

            param[13] = new SqlParameter("@Jor_D_Net", SqlDbType.Decimal);
            param[13].Value = Jor_D_Net;

            param[14] = new SqlParameter("@Jor_D_Total_SPrice", SqlDbType.Decimal);
            param[14].Value = Jor_D_Total_SPrice;

            param[15] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[15].Value = User_ID;

            param[16] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[16].Value = dt_Items;

            string F;
            F = DAL.ExecuteCommand("Sp_Jor_D_Insert", param);

            DAL.Close();

            return F;
        }


        public string Jor_D_Update(
             int Jor_D_ID
           , int Branche_ID
           , int Store_ID
           , int CC1_ID
           , int CC2_ID
           , string Ven_ID
           , string Jor_D_B_Type
           , string Jor_D_Jor_D_No
           , DateTime Jor_D_Jor_D_Date
           , DateTime Jor_D_Date
           , string Jor_D_Notes
           , decimal Jor_D_Total
           , decimal Jor_D_Total_Dis_Rate
           , decimal Jor_D_Total_Dis_Value
           , decimal Jor_D_Net
           , decimal Jor_D_Total_SPrice
           , int User_ID
           , DataTable dt_Items
            )
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[18];

            param[0] = new SqlParameter("@Jor_D_ID", SqlDbType.Int);
            param[0].Value = Jor_D_ID;

            param[1] = new SqlParameter("@Branche_ID", SqlDbType.Int);
            param[1].Value = Branche_ID;

            param[2] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[2].Value = Store_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@Ven_ID", SqlDbType.NVarChar, 50);
            param[5].Value = Ven_ID;

            param[6] = new SqlParameter("@Jor_D_B_Type", SqlDbType.NVarChar, 50);
            param[6].Value = Jor_D_B_Type;

            param[7] = new SqlParameter("@Jor_D_Jor_D_No", SqlDbType.NVarChar, 50);
            param[7].Value = Jor_D_Jor_D_No;

            param[8] = new SqlParameter("@Jor_D_Jor_D_Date", SqlDbType.DateTime);
            param[8].Value = Jor_D_Jor_D_Date;

            param[9] = new SqlParameter("@Jor_D_Date", SqlDbType.DateTime);
            param[9].Value = Jor_D_Date;

            param[10] = new SqlParameter("@Jor_D_Notes", SqlDbType.NVarChar, 50);
            param[10].Value = Jor_D_Notes;

            param[11] = new SqlParameter("@Jor_D_Total", SqlDbType.Decimal);
            param[11].Value = Jor_D_Total;

            param[12] = new SqlParameter("@Jor_D_Total_Dis_Rate", SqlDbType.Decimal);
            param[12].Value = Jor_D_Total_Dis_Rate;

            param[13] = new SqlParameter("@Jor_D_Total_Dis_Value", SqlDbType.Decimal);
            param[13].Value = Jor_D_Total_Dis_Value;

            param[14] = new SqlParameter("@Jor_D_Net", SqlDbType.Decimal);
            param[14].Value = Jor_D_Net;

            param[15] = new SqlParameter("@Jor_D_Total_SPrice", SqlDbType.Decimal);
            param[15].Value = Jor_D_Total_SPrice;

            param[16] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[16].Value = User_ID;

            param[17] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[17].Value = dt_Items;

            string F;
            F = DAL.ExecuteCommand("Sp_Jor_D_Update", param);

            DAL.Close();

            return F;
        }


        public string Jor_D_Delete(int Jor_D_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_D_ID", SqlDbType.Int);
            param[0].Value = Jor_D_ID;

            string F;
            F = DAL.ExecuteCommand("Sp_Jor_D_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
