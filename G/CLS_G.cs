using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.G
{
    class CLS_G
    {
        public DataSet Select_All()
        {
            DAL.DAL DAL = new DAL.DAL();
            return DAL.Select_ALL("Select_ALL");
        }

        #region Last
        public DataTable Select_LastBill(string Bill_ID,int Bill_Type)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.VarChar, 10);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@Bill_Type", SqlDbType.Int);
            param[1].Value = Bill_Type;

            DataTable T = new DataTable();
            T = DAL.SelectData("G_Select_LastBill", param);

            return T;
        }
        public DataTable Select_LastIO(string Bill_ID,int Bill_Type)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.VarChar, 10);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@Bill_Type", SqlDbType.Int);
            param[1].Value = Bill_Type;

            DataTable T = new DataTable();
            T = DAL.SelectData("G_Select_LastIO", param);

            return T;
        }
        public DataTable Select_Jor(string Jor_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_ID", SqlDbType.VarChar, 10);
            param[0].Value = Jor_ID;

            DataTable Jor = new DataTable();
            Jor = DAL.SelectData("G_Jor_Select_Last", param);

            return Jor;
        }
        public DataTable Select_Jor_D(string Jor_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Jor_ID", SqlDbType.VarChar, 10);
            param[0].Value = Jor_ID;

            DataTable Jor = new DataTable();
            Jor = DAL.SelectData("G_Jor_D_Select_Last", param);

            return Jor;
        }
        #endregion

        #region Levels
        #region var Level
        public int n1;
        public int n2;
        public int n3;
        public int n4;
        public int n5;
        public int n6;
        public int n7;
        public int n8;
        public int n9;
        public int n10;

        public int cc1;
        public int cc2;
        public int cc3;
        public int cc4;
        public int cc5;
        public int cc6;
        public int cc7;
        public int cc8;
        public int cc9;
        public int cc10;

        public int i1;
        public int i2;
        public int i3;
        public int i4;
        public int i5;
        public int i6;
        public int i7;
        public int i8;
        public int i9;
        public int i10;
        #endregion
        public DataTable Select_Level_Set()
        {
            var DAL = new DAL.DAL();

            var ACC = new DataTable();
            ACC = DAL.SelectData("G_Level_Set_Select", null);

            return ACC;
        }
        public string Update_Level_Set()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[30];

            param[0] = new SqlParameter("@n1", SqlDbType.Int);
            param[0].Value = n1;

            param[1] = new SqlParameter("@n2", SqlDbType.Int);
            param[1].Value = n2;

            param[2] = new SqlParameter("@n3", SqlDbType.Int);
            param[2].Value = n3;

            param[3] = new SqlParameter("@n4", SqlDbType.Int);
            param[3].Value = n4;

            param[4] = new SqlParameter("@n5", SqlDbType.Int);
            param[4].Value = n5;

            param[5] = new SqlParameter("@n6", SqlDbType.Int);
            param[5].Value = n6;

            param[6] = new SqlParameter("@n7", SqlDbType.Int);
            param[6].Value = n7;

            param[7] = new SqlParameter("@n8", SqlDbType.Int);
            param[7].Value = n8;

            param[8] = new SqlParameter("@n9", SqlDbType.Int);
            param[8].Value = n9;

            param[9] = new SqlParameter("@n10", SqlDbType.Int);
            param[9].Value = n10;

            param[10] = new SqlParameter("@cc1", SqlDbType.Int);
            param[10].Value = cc1;

            param[11] = new SqlParameter("@cc2", SqlDbType.Int);
            param[11].Value = cc2;

            param[12] = new SqlParameter("@cc3", SqlDbType.Int);
            param[12].Value = cc3;

            param[13] = new SqlParameter("@cc4", SqlDbType.Int);
            param[13].Value = cc4;

            param[14] = new SqlParameter("@cc5", SqlDbType.Int);
            param[14].Value = cc5;

            param[15] = new SqlParameter("@cc6", SqlDbType.Int);
            param[15].Value = cc6;

            param[16] = new SqlParameter("@cc7", SqlDbType.Int);
            param[16].Value = cc7;

            param[17] = new SqlParameter("@cc8", SqlDbType.Int);
            param[17].Value = cc8;

            param[18] = new SqlParameter("@cc9", SqlDbType.Int);
            param[18].Value = cc9;

            param[19] = new SqlParameter("@cc10", SqlDbType.Int);
            param[19].Value = cc10;

            param[20] = new SqlParameter("@i1", SqlDbType.Int);
            param[20].Value = i1;

            param[21] = new SqlParameter("@i2", SqlDbType.Int);
            param[21].Value = i2;

            param[22] = new SqlParameter("@i3", SqlDbType.Int);
            param[22].Value = i3;

            param[23] = new SqlParameter("@i4", SqlDbType.Int);
            param[23].Value = i4;

            param[24] = new SqlParameter("@i5", SqlDbType.Int);
            param[24].Value = i5;

            param[25] = new SqlParameter("@i6", SqlDbType.Int);
            param[25].Value = i6;

            param[26] = new SqlParameter("@i7", SqlDbType.Int);
            param[26].Value = i7;

            param[27] = new SqlParameter("@i8", SqlDbType.Int);
            param[27].Value = i8;

            param[28] = new SqlParameter("@i9", SqlDbType.Int);
            param[28].Value = i9;

            param[29] = new SqlParameter("@i10", SqlDbType.Int);
            param[29].Value = i10;

            string F;
            F = DAL.ExecuteCommand("G_Level_Set_Update", param);

            DAL.Close();

            return F;
        }
        #endregion

        public DataTable ACC_Proper_Select()
        {
            DAL.DAL DAL = new DAL.DAL();

            DataTable d = new DataTable();
            d = DAL.SelectData("G_ACC_Proper_Select", null);

            return d;
        }

        public struct Currency
        {
            #region var
            public int ID;
            public string Anm;
            public string Enm;
            public string Rate;
            #endregion

            public DataTable Select()
            {
                DAL.DAL DAL = new DAL.DAL();

                DataTable Currency = new DataTable();
                Currency = DAL.SelectData("Currency_Select", null);

                return Currency;
            }
            public string Insert()
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.open();

                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@Anm", SqlDbType.NVarChar, 20);
                param[0].Value = Anm;

                param[1] = new SqlParameter("@Enm", SqlDbType.NVarChar, 20);
                param[1].Value = Enm;

                param[2] = new SqlParameter("@Rate", SqlDbType.Decimal);
                param[2].Value = Rate;

                string F;
                F = DAL.ExecuteCommand("Currency_Insert", param);

                DAL.Close();

                return F;
            }
            public string Update()
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.open();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Anm", SqlDbType.NVarChar, 20);
                param[1].Value = Anm;

                param[2] = new SqlParameter("@Enm", SqlDbType.NVarChar, 20);
                param[2].Value = Enm;

                param[3] = new SqlParameter("@Rate", SqlDbType.Decimal);
                param[3].Value = Rate;

                string F;
                F = DAL.ExecuteCommand("Currency_Update", param);

                DAL.Close();

                return F;
            }
            public string Delete(int ID)
            {
                DAL.DAL DAL = new DAL.DAL();
                DAL.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                string F;
                F = DAL.ExecuteCommand("Currency_Delete", param);

                DAL.Close();

                return F;
            }
        }
    }
}
