using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BL
{
    class CLS_Items
    {
        #region Var

        #region Items
        public string Item_ID;
        public string anm;
        public string enm;

        public decimal Max_Quan;
        public decimal Min_Quan;
        public decimal Alarm_Quan;
        public decimal Current_Quan;
        public int des1;
        public int des2;
        public int des3;
        public int des4;
        public int des5;
        public int des6;
        public int des7;
        public string des8;
        public string des9;
        public string des10;
        public byte[] image;

        public bool is_commodity;
        public bool is_complex;
        public int SPrice_complex_Type;
        public decimal SPrice_complex2_Val;
        public decimal SPrice_complex3_Val;
        public decimal bonus;
        public decimal bonus_range;
        public int Currency_ID;
        public decimal sales_tax;
        public bool is_searchable;

        public string Parent_ID;
        public bool Is_Parent;
        public int level;
        public int user_id;

        public DataTable dt_Item_Unit;
        public DataTable dt_Item_Price;
        public DataTable dt_Item_Barcode;
        public DataTable dt_Item_Ven;
        public DataTable dt_Item_Alt;
        #endregion

        #region Items_Des
        public int des_id;
        public string des_name;
        #endregion

        #region Items_Des_Add
        public int des_item_id;
        public string des_item_name;
        public string des_item_notes;
        public int des_item_type;
        #endregion

        #region Units
        public int unit_id;
        public string unit_anm;
        public string unit_enm;
        #endregion

        #endregion

        public DataSet Select(string Item_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar, 50);
            param[0].Value = Item_ID;

            return DAL.Select_ALL("Items_Select", param);
        }
        public DataTable Image_Select(string Item_ID)
        {
            DAL.DAL DAL = new DAL.DAL();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar, 50);
            param[0].Value = Item_ID;

            return DAL.SelectData("Items_Images_Select", param);
        }
        public string Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[36];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar, 50);
            param[0].Value = Item_ID;

            param[1] = new SqlParameter("@anm", SqlDbType.NVarChar, 50);
            param[1].Value = anm;

            param[2] = new SqlParameter("@enm", SqlDbType.NVarChar, 50);
            param[2].Value = enm;

            param[3] = new SqlParameter("@Max_Quan", SqlDbType.Decimal);
            param[3].Value = Max_Quan;

            param[4] = new SqlParameter("@Min_Quan", SqlDbType.Decimal);
            param[4].Value = Min_Quan;

            param[5] = new SqlParameter("@Alarm_Quan", SqlDbType.Decimal);
            param[5].Value = Alarm_Quan;




            param[6] = new SqlParameter("@des1", SqlDbType.Int);
            param[6].Value = des1;

            param[7] = new SqlParameter("@des2", SqlDbType.Int);
            param[7].Value = des2;

            param[8] = new SqlParameter("@des3", SqlDbType.Int);
            param[8].Value = des3;

            param[9] = new SqlParameter("@des4", SqlDbType.Int);
            param[9].Value = des4;

            param[10] = new SqlParameter("@des5", SqlDbType.Int);
            param[10].Value = des5;

            param[11] = new SqlParameter("@des6", SqlDbType.Int);
            param[11].Value = des6;

            param[12] = new SqlParameter("@des7", SqlDbType.Int);
            param[12].Value = des7;

            param[13] = new SqlParameter("@des8", SqlDbType.NVarChar, 20);
            param[13].Value = des8;

            param[14] = new SqlParameter("@des9", SqlDbType.NVarChar, 20);
            param[14].Value = des9;

            param[15] = new SqlParameter("@des10", SqlDbType.NVarChar, 20);
            param[15].Value = des10;

            param[16] = new SqlParameter("@image", SqlDbType.VarBinary);
            param[16].Value = image;




            param[17] = new SqlParameter("@is_commodity", SqlDbType.Bit);
            param[17].Value = is_commodity;

            param[18] = new SqlParameter("@is_complex", SqlDbType.Bit);
            param[18].Value = is_complex;

            param[19] = new SqlParameter("@SPrice_complex_Type", SqlDbType.Int);
            param[19].Value = SPrice_complex_Type;

            param[20] = new SqlParameter("@SPrice_complex2_Val", SqlDbType.Decimal);
            param[20].Value = SPrice_complex2_Val;

            param[21] = new SqlParameter("@SPrice_complex3_Val", SqlDbType.Decimal);
            param[21].Value = SPrice_complex3_Val;

            param[22] = new SqlParameter("@bonus", SqlDbType.Decimal);
            param[22].Value = bonus;

            param[23] = new SqlParameter("@bonus_range", SqlDbType.Decimal);
            param[23].Value = bonus_range;

            param[24] = new SqlParameter("@Currency_ID", SqlDbType.Int);
            param[24].Value = Currency_ID;

            param[25] = new SqlParameter("@sales_tax", SqlDbType.Int);
            param[25].Value = sales_tax;

            param[26] = new SqlParameter("@is_searchable", SqlDbType.Bit);
            param[26].Value = is_searchable;

            param[27] = new SqlParameter("@Parent_ID", SqlDbType.VarChar, 50);
            param[27].Value = Parent_ID;

            param[28] = new SqlParameter("@Is_Parent", SqlDbType.Bit);
            param[28].Value = Is_Parent;

            param[29] = new SqlParameter("@level", SqlDbType.Int);
            param[29].Value = level;

            param[30] = new SqlParameter("@user_id", SqlDbType.Int);
            param[30].Value = user_id;

            param[31] = new SqlParameter("@dt_Item_Unit", SqlDbType.Structured);
            param[31].Value = dt_Item_Unit;

            param[32] = new SqlParameter("@dt_Item_Price", SqlDbType.Structured);
            param[32].Value = dt_Item_Price;

            param[33] = new SqlParameter("@dt_Item_Barcode", SqlDbType.Structured);
            param[33].Value = dt_Item_Barcode;

            param[34] = new SqlParameter("@dt_Item_Ven", SqlDbType.Structured);
            param[34].Value = dt_Item_Ven;

            param[35] = new SqlParameter("@dt_Item_Alt", SqlDbType.Structured);
            param[35].Value = dt_Item_Alt;


            string F;
            F = DAL.ExecuteCommand("Items_Insert", param);

            DAL.Close();

            return F;
        }
        public string Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[36];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar, 50);
            param[0].Value = Item_ID;

            param[1] = new SqlParameter("@anm", SqlDbType.NVarChar, 50);
            param[1].Value = anm;

            param[2] = new SqlParameter("@enm", SqlDbType.NVarChar, 50);
            param[2].Value = enm;

            param[3] = new SqlParameter("@Max_Quan", SqlDbType.Decimal);
            param[3].Value = Max_Quan;

            param[4] = new SqlParameter("@Min_Quan", SqlDbType.Decimal);
            param[4].Value = Min_Quan;

            param[5] = new SqlParameter("@Alarm_Quan", SqlDbType.Decimal);
            param[5].Value = Alarm_Quan;




            param[6] = new SqlParameter("@des1", SqlDbType.Int);
            param[6].Value = des1;

            param[7] = new SqlParameter("@des2", SqlDbType.Int);
            param[7].Value = des2;

            param[8] = new SqlParameter("@des3", SqlDbType.Int);
            param[8].Value = des3;

            param[9] = new SqlParameter("@des4", SqlDbType.Int);
            param[9].Value = des4;

            param[10] = new SqlParameter("@des5", SqlDbType.Int);
            param[10].Value = des5;

            param[11] = new SqlParameter("@des6", SqlDbType.Int);
            param[11].Value = des6;

            param[12] = new SqlParameter("@des7", SqlDbType.Int);
            param[12].Value = des7;

            param[13] = new SqlParameter("@des8", SqlDbType.NVarChar, 20);
            param[13].Value = des8;

            param[14] = new SqlParameter("@des9", SqlDbType.NVarChar, 20);
            param[14].Value = des9;

            param[15] = new SqlParameter("@des10", SqlDbType.NVarChar, 20);
            param[15].Value = des10;

            param[16] = new SqlParameter("@image", SqlDbType.VarBinary);
            param[16].Value = image;




            param[17] = new SqlParameter("@is_commodity", SqlDbType.Bit);
            param[17].Value = is_commodity;

            param[18] = new SqlParameter("@is_complex", SqlDbType.Bit);
            param[18].Value = is_complex;

            param[19] = new SqlParameter("@SPrice_complex_Type", SqlDbType.Int);
            param[19].Value = SPrice_complex_Type;

            param[20] = new SqlParameter("@SPrice_complex2_Val", SqlDbType.Decimal);
            param[20].Value = SPrice_complex2_Val;

            param[21] = new SqlParameter("@SPrice_complex3_Val", SqlDbType.Decimal);
            param[21].Value = SPrice_complex3_Val;

            param[22] = new SqlParameter("@bonus", SqlDbType.Decimal);
            param[22].Value = bonus;

            param[23] = new SqlParameter("@bonus_range", SqlDbType.Decimal);
            param[23].Value = bonus_range;

            param[24] = new SqlParameter("@Currency_ID", SqlDbType.Int);
            param[24].Value = Currency_ID;

            param[25] = new SqlParameter("@sales_tax", SqlDbType.Int);
            param[25].Value = sales_tax;

            param[26] = new SqlParameter("@is_searchable", SqlDbType.Bit);
            param[26].Value = is_searchable;

            param[27] = new SqlParameter("@Parent_ID", SqlDbType.VarChar, 50);
            param[27].Value = Parent_ID;

            param[28] = new SqlParameter("@Is_Parent", SqlDbType.Bit);
            param[28].Value = Is_Parent;

            param[29] = new SqlParameter("@level", SqlDbType.Int);
            param[29].Value = level;

            param[30] = new SqlParameter("@user_id", SqlDbType.Int);
            param[30].Value = user_id;

            param[31] = new SqlParameter("@dt_Item_Unit", SqlDbType.Structured);
            param[31].Value = dt_Item_Unit;

            param[32] = new SqlParameter("@dt_Item_Price", SqlDbType.Structured);
            param[32].Value = dt_Item_Price;

            param[33] = new SqlParameter("@dt_Item_Barcode", SqlDbType.Structured);
            param[33].Value = dt_Item_Barcode;

            param[34] = new SqlParameter("@dt_Item_Ven", SqlDbType.Structured);
            param[34].Value = dt_Item_Ven;

            param[35] = new SqlParameter("@dt_Item_Alt", SqlDbType.Structured);
            param[35].Value = dt_Item_Alt;

            string F;
            F = DAL.ExecuteCommand("Items_Update", param);

            DAL.Close();

            return F;
        }
        public string Delete(string Item_ID)
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar, 50);
            param[0].Value = Item_ID;

            string F;
            F = DAL.ExecuteCommand("Items_Delete", param);

            DAL.Close();

            return F;
        }

        public string Descriptions_Names_Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = des_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 15);
            param[1].Value = des_name;

            string F;
            F = DAL.ExecuteCommand("Descriptions_Names_Update", param);

            DAL.Close();

            return F;
        }
        public string Description_Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@des_id", SqlDbType.Int);
            param[0].Value = des_item_id;

            param[1] = new SqlParameter("@des_name", SqlDbType.NVarChar, 50);
            param[1].Value = des_item_name;

            param[2] = new SqlParameter("@des_Notes", SqlDbType.NVarChar, 100);
            param[2].Value = des_item_notes;

            string F;
            F = DAL.ExecuteCommand("Items_Description_Update", param);

            DAL.Close();

            return F;
        }
        public string Description_Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@des_name", SqlDbType.NVarChar, 50);
            param[0].Value = des_item_name;

            param[1] = new SqlParameter("@des_Notes", SqlDbType.NVarChar, 100);
            param[1].Value = des_item_notes;

            param[2] = new SqlParameter("@des_type", SqlDbType.Int);
            param[2].Value = des_item_type;

            string F;
            F = DAL.ExecuteCommand("Items_Description_Insert", param);

            DAL.Close();

            return F;
        }
        public string Description_Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@des_id", SqlDbType.Int);
            param[0].Value = des_item_id;

            string F;
            F = DAL.ExecuteCommand("Items_Description_Delete", param);

            DAL.Close();

            return F;
        }

        public string Units_Update()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[0].Value = unit_id;

            param[1] = new SqlParameter("@anm", SqlDbType.NVarChar, 20);
            param[1].Value = unit_anm;

            param[2] = new SqlParameter("@enm", SqlDbType.NVarChar, 20);
            param[2].Value = unit_enm;

            string F;
            F = DAL.ExecuteCommand("Units_Update", param);

            DAL.Close();

            return F;
        }
        public string Units_Insert()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@anm", SqlDbType.NVarChar, 20);
            param[0].Value = unit_anm;

            param[1] = new SqlParameter("@enm", SqlDbType.NVarChar, 20);
            param[1].Value = unit_enm;

            string F;
            F = DAL.ExecuteCommand("Units_Insert", param);

            DAL.Close();

            return F;
        }
        public string Units_Delete()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[0].Value = unit_id;

            string F;
            F = DAL.ExecuteCommand("Units_Delete", param);

            DAL.Close();

            return F;
        }
        public string Item_Units_Delete_Check()
        {
            DAL.DAL DAL = new DAL.DAL();
            DAL.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Item_ID", SqlDbType.VarChar,10);
            param[0].Value = Item_ID;

            param[1] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[1].Value = unit_id;

            string F;
            F = DAL.ExecuteCommand("Item_Units_Delete_Check", param);

            DAL.Close();

            return F;
        }
    }
}
