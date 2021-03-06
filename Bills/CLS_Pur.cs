﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Pur
    {
        #region Var
        // Head var
       public string Branche_ID;
       public int Store_ID;
       public string CC1_ID;
       public string CC2_ID;
       public string Bill_ID;
       public string Ven_ID;
       public int Pur_B_Type;
       public string Pur_Pur_No;
       public DateTime? Pur_Pur_Date;
       public DateTime Pur_Date;
       public string Pur_Notes;
       public int Currency;
       public decimal Currency_Rate;
       public decimal Pur_Total;
       public decimal Pur_Total_Dis_Rate;
       public decimal Pur_Total_Dis_Value;
       public decimal Pur_Net;
       public decimal Pur_Total_SPrice;
       public int User_ID;
       public DataTable dt_Items;

       // Details var
       public string Item_ID;
       public string Item_Name;
       public decimal Item_Quan;
       public decimal Item_Bonus;
       public decimal Item_PPrice;
       public decimal Item_SPrice;
       decimal item_dis_rate;
       decimal item_dis_value;
       public decimal Item_Net;

        // Proberties
        public decimal Item_Dis_Value
        {
            set { item_dis_value = value; }
            get 
            {
                if (item_dis_value != 0) {return item_dis_value;  }
                else { return 0; }           
            }
        }
        public decimal Item_Dis_Rate
        {
            set { item_dis_rate = value; }
            get
            {
                if (item_dis_rate != 0) { return item_dis_rate; }
                else { return 0; }
            }
        }
        #endregion

        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Pur = new DataTable();
            Pur = DAL.SelectData("Pur_Select", null);

            return Pur;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[19];

            param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[0].Value = Branche_ID;

            param[1] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[1].Value = Store_ID;

            param[2] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[2].Value = CC1_ID;

            param[3] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[3].Value = CC2_ID;

            param[4] = new SqlParameter("@Ven_ID", SqlDbType.NVarChar,50);
            param[4].Value = Ven_ID;

            param[5] = new SqlParameter("@Pur_B_Type", SqlDbType.Int);
            param[5].Value = Pur_B_Type;

            param[6] = new SqlParameter("@Pur_Pur_No", SqlDbType.NVarChar, 50);
            param[6].Value = Pur_Pur_No;

            param[7] = new SqlParameter("@Pur_Pur_Date", SqlDbType.DateTime);
            param[7].Value = Pur_Pur_Date;

            param[8] = new SqlParameter("@Pur_Date", SqlDbType.DateTime);
            param[8].Value = Pur_Date;

            param[9] = new SqlParameter("@Pur_Notes", SqlDbType.NVarChar, 50);
            param[9].Value = Pur_Notes;

            param[10] = new SqlParameter("@Currency", SqlDbType.Int);
            param[10].Value = Currency;

            param[11] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[11].Value = Currency_Rate;

            param[12] = new SqlParameter("@Pur_Total", SqlDbType.Decimal);
            param[12].Value = Pur_Total;

            param[13] = new SqlParameter("@Pur_Total_Dis_Rate", SqlDbType.Decimal);
            param[13].Value = Pur_Total_Dis_Rate;

            param[14] = new SqlParameter("@Pur_Total_Dis_Value", SqlDbType.Decimal);
            param[14].Value = Pur_Total_Dis_Value;

            param[15] = new SqlParameter("@Pur_Net", SqlDbType.Decimal);
            param[15].Value = Pur_Net;

            param[16] = new SqlParameter("@Pur_Total_SPrice", SqlDbType.Decimal);
            param[16].Value = Pur_Total_SPrice;

            param[17] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[17].Value = User_ID;

            param[18] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[18].Value = dt_Items;

            string F;
            F = DAL.ExecuteCommand("Pur_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[20];

            param[0] = new SqlParameter("@Pur_ID", SqlDbType.VarChar,10);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[1].Value = Branche_ID;

            param[2] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[2].Value = Store_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.VarChar, 50);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.VarChar, 50);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@Ven_ID", SqlDbType.NVarChar, 50);
            param[5].Value = Ven_ID;

            param[6] = new SqlParameter("@Pur_B_Type", SqlDbType.NVarChar, 50);
            param[6].Value = Pur_B_Type;

            param[7] = new SqlParameter("@Pur_Pur_No", SqlDbType.NVarChar, 50);
            param[7].Value = Pur_Pur_No;

            param[8] = new SqlParameter("@Pur_Pur_Date", SqlDbType.DateTime);
            param[8].Value = Pur_Pur_Date;

            param[9] = new SqlParameter("@Pur_Date", SqlDbType.DateTime);
            param[9].Value = Pur_Date;

            param[10] = new SqlParameter("@Pur_Notes", SqlDbType.NVarChar, 50);
            param[10].Value = Pur_Notes;

            param[11] = new SqlParameter("@Currency", SqlDbType.Int);
            param[11].Value = Currency;

            param[12] = new SqlParameter("@Currency_Rate", SqlDbType.Decimal);
            param[12].Value = Currency_Rate;

            param[13] = new SqlParameter("@Pur_Total", SqlDbType.Decimal);
            param[13].Value = Pur_Total;

            param[14] = new SqlParameter("@Pur_Total_Dis_Rate", SqlDbType.Decimal);
            param[14].Value = Pur_Total_Dis_Rate;

            param[15] = new SqlParameter("@Pur_Total_Dis_Value", SqlDbType.Decimal);
            param[15].Value = Pur_Total_Dis_Value;

            param[16] = new SqlParameter("@Pur_Net", SqlDbType.Decimal);
            param[16].Value = Pur_Net;

            param[17] = new SqlParameter("@Pur_Total_SPrice", SqlDbType.Decimal);
            param[17].Value = Pur_Total_SPrice;

            param[18] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[18].Value = User_ID;

            param[19] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[19].Value = dt_Items;

            string F;
            F = DAL.ExecuteCommand("Pur_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Pur_ID", SqlDbType.VarChar,10);
            param[0].Value = Bill_ID;

            string F;
            F = DAL.ExecuteCommand("Pur_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
