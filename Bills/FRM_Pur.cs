using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Bills
{
    public partial class FRM_Pur : Form
    {
        #region Declaration
        CLS_Pur Pur = new CLS_Pur();
        Bills.FRM_Jor Jor;
        G.CLS_G G = new G.CLS_G();
        FRM_Pur_Add add = new FRM_Pur_Add();
        DataRow dr_Pur;
        bool up;

        DataTable Temp_dgv = new DataTable();

        DataView dv_branches;
        DataView dv_stores;
        DataView dv_cc1;
        DataView dv_cc2;
        DataView dv_users;
        DataView dv_ven;
        DataView dv_typs;
        DataView dv_Items;
        DataView dv_Units;
        DataView dv_Item_Units;
        DataView dv_Item_Prices;
        DataView dv_currency;

        frm_Main Main;
        #endregion

        public FRM_Pur(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_Stores.Image = Main.imageList32.Images["store_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];

            button_New.Image = Main.imageList48.Images["new_48.png"];
            button_Edit.Image = Main.imageList48.Images["edit_48.png"];
            button_Delete.Image = Main.imageList48.Images["delete_48.png"];
            button_Cancel.Image = Main.imageList48.Images["cancel_48.png"];
            button_Print.Image = Main.imageList48.Images["print_48.png"];
            button_Settings.Image = main.imageList48.Images["settings_48.png"];
            button_Close.Image = Main.imageList48.Images["close_48.png"];

            dv_branches = new DataView(Main.ds.Tables[1]);
            dv_stores = new DataView(Main.ds.Tables[2]);
            dv_cc1 = new DataView(Main.ds.Tables[3]);
            dv_cc2 = new DataView(Main.ds.Tables[3]);
            dv_users = new DataView(Main.ds.Tables[0]);
            dv_ven = new DataView(Main.ds.Tables[9]);
            dv_typs = new DataView(Main.ds.Tables[16]);
            dv_Items = new DataView(Main.ds.Tables[5]);
            dv_Units = new DataView(Main.ds.Tables[28]);
            dv_Item_Units = new DataView(Main.ds.Tables[29]);
            dv_Item_Prices = new DataView(Main.ds.Tables[30]);
            dv_currency = new DataView(Main.ds.Tables[35]);

            dv_cc1.RowFilter = "CC1 = 1";
            dv_cc2.RowFilter = "CC2 = 1";
            dv_Items.RowFilter = "Is_Parent = 0";

            com_Bill_Branches.DataSource = dv_branches;
            com_Stores.DataSource = dv_stores;
            com_CC1.DataSource = dv_cc1;
            com_CC2.DataSource = dv_cc2;
            com_Bill_User.DataSource = dv_users;
            com_Ven_Name.DataSource = dv_ven;
            com_B_Type.DataSource = dv_typs;
            com_Currency.DataSource = dv_currency;

            com_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
            com_CC1.SelectedValue = -1;
            com_CC2.SelectedValue = -1;
            com_Bill_User.SelectedValue = -1;
            com_Ven_Name.SelectedValue = -1;
            com_B_Type.SelectedValue = -1;
            com_Currency.SelectedValue = -1;
            
            DGV.AutoGenerateColumns = false;

            #region ContextMenuStrips
            // Branches
            lbl_bill_Branches.Text = com_Bill_Branches.Text;
            contextMenuStrip_branches.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_Bill_Branches.Items.Count; i++)
            {
                contextMenuStrip_branches.Items.Add(com_Bill_Branches.GetItemText(com_Bill_Branches.Items[i]),Main.imageList16.Images["branche_16.png"]);
            }

            // Stores
            contextMenuStrip_stores.ForeColor = Color.MidnightBlue;
            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < com_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(com_Stores.GetItemText(com_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (com_Stores.Items.Count > 0) { com_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = com_Stores.Text;

            // CC1
            lbl_CC1.Text = com_CC1.Text;
            btn_cc1_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc1.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_CC1.Items.Count; i++)
            {
                contextMenuStrip_cc1.Items.Add(com_CC1.GetItemText(com_CC1.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // CC2
            lbl_CC2.Text = com_CC2.Text;
            btn_cc2_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc2.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_CC2.Items.Count; i++)
            {
                contextMenuStrip_cc2.Items.Add(com_CC2.GetItemText(com_CC2.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // Users
            contextMenuStrip_users.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_Bill_User.Items.Count; i++)
            {
                contextMenuStrip_users.Items.Add(com_Bill_User.GetItemText(com_Bill_User.Items[i]), Main.imageList16.Images["user_16.png"]);
            }
            #endregion

            #region DGV Fildes
            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "Item_ID";
            Item_ID.DataPropertyName = "Items_ID";
            Item_ID.HeaderText = "كود الصنف";
            Item_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_ID.Width = 130;
            DGV.Columns.Add(Item_ID);

            var Item_Name = new DataGridViewTextBoxColumn();
            Item_Name.Name = "Item_Name";
            Item_Name.DataPropertyName = "Items_Name";
            Item_Name.HeaderText = "أسم الصنف";
            Item_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item_Name.Width = 130;
            DGV.Columns.Add(Item_Name);

            var Unit = new DataGridViewComboBoxColumn();
            Unit.Name = "Unit";
            Unit.DataPropertyName = "Item_Unit";
            Unit.DataSource = dv_Units;
            Unit.ValueMember = "unit_id";
            Unit.DisplayMember = "anm";
            Unit.HeaderText = "الوحدة";
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Unit.Width = 75;
            DGV.Columns.Add(Unit);

            var Item_Quan = new DataGridViewTextBoxColumn();
            Item_Quan.Name = "Item_Quan";
            Item_Quan.HeaderText = "الكمية";
            Item_Quan.DataPropertyName = "Items_Quan";
            Item_Quan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_Quan.Width = 100;
            Item_Quan.Visible = true;
            DGV.Columns.Add(Item_Quan);

            var Bonus = new DataGridViewTextBoxColumn();
            Bonus.Name = "Bonus";
            Bonus.HeaderText = "الإضافي";
            Bonus.DataPropertyName = "Bonus";
            Bonus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Bonus.Width = 100;
            Bonus.Visible = true;
            DGV.Columns.Add(Bonus);

            var Items_PPrice = new DataGridViewTextBoxColumn();
            Items_PPrice.Name = "Items_PPrice";
            Items_PPrice.HeaderText = "سعر الشراء";
            Items_PPrice.DataPropertyName = "Items_PPrice";
            Items_PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_PPrice.Width = 100;
            Items_PPrice.Visible = true;
            DGV.Columns.Add(Items_PPrice);

            var Items_SPrice = new DataGridViewTextBoxColumn();
            Items_SPrice.Name = "Items_SPrice";
            Items_SPrice.HeaderText = "سعر البيع";
            Items_SPrice.DataPropertyName = "Items_SPrice";
            Items_SPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_SPrice.Width = 100;
            Items_SPrice.Visible = true;
            DGV.Columns.Add(Items_SPrice);

            var Items_Total = new DataGridViewTextBoxColumn();
            Items_Total.Name = "Items_Total";
            Items_Total.HeaderText = "الإجمالي";
            Items_Total.DataPropertyName = "Items_Total";
            Items_Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_Total.Width = 100;
            Items_Total.Visible = true;
            DGV.Columns.Add(Items_Total);

            var Items_Dis_Rate = new DataGridViewTextBoxColumn();
            Items_Dis_Rate.Name = "Items_Dis_Rate";
            Items_Dis_Rate.HeaderText = "نسبة الخصم %";
            Items_Dis_Rate.DataPropertyName = "Items_Dis_Rate";
            Items_Dis_Rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_Dis_Rate.Width = 105;
            Items_Dis_Rate.Visible = true;
            DGV.Columns.Add(Items_Dis_Rate);

            var Items_Dis_Value = new DataGridViewTextBoxColumn();
            Items_Dis_Value.Name = "Items_Dis_Value";
            Items_Dis_Value.HeaderText = "مبلغ الخصم";
            Items_Dis_Value.DataPropertyName = "Items_Dis_Value";
            Items_Dis_Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_Dis_Value.Width = 100;
            Items_Dis_Value.Visible = true;
            DGV.Columns.Add(Items_Dis_Value);

            var Total_PPrice = new DataGridViewTextBoxColumn();
            Total_PPrice.Name = "Net";
            Total_PPrice.HeaderText = "الصافي";
            Total_PPrice.DataPropertyName = "Net";
            Total_PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total_PPrice.Width = 100;
            Total_PPrice.Visible = true;
            DGV.Columns.Add(Total_PPrice);
            #endregion
        }

        #region Pro
        public void ChangetxtSearch(string s)
        {
            Location = (Parent == null) ? new Point(Location.X - 40, Location.Y + 45) : Jor.Location;
            Height = 700;
            Width = 975;
            WindowState = FormWindowState.Normal;
            StartPosition = (WindowState == FormWindowState.Maximized) ? FormStartPosition.CenterScreen : FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.Sizable;
            textBox_Search.Focus();
            textBox_Search.Text = s;
            KeyPressEventArgs kpea = new KeyPressEventArgs((char)Keys.Enter);
            textBox_Search_KeyPress(null, kpea);
            textBox_Search.Text = "";
            Show();
        }
        void Set_default()
        {
            // Head var

            Pur.Ven_ID ="";
            Pur.Pur_B_Type = 1;
            Pur.Pur_Pur_No ="";
            Pur.Pur_Notes ="";
            Pur.Pur_Total = 0;
            Pur.Pur_Total_Dis_Rate = 0;
            Pur.Pur_Total_Dis_Value = 0;
            Pur.Pur_Net = 0;
            Pur.Pur_Total_SPrice = 0;
            if (Pur.dt_Items != null) { Pur.dt_Items.Clear(); }

            // Details var
            Pur.Item_ID = "-1";
            Pur.Item_Name = "";
            Pur.Item_Quan = 1;
            Pur.Item_Bonus = 0;
            Pur.Item_PPrice = 0;
            Pur.Item_SPrice = 0;
            Pur.Item_Net = 0;

            Pur.Item_Dis_Value = 0;
            Pur.Item_Dis_Rate = 0;
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    com_Bill_Branches.Enabled = false;
                    com_Stores.Enabled = false;
                    com_CC1.Enabled = false;
                    com_CC2.Enabled = false;
                    btn_cc1_del.Visible = false;
                    btn_cc2_del.Visible = false;

                    btn_Add.Visible = false;
                    txt_Notes.ReadOnly = true;
                    com_B_Type.Enabled = false;
                    com_Ven_Name.Enabled = false;
                    dtp_Pur_Date.Enabled = false;
                    txt_Pur_Pur_No.ReadOnly = true;
                    dtp_Pur_Pur_Date.Enabled = false;
                    com_Currency.Enabled = false;
                    txt_Currency_Rate.ReadOnly = true;

                    txt_Barcode.Enabled = false;

                    panel_Navigations.Enabled = true;

                    button_New.Visible = true;
                    //button_New.Text = "جديد";
                    button_New.Image = Main.imageList48.Images["new_48.png"];
                    button_Edit.Visible = true;
                   // button_Edit.Text = "تعديل";
                    button_Edit.Image = Main.imageList48.Images["edit_48.png"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Print.Visible = true;
                    button_Settings.Visible = true;
                    button_Close.Visible = true;

                    DGV.DataSource = Main.dt_IO;
                    Main.dt_IO.DefaultView.RowFilter = string.Format("Bill_ID ='" + txt_Bill_ID.Text + "' and Bill_Type = 7");
                    Other_Col();
                    DGV.AllowUserToDeleteRows = false;

                    textBox_Total_Dis_Rate.ReadOnly = true;
                    textBox_Total_Dis_Value.ReadOnly = true;
                    textBox_Total_Dis_Rate.ForeColor = Color.Black;
                    textBox_Total_Dis_Value.ForeColor = Color.Black;

                    if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                    EmptyZero();

                    break;
                #endregion

                #region New
                case "New":

                    com_Bill_Branches.Enabled = true;
                    com_Stores.Enabled = true;
                    com_CC1.Enabled = true;
                    com_CC2.Enabled = true;

                    btn_Add.Visible = true;
                    txt_Notes.ReadOnly = false;
                    com_B_Type.Enabled = true;
                    com_Ven_Name.Enabled = true;
                    dtp_Pur_Date.Enabled = true;
                    txt_Pur_Pur_No.ReadOnly = false;
                    dtp_Pur_Pur_Date.Enabled = true;
                    com_Currency.Enabled = true;
                    txt_Currency_Rate.ReadOnly = false;

                    com_CC1.SelectedValue = -1;
                    com_CC2.SelectedValue = -1;
                    com_Currency.SelectedIndex = 0;

                    Set_default();

                    groupBox_Header.Enabled = true;
                    txt_Bill_ID.Clear();
                    dtp_Pur_Date.Value = DateTime.Today;
                    dtp_Pur_Date.Format = DateTimePickerFormat.Short;
                    com_B_Type.SelectedIndex = 0;
                    txt_Pur_Pur_No.Clear();
                    dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Custom;
                    dtp_Pur_Pur_Date.Checked = false;
                    txt_Notes.Clear();
                    com_Ven_Name.SelectedValue = -1;
                    btn_Ref_No.Text = "";

                    txt_Total_Pur_Price.Text = "0";
                    textBox_Total_Dis_Rate.Text = "Rate";  
                    textBox_Total_Dis_Value.Text = "Value";
                    textBox_Total_Dis_Rate.ForeColor = Color.Silver;
                    textBox_Total_Dis_Value.ForeColor = Color.Silver;
                    textBox_Net.Text = "0";
                    txt_Total_Sal_Price.Text = "0";

                    // Details

               

                    txt_Barcode.Enabled = true;


                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    DGV.AllowUserToDeleteRows = true;

                    tab_Footer.Enabled = true;
                    panel_Navigations.Enabled = false;


                   // button_New.Text = "حفظ";
                    button_New.Image = Main.imageList48.Images["save_48.png"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;  
                                 
                    break;
                #endregion

                #region Edit
                case "Edit":

                    com_Bill_Branches.Enabled = true;
                    com_Stores.Enabled = true;
                    com_CC1.Enabled = true;
                    com_CC2.Enabled = true;
                    btn_cc1_del.Visible = (com_CC1.SelectedValue != null)? true : false;
                    btn_cc2_del.Visible = (com_CC2.SelectedValue != null) ? true : false;

                    btn_Add.Visible = true;
                    txt_Notes.ReadOnly = false;
                    com_B_Type.Enabled = true;
                    com_Ven_Name.Enabled = true;
                    dtp_Pur_Date.Enabled = true;
                    txt_Pur_Pur_No.ReadOnly = false;
                    dtp_Pur_Pur_Date.Enabled = true;
                    com_Currency.Enabled = true;
                    txt_Currency_Rate.ReadOnly = false;


                    txt_Barcode.Enabled = true;

                    DGV.DataSource = null;
                    DGV.AllowUserToDeleteRows = true;

                    // button_Edit.Text = "حفظ";
                    button_Edit.Image = Main.imageList48.Images["save_48.png"];
                    button_New.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

                    tab_Footer.Enabled = true;
   
                    textBox_Total_Dis_Rate.ReadOnly = false;
                    textBox_Total_Dis_Value.ReadOnly = false;

                    panel_Navigations.Enabled = false;
                    break;
                #endregion

                #region Empty
                case "Empty":

                    com_Bill_Branches.Enabled = false;
                    com_Stores.Enabled = false;
                    com_CC1.Enabled = false;
                    com_CC2.Enabled = false;
                    btn_cc1_del.Visible = false;
                    btn_cc2_del.Visible = false;

                    btn_Add.Visible = false;
                    txt_Notes.ReadOnly = true;
                    com_B_Type.Enabled = false;
                    com_Ven_Name.Enabled = false;
                    dtp_Pur_Date.Enabled = false;
                    txt_Pur_Pur_No.ReadOnly = true;
                    dtp_Pur_Pur_Date.Enabled = false;
                    com_Currency.Enabled = false;
                    txt_Currency_Rate.ReadOnly = true;

                    DGV.DataSource = null;
                    DGV.Rows.Clear();

                    // Clare Controls
                    // Head
                    Set_default();

                    com_Bill_Branches.Enabled = true;
                    com_CC1.SelectedValue = -1;
                    com_CC2.SelectedValue = -1;             
                    groupBox_Header.Enabled = true;

                    txt_Bill_ID.Clear();
                    dtp_Pur_Date.Value = DateTime.Today;
                    dtp_Pur_Date.Format = DateTimePickerFormat.Custom;
                    com_B_Type.SelectedIndex = 0;
                    txt_Pur_Pur_No.Clear();
                    dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Custom;
                    dtp_Pur_Pur_Date.Checked = false;
                    txt_Notes.Clear();
                    com_Currency.SelectedValue = -1;                 
                    com_B_Type.SelectedIndex = -1;
                    com_Ven_Name.SelectedValue = -1;
                    btn_Ref_No.Text = "";

                    txt_Total_Pur_Price.Text = "";
                    textBox_Total_Dis_Rate.Text = "Rate";
                    textBox_Total_Dis_Value.Text = "Value";
                    textBox_Total_Dis_Rate.ForeColor = Color.Silver;
                    textBox_Total_Dis_Value.ForeColor = Color.Silver;
                    textBox_Net.Text = "";
                    txt_Total_Sal_Price.Text = "";                          

                    txt_Barcode.Enabled = false;


                    panel_Navigations.Enabled = true;

                    button_New.Visible = true;
                  //  button_New.Text = "جديد";
                    button_New.Image = Main.imageList48.Images["new_48.png"];
                    button_Cancel.Visible = false;
                    button_Print.Visible = true;
                    button_Settings.Visible = true;
                    button_Close.Visible = true;

                    textBox_Total_Dis_Rate.ReadOnly = true;
                    textBox_Total_Dis_Value.ReadOnly = true;
                    textBox_Total_Dis_Rate.ForeColor = Color.Black;
                    textBox_Total_Dis_Value.ForeColor = Color.Black;

                    break;
                #endregion
            }
        }
        private DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in DGV.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            dt.Columns.Remove("الإجمالي");
            return dt;
        }
        private DataTable table(int t)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in DGV.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        void Recored()
        {

        }
        void Other_Col()
        {
            for (int i = 0; i < DGV.Rows.Count ; i++)
            {
                DGV.Rows[i].Cells["Items_Total"].Value = Math.Round(Convert.ToDecimal(DGV.Rows[i].Cells["Item_Quan"].Value) * Convert.ToDecimal(DGV.Rows[i].Cells["Items_PPrice"].Value),2);
                DGV.Rows[i].Cells["Net"].Value = Math.Round(Convert.ToDecimal(DGV.Rows[i].Cells["Items_Total"].Value) - Convert.ToDecimal(DGV.Rows[i].Cells["Items_Dis_Value"].Value), 2);
            }
        }
        void Navigate()
        {
            Tag = "Select";

            com_Stores.SelectedValue = dr_Pur["Store_ID"];
            com_CC1.SelectedValue = dr_Pur["CC1_ID"];
            com_CC2.SelectedValue = dr_Pur["CC2_ID"];
            com_Bill_User.SelectedValue = dr_Pur["User_ID"];

            txt_Bill_ID.Text = dr_Pur["Pur_ID"].ToString();
            dtp_Pur_Date.Value = Convert.ToDateTime(dr_Pur["Pur_Date"]);
            btn_Ref_No.Text = dr_Pur["Jor_ID"].ToString();
            com_B_Type.SelectedValue = dr_Pur["Pur_B_Type"];
            txt_Pur_Pur_No.Text = dr_Pur["Pur_Pur_No"].ToString();

            if (dr_Pur["Pur_Pur_Date"] != DBNull.Value)
            {
                dtp_Pur_Pur_Date.Value = Convert.ToDateTime(dr_Pur["Pur_Pur_Date"]);
                dtp_Pur_Pur_Date.Checked = true;
                dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dtp_Pur_Pur_Date.Checked = false;
                dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Custom;
            }

            txt_Notes.Text = dr_Pur["Pur_Notes"].ToString();
            com_Ven_Name.SelectedValue = dr_Pur["Ven_ID"];
            com_Currency.SelectedValue = dr_Pur["Currency"];
            txt_Currency_Rate.Text = dr_Pur["Currency_Rate"].ToString();

            txt_Total_Pur_Price.Text = dr_Pur["Pur_Total"].ToString();
            textBox_Total_Dis_Rate.Text = dr_Pur["Pur_Total_Dis_Rate"].ToString();
            textBox_Total_Dis_Value.Text = dr_Pur["Pur_Total_Dis_Value"].ToString();
            textBox_Net.Text = dr_Pur["Pur_Net"].ToString();
            txt_Total_Sal_Price.Text = dr_Pur["Pur_Total_SPrice"].ToString();

            DGV.DataSource = Main.dt_IO;
            Main.dt_IO.DefaultView.RowFilter = string.Format("Bill_ID ='" + txt_Bill_ID.Text + "' and Bill_Type = 7");
           
            Form_Mode("Select");         
        }
        void var()
        {
            Pur.Branche_ID = com_Bill_Branches.SelectedValue.ToString();
            Pur.Store_ID = Convert.ToInt32(com_Stores.SelectedValue);
            Pur.CC1_ID = (com_CC1.SelectedValue == null)? null : com_CC1.SelectedValue.ToString();
            Pur.CC2_ID = (com_CC2.SelectedValue == null) ? null : com_CC2.SelectedValue.ToString();
            Pur.Bill_ID = txt_Bill_ID.Text;
            Pur.Ven_ID = (com_Ven_Name.SelectedValue != null) ? com_Ven_Name.SelectedValue.ToString() : null;
            Pur.Pur_B_Type = Convert.ToInt32(com_B_Type.SelectedValue);
            Pur.Pur_Pur_No = txt_Pur_Pur_No.Text.ToString();

            if (dtp_Pur_Pur_Date.Checked == true)
            {
                Pur.Pur_Pur_Date = dtp_Pur_Pur_Date.Value;
            }
            else
            {
                Pur.Pur_Pur_Date = null;
            }

            Pur.Pur_Date = dtp_Pur_Date.Value;
            Pur.Pur_Notes = txt_Notes.Text.ToString();
            Pur.Currency = Convert.ToInt16(com_Currency.SelectedValue);
            Pur.Currency_Rate = Convert.ToDecimal(txt_Currency_Rate.Text);
            Pur.Pur_Total = Convert.ToDecimal(txt_Total_Pur_Price.Text);
            Pur.Pur_Total_Dis_Rate = (textBox_Total_Dis_Rate.Text != "." && textBox_Total_Dis_Rate.Text != "Rate") ? Math.Round(Convert.ToDecimal(textBox_Total_Dis_Rate.Text), 2) : 0;
            Pur.Pur_Total_Dis_Value = (textBox_Total_Dis_Value.Text != "." && textBox_Total_Dis_Value.Text != "Value") ? Math.Round(Convert.ToDecimal(textBox_Total_Dis_Value.Text), 2) : 0;
            Pur.Pur_Net = Convert.ToDecimal(textBox_Net.Text);
            Pur.Pur_Total_SPrice = Convert.ToDecimal(txt_Total_Sal_Price.Text);
            Pur.User_ID = Convert.ToInt32(com_Bill_User.SelectedValue);
            Pur.dt_Items = table();
        }
        void UpDowen()
        {
            if (Main.tab_Main.Visible == false && up == false)
            {
                up = true;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else if (Main.tab_Main.Visible == true && up == true)
            {
                up = false;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
        }
        void Calc_Totals()
        {
            decimal pp = 0;
            decimal sp = 0;

            foreach (DataGridViewRow r in DGV.Rows)
            {
                pp += Convert.ToDecimal(r.Cells["Net"].Value);
                sp += Convert.ToDecimal(r.Cells["Items_SPrice"].Value) * Convert.ToDecimal(r.Cells["Item_Quan"].Value);

                txt_Total_Pur_Price.Text = pp.ToString();
                txt_Total_Sal_Price.Text = sp.ToString();
            }
        }
        void EmptyZero()
        {
            foreach (DataGridViewRow r in DGV.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if(c.ColumnIndex > 2)
                    {
                        if (Convert.ToDecimal(c.Value) == 0) { c.Style.ForeColor = Color.Transparent; }
                    }
                }               
            }
        }

        #endregion

        #region Form
        private void FRM_Pur_Enter(object sender, EventArgs e)
        {
            UpDowen();
        }
        private void FRM_Pur_Shown(object sender, EventArgs e)
        {
            dv_stores.RowFilter = "Branche_ID ='" + com_Bill_Branches.SelectedValue + "'";
            com_Stores.SelectedValue = Main.combo_Stores.SelectedValue;
            com_Bill_User.SelectedValue = Main.combo_Users.SelectedValue;

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }
        }
        #endregion

        #region Panel_FRM_Header

        #region btn display
        private void btn_Bill_Branche_MouseEnter(object sender, EventArgs e)
        {
            btn_Bill_Branche.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Bill_Branche_MouseLeave(object sender, EventArgs e)
        {
            btn_Bill_Branche.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Stores_MouseEnter(object sender, EventArgs e)
        {
            btn_Stores.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Stores_MouseLeave(object sender, EventArgs e)
        {
            btn_Stores.FlatStyle = FlatStyle.Flat;
        }

        private void btn_CC1_MouseEnter(object sender, EventArgs e)
        {
            btn_CC1.FlatStyle = FlatStyle.Popup;
        }
        private void btn_CC1_MouseLeave(object sender, EventArgs e)
        {
            btn_CC1.FlatStyle = FlatStyle.Flat;
        }
        private void btn_CC2_MouseEnter(object sender, EventArgs e)
        {
            btn_CC2.FlatStyle = FlatStyle.Popup;
        }

        private void btn_CC2_MouseLeave(object sender, EventArgs e)
        {
            btn_CC2.FlatStyle = FlatStyle.Flat;
        }
        private void lbl_CC1_TextChanged(object sender, EventArgs e)
        {
            btn_cc1_del.Visible = (lbl_CC1.Text != "" && Tag.ToString() == "New" | Tag.ToString() == "Edit") ? true : false;
        }

        private void lbl_CC2_TextChanged(object sender, EventArgs e)
        {
            btn_cc2_del.Visible = (lbl_CC2.Text != "" && Tag.ToString() == "New" | Tag.ToString() == "Edit") ? true : false;
        }
        private void btn_Bill_User_MouseEnter(object sender, EventArgs e)
        {
            btn_Bill_User.FlatStyle = FlatStyle.Popup;
        }

        private void btn_Bill_User_MouseLeave(object sender, EventArgs e)
        {
            btn_Bill_User.FlatStyle = FlatStyle.Flat;
        }

        #endregion
        private void combo_Bill_Branches_SelectedValueChanged(object sender, EventArgs e)
        {
            com_Stores.Visible = true;
            dv_stores.RowFilter = "Branche_ID = '" + com_Bill_Branches.SelectedValue.ToString() + "'";
            lbl_bill_Branches.Text = com_Bill_Branches.Text;

            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < com_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(com_Stores.GetItemText(com_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (com_Stores.Items.Count > 0) { com_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = com_Stores.Text;
            com_Stores.Visible = false;
        }
        private void combo_Stores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_Stores.Text = com_Stores.Text;
        }
        private void combo_CC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CC1.Text = com_CC1.Text;
        }
        private void combo_CC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CC2.Text = com_CC2.Text;
        }
        private void combo_Bill_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_User.Text = com_Bill_User.Text;
        }

        private void btn_Bill_Branche_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 5), 54); return; }
            if (com_Bill_Branches.Enabled == true && up == false) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 267); }
            else if (com_Bill_Branches.Enabled == true && up == true) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 133); }
        }
        private void btn_Stores_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 54); return; }
            if (com_Stores.Enabled == true && up == false) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 267); }
            if (com_Stores.Enabled == true && up == true) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 133); }
        }
        private void btn_CC1_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 54); return; }
            if (com_CC1.Enabled == true && up == false) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 267); }
            if (com_CC1.Enabled == true && up == true) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 133); }
        }
        private void btn_cc1_del_Click(object sender, EventArgs e)
        {
            com_CC1.SelectedValue = -1;
            btn_cc1_del.Visible = false;
        }
        private void btn_CC2_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 54); return; }
            if (com_CC2.Enabled == true && up == false) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 267); }
            if (com_CC2.Enabled == true && up == true) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 133); }
        }
        private void btn_cc2_del_Click(object sender, EventArgs e)
        {
            com_CC2.SelectedValue = -1;
            btn_cc2_del.Visible = false;
        }
        private void btn_Bill_User_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 54); return; }
            if (com_Bill_User.Enabled == true && up == false) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 267); }
            if (com_Bill_User.Enabled == true && up == true) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 133); }
        }

        private void contextMenuStrip_branches_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_Bill_Branches.SelectedIndex = contextMenuStrip_branches.Items.IndexOf(e.ClickedItem);
            lbl_bill_Branches.Text = com_Bill_Branches.Text;
            lbl_bill_Branches.Location = new Point(lbl_bill_Branches.Left - lbl_bill_Branches.Width, lbl_bill_Branches.Location.Y);
        }
        private void contextMenuStrip_stores_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_Stores.SelectedIndex = contextMenuStrip_stores.Items.IndexOf(e.ClickedItem);
            lbl_Bill_Stores.Text = com_Stores.Text;
            lbl_Bill_Stores.Location = new Point(lbl_Bill_Stores.Left - lbl_Bill_Stores.Width, lbl_Bill_Stores.Location.Y);
        }
        private void contextMenuStrip_cc1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_CC1.SelectedIndex = contextMenuStrip_cc1.Items.IndexOf(e.ClickedItem);
            lbl_CC1.Text = com_CC1.Text;
            btn_cc1_del.Visible = true;
        }
        private void contextMenuStrip_cc2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_CC2.SelectedIndex = contextMenuStrip_cc2.Items.IndexOf(e.ClickedItem);
            lbl_CC2.Text = com_CC2.Text;
            btn_cc2_del.Visible = true;
        }
        private void contextMenuStrip_users_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_Bill_User.SelectedIndex = contextMenuStrip_users.Items.IndexOf(e.ClickedItem);
            lbl_Bill_User.Text = com_Bill_User.Text;
            lbl_Bill_User.Location = new Point(lbl_Bill_User.Left - lbl_Bill_User.Width, lbl_Bill_User.Location.Y);
        }
        #endregion

        #region GroupBox Head Controls

        #region btn display
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
        private void button_Print_MouseEnter(object sender, EventArgs e)
        {
            button_Print.FlatStyle = FlatStyle.Popup;
        }

        private void button_Print_MouseLeave(object sender, EventArgs e)
        {
            button_Print.FlatStyle = FlatStyle.Flat;
        }
        private void button_Settings_MouseEnter_1(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Popup;
        }

        private void button_Settings_MouseLeave_1(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        private void button_New_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Empty" || Tag.ToString() == "Select")
            {
                Tag = "New";
                Form_Mode("New");
            }
            else if (Tag.ToString() == "New")
            {
                if (DGV.Rows.Count == 0) { MessageBox.Show("يجب إدخال أصناف قبل حفظ الفاتورة"); return; }

                //insert into database   
                Tag = "Select";
                var();
                string t = Pur.Insert();

                if (t.Length > 6)
                {
                    if (t.Substring(0, 6) == "SQL : ")
                    {
                        MessageBox.Show(t, "! حفظ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        button_Cancel_Click(null, null);
                        return;
                    }
                }

                txt_Bill_ID.Text = t.ToString();

                // ADD  Bill From DataBase To Main.dt_Pur
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(t, 7);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_Pur.Rows.Add(r.ItemArray);
                }
                // Add IO to Main.dt_IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(t, 7);
                foreach (DataRow r in p2.Rows)
                {
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }

                // Reset Cursor Position
                n = Main.dt_Pur.Rows.Count - 1;
                dr_Pur=Main.dt_Pur.Rows[n];
                Navigate();
                
                //Jor
                if (btn_Ref_No.Text != "")
                {
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(btn_Ref_No.Text);
                    foreach (DataRow dr in j.Rows)
                    {
                        Main.dt_Jor.Rows.Add(dr.ItemArray);
                    }
                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(btn_Ref_No.Text);
                    foreach (DataRow dr in j_d.Rows)
                    {
                        Main.dt_Jor_D.Rows.Add(dr.ItemArray);
                    }
                }
            }
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {        
            if (Tag.ToString().ToString() == "Select")
            {
                Tag = "Edit";
                Temp_dgv= table(1);
                Form_Mode("Edit");

                foreach (DataRow row in Temp_dgv.Rows)
                {
                    DGV.Rows.Add();
                    DGV.CurrentCell = DGV.Rows[DGV.Rows.Count - 1].Cells[0];

                    DGV.CurrentRow.Cells["Item_ID"].Value = row["Item_ID"].ToString();
                    DGV.CurrentRow.Cells["Item_Name"].Value = row["Item_Name"].ToString();
                    int x = Convert.ToInt16(row["Unit"]);
                    DGV.CurrentRow.Cells["Unit"].Value = x;
                    DGV.CurrentRow.Cells["Item_Quan"].Value = row["Item_Quan"].ToString();
                    DGV.CurrentRow.Cells["Bonus"].Value = row["Bonus"].ToString();
                    DGV.CurrentRow.Cells["Items_PPrice"].Value = row["Items_PPrice"].ToString();
                    DGV.CurrentRow.Cells["Items_SPrice"].Value = row["Items_SPrice"].ToString();
                    DGV.CurrentRow.Cells["Items_Total"].Value = row["Items_Total"].ToString();
                    DGV.CurrentRow.Cells["Items_Dis_Rate"].Value = row["Items_Dis_Rate"].ToString();
                    DGV.CurrentRow.Cells["Items_Dis_Value"].Value = row["Items_Dis_Value"].ToString();
                    DGV.CurrentRow.Cells["Net"].Value = row["Net"].ToString();
                }

            }
            else if (Tag.ToString().ToString() == "Edit")
            {
                if (DGV.Rows.Count == 0) { MessageBox.Show("يجب إدخال أصناف قبل حفظ الفاتورة"); return; }
                // Update database  
                var();
                string t = Pur.Update();

                // Remove Old Bill From Datatable
                Main.dt_Pur.Rows.RemoveAt(n);
                // Remove Old IO
                for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                {
                    if (Main.dt_IO.Rows[i]["Bill_ID"].ToString() == txt_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "7")
                    {
                        Main.dt_IO.Rows.RemoveAt(i);
                        i--;
                    }
                }
                // Insert Last Bill From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(t, 7);
                dr_Pur = Main.dt_Pur.NewRow();
                dr_Pur.ItemArray = p1.Rows[0].ItemArray.Clone() as object[];
                Main.dt_Pur.Rows.InsertAt(dr_Pur, n);
                // Add IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(t, 7);
                foreach (DataRow r in p2.Rows)
                {
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }

                dr_Pur = Main.dt_Pur.Rows[n];
                Navigate();

                // Remove old Jor from Main.dt_Jor
                int n_Jor = Main.dt_Jor.Rows.Count - 1;              
                foreach (DataRow r in Main.dt_Jor.Rows)
                {
                    if (r["Ref_NO"].ToString() == txt_Bill_ID.Text && Convert.ToInt16(r["Ref_Type"]) == 7)
                    { n_Jor = Main.dt_Jor.Rows.IndexOf(r); Main.dt_Jor.Rows.Remove(r); break; }
                }
                // Removr Old Jor_D
                for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                {
                    if (Main.dt_Jor_D.Rows[i]["Ref_NO"].ToString() == txt_Bill_ID.Text && Convert.ToInt16(Main.dt_Jor_D.Rows[i]["Ref_Type"]) == 7)
                    {
                        Main.dt_Jor_D.Rows.RemoveAt(i);
                        i--;
                    }
                }


                // Jor
                if (btn_Ref_No.Text != "")
                {
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(btn_Ref_No.Text);

                    DataRow dr_Jor = Main.dt_Jor.NewRow();
                    dr_Jor.ItemArray = j.Rows[0].ItemArray.Clone() as object[];
                    Main.dt_Jor.Rows.InsertAt(dr_Jor, n_Jor);

                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(btn_Ref_No.Text);
                    foreach (DataRow dr in j_d.Rows)
                    {
                        Main.dt_Jor_D.Rows.Add(dr.ItemArray);
                    }
                }
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                // Confirm
                if (MessageBox.Show("هل بالفعل تريد حذف السند ؟", "حذف ؟", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Pur.Bill_ID = txt_Bill_ID.Text;
                    //Delete In DataBase
                    Pur.Delete();

                    //Delete In dt_Pur
                    Main.dt_Pur.Rows.RemoveAt(n);
                    // Delete Old IO
                    for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                    {
                        if (Main.dt_IO.Rows[i]["Bill_ID"].ToString() == txt_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "7")
                        {
                            Main.dt_IO.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    // Jor
                    if (btn_Ref_No.Text != "")
                    {
                        int n_Jor = 0;
                        // Remove old Jor from Main.dt_Jor
                        foreach (DataRow r in Main.dt_Jor.Rows)
                        {
                            if (r["Jor_ID"].ToString() == btn_Ref_No.Text)
                            { n_Jor = Main.dt_Jor.Rows.IndexOf(r); Main.dt_Jor.Rows.Remove(r); break; }
                        }
                        // Removr Old Jor_D
                        for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                        {
                            if (Main.dt_Jor_D.Rows[i]["Jor_ID"].ToString() == btn_Ref_No.Text)
                            {
                                Main.dt_Jor_D.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                        Form_Mode("Empty");
                    Tag = "Empty";
                }
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString().ToString() == "New")
            {
                Tag = "Empty";
                Form_Mode("Empty");               
            }
            else if (Tag.ToString().ToString() == "Edit")
            {
                dr_Pur = Main.dt_Pur.Rows[n];
                Navigate();
            }    
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
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
            if (this.Parent != null) { Parent.Dispose(); }
            else { this.Dispose(); }
        }
        #endregion

        #region GroupBox_Header
        private void btn_Ref_No_Click(object sender, EventArgs e)
        {
            if (btn_Ref_No.Text != "")
            {
                Jor = new Bills.FRM_Jor(Main);
                string t = btn_Ref_No.Text;
                Jor.combo_Bill_Branches.SelectedValue = t.Substring(0, 3);
                Jor.ChangetxtSearch(t.Substring(4));
                Jor.FormBorderStyle = FormBorderStyle.Sizable;
                Jor.StartPosition = (WindowState == FormWindowState.Maximized) ? FormStartPosition.CenterScreen : FormStartPosition.Manual;
                Jor.Location = (Parent == null) ? new Point(Location.X - 40, Location.Y + 45) : Jor.Location;
                Jor.Height = 700;
                Jor.Width = 975;

                Jor.top = Main.panel_Main.Height + ((Main.tab_Main.Visible == true)? Main.tab_Main.Height:0) + panel_FRM_Head.Height + 27;

                Jor.Visible = false;

                Jor.ShowDialog();
            }
        }
        private void dateTimePicker_Pur_Pur_Date_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtp_Pur_Pur_Date.Checked == true) { dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Short; }
            if (dtp_Pur_Pur_Date.Checked == false) { dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Custom; }
        }
        private void dateTimePicker_Pur_Pur_Date_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Pur_Pur_Date.Checked == true) { dtp_Pur_Pur_Date.Format = DateTimePickerFormat.Short; }
        }
        private void dateTimePicker_Pur_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Pur_Date.Format = DateTimePickerFormat.Short;
        }
        private void com_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Currency.SelectedValue == null) { txt_Currency_Rate.Text = ""; return; }
            foreach (DataRowView r in dv_currency)
            {
                if (r["id"].ToString() == com_Currency.SelectedValue.ToString())
                {
                    txt_Currency_Rate.Text = r["rate"].ToString();
                    break;
                }
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            add.Main = Main;          
            add.dv_Items = dv_Items;
            add.dv_Item_Units = dv_Item_Units;
            add.dv_Item_Prices = dv_Item_Prices;

            add.top = Main.panel_Main.Height + 27 + panel_FRM_Head.Height;
            if (Main.tab_Main.Visible == true) { add.top += Main.tab_Main.Height; }
            add.Search = Main.imageList16.Images["Search_16.png"];
            add.Edit = Main.imageList16.Images["Edit_16.png"];
            add.DGV = DGV;


            add.Text = "إضافة";
            add.btn_Add.Text = "+ إضافة";

            add.com_Item_Name.SelectedValue = -1;
            add.txt_Quan.Text = "";
            add.txt_Bonus.Text = "";
            add.txt_PPrice.Text = "";
            add.txt_SPrice.Text = "";
            add.txt_Total.Text = "";
            add.txt_Dis_Rate.Text = "";
            add.txt_Dis_Value.Text = "";
            add.txt_Total.Text = "";

            add.ShowDialog();
        }
        #endregion

        #region GroupBox_Details

        // Barcodr
        private void txt_Barcode_MouseEnter(object sender, EventArgs e)
        {
            if(txt_Barcode.Text == "Barcode")
            {
                txt_Barcode.ForeColor = Color.CadetBlue;
                txt_Barcode.Font = new Font(txt_Barcode.Font, FontStyle.Bold);
            }
        }
        private void txt_Barcode_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Barcode.Text == "Barcode")
            {
                txt_Barcode.ForeColor = Color.Silver;
                txt_Barcode.Font = new Font(txt_Barcode.Font, FontStyle.Regular);
            }
        }
        private void txt_Barcode_Enter(object sender, EventArgs e)
        {
            txt_Barcode.Text = "";
            txt_Barcode.ForeColor = Color.Black;       
        }
        private void txt_Barcode_Leave(object sender, EventArgs e)
        {
            txt_Barcode.Text = "Barcode";
            txt_Barcode.ForeColor = Color.Silver;
        }
        private void txt_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play();}
            }
            if (e.KeyChar == 13 && txt_Barcode.Text != "")
            {
                foreach (DataRow dr in Main.dt_Items.Rows)
                {
                    if (dr["Item_ID"].ToString() == txt_Barcode.Text && Convert.ToBoolean(dr["Is_Parent"]) == false)
                    {
                        dr_Pur = dr;
                    }
                }
                if (dr_Pur == null) { return; }
                

                if (DGV.Rows.Count > 0)
                {
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Cells["Item_ID"].Value.ToString() == dr_Pur["Item_ID"].ToString())
                        {
                            DGV.CurrentCell = DGV.Rows[r.Index].Cells["Item_Quan"];
                            DGV.CurrentRow.Cells["Item_Quan"].Value = Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value) + 1;
                            DGV.CurrentRow.Cells["Items_Total"].Value = Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Items_PPrice"].Value);
                            DGV.CurrentRow.Cells["Total_PPrice"].Value = Convert.ToDecimal(DGV.CurrentRow.Cells["Items_Total"].Value) - Convert.ToDecimal(DGV.CurrentRow.Cells["Items_Dis_Value"].Value);
                            Console.Beep();

                            decimal pp = 0;
                            decimal sp = 0;
                            foreach (DataGridViewRow rr in DGV.Rows)
                            {
                                pp += Convert.ToDecimal(rr.Cells["Total_PPrice"].Value);
                                sp += Convert.ToDecimal(rr.Cells["Items_SPrice"].Value) * Convert.ToDecimal(rr.Cells["Item_Quan"].Value);
                            }
                            txt_Total_Pur_Price.Text = pp.ToString();
                            txt_Total_Sal_Price.Text = sp.ToString();

                            txt_Barcode.Select(0, txt_Barcode.TextLength);

                            dr_Pur = null;
                            e.Handled = true;

                            return;
                        }
                    }
                    txt_Barcode.Tag = "1";
                    DGV.Rows.Add();
                }
                else if (DGV.Rows.Count == 0)
                {
                    txt_Barcode.Tag = "1";
                    DGV.Rows.Add();
                }                 

                txt_Barcode.Select(0, txt_Barcode.TextLength);

                dr_Pur = null;
                e.Handled = true;
            }
        }
       
        // DGV
        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Tag.ToString() != "Select" & txt_Barcode.Focused)
            {
                DGV.CurrentCell = DGV.Rows[e.RowIndex].Cells[0];

                if (txt_Barcode.Tag.ToString() == "1")
                {
                    DGV.CurrentRow.Cells["Item_ID"].Value = dr_Pur["Item_ID"].ToString();
                    DGV.CurrentRow.Cells["Item_Name"].Value = dr_Pur["Item_ID"].ToString();
                    DGV.CurrentRow.Cells["Item_Quan"].Value = 1;
                    DGV.CurrentRow.Cells["Bonus"].Value = 0;
                    DGV.CurrentRow.Cells["Items_PPrice"].Value = dr_Pur["PPrice"].ToString();
                    DGV.CurrentRow.Cells["Items_SPrice"].Value = dr_Pur["SPrice"].ToString();
                    DGV.CurrentRow.Cells["Items_Total"].Value = dr_Pur["PPrice"].ToString();
                    DGV.CurrentRow.Cells["Items_Dis_Rate"].Value = 0;
                    DGV.CurrentRow.Cells["Items_Dis_Value"].Value = 0;
                    DGV.CurrentRow.Cells["Total_PPrice"].Value = dr_Pur["PPrice"].ToString();
                    Console.Beep();
                }
                else 
                {
                    DGV.CurrentRow.Cells["Item_ID"].Value = add.com_Item_Name.SelectedValue.ToString();
                    DGV.CurrentRow.Cells["Item_Name"].Value = add.com_Item_Name.Text;
                    DGV.CurrentRow.Cells["Item_Quan"].Value = add.txt_Quan.Text;
                    DGV.CurrentRow.Cells["Bonus"].Value = add.txt_Bonus.Text;
                    DGV.CurrentRow.Cells["Items_PPrice"].Value = add.txt_PPrice.Text;
                    DGV.CurrentRow.Cells["Items_SPrice"].Value = add.txt_SPrice.Text;
                    DGV.CurrentRow.Cells["Items_Total"].Value = add.txt_Total.Text;
                    DGV.CurrentRow.Cells["Items_Dis_Rate"].Value = add.txt_Dis_Rate.Text;
                    DGV.CurrentRow.Cells["Items_Dis_Value"].Value = add.txt_Dis_Value.Text;
                    DGV.CurrentRow.Cells["Net"].Value = add.txt_Item_Net.Text;
                    Console.Beep();
                }

                foreach (DataGridViewRow r in DGV.Rows)
                {
                    if (DGV.CurrentRow.Cells["Item_ID"].Value == r.Cells["Item_ID"].Value)
                    {
                        if (r == DGV.CurrentRow) { break; }
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                        DGV.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                        Console.Beep();
                    }
                }
            }
            else if (Tag.ToString() == "New" | Tag.ToString() == "Edit" && !button_Edit.Focused)
            {
                DGV.Rows[e.RowIndex].Cells["Item_ID"].Value = add.com_Item_Name.SelectedValue.ToString();
                DGV.Rows[e.RowIndex].Cells["Item_Name"].Value = add.com_Item_Name.Text;
                DGV.Rows[e.RowIndex].Cells["Unit"].Value = add.com_Unit.SelectedValue;
                DGV.Rows[e.RowIndex].Cells["Item_Quan"].Value = add.txt_Quan.Text;
                DGV.Rows[e.RowIndex].Cells["Bonus"].Value = add.txt_Bonus.Text;
                DGV.Rows[e.RowIndex].Cells["Items_PPrice"].Value = add.txt_PPrice.Text;
                DGV.Rows[e.RowIndex].Cells["Items_SPrice"].Value = add.txt_SPrice.Text;
                DGV.Rows[e.RowIndex].Cells["Items_Total"].Value = add.txt_Total.Text;
                DGV.Rows[e.RowIndex].Cells["Items_Dis_Rate"].Value = add.txt_Dis_Rate.Text;
                DGV.Rows[e.RowIndex].Cells["Items_Dis_Value"].Value = add.txt_Dis_Value.Text;
                DGV.Rows[e.RowIndex].Cells["Net"].Value = add.txt_Item_Net.Text;

                decimal pp = Math.Round(Convert.ToDecimal(txt_Total_Pur_Price.Text), 2) + Convert.ToDecimal(DGV.Rows[e.RowIndex].Cells["Net"].Value);
                txt_Total_Pur_Price.Text = pp.ToString();

                decimal sp = Math.Round(Convert.ToDecimal(txt_Total_Sal_Price.Text), 2) + (Convert.ToDecimal(DGV.Rows[e.RowIndex].Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.Rows[e.RowIndex].Cells["Item_Quan"].Value));
                txt_Total_Sal_Price.Text = sp.ToString();
            }

        }
        private void DGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (nav == true) { return; }
            decimal pp = Math.Round(Convert.ToDecimal(txt_Total_Pur_Price.Text), 2) - Convert.ToDecimal(DGV.CurrentRow.Cells["Net"].Value);
            txt_Total_Pur_Price.Text = pp.ToString();

            decimal sp = Math.Round(Convert.ToDecimal(txt_Total_Sal_Price.Text), 2) - (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value));
            txt_Total_Sal_Price.Text = sp.ToString();
        }
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() != "New" & Tag.ToString() != "Edit") { return; }

            add.edit = true;
            add.Main = Main;
            add.dv_Items = dv_Items;
            add.dv_Item_Units = dv_Item_Units;
            add.dv_Item_Prices = dv_Item_Prices;

            add.com_Item_Name.DataSource = dv_Items;
            add.com_Unit.DataSource = add.dv_Item_Units;
            add.dv_Item_Units.RowFilter = "Item_ID = '" + DGV.Rows[e.RowIndex].Cells["Item_ID"].Value.ToString() + "'";

            add.top = Main.panel_Main.Height + 27 + panel_FRM_Head.Height;
            if (Main.tab_Main.Visible == true) { add.top += Main.tab_Main.Height; }
            add.Search = Main.imageList16.Images["Search_16.png"];
            add.Edit = Main.imageList16.Images["Edit_16.png"];
            add.DGV = DGV;


            add.Text = "تعديل";
            add.btn_Add.Text = "تعديل";

            add.rowindex = e.RowIndex;
            add.com_Item_Name.Text = DGV.Rows[e.RowIndex].Cells["Item_Name"].Value.ToString();
            add.com_Unit.SelectedValue = DGV.Rows[e.RowIndex].Cells["Unit"].Value.ToString();
            add.txt_Quan.Text = DGV.Rows[e.RowIndex].Cells["Item_Quan"].Value.ToString();
            add.txt_Bonus.Text = DGV.Rows[e.RowIndex].Cells["Bonus"].Value.ToString();
            add.txt_PPrice.Text = DGV.Rows[e.RowIndex].Cells["Items_PPrice"].Value.ToString();
            add.txt_SPrice.Text = DGV.Rows[e.RowIndex].Cells["Items_SPrice"].Value.ToString();
            add.txt_Total.Text = DGV.Rows[e.RowIndex].Cells["Items_Total"].Value.ToString();
            add.txt_Dis_Rate.Text = DGV.Rows[e.RowIndex].Cells["Items_Dis_Rate"].Value.ToString();
            add.txt_Dis_Value.Text = DGV.Rows[e.RowIndex].Cells["Items_Dis_Value"].Value.ToString();
            add.txt_Item_Net.Text = DGV.Rows[e.RowIndex].Cells["Net"].Value.ToString();

            add.ShowDialog();

            Calc_Totals();
        }
        #endregion

        #region Footer_Tab

        #region Display

        private void textBox_Total_Dis_Rate_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Rate.Text == "Rate")
            {
                textBox_Total_Dis_Rate.ForeColor = Color.CadetBlue;
            }
        }
        private void textBox_Total_Dis_Rate_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Rate.Text == "Rate")
            {
                textBox_Total_Dis_Rate.ForeColor = Color.Silver;
            }
        }
        private void textBox_Total_Dis_Rate_Enter(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Rate.Text == "Rate" || Convert.ToDecimal(textBox_Total_Dis_Rate.Text) == 0) 
            {
                textBox_Total_Dis_Rate.Text = "";
            }                   
        }
        private void textBox_Total_Dis_Rate_Leave(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Rate.Text == "" || textBox_Total_Dis_Rate.Text == ".")
            {
                textBox_Total_Dis_Rate.Text = "Rate";
                textBox_Total_Dis_Rate.ForeColor = Color.Silver;

                textBox_Total_Dis_Value.Text = "Value";
                textBox_Total_Dis_Value.ForeColor = Color.Silver;
            }
        }

        private void textBox_Total_Dis_Value_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Value.Text == "Value")
            {
                textBox_Total_Dis_Value.ForeColor = Color.CadetBlue;
            }
        }
        private void textBox_Total_Dis_Value_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Value.Text == "Value")
            {
                textBox_Total_Dis_Value.ForeColor = Color.Silver;
            }
        }
        private void textBox_Total_Dis_Value_Enter(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Value.Text == "Value" || Convert.ToDecimal(textBox_Total_Dis_Value.Text) == 0)
            {
                textBox_Total_Dis_Value.Text = "";
            }
        }
        private void textBox_Total_Dis_Value_Leave(object sender, EventArgs e)
        {
            if (textBox_Total_Dis_Value.Text == "" || textBox_Total_Dis_Value.Text == ".")
            {
                textBox_Total_Dis_Value.Text = "Value";
                textBox_Total_Dis_Value.ForeColor = Color.Silver;

                textBox_Total_Dis_Rate.Text = "Rate";
                textBox_Total_Dis_Rate.ForeColor = Color.Silver;
            }
        }


        #endregion
        private void textBox_Total_Pur_Price_TextChanged(object sender, EventArgs e)
        {
            if (nav == true ) { return; }
            txt_Total_Pur_Price.Text = (txt_Total_Pur_Price.Text == "" | txt_Total_Pur_Price.Text == ".") ? "0" : txt_Total_Pur_Price.Text;
            decimal total_pp = Convert.ToDecimal(txt_Total_Pur_Price.Text);

            if (textBox_Total_Dis_Rate.Text != "" && textBox_Total_Dis_Rate.Text != "Rate")
            {
                decimal total_rate = Math.Round(Convert.ToDecimal(textBox_Total_Dis_Rate.Text) / 100 , 2);
                decimal total_value = Math.Round(total_pp * total_rate, 2);

                textBox_Total_Dis_Rate.Text = (total_rate * 100).ToString();
                textBox_Total_Dis_Value.Text = total_value.ToString();
                textBox_Net.Text = (total_pp - total_value).ToString();                       
            }
            else
            {
                textBox_Net.Text = total_pp.ToString();        
            }

            textBox_Total_Dis_Rate.ReadOnly = false;
            textBox_Total_Dis_Value.ReadOnly= false;       
        }

        private void textBox_Total_Dis_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion
        }
        private void textBox_Total_Dis_Rate_TextChanged(object sender, EventArgs e)
        {
            if (nav == true) { return; }
            if (Tag.ToString().ToString() == "Select" | textBox_Total_Dis_Value.ReadOnly == true) { return; }

            if (textBox_Total_Dis_Rate.Text != "Rate" && textBox_Total_Dis_Rate.Text != "" && textBox_Total_Dis_Rate.Text != ".")
            {
                textBox_Total_Dis_Rate.ForeColor = Color.Black;

                if (!textBox_Total_Dis_Value.Focused)
                {
                    textBox_Total_Dis_Value.Text = (Math.Round(((Convert.ToDecimal(textBox_Total_Dis_Rate.Text) / 100) * Convert.ToDecimal(txt_Total_Pur_Price.Text)), 2)).ToString();
                    textBox_Total_Dis_Value.ForeColor = Color.Black;
                }
            }
            else
            {
                if (!textBox_Total_Dis_Value.Focused)
                {
                    textBox_Total_Dis_Value.Text = "Value";
                    textBox_Total_Dis_Value.ForeColor = Color.Silver;
                }
            }
        }

        private void textBox_Total_Dis_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion
            textBox_Total_Dis_Rate.Tag = "";
        }
        private void textBox_Total_Dis_Value_TextChanged(object sender, EventArgs e)
        {
            if (nav == true ) { return; }
            if (Tag.ToString() == "Select" | textBox_Total_Dis_Value.ReadOnly == true) { return; }

            if (textBox_Total_Dis_Value.Text != "Value" & textBox_Total_Dis_Value.Text != "" & textBox_Total_Dis_Value.Text != ".")
            {
                textBox_Total_Dis_Value.ForeColor = Color.Black;
                if (!textBox_Total_Dis_Rate.Focused)
                {
                    if (Convert.ToDecimal(textBox_Total_Dis_Value.Text) == 0) { textBox_Total_Dis_Rate.Text = "0"; }
                    else
                    {
                        textBox_Total_Dis_Rate.Text = (Math.Round(((Convert.ToDecimal(textBox_Total_Dis_Value.Text) / Convert.ToDecimal(txt_Total_Pur_Price.Text)) * 100), 2)).ToString();                      
                    }
                    textBox_Total_Dis_Rate.ForeColor = Color.Black;
                }
                textBox_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total_Pur_Price.Text) - Convert.ToDecimal(textBox_Total_Dis_Value.Text), 2)).ToString();
            }
            else
            {
                if (!textBox_Total_Dis_Rate.Focused)
                {
                    textBox_Total_Dis_Rate.Text = "Rate";
                    textBox_Total_Dis_Rate.ForeColor = Color.Silver;
                }

                textBox_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total_Pur_Price.Text), 2)).ToString();
            }
        }
        #endregion

        #region Navigation
        int n;
        bool nav;
        #region display
        private void button_First_MouseEnter(object sender, EventArgs e)
        {
            button_First.FlatStyle = FlatStyle.Popup;
        }
        private void button_First_MouseLeave(object sender, EventArgs e)
        {
            button_First.FlatStyle = FlatStyle.Flat;
        }
        private void button_Prev_MouseEnter(object sender, EventArgs e)
        {
            button_Prev.FlatStyle = FlatStyle.Popup;
        }
        private void button_Prev_MouseLeave(object sender, EventArgs e)
        {
            button_Prev.FlatStyle = FlatStyle.Flat;
        }
        private void button_Next_MouseEnter(object sender, EventArgs e)
        {
            button_Next.FlatStyle = FlatStyle.Popup;
        }
        private void button_Next_MouseLeave(object sender, EventArgs e)
        {
            button_Next.FlatStyle = FlatStyle.Flat;
        }
        private void button_Last_MouseEnter(object sender, EventArgs e)
        {
            button_Last.FlatStyle = FlatStyle.Popup;
        }
        private void button_Last_MouseLeave(object sender, EventArgs e)
        {
            button_Last.FlatStyle = FlatStyle.Flat;
        }
        private void textBox_Search_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "Search")
            {
                textBox_Search.ForeColor = Color.CadetBlue;
                textBox_Search.Font = new Font(textBox_Search.Font, FontStyle.Bold);
            }
        }
        private void textBox_Search_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "Search")
            {
                textBox_Search.ForeColor = Color.Silver;
                textBox_Search.Font = new Font(textBox_Search.Font, FontStyle.Regular);
            }
        }
        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            textBox_Search.ForeColor = Color.Black;
        }
        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            textBox_Search.Text = "Search";
            textBox_Search.ForeColor = Color.Silver;
        }
        #endregion

        private void button_First_Click(object sender, EventArgs e)
        {
            if (Main.dt_Pur.Rows.Count == 0) { return; }
            nav = true;
            n = 0;
            do
            {
                if (n > Main.dt_Pur.Rows.Count - 1) { n = 0; Form_Mode("Empty"); return; }
                dr_Pur = Main.dt_Pur.Rows[n];
                n++;
            } while (dr_Pur["Branche_ID"].ToString() != com_Bill_Branches.SelectedValue.ToString());
            n--;
            Navigate();
            nav = false;
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            if (Main.dt_Pur.Rows.Count == 0) { return; }
            nav = true;
            n = Main.dt_Pur.Rows.Count - 1;
            do
            {
                if (n < 0) { n = Main.dt_Pur.Rows.Count - 1; Form_Mode("Empty"); return; }
                dr_Pur = Main.dt_Pur.Rows[n];
                n--;            
            } while (dr_Pur["Branche_ID"].ToString() != com_Bill_Branches.SelectedValue.ToString());
            n++;
            Navigate();
            nav = false;
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            nav = true;
            do
            {
                n--;
                if (n < 0) { n = 0; return; }
                dr_Pur = Main.dt_Pur.Rows[n];

            } while (dr_Pur["Branche_ID"].ToString() != com_Bill_Branches.SelectedValue.ToString());

            Navigate();
            nav = false;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            nav = true;
            do
            {
                n++;
                if (n > Main.dt_Pur.Rows.Count - 1) { n = Main.dt_Pur.Rows.Count - 1; return; }
                dr_Pur = Main.dt_Pur.Rows[n];

            } while (dr_Pur["Branche_ID"].ToString() != com_Bill_Branches.SelectedValue.ToString());

            Navigate();
            nav = false;
        }
        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }

            if (e.KeyChar == 13)
            {
                DataRow dr;
                for (int i = 0; i < Main.dt_Pur.Rows.Count; i++)
                {
                    dr = Main.dt_Pur.Rows[i];
                    if (dr["ID"].ToString() == textBox_Search.Text && dr["Branche_ID"].ToString() == com_Bill_Branches.SelectedValue.ToString())
                    {
                        e.Handled = true;
                        dr_Pur = dr;
                        n = i;
                    }
                }
                if (dr_Pur == null) { return; }

                Navigate();
            }
        }

        #endregion
    }
}
