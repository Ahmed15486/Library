using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.BasicData
{
    public partial class FRM_Items : Form
    {
        #region Declarations
        BL.CLS_Items Items = new BL.CLS_Items();       
        G.CLS_G G = new G.CLS_G();
        Items.FRM_Price_Edit price_edit = new Items.FRM_Price_Edit();
        Items.FRM_Units frm_units;
        Items.FRM_Items_Units_Edit frm_units_edit;
        Items.FRM_Barcode_Edit frm_barcode_edit;

        DataTable dt_des_names;
        DataTable dt_description;

        public DataView des1_view;
        public DataView des2_view;
        public DataView des3_view;
        public DataView des4_view;
        public DataView des5_view;
        public DataView des6_view;
        public DataView des7_view;
        public DataView des11_view;
        public DataView Items_Last_view;

        public DataView Items_Units_view;
        public DataView Items_Price_view;
        public DataView Items_Barcode_view;
        public DataView Items_Ven_view;
        public DataView Items_Alt_view;

        DataTable dt_Item_Units;
        DataTable dt_Item_Price;
        DataTable dt_Item_Barcode;
        DataTable dt_Item_Ven;
        DataTable dt_Item_Alt;
        DataRow r;
        bool up;
        string s;

        public frm_Main Main;
        #endregion

        public FRM_Items(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            Main.ds = G.Select_All();

            pic_Item.Image = Main.imageList64.Images["Camera_64.png"];           

            dt_des_names = Main.ds.Tables[26];
            lbl_des1.Text = dt_des_names.Rows[0]["name"].ToString();
            lbl_des2.Text = dt_des_names.Rows[1]["name"].ToString();
            lbl_des3.Text = dt_des_names.Rows[2]["name"].ToString();
            lbl_des4.Text = dt_des_names.Rows[3]["name"].ToString();
            lbl_des5.Text = dt_des_names.Rows[4]["name"].ToString();
            lbl_des6.Text = dt_des_names.Rows[5]["name"].ToString();
            lbl_des7.Text = dt_des_names.Rows[6]["name"].ToString();
            lbl_des8.Text = dt_des_names.Rows[7]["name"].ToString();
            lbl_des9.Text = dt_des_names.Rows[8]["name"].ToString();
            lbl_des10.Text = dt_des_names.Rows[9]["name"].ToString();

            dt_description = Main.ds.Tables[27];

            des1_view = new DataView(Main.ds.Tables[27]);
            des1_view.RowFilter = "des_type = 1";
            com_Des1.DataSource = des1_view;

            des2_view = new DataView(Main.ds.Tables[27]);
            des2_view.RowFilter = "des_type = 2";
            com_Des2.DataSource = des2_view;

            des3_view = new DataView(Main.ds.Tables[27]);
            des3_view.RowFilter = "des_type = 3";
            com_Des3.DataSource = des3_view;

            des4_view = new DataView(Main.ds.Tables[27]);
            des4_view.RowFilter = "des_type = 4";
            com_Des4.DataSource = des4_view;

            des5_view = new DataView(Main.ds.Tables[27]);
            des5_view.RowFilter = "des_type = 5";
            com_Des5.DataSource = des5_view;

            des6_view = new DataView(Main.ds.Tables[27]);
            des6_view.RowFilter = "des_type = 6";
            com_Des6.DataSource = des6_view;

            des7_view = new DataView(Main.ds.Tables[27]);
            des7_view.RowFilter = "des_type = 7";
            com_Des7.DataSource = des7_view;

            des11_view = new DataView(Main.ds.Tables[27]);
            des11_view.RowFilter = "des_type = 11";
            com_Items_Ven.DataSource = des11_view;

            Items_Last_view = new DataView(Main.ds.Tables[5]);
            Items_Last_view.RowFilter = "Is_Parent = 0";
            com_Alternative_Item_Name.DataSource = Items_Last_view;
            com_Alternative_Item_Name.SelectedValue = -1;                  

            com_Items_count_Ven_name.DataSource = Main.ds.Tables[9];
            com_Items_count_Ven_name.SelectedValue = -1;
            com_Items_Ven.SelectedValue = -1;

            Items_Units_view = new DataView(Main.ds.Tables[29]);
            Items_Price_view = new DataView(Main.ds.Tables[30]);
            Items_Barcode_view = new DataView(Main.ds.Tables[31]);
            Items_Ven_view = new DataView(Main.ds.Tables[32]);
            Items_Alt_view = new DataView(Main.ds.Tables[33]);

            com_Unit.DataSource = Main.ds.Tables[28];

            #region 5 Datatabels
            dt_Item_Units = new DataTable();
            dt_Item_Units.Columns.Add("Unit_ID");
            dt_Item_Units.Columns.Add("op");

            dt_Item_Price = new DataTable();
            dt_Item_Price.Columns.Add("Unit_ID");
            dt_Item_Price.Columns.Add("PPrice");
            dt_Item_Price.Columns.Add("SPrice1");
            dt_Item_Price.Columns.Add("SPrice2");
            dt_Item_Price.Columns.Add("SPrice3");
            dt_Item_Price.Columns.Add("SPrice4");
            dt_Item_Price.Columns.Add("SPrice5");
            dt_Item_Price.Columns.Add("SPrice6");

            dt_Item_Barcode = new DataTable();
            dt_Item_Barcode.Columns.Add("Unit_ID");
            dt_Item_Barcode.Columns.Add("Barcode");

            dt_Item_Ven = new DataTable();
            dt_Item_Ven.Columns.Add("Ven_Name");

            dt_Item_Alt = new DataTable();
            dt_Item_Alt.Columns.Add("Item_Alt_ID");
            #endregion

            #region DGV

            #region Units
            var index = new DataGridViewTextBoxColumn();
            index.HeaderText = "#";
            index.DataPropertyName = "#";
            index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            index.Width = 50;
            DGV_Units.Columns.Add(index);

            var Unit = new DataGridViewComboBoxColumn();
            Unit.HeaderText = "الوحدة";
            Unit.DataPropertyName = "Unit";
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Unit.Width = 200;
            Unit.FlatStyle = FlatStyle.Flat;
            Unit.DataSource = Main.ds.Tables[28];
            Unit.ValueMember = "Unit_ID";
            Unit.DisplayMember = "Anm";
            DGV_Units.Columns.Add(Unit);

            var OP = new DataGridViewTextBoxColumn();
            OP.HeaderText = "العدد من الوحدة الأولى";
            OP.DataPropertyName = "OP";
            OP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OP.Width = 100;
            DGV_Units.Columns.Add(OP);

            var Edit = new DataGridViewImageColumn();
            Edit.HeaderText = "تعديل";
            Edit.DataPropertyName = "Edit";
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.Width = 50;
            DGV_Units.Columns.Add(Edit);

            var Delete = new DataGridViewTextBoxColumn();
            Delete.HeaderText = "حذف";
            Delete.DataPropertyName = "Delete";
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delete.Width = 50;
            DGV_Units.Columns.Add(Delete);
            #endregion

            #region Price
            var Price_Unit = new DataGridViewComboBoxColumn();
            Price_Unit.HeaderText = "الوحدة";
            Price_Unit.DataPropertyName = "Unit";
            Price_Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price_Unit.Width = 100;
            Price_Unit.FlatStyle = FlatStyle.Flat;
            Price_Unit.DataSource = Main.ds.Tables[28];
            Price_Unit.ValueMember = "Unit_ID";
            Price_Unit.DisplayMember = "Anm";
            DGV_Pricing.Columns.Add(Price_Unit);

            var PPrice = new DataGridViewTextBoxColumn();
            PPrice.HeaderText = "سعر الشراء";
            PPrice.DataPropertyName = "PPrice";
            PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PPrice.Width = 70;
            DGV_Pricing.Columns.Add(PPrice);

            var CPrice = new DataGridViewTextBoxColumn();
            CPrice.HeaderText = "سعر التكلفة";
            CPrice.DataPropertyName = "CPrice";
            CPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CPrice.Width = 70;
            DGV_Pricing.Columns.Add(CPrice);

            var SPrice1 = new DataGridViewTextBoxColumn();
            SPrice1.HeaderText = "بيع تجزئة";
            SPrice1.DataPropertyName = "SPrice1";
            SPrice1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice1.Width = 70;
            DGV_Pricing.Columns.Add(SPrice1);

            var SPrice2 = new DataGridViewTextBoxColumn();
            SPrice2.HeaderText = "بيع مندوب";
            SPrice2.DataPropertyName = "SPrice2";
            SPrice2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice1.Width = 70;
            DGV_Pricing.Columns.Add(SPrice2);

            var SPrice3 = new DataGridViewTextBoxColumn();
            SPrice3.HeaderText = "بيع موزع";
            SPrice3.DataPropertyName = "SPrice3";
            SPrice3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice3.Width = 70;
            DGV_Pricing.Columns.Add(SPrice3);

            var SPrice4 = new DataGridViewTextBoxColumn();
            SPrice4.HeaderText = "بيع جملة";
            SPrice4.DataPropertyName = "SPrice4";
            SPrice4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice4.Width = 70;
            DGV_Pricing.Columns.Add(SPrice4);

            var SPrice5 = new DataGridViewTextBoxColumn();
            SPrice5.HeaderText = "بيع تصدير";
            SPrice5.DataPropertyName = "SPrice5";
            SPrice5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice5.Width = 70;
            DGV_Pricing.Columns.Add(SPrice5);

            var SPrice6 = new DataGridViewTextBoxColumn();
            SPrice6.HeaderText = "بيع خاص";
            SPrice6.DataPropertyName = "SPrice6";
            SPrice6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SPrice6.Width = 70;
            DGV_Pricing.Columns.Add(SPrice6);

            var Price_Edit = new DataGridViewImageColumn();
            Price_Edit.HeaderText = "تعديل";
            Price_Edit.DataPropertyName = "Price_Edit";
            Price_Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price_Edit.Width = 50;
            DGV_Pricing.Columns.Add(Price_Edit);
            #endregion

            #region Barcode
            var Barcode_index = new DataGridViewTextBoxColumn();
            Barcode_index.HeaderText = "#";
            Barcode_index.DataPropertyName = "#";
            Barcode_index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Barcode_index.Width = 50;
            DGV_Barcode.Columns.Add(Barcode_index);

            var Barcode_Unit = new DataGridViewComboBoxColumn();
            Barcode_Unit.HeaderText = "الوحدة";
            Barcode_Unit.DataPropertyName = "Unit";
            Barcode_Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Barcode_Unit.Width = 200;
            Barcode_Unit.FlatStyle = FlatStyle.Flat;
            Barcode_Unit.DataSource = Main.ds.Tables[28];
            Barcode_Unit.ValueMember = "Unit_ID";
            Barcode_Unit.DisplayMember = "Anm";
            DGV_Barcode.Columns.Add(Barcode_Unit);

            var Barcode = new DataGridViewTextBoxColumn();
            Barcode.HeaderText = "الباركود";
            Barcode.DataPropertyName = "Barcode";
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Barcode.Width = 100;
            DGV_Barcode.Columns.Add(Barcode);

            var Barcode_Edit = new DataGridViewImageColumn();
            Barcode_Edit.HeaderText = "تعديل";
            Barcode_Edit.DataPropertyName = "Edit";
            Barcode_Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Barcode_Edit.Width = 50;
            DGV_Barcode.Columns.Add(Barcode_Edit);

            var Barcode_Delete = new DataGridViewTextBoxColumn();
            Barcode_Delete.HeaderText = "حذف";
            Barcode_Delete.DataPropertyName = "Delete";
            Barcode_Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Barcode_Delete.Width = 50;
            DGV_Barcode.Columns.Add(Barcode_Delete);
            #endregion

            #region Ven
            var Ven_index = new DataGridViewTextBoxColumn();
            Ven_index.HeaderText = "#";
            Ven_index.DataPropertyName = "#";
            Ven_index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ven_index.Width = 50;
            DGV_Items_Ven.Columns.Add(Ven_index);

            var Ven_name = new DataGridViewTextBoxColumn();
            Ven_name.HeaderText = "أسم المورد";
            Ven_name.DataPropertyName = "Ven_name";
            Ven_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ven_name.Width = 100;
            DGV_Items_Ven.Columns.Add(Ven_name);

            var Ven_Delete = new DataGridViewTextBoxColumn();
            Ven_Delete.HeaderText = "حذف";
            Ven_Delete.DataPropertyName = "Delete";
            Ven_Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ven_Delete.Width = 50;
            DGV_Items_Ven.Columns.Add(Ven_Delete);
            #endregion

            #region Alt
            var Alt_index = new DataGridViewTextBoxColumn();
            Alt_index.HeaderText = "#";
            Alt_index.DataPropertyName = "#";
            Alt_index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Alt_index.Width = 50;
            DGV_Alt.Columns.Add(Alt_index);

            var Alt_ID = new DataGridViewComboBoxColumn();
            Alt_ID.HeaderText = "كود الصنف";
            Alt_ID.DataPropertyName = "Alt_ID";
            Alt_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Alt_ID.Width = 200;
            Alt_ID.FlatStyle = FlatStyle.Flat;
            Alt_ID.DataSource = Main.ds.Tables[5];
            Alt_ID.ValueMember = "Item_ID";
            Alt_ID.DisplayMember = "Item_ID";
            DGV_Alt.Columns.Add(Alt_ID);

            var Alt_Name = new DataGridViewComboBoxColumn();
            Alt_Name.HeaderText = "أسم الصنف";
            Alt_Name.DataPropertyName = "Alt_Name";
            Alt_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alt_Name.Width = 200;
            Alt_Name.FlatStyle = FlatStyle.Flat;
            Alt_Name.DataSource = Main.ds.Tables[5];
            Alt_Name.ValueMember = "Item_ID";
            Alt_Name.DisplayMember = "Anm";
            DGV_Alt.Columns.Add(Alt_Name);

            var Alt_Delete = new DataGridViewTextBoxColumn();
            Alt_Delete.HeaderText = "حذف";
            Alt_Delete.DataPropertyName = "Delete";
            Alt_Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Alt_Delete.Width = 50;
            DGV_Alt.Columns.Add(Alt_Delete);
            #endregion

            #endregion
        }

        #region Pro
        private void Form_Cleare()
        {
            txt_Item_ID.Clear();
            txt_Anm.Clear();
            txt_Enm.Clear();

            txt_MaxQuan.Clear();
            txt_Min_Quan.Clear();
            txt_Alarm_Quan.Clear();
            txt_Current_Quan.Clear();

            com_Des1.SelectedValue = -1;
            com_Des2.SelectedValue = -1;
            com_Des3.SelectedValue = -1;
            com_Des4.SelectedValue = -1;
            com_Des5.SelectedValue = -1;
            com_Des6.SelectedValue = -1;
            com_Des7.SelectedValue = -1;
            txt_Des8.Clear();
            txt_Des9.Clear();
            txt_Des10.Clear();
            pic_Item.Image = Main.imageList64.Images["Camera_64.png"];
            
            pic_Item.SizeMode = PictureBoxSizeMode.CenterImage;

            rad_Commodity.Checked = true;
            chk_Complex.Checked = false;
            rad_SPrice1.Checked = true;
            chk_Searchable.Checked = false;
            txt_SPrice_Complex2_Val.Clear();
            txt_SPrice_Complex3_Val.Clear();
            txt_Bonus.Clear();
            txt_Bouns_Range.Clear();
            txt_Taxes.Clear();
            //com_Currency.SelectedIndex = 0;

            DGV_Units.Rows.Clear();
            DGV_Pricing.Rows.Clear();
            DGV_Barcode.Rows.Clear();
            DGV_Items_Ven.Rows.Clear();
            DGV_Alt.Rows.Clear();
        }
        private void Form_Enable()
        {
            if (tree.Nodes.Count > 0) { ckb_Main_Group.Visible = true; }
            else { ckb_Main_Group.Checked = true; }

            tree.Enabled = false;

            txt_Anm.ReadOnly = false;
            txt_Enm.ReadOnly = false;

            txt_MaxQuan.ReadOnly = false;
            txt_Min_Quan.ReadOnly = false;
            txt_Alarm_Quan.ReadOnly = false;

            pnl_Des.Enabled = true;
            pnl_btn_Des_Remove.Enabled = true;

            txt_Des8.ReadOnly = false;
            txt_Des9.ReadOnly = false;
            txt_Des10.ReadOnly = false;

            btn_pic_item_Delete.Enabled = true;
            btn_pic_item_Edit.Enabled = true;

            tab_Item_Info.Visible = true;
            tree.Enabled = false;

            ((Control)tab_Units).Enabled = true;
            ((Control)tab_Prices).Enabled = true;
            ((Control)tab_Barcode).Enabled = true;
            ((Control)tab_Options).Enabled = true;
            ((Control)tab_Ven).Enabled = true;
            ((Control)tab_AlternateveItems).Enabled = true;
        }
        private void Form_Disable()
        {
            ckb_Main_Group.Checked = false;
            ckb_Main_Group.Visible = false;
            tree.Enabled = true;

            txt_Anm.ReadOnly = true;
            txt_Enm.ReadOnly = true;

            txt_MaxQuan.ReadOnly = true;
            txt_Min_Quan.ReadOnly = true;
            txt_Alarm_Quan.ReadOnly = true;

            pnl_Des.Enabled = false;
            pnl_btn_Des_Remove.Enabled = false;

            txt_Des8.ReadOnly = true;
            txt_Des9.ReadOnly = true;
            txt_Des10.ReadOnly = true;

            btn_pic_item_Delete.Enabled = false;
            btn_pic_item_Edit.Enabled = false;

            ((Control)tab_Units).Enabled = false;
            ((Control)tab_Prices).Enabled = false;
            ((Control)tab_Barcode).Enabled = false;
            ((Control)tab_Options).Enabled = false;
            ((Control)tab_Ven).Enabled = false;
            ((Control)tab_AlternateveItems).Enabled = false;
        }
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select_Node
                case "Select_Node":
                    if (tree.Nodes.Count == 0)
                    {
                        Tag = "Empty";
                        Form_Mode("Empty");
                        return;
                    }
                    if (tree.SelectedNode == null) { tree.SelectedNode = tree.Nodes[0]; }
                    if(tree.SelectedNode.Nodes.Count == 0)
                    { tab_Item_Info.Visible = true; } else { tab_Item_Info.Visible = false; }

                    lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                    
                             
                    foreach (DataRow dr in Main.ds.Tables[5].Rows)
                    {
                        if (dr["Item_ID"].ToString() == tree.SelectedNode.Tag.ToString())
                        {
                            r = dr;
                            txt_Item_ID.Text = r["Item_ID"].ToString();
                            txt_Anm.Text = r["Anm"].ToString();
                            txt_Enm.Text = r["Enm"].ToString();

                            #region General_Details
                            txt_MaxQuan.Text = r["Max_Quan"].ToString();
                            txt_Min_Quan.Text = r["Min_Quan"].ToString();
                            txt_Alarm_Quan.Text = r["Alarm_Quan"].ToString();
                            txt_Current_Quan.Text = r["Current_Quan"].ToString();

                            com_Des1.SelectedValue = r["des1"].ToString();
                            com_Des2.SelectedValue = r["des2"].ToString();
                            com_Des3.SelectedValue = r["des3"].ToString();
                            com_Des4.SelectedValue = r["des4"].ToString();
                            com_Des5.SelectedValue = r["des5"].ToString();
                            com_Des6.SelectedValue = r["des6"].ToString();
                            com_Des7.SelectedValue = r["des7"].ToString();
                            txt_Des8.Text = r["des8"].ToString();
                            txt_Des9.Text = r["des9"].ToString();
                            txt_Des10.Text = r["des10"].ToString();

                            #region Fill Options
                            switch (Convert.ToBoolean(r["is_commodity"]))
                            {
                                case true:
                                    rad_Commodity.Checked = true;
                                    break;
                                case false:
                                    rad_Service.Checked = true;
                                    break;
                            }

                            chk_Complex.Checked = Convert.ToBoolean(r["is_complex"]);

                            switch (Convert.ToInt16(r["SPrice_complex_Type"]))
                            {
                                case 1:
                                    rad_SPrice1.Checked = true;
                                    break;
                                case 2:
                                    rad_SPrice2.Checked = true;
                                    break;
                                case 3:
                                    rad_SPrice3.Checked = true;
                                    break;
                            }

                            chk_Searchable.Checked = Convert.ToBoolean(r["is_searchable"]);
                            txt_SPrice_Complex2_Val.Text = r["SPrice_complex2_Val"].ToString();
                            txt_SPrice_Complex3_Val.Text = r["SPrice_complex3_Val"].ToString();
                            txt_Bonus.Text = r["bonus"].ToString();
                            txt_Bouns_Range.Text = r["bonus_range"].ToString();
                            txt_Taxes.Text = r["sales_tax"].ToString();
                            com_Currency.SelectedValue = Convert.ToInt16(r["Currency_ID"]);
                            #endregion

                            #endregion
                        }
                    }
                    tree.SelectedNode.Text = txt_Anm.Text;
                    tree.SelectedNode.Tag = txt_Item_ID.Text;
                    lbl_Path.Text = tree.SelectedNode.FullPath;

                    Form_Disable();

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;

                    Color_Nodes(tree.SelectedNode, Color.Red);

                    #region Fill Pic
                    DataRow[] rp = Main.ds.Tables[34].Select("Item_ID = '" + txt_Item_ID.Text + "'");
                    if (rp != null & rp.Count() > 0)
                    {
                        pic_Item.Image = byteArrayToImage((byte[])rp[0][1]);
                        pic_Item.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pic_Item.Image = Main.imageList64.Images["Camera_64.png"];
                        
                        pic_Item.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    
                    #endregion

                    #region Fill DGVs
                    // Fill DGV_Units From Items_Units_view
                    Items_Units_view.RowFilter = "ITEM_ID = " + txt_Item_ID.Text;
                    DGV_Units.Rows.Clear();
                    int i = 1;
                    foreach (DataRowView rv in Items_Units_view)
                    {
                        DGV_Units.Rows.Add(i,rv[1],rv[2],imageList16.Images["Edit_16.png"],"x");
                        i++;
                    }

                    // Fill DGV_Pricing From Items_Price_view
                    Items_Price_view.RowFilter = "ITEM_ID = " + txt_Item_ID.Text;
                    DGV_Pricing.Rows.Clear();
                    foreach (DataRowView rv in Items_Price_view)
                    {
                        DGV_Pricing.Rows.Add(rv[1],rv[2], rv[3], rv[4], rv[5], rv[6], rv[7], rv[8], rv[9],imageList16.Images["Edit_16.png"]);
                    }

                    // Rename Units In com_Units_Barcode
                    com_Units_Barcode.Items.Clear();
                    int ii = Convert.ToInt16(com_Unit.SelectedValue);
                    foreach (DataGridViewRow r in DGV_Units.Rows)
                    {
                        com_Unit.SelectedValue = r.Cells[1].Value;
                        com_Units_Barcode.Items.Add(com_Unit.Text);
                    }
                    com_Unit.SelectedValue = ii;

                    // Fill DGV_Barcode From Items_Barcode_view
                    Items_Barcode_view.RowFilter = "ITEM_ID = " + txt_Item_ID.Text;
                    DGV_Barcode.Rows.Clear();
                    int ib = 1;
                    foreach (DataRowView rv in Items_Barcode_view)
                    {
                        DGV_Barcode.Rows.Add(ib, rv[1], rv[2], imageList16.Images["Edit_16.png"], "x");
                        ib++;
                    }

                    // Fill DGV_Ven From Items_Ven_view
                    Items_Ven_view.RowFilter = "ITEM_ID = " + txt_Item_ID.Text;
                    DGV_Items_Ven.Rows.Clear();
                    int iv = 1;
                    foreach (DataRowView rv in Items_Ven_view)
                    {
                        DGV_Items_Ven.Rows.Add(iv, rv[1], "x");
                        iv++;
                    }

                    // Fill DGV_Alt From Items_Alt_view
                    Items_Alt_view.RowFilter = "ITEM_ID = " + txt_Item_ID.Text;
                    DGV_Alt.Rows.Clear();
                    int ia = 1;
                    foreach (DataRowView rv in Items_Alt_view)
                    {
                        DGV_Alt.Rows.Add(ia, rv[1], rv[1] , "x");
                        ia++;
                    }
                    #endregion

                    break;
                #endregion

                #region New
                case "New":

                    Form_Cleare();
                    Form_Enable();

                    txt_Anm.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region Edit
                case "Edit":

                    Form_Enable();
                   
                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_New.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region Empty
                case "Empty":

                    ckb_Main_Group.Checked = false;

                    Form_Cleare();

                    lbl_Level.Text = "";
                    lbl_Path.Text = "";
                    tree.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;

                    break;
                    #endregion
            }
        }
        private void Remove_Form_DS()
        {
            // Item
            for (int i = 0; i < Main.ds.Tables[5].Rows.Count; i++)
            {
                if (Main.ds.Tables[5].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[5].Rows.RemoveAt(i);
                    i--;
                    break;
                }
            }

            // Image
            for (int i = 0; i < Main.ds.Tables[34].Rows.Count; i++)
            {
                if (Main.ds.Tables[34].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[34].Rows.RemoveAt(i);
                    i--;
                }
            }

            // Units
            for (int i = 0; i < Main.ds.Tables[29].Rows.Count; i++)
            {
                if (Main.ds.Tables[29].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[29].Rows.RemoveAt(i);
                    i--;
                }
            }

            // Price
            for (int i = 0; i < Main.ds.Tables[30].Rows.Count; i++)
            {
                if (Main.ds.Tables[30].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[30].Rows.RemoveAt(i);
                    i--;
                }
            }

            // Barcode
            for (int i = 0; i < Main.ds.Tables[31].Rows.Count; i++)
            {
                if (Main.ds.Tables[31].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[31].Rows.RemoveAt(i);
                    i--;
                }
            }

            // Ven
            for (int i = 0; i < Main.ds.Tables[32].Rows.Count; i++)
            {
                if (Main.ds.Tables[32].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[32].Rows.RemoveAt(i);
                    i--;
                }
            }

            // Alt
            for (int i = 0; i < Main.ds.Tables[33].Rows.Count; i++)
            {
                if (Main.ds.Tables[33].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                {
                    Main.ds.Tables[33].Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void FDBTODS(string t)
        {
            DataSet s = new DataSet();
            s = Items.Select(t);
            foreach (DataRow r in s.Tables[0].Rows)
            {
                Main.ds.Tables[5].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[1].Rows)
            {
                Main.ds.Tables[29].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[2].Rows)
            {
                Main.ds.Tables[30].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[3].Rows)
            {
                Main.ds.Tables[31].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[4].Rows)
            {
                Main.ds.Tables[32].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[5].Rows)
            {
                Main.ds.Tables[33].Rows.Add(r.ItemArray);
            }
            foreach (DataRow r in s.Tables[6].Rows)
            {
                Main.ds.Tables[34].Rows.Add(r.ItemArray);
            }
        }
        private void Color_Nodes(TreeNode node, Color color)
        {
            if (node == null) { return; }
            node.ForeColor = color;
            if (node.Parent == null) { return; }

            node.Parent.ForeColor = color;
            Color_Nodes(node.Parent, color);
        }
        private void Fill()
        {
            foreach (DataRow dr in Main.ds.Tables[5].Rows)
            {
                if (Convert.ToInt32(dr["Item_Level"]) == 1)
                {
                    TreeNode Pnode = new TreeNode();
                    Pnode.Name = (dr["Anm"].ToString());
                    Pnode.Text = (dr["Anm"].ToString());
                    Pnode.Tag = dr["Item_ID"].ToString();

                    if (Convert.ToBoolean(dr["Is_Parent"]) == true)
                    {
                        foreach (DataRow r in Main.ds.Tables[5].Rows)
                        {
                            if (r["Parent_ID"].ToString() == Pnode.Tag.ToString())
                            {
                                TreeNode Cnode = new TreeNode();
                                Cnode.Name = r["Anm"].ToString();
                                Cnode.Text = r["Anm"].ToString();
                                Cnode.Tag = r["Item_ID"].ToString();
                                Pnode.Nodes.Add(Cnode);
                            }
                        }
                    }
                    tree.Nodes.Add(Pnode);
                }
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, pic_Item.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            catch { return null; }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        private void var()
        {
            Items.Item_ID = txt_Item_ID.Text.Trim();
            Items.anm = txt_Anm.Text.Trim();
            Items.enm = txt_Enm.Text.Trim();
            Items.Max_Quan = (txt_MaxQuan.Text.Trim() != "")? Convert.ToDecimal(txt_MaxQuan.Text) : 0;
            Items.Min_Quan = (txt_Min_Quan.Text.Trim() != "") ? Convert.ToDecimal(txt_Min_Quan.Text) : 0;
            Items.Alarm_Quan = (txt_Alarm_Quan.Text.Trim() != "") ? Convert.ToDecimal(txt_Alarm_Quan.Text) : 0;
            Items.des1 = Convert.ToInt32(com_Des1.SelectedValue);
            Items.des2 = Convert.ToInt32(com_Des2.SelectedValue);
            Items.des3 = Convert.ToInt32(com_Des3.SelectedValue);
            Items.des4 = Convert.ToInt32(com_Des4.SelectedValue);
            Items.des5 = Convert.ToInt32(com_Des5.SelectedValue);
            Items.des6 = Convert.ToInt32(com_Des6.SelectedValue);
            Items.des7 = Convert.ToInt32(com_Des7.SelectedValue);
            Items.des8 = txt_Des8.Text;
            Items.des9 = txt_Des9.Text;
            Items.des10 = txt_Des10.Text;
            
            
            Items.image = imageToByteArray(pic_Item.Image);

            Items.is_commodity = (rad_Commodity.Checked ) ? true : false;
            Items.is_complex = (chk_Complex.Checked ) ? true : false;

            if (rad_SPrice1.Checked) { Items.SPrice_complex_Type = 1; }
            else if (rad_SPrice2.Checked) { Items.SPrice_complex_Type = 2; }
            else if (rad_SPrice3.Checked) { Items.SPrice_complex_Type = 3; }

            Items.SPrice_complex2_Val = (txt_SPrice_Complex2_Val.Text.Trim() != "") ? Convert.ToDecimal(txt_SPrice_Complex2_Val.Text) : 0;
            Items.SPrice_complex3_Val = (txt_SPrice_Complex3_Val.Text.Trim() != "") ? Convert.ToDecimal(txt_SPrice_Complex3_Val.Text) : 0;

            Items.bonus = (txt_Bonus.Text.Trim() != "")? Convert.ToDecimal(txt_Bonus.Text): 0;
            Items.bonus_range = (txt_Bouns_Range.Text.Trim() != "")? Convert.ToDecimal(txt_Bouns_Range.Text): 0;

            Items.Currency_ID = Convert.ToInt32(com_Currency.SelectedValue);
            Items.sales_tax = (txt_Taxes.Text.Trim() != "")? Convert.ToDecimal(txt_Taxes.Text): 0;
            Items.is_searchable = chk_Searchable.Checked;

            Items.Parent_ID = (ckb_Main_Group.Checked || tree.SelectedNode.Parent == null) ? "" : tree.SelectedNode.Parent.Tag.ToString();
            
            Items.level = (ckb_Main_Group.Checked) ? 1 : tree.SelectedNode.Level + 1;
            Items.user_id = Convert.ToInt16(Main.combo_Users.SelectedValue);

            // Fill dt_Item_Units From DGV_Units
            dt_Item_Units.Rows.Clear();
            foreach (DataGridViewRow r in DGV_Units.Rows)
            {
                dt_Item_Units.Rows.Add(Convert.ToInt32(r.Cells[1].Value), r.Cells[2].Value.ToString());
            }
            Items.dt_Item_Unit = dt_Item_Units;

            // Fill dt_Item_Price From DGV_Price
            dt_Item_Price.Rows.Clear();
            foreach (DataGridViewRow r in DGV_Pricing.Rows)
            {
                dt_Item_Price.Rows.Add(
                      (r.Cells[0].Value.ToString().Trim() == "")? 0 : Convert.ToInt32(r.Cells[0].Value)
                    , (r.Cells[1].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[1].Value)
                    , (r.Cells[3].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[3].Value)
                    , (r.Cells[4].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[4].Value)
                    , (r.Cells[5].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[5].Value)
                    , (r.Cells[6].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[6].Value)
                    , (r.Cells[7].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[7].Value)
                    , (r.Cells[8].Value.ToString().Trim() == "") ? 0 : Convert.ToDecimal(r.Cells[8].Value)
                    );
            }
            Items.dt_Item_Price = dt_Item_Price;

            // Fill dt_Item_Barcode From DGV_Barcode
            dt_Item_Barcode.Rows.Clear();
            foreach (DataGridViewRow r in DGV_Barcode.Rows)
            {
                dt_Item_Barcode.Rows.Add(Convert.ToInt32(r.Cells[1].Value), r.Cells[2].Value.ToString());
            }
            Items.dt_Item_Barcode = dt_Item_Barcode;

            // Fill dt_Item_Ven From DGV_Item_Ven
            dt_Item_Ven.Rows.Clear();
            foreach (DataGridViewRow r in DGV_Items_Ven.Rows)
            {
                dt_Item_Ven.Rows.Add(r.Cells[1].Value.ToString());
            }
            Items.dt_Item_Ven = dt_Item_Ven;

            // Fill dt_Item_Alt From DGV_Alt
            dt_Item_Alt.Rows.Clear();
            foreach (DataGridViewRow r in DGV_Alt.Rows)
            {
                dt_Item_Alt.Rows.Add(r.Cells[1].Value.ToString());
            }
            Items.dt_Item_Alt = dt_Item_Alt;

        }
        private void open_pic()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp";
                f.FilterIndex = 2;
                if(f.ShowDialog() == DialogResult.OK)
                {
                    pic_Item.Image = Main.imageList64.Images["Camera_64.png"];
                    pic_Item.Image = Image.FromFile(f.FileName);
                    pic_Item.SizeMode = PictureBoxSizeMode.StretchImage;
                }              
            }
            catch { }
        }
        private byte[] save_pic()
        {
            if (pic_Item.Image != null) { return null; }

            MemoryStream ms = new MemoryStream();
            pic_Item.Image.Save(ms, pic_Item.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();

            return a;
        }
        #endregion

        #region Form
        private void FRM_Items_Shown(object sender, EventArgs e)
        {
            Top = Main.panel_Main.Height + Main.tab_Main.Height;
            try
            {
                Fill();
                if (tree.Nodes.Count > 0)
                {
                    tree.SelectedNode = tree.Nodes[0];
                    ckb_Main_Group.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FRM_Items_Shown");
            }
        }
        private void FRM_Items_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #region Controls
        #region display
        private void button_New_MouseLeave(object sender, EventArgs e)
        {
            button_New.FlatStyle = FlatStyle.Flat;
        }
        private void button_New_MouseEnter(object sender, EventArgs e)
        {
            button_New.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_MouseEnter(object sender, EventArgs e)
        {
            button_Edit.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_MouseLeave(object sender, EventArgs e)
        {
            button_Edit.FlatStyle = FlatStyle.Flat;
        }
        private void button_Delete_MouseEnter(object sender, EventArgs e)
        {
            button_Delete.FlatStyle = FlatStyle.Popup;
        }
        private void button_Delete_MouseLeave(object sender, EventArgs e)
        {
            button_Delete.FlatStyle = FlatStyle.Flat;
        }
        private void button_Cancel_MouseEnter(object sender, EventArgs e)
        {
            button_Cancel.FlatStyle = FlatStyle.Popup;
        }
        private void button_Cancel_MouseLeave(object sender, EventArgs e)
        {
            button_Cancel.FlatStyle = FlatStyle.Flat;
        }


        private void button_Close_MouseEnter(object sender, EventArgs e)
        {
            button_Close.FlatStyle = FlatStyle.Popup;
        }
        private void button_Close_MouseLeave(object sender, EventArgs e)
        {
            button_Close.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void button_New_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Empty")
            {
                Tag = "New";
                Form_Mode("New");
                tree.Nodes.Add("");
                tree.SelectedNode = tree.Nodes[tree.Nodes.Count - 1];
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                Color_Nodes(tree.SelectedNode, Color.Red);
                s = lbl_Path.Text;

                com_Unit.SelectedIndex = 0;
                btn_Item_Unit_Add_Click(null, null);
                com_Unit.SelectedValue = -1;
            }
            else if (Tag.ToString() == "Select_Node")
            {
                Tag = "New";
                Form_Mode("New");
                tree.SelectedNode.Expand();
                tree.SelectedNode.Nodes.Add("");
                tree.SelectedNode = tree.SelectedNode.Nodes[tree.SelectedNode.Nodes.Count - 1];
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                Color_Nodes(tree.SelectedNode, Color.Red);
                s = lbl_Path.Text + " / ";

                com_Unit.SelectedIndex = 0;
                btn_Item_Unit_Add_Click(null, null);
                com_Unit.SelectedValue = -1;
            }
            else if (Tag.ToString() == "New")
            {
                if(txt_Anm.Text.Trim() == "" & txt_Enm.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال أسم الصنف", "حفظ صنف جديد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var();
                string t = Items.Insert();
                if (t.Substring(0,1)== "!")
                {
                    MessageBox.Show("الصنف التالي مسجل بنفس الكود" + Environment.NewLine + Environment.NewLine + t.Substring(1));
                    return;
                }

                txt_Item_ID.Text = t;
                tree.SelectedNode.Tag = t;

                FDBTODS(t);

                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }

        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select_Node")
            {
                Tag = "Edit";
                Form_Mode("Edit");               
                s = (tree.SelectedNode.Parent != null) ? tree.SelectedNode.Parent.FullPath + " / " : "";
                
                btn_ShowImage_Click(null, null);
            }
            else if (Tag.ToString() == "Edit")
            {
                var();
                string s =Items.Update();
                MessageBox.Show(s);

                Remove_Form_DS();
                FDBTODS(txt_Item_ID.Text);

                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الصنف المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    string t = Items.Delete((txt_Item_ID.Text));
                    if (t == "0") { MessageBox.Show("لايمكن حذف مجموعة تحتوي على أصناف"); return; }

                    // Remove Item From DS
                    for (int i = 0; i < Main.ds.Tables[5].Rows.Count; i++)
                    {
                        if (Main.ds.Tables[5].Rows[i]["Item_ID"].ToString() == txt_Item_ID.Text)
                        {
                            Main.ds.Tables[5].Rows.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    Tag = "Empty";
                    Form_Mode("Empty");
                    //Remove Item Form TreeView
                    tree.SelectedNode.Remove();
                }
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                if(MessageBox.Show("هل تريد بالفعل التراجع عن إدخال صنف جديد ؟","تأكيد التراجع",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
                {
                    return;
                }

                tree.SelectedNode.Remove();
                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }
            else if (Tag.ToString() == "Edit")
            {
                if (MessageBox.Show("هل تريد بالفعل التراجع عن تعديل هذا الصنف ؟", "تأكيد التراجع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                Tag = "Select_Node";
                Form_Mode("Select_Node");               
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Main.Items_Form_Open = false;
            if (Main.tabForms.TabPages.Count > 1)
            {
                if (Main.tabForms.SelectedIndex == Main.tabForms.TabCount - 1)
                {
                    Main.tabForms.SelectedIndex--;
                }
                else { Main.tabForms.SelectedIndex++; }
            }
            else if (Main.tabForms.TabPages.Count == 1 && Main.tab_Main.Visible == false)
            {
                Main.btn_UpDowen_Click(null, null);
            }
            if (Parent == null) { Hide(); } else { Parent.Dispose(); }
        }
        #endregion

        #region groupBox_Data
        private void ckb_Main_Group_CheckedChanged(object sender, EventArgs e)
        {
            if (tree.Nodes.Count == 0 || !ckb_Main_Group.Focused) { return; }
            if (ckb_Main_Group.Checked)
            {
                tree.SelectedNode.Remove();
                tree.CollapseAll();
                lbl_Path.Text = "";
                foreach (TreeNode n in tree.Nodes)
                {
                    n.ForeColor = Color.Black;
                }
                tree.Nodes.Add(txt_Anm.Text);
                tree.SelectedNode = tree.Nodes[tree.Nodes.Count - 1];
                tree.SelectedNode.ForeColor = Color.Red;
                s = "";
                lbl_Path.Text = txt_Anm.Text;
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                txt_Anm.Focus();
            }
            else if (!ckb_Main_Group.Checked)
            {
                tree.SelectedNode.Remove();
                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }
        }
        private void txt_Item_Name_TextChanged(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New" | Tag.ToString() == "Edit" && txt_Anm.Focused)
            {
                tree.SelectedNode.Text = txt_Anm.Text;
                lbl_Path.Text = s + txt_Anm.Text;
            }
        }
        private void tab_Item_Info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tree
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ckb_Main_Group.Checked || Tag.ToString() == "New") { return; }
            Form_Mode("Select_Node");
            Tag = "Select_Node";
        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Color_Nodes(tree.SelectedNode, Color.Black);
            }
        }
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (Tag.ToString() == "New") { return; }
            tree.SelectedNode = e.Node;
            foreach (TreeNode Pnode in tree.SelectedNode.Nodes)
            {
                Pnode.Nodes.Clear();
                foreach (DataRow r in Main.ds.Tables[5].Rows)
                {
                    if (Pnode.Tag == null) { break; }
                    if (r["Parent_ID"].ToString() == Pnode.Tag.ToString())
                    {
                        TreeNode Cnode = new TreeNode();
                        Cnode.Name = r["Anm"].ToString();
                        Cnode.Text = r["Anm"].ToString();
                        Cnode.Tag = r["Item_ID"].ToString();
                        Pnode.Nodes.Add(Cnode);
                    }
                }
            }
        }
        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            tree.SelectedNode = e.Node;
            foreach (TreeNode Cnode in tree.SelectedNode.Nodes)
            {
                Cnode.Collapse();
            }
        }
        #endregion

        #region General Data

        #region Descriptions

        #region Edit
        private void btn_Des1_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des1.Text;
            des.des_label = lbl_des1;
            des.des_com = com_Des1;
            des.des_id = 1;
            des.dv = des1_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des1_view;
         
            des.ShowDialog();
        }
        private void btn_Des2_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des2.Text;
            des.des_label = lbl_des2;
            des.des_com = com_Des2;
            des.des_id = 2;
            des.dv = des2_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des2_view;

            des.ShowDialog();
        }
        private void btn_Des3_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des3.Text;
            des.des_label = lbl_des3;
            des.des_com = com_Des3;
            des.des_id = 3;
            des.dv = des3_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des3_view;

            des.ShowDialog();
        }
        private void btn_Des4_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des4.Text;
            des.des_label = lbl_des4;
            des.des_com = com_Des4;
            des.des_id = 4;
            des.dv = des4_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des4_view;

            des.ShowDialog();
        }
        private void btn_Des5_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des5.Text;
            des.des_label = lbl_des5;
            des.des_com = com_Des5;
            des.des_id = 5;
            des.dv = des5_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des5_view;

            des.ShowDialog();
        }
        private void btn_Des6_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des6.Text;
            des.des_label = lbl_des6;
            des.des_com = com_Des6;
            des.des_id = 6;
            des.dv = des6_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des6_view;

            des.ShowDialog();
        }
        private void btn_Des7_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des7.Text;
            des.des_label = lbl_des7;
            des.des_com = com_Des7;
            des.des_id = 7;
            des.dv = des7_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des7_view;

            des.ShowDialog();
        }
        private void btn_Des8_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des8.Text;
            des.des_label = lbl_des8;
            des.des_id = 8;

            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.pnl_Items.Visible = false;
            des.grbx_Item.Visible = false;
            des.Size = new Size(420, 200);

            des.ShowDialog();
        }
        private void btn_Des9_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des9.Text;
            des.des_label = lbl_des9;
            des.des_id = 9;

            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.pnl_Items.Visible = false;
            des.grbx_Item.Visible = false;
            des.Size = new Size(420, 200);

            des.ShowDialog();
        }
        private void btn_Des10_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_des10.Text;
            des.des_label = lbl_des10;
            des.des_id = 10;

            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.pnl_Items.Visible = false;
            des.grbx_Item.Visible = false;
            des.Size = new Size(420, 200);

            des.ShowDialog();
        }
        #endregion

        #region Delete
        private void btn_Des1_Delete_Click(object sender, EventArgs e)
        {
            com_Des1.SelectedValue = -1;
        }
        private void btn_Des2_Delete_Click(object sender, EventArgs e)
        {
            com_Des2.SelectedValue = -1;
        }
        private void btn_Des3_Delete_Click(object sender, EventArgs e)
        {
            com_Des3.SelectedValue = -1;
        }
        private void btn_Des4_Delete_Click(object sender, EventArgs e)
        {
            com_Des4.SelectedValue = -1;
        }
        private void btn_Des5_Delete_Click(object sender, EventArgs e)
        {
            com_Des5.SelectedValue = -1;
        }
        private void btn_Des6_Delete_Click(object sender, EventArgs e)
        {
            com_Des6.SelectedValue = -1;
        }
        private void btn_Des7_Delete_Click(object sender, EventArgs e)
        {
            com_Des7.SelectedValue = -1;
        }
        #endregion

        #region Validated
        private void com_Des1_Validated(object sender, EventArgs e)
        {
            if (com_Des1.SelectedValue == null)
            {
                com_Des1.Text = "";
            }
        }
        private void com_Des2_Validated(object sender, EventArgs e)
        {
            if (com_Des2.SelectedValue == null)
            {
                com_Des2.Text = "";
            }
        }
        private void com_Des3_Validated(object sender, EventArgs e)
        {
            if (com_Des3.SelectedValue == null)
            {
                com_Des3.Text = "";
            }
        }
        private void com_Des4_Validated(object sender, EventArgs e)
        {
            if (com_Des4.SelectedValue == null)
            {
                com_Des4.Text = "";
            }
        }
        private void com_Des5_Validated(object sender, EventArgs e)
        {
            if (com_Des5.SelectedValue == null)
            {
                com_Des5.Text = "";
            }
        }
        private void com_Des6_Validated(object sender, EventArgs e)
        {
            if (com_Des6.SelectedValue == null)
            {
                com_Des6.Text = "";
            }
        }
        private void com_Des7_Validated(object sender, EventArgs e)
        {
            if (com_Des7.SelectedValue == null)
            {
                com_Des7.Text = "";
            }
        }

        #endregion

        #endregion

        #region Pic
        private void btn_pic_item_Edit_Click(object sender, EventArgs e)
        {
            open_pic();
        }
        private void btn_pic_item_Delete_Click(object sender, EventArgs e)
        {
            pic_Item.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_Item.Image = Main.imageList64.Images["Camera_64.png"];         
        }
        private void btn_ShowImage_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select_Node" | Tag.ToString() == "Edit")
            {
                DataTable dt_image = new DataTable();
                dt_image = Items.Image_Select(txt_Item_ID.Text);
                if (dt_image.Rows.Count > 0)
                {
                    pic_Item.Image = byteArrayToImage((byte[])(dt_image.Rows[0][1]));
                    pic_Item.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (Tag.ToString() != "Edit")
                    {
                        Main.ds.Tables[34].Rows.Add(dt_image.Rows[0].ItemArray);
                    }                   
                }
                else
                {
                    if (Tag.ToString() != "Edit")
                    {
                        MessageBox.Show("لا يوجد صورة لهذا الصنف", "عرض الصورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }                          
        }
        #endregion

        #endregion

        #region Units
        private void btn_Unit_Add_Click(object sender, EventArgs e)
        {
            frm_units = new Items.FRM_Units();
            frm_units.Image_Edit = Main.imageList16.Images["Edit_16.png"];
            frm_units.Image_Save = Main.imageList16.Images["Save_16.png"];
            frm_units.Image_Cancel = Main.imageList16.Images["Cancel_16.png"];
            frm_units.COM_UNITS = com_Unit;
            frm_units.dt_units = Main.ds.Tables[28];

            frm_units.ShowDialog();
        }
        private void btn_Item_Unit_Add_Click(object sender, EventArgs e)
        {
            // Unit Must not Empty
            if(com_Unit.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد وحدة", "إضافة وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Unit.DroppedDown = true;
                return;
            }

            // If this unit add before
            foreach (DataGridViewRow r in DGV_Units.Rows)
            {
                if(r.Cells[1].Value.ToString() == com_Unit.SelectedValue.ToString())
                {
                    r.Selected = true;
                    MessageBox.Show("هذه الوحدة تم إضافتها سابقاً", "إضافة وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // If It's The First Unit
            if (DGV_Units.Rows.Count == 0) { txt_OP.Text = "1"; }

            // Must Enter The Operator For The Non First Unit
            if(txt_OP.Text.Trim() == "")
            {
                MessageBox.Show("يجب تحديد عدد الوحدة الأولى الموجود بتلك الوحدة", "إضافة وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_OP.Select();
                return;
            }

            // Add Unit
            foreach (Control c in price_edit.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            DGV_Units.Rows.Add();
        }
        private void DGV_Units_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btn_Item_Unit_Add.Focused | Tag.ToString() == "New" | Tag.ToString() == "Edit")
            {
                DGV_Units.Rows[e.RowIndex].Cells[0].Value = (DGV_Units.Rows.Count > 1) ? Convert.ToInt16(DGV_Units.Rows[e.RowIndex - 1].Cells[0].Value) + 1 : 1;
                DGV_Units.Rows[e.RowIndex].Cells[1].Value = com_Unit.SelectedValue;
                DGV_Units.Rows[e.RowIndex].Cells[2].Value = txt_OP.Text;
                DGV_Units.Rows[e.RowIndex].Cells[3].Value = imageList16.Images["Edit_16.png"];
                DGV_Units.Rows[e.RowIndex].Cells[4].Value = (e.RowIndex > 0) ? "x" : "";

                txt_OP.Text = "";
                DGV_Units.ClearSelection();

                // Add price for this unit
                DGV_Pricing.Rows.Add();

                // Add Units In com_Units_Barcode
                com_Units_Barcode.Items.Clear();
                int ii = Convert.ToInt16(com_Unit.SelectedValue);
                foreach (DataGridViewRow r in DGV_Units.Rows)
                {
                    com_Unit.SelectedValue = r.Cells[1].Value;
                    com_Units_Barcode.Items.Add(com_Unit.Text);
                }
                com_Unit.SelectedValue = ii;
            }
        }
        private void DGV_Units_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // حذف
            {
                if(e.RowIndex == 0)
                {
                    MessageBox.Show("لا يمكن حذف الوحدة الأولى", "حذف وحدة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(Tag.ToString() != "New")
                {
                    Items.Item_ID = txt_Item_ID.Text;
                    Items.unit_id = Convert.ToInt16(DGV_Units.Rows[e.RowIndex].Cells[1].Value);
                    if(Items.Item_Units_Delete_Check() == "0")
                    {
                        MessageBox.Show("لا يمكن حذف هذه الوحدة لأنها أستخدمت في بعض السندات", "حذف وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                int s =Convert.ToInt16(DGV_Units.Rows[e.RowIndex].Cells[1].Value);

                // Delete From Units
                DGV_Units.Rows.RemoveAt(e.RowIndex); 
                if (DGV_Units.RowCount > 0)
                {
                    for (int i = 0; i < DGV_Units.RowCount; i++)
                    {
                        DGV_Units.Rows[i].Cells[0].Value = i + 1;
                    }
                }

                // Delete From Price
                DGV_Pricing.Rows.RemoveAt(e.RowIndex); 

                // Rename Units In com_Units_Barcode
                com_Units_Barcode.Items.Clear();
                foreach (DataGridViewRow r in DGV_Units.Rows)
                {
                    com_Units_Barcode.Items.Add(r.Cells[1].Value.ToString());
                }

                // Delete From Barcode
                foreach (DataGridViewRow r in DGV_Barcode.Rows) 
                {
                    if (Convert.ToInt16(r.Cells[1].Value) == s)
                    {
                        DGV_Barcode.Rows.RemoveAt(r.Index);
                    }
                }
                if (DGV_Barcode.RowCount > 0)
                {
                    for (int i = 0; i < DGV_Barcode.RowCount; i++)
                    {
                        DGV_Barcode.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
            else if(e.ColumnIndex == 3) // تعديل
            {
                frm_units_edit = new Library.Items.FRM_Items_Units_Edit();
                frm_units_edit.com_Unit.DataSource = Main.ds.Tables[28];
                frm_units_edit.com_Unit.SelectedValue = DGV_Units.Rows[e.RowIndex].Cells[1].Value;
                frm_units_edit.txt_OP.Text = DGV_Units.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(e.RowIndex == 0) { frm_units_edit.txt_OP.ReadOnly = true; }
                frm_units_edit.DGV_UNITS = DGV_Units;

                string s = DGV_Units.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm_units_edit.ShowDialog();

                // Rename Units In DGV_Pricing
                foreach (DataGridViewRow r in DGV_Units.Rows)
                {
                    DGV_Pricing.Rows[r.Index].Cells[0].Value = r.Cells[1].Value;
                }

                // Rename Units In com_Units_Barcode
                com_Units_Barcode.Items.Clear();
                int ii = Convert.ToInt16(com_Unit.SelectedValue);
                foreach (DataGridViewRow r in DGV_Units.Rows)
                {
                    com_Unit.SelectedValue = r.Cells[1].Value;
                    com_Units_Barcode.Items.Add(com_Unit.Text);
                }
                com_Unit.SelectedValue = ii;

                // Rename Units In DGV_Barcode
                foreach (DataGridViewRow r in DGV_Barcode.Rows)
                {
                    if(r.Cells[1].Value.ToString() == s)
                    {
                        r.Cells[1].Value = DGV_Units.SelectedRows[0].Cells[1].Value.ToString();
                    }
                }
            }
        }
        #endregion

        #region Pricing
        private void DGV_Pricing_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btn_Item_Unit_Add.Focused | Tag.ToString() == "New" | Tag.ToString() == "Edit")
            {          
                DGV_Pricing.Rows[e.RowIndex].Cells[0].Value = DGV_Units.Rows[e.RowIndex].Cells[1].Value;
                DGV_Pricing.Rows[e.RowIndex].Cells[1].Value = price_edit.txt_PPrice.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[3].Value = price_edit.txt_Sal1.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[4].Value = price_edit.txt_Sal2.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[5].Value = price_edit.txt_Sal3.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[6].Value = price_edit.txt_Sal4.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[7].Value = price_edit.txt_Sal5.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[8].Value = price_edit.txt_Sal6.Text;
                DGV_Pricing.Rows[e.RowIndex].Cells[9].Value = imageList16.Images["Edit_16.png"];

                DGV_Pricing.ClearSelection();
            }
        }
        private void DGV_Pricing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9) // تعديل
            {               
                price_edit.DGV_Pricing = DGV_Pricing;
                price_edit.com_Price_Unit.DataSource = Main.ds.Tables[28];
                price_edit.com_Price_Unit.SelectedValue = DGV_Pricing.SelectedRows[0].Cells[0].Value;
                price_edit.txt_PPrice.Text = DGV_Pricing.SelectedRows[0].Cells[1].Value.ToString();
                price_edit.txt_Sal1.Text = DGV_Pricing.SelectedRows[0].Cells[3].Value.ToString();
                price_edit.txt_Sal2.Text = DGV_Pricing.SelectedRows[0].Cells[4].Value.ToString();
                price_edit.txt_Sal3.Text = DGV_Pricing.SelectedRows[0].Cells[5].Value.ToString();
                price_edit.txt_Sal4.Text = DGV_Pricing.SelectedRows[0].Cells[6].Value.ToString();
                price_edit.txt_Sal5.Text = DGV_Pricing.SelectedRows[0].Cells[7].Value.ToString();
                price_edit.txt_Sal6.Text = DGV_Pricing.SelectedRows[0].Cells[8].Value.ToString();

                price_edit.ShowDialog();
            }
        }
        #endregion

        #region Barcode
        private void btn_Barcode_Add_Click(object sender, EventArgs e)
        {
            if (com_Units_Barcode.Text == "")
            {
                MessageBox.Show("يجب تحديد وحدة", "إضافة باركود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Units_Barcode.DroppedDown = true;
                return;
            }
            if (txt_Barcode.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال الباركود الخاص بتلك الوحدة", "إضافة باركود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Barcode.Select();
                return;
            }

            DGV_Barcode.Rows.Add();
        }
        private void DGV_Barcode_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btn_Barcode_Add.Focused | Tag.ToString() == "New" | Tag.ToString() == "Edit")
            {
                DGV_Barcode.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;

                string s = com_Unit.Text;
                com_Unit.Text = com_Units_Barcode.Text;
                DGV_Barcode.Rows[e.RowIndex].Cells[1].Value = com_Unit.SelectedValue;
                com_Unit.Text = s;

                DGV_Barcode.Rows[e.RowIndex].Cells[2].Value = txt_Barcode.Text;
                DGV_Barcode.Rows[e.RowIndex].Cells[3].Value = imageList16.Images["Edit_16.png"];
                DGV_Barcode.Rows[e.RowIndex].Cells[4].Value = "x";

                com_Units_Barcode.SelectedValue = -1;
                txt_Barcode.Text = "";

                DGV_Barcode.ClearSelection();
            }
        }
        private void DGV_Barcode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // حذف
            {
                DGV_Barcode.Rows.RemoveAt(e.RowIndex);
                if (DGV_Barcode.RowCount > 0)
                {
                    for (int i = 0; i < DGV_Barcode.RowCount; i++)
                    {
                        DGV_Barcode.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
            else if (e.ColumnIndex == 3) // تعديل
            {
                frm_barcode_edit = new Library.Items.FRM_Barcode_Edit();
                frm_barcode_edit.com_Units_Barcode.DataSource = com_Units_Barcode.DataSource;
                frm_barcode_edit.com_Units_Barcode.Text = DGV_Barcode.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm_barcode_edit.txt_Barcode.Text = DGV_Barcode.Rows[e.RowIndex].Cells[2].Value.ToString();

                frm_barcode_edit.DGV_Unit_Barcode = DGV_Barcode;
                frm_barcode_edit.ShowDialog();
            }
        }
        #endregion

        #region Options
        private void chk_Complex_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Complex.Checked)
            {
                grbx_SPrice.Visible = true;
            }
            else
            {
                grbx_SPrice.Visible = false;
            }
        }
        #endregion

        #region Ven
        private void btn_Items_Ven_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Items_Des des = new G.FRM_Items_Des(this);
            des.Text = lbl_Other_Ven.Text;
            des.des_label = lbl_des1;
            des.des_com = com_Items_Ven;
            des.des_id = 11;
            des.dv = des11_view;
            des.btn_Edit_des.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save_des.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel_des.Image = Main.imageList16.Images["Cancel_16.png"];

            des.btn_Edit.Image = Main.imageList16.Images["Edit_16.png"];
            des.btn_Save.Image = Main.imageList16.Images["Save_16.png"];
            des.btn_Cancel.Image = Main.imageList16.Images["Cancel_16.png"];
            des.list_items.DataSource = des11_view;

            des.ShowDialog();
        }
        private void btn_Items_Count_Ven_Search_Click(object sender, EventArgs e)
        {

        }
        private void btn_Items_Count_Ven_Edit_Click(object sender, EventArgs e)
        {
            Main.Ven_Form = new FRM_Ven(Main);
            Main.Ven_Form.FormBorderStyle = FormBorderStyle.FixedSingle;

            Main.Ven_Form.BackColor = Color.White;
            Main.Ven_Form.Width = 1000;
            Main.Ven_Form.WindowState = FormWindowState.Normal;
            Main.Ven_Form.ShowDialog();
            com_Items_count_Ven_name.SelectedValue = Main.Ven_Form.txt_Ven_ID.Text;
        }
        private void btn_Items_count_Ven_Add_Click(object sender, EventArgs e)
        {
            if (com_Items_count_Ven_name.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد مورد", "إضافة مورد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Items_count_Ven_name.DroppedDown = true;
                return;
            }

            // If this Ven add before
            foreach (DataGridViewRow r in DGV_Items_Ven.Rows)
            {
                if (r.Cells[1].Value.ToString() == com_Items_count_Ven_name.Text)
                {
                    r.Selected = true;
                    MessageBox.Show("هذا المورد تم إضافته سابقاً", "إضافة مورد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DGV_Items_Ven.Rows.Add();
        }
        private void btn_Items_Ven_Add_Click(object sender, EventArgs e)
        {
            if (com_Items_Ven.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد مورد", "إضافة مورد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Items_Ven.DroppedDown = true;
                return;
            }

            // If this Ven add before
            foreach (DataGridViewRow r in DGV_Items_Ven.Rows)
            {
                if (r.Cells[1].Value.ToString() == com_Items_Ven.Text)
                {
                    r.Selected = true;
                    MessageBox.Show("هذا المورد تم إضافته سابقاً", "إضافة مورد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DGV_Items_Ven.Rows.Add();
        }
        private void DGV_Items_Ven_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DGV_Items_Ven.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            DGV_Items_Ven.Rows[e.RowIndex].Cells[2].Value = "x";
            DGV_Items_Ven.ClearSelection();

            if (btn_Items_count_Ven_Add.Focused)
            {
                DGV_Items_Ven.Rows[e.RowIndex].Cells[1].Value = com_Items_count_Ven_name.Text;                
            }
            else if (btn_Items_Ven_Add.Focused)
            {        
                DGV_Items_Ven.Rows[e.RowIndex].Cells[1].Value = com_Items_Ven.Text;                              
            }
        }
        private void DGV_Items_Ven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // حذف
            {
                DGV_Items_Ven.Rows.RemoveAt(e.RowIndex);
                if (DGV_Items_Ven.RowCount > 0)
                {
                    for (int i = 0; i < DGV_Items_Ven.RowCount; i++)
                    {
                        DGV_Items_Ven.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
        }

        #endregion

        #region Alt       
        private void btn_Alternateve_Item_Add_Click(object sender, EventArgs e)
        {
            if (com_Alternative_Item_Name.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد صنف", "إضافة صنف بديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Alternative_Item_Name.DroppedDown = true;
                return;
            }

            // If this Item add before
            foreach (DataGridViewRow r in DGV_Alt.Rows)
            {
                if (r.Cells[1].Value == com_Alternative_Item_Name.SelectedValue)
                {
                    r.Selected = true;
                    MessageBox.Show("هذا الصنف تم إضافته سابقاً", "إضافة صنف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DGV_Alt.Rows.Add();
        }
        private void DGV_Alt_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btn_Alternateve_Item_Add.Focused)
            {
                DGV_Alt.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                DGV_Alt.Rows[e.RowIndex].Cells[1].Value = com_Alternative_Item_Name.SelectedValue.ToString();
                DGV_Alt.Rows[e.RowIndex].Cells[2].Value = com_Alternative_Item_Name.SelectedValue.ToString();
                DGV_Alt.Rows[e.RowIndex].Cells[3].Value = "x";

                DGV_Alt.ClearSelection();
            }
        }
        private void DGV_Alt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) // حذف
            {
                DGV_Alt.Rows.RemoveAt(e.RowIndex);
                if (DGV_Alt.RowCount > 0)
                {
                    for (int i = 0; i < DGV_Alt.RowCount; i++)
                    {
                        DGV_Alt.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
        }
        #endregion

    }
}
