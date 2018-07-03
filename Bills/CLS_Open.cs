using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Bills
{
    class CLS_Open
    {
        #region var
        public string Branche_ID;
        public int Store_ID;
        public int CC1_ID;
        public int CC2_ID;

        public string Open_ID;
        public DateTime Open_Date;
        public int Open_Person;
        public string Open_Notes;
        public decimal Open_Total_CPrice;
        public decimal Open_Total_SPrice;
        public int User_ID;
        public DataTable dt_Open;
        #endregion
        public DataTable Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable Open = new DataTable();
            Open = DAL.SelectData("Open_Select", null);

            return Open;
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
            param[0].Value = Branche_ID;

            param[1] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[1].Value = Store_ID;

            param[2] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[2].Value = CC1_ID;

            param[3] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[3].Value = CC2_ID;

            param[4] = new SqlParameter("@Open_Date", SqlDbType.DateTime);
            param[4].Value = Open_Date;

            param[5] = new SqlParameter("@Open_Person", SqlDbType.Int);
            param[5].Value = Open_Person;

            param[6] = new SqlParameter("@Open_Notes", SqlDbType.NVarChar, 50);
            param[6].Value = Open_Notes;

            param[7] = new SqlParameter("@Open_Total_CPrice", SqlDbType.Decimal);
            param[7].Value = Open_Total_CPrice;

            param[8] = new SqlParameter("@Open_Total_SPrice", SqlDbType.Decimal);
            param[8].Value = Open_Total_SPrice;

            param[9] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[9].Value = User_ID;

            param[10] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[10].Value = dt_Open;

            string F;
            F = DAL.ExecuteCommand("Open_Insert", param);

            DAL.Close();
            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@Open_ID", SqlDbType.VarChar,10);
            param[0].Value = Open_ID;

            param[1] = new SqlParameter("@Branche_ID", SqlDbType.VarChar,3);
            param[1].Value = Branche_ID;

            param[2] = new SqlParameter("@Store_ID", SqlDbType.Int);
            param[2].Value = Store_ID;

            param[3] = new SqlParameter("@CC1_ID", SqlDbType.Int);
            param[3].Value = CC1_ID;

            param[4] = new SqlParameter("@CC2_ID", SqlDbType.Int);
            param[4].Value = CC2_ID;

            param[5] = new SqlParameter("@Open_Date", SqlDbType.DateTime);
            param[5].Value = Open_Date;

            param[6] = new SqlParameter("@Open_Person", SqlDbType.Int);
            param[6].Value = Open_Person;

            param[7] = new SqlParameter("@Open_Notes", SqlDbType.NVarChar, 50);
            param[7].Value = Open_Notes;

            param[8] = new SqlParameter("@Open_Total_CPrice", SqlDbType.Decimal);
            param[8].Value = Open_Total_CPrice;

            param[9] = new SqlParameter("@Open_Total_SPrice", SqlDbType.Decimal);
            param[9].Value = Open_Total_SPrice;

            param[10] = new SqlParameter("@User_ID", SqlDbType.Int);
            param[10].Value = User_ID;

            param[11] = new SqlParameter("@dt_Items", SqlDbType.Structured);
            param[11].Value = dt_Open;

            string F;
            F = DAL.ExecuteCommand("Open_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string Open_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Open_ID", SqlDbType.VarChar,10);
            param[0].Value = Open_ID;

            string F;
            F = DAL.ExecuteCommand("Open_Delete", param);

            DAL.Close();

            return F;
        }
    }
}
