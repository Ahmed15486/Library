using System;
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
    public partial class FRM_Open : Form
    {
        #region Declaration
        CLS_Open Open = new CLS_Open();
        Bills.FRM_Jor Jor;
        G.CLS_G G = new G.CLS_G();
        DataRow dr_Open;
        DataTable Temp_dgv = new DataTable();
        bool up;
        bool skip_d;
        bool dgv_select;
        int n;
        bool nav;

        DataView dv_branches;
        DataView dv_stores;
        DataView dv_cc1;
        DataView dv_cc2;
        DataView dv_users;
        DataView dv_items;
        DataView dv_acc;

        frm_Main Main;
        #endregion

        public FRM_Open(frm_Main main)
        {
            InitializeComponent();
            Main = main;
            dr_Open = Main.dt_Jor.NewRow();

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_Stores.Image = Main.imageList32.Images["store_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];

            dv_branches = new DataView(Main.ds.Tables[1]);
            dv_stores = new DataView(Main.ds.Tables[2]);
            dv_stores.RowFilter = "";
            dv_cc1 = new DataView(Main.ds.Tables[3]);
            dv_cc1.RowFilter = "Is_Parent = 0";
            dv_cc2 = new DataView(Main.ds.Tables[3]);
            dv_cc2.RowFilter = "Is_Parent = 0";
            dv_users = new DataView(Main.ds.Tables[0]);
            dv_items = new DataView(Main.ds.Tables[5]);
            dv_items.RowFilter = "Is_Parent = 0";
            dv_acc = new DataView(Main.ds.Tables[6]);
            dv_acc.RowFilter = "Is_Parent = 0";


            com_Emp_Name.DataSource = Main.ds.Tables[4];
            com_Emp_Name.SelectedValue = -1;


            combo_Item_ID.DataSource = dv_items;
            combo_Item_Name.DataSource = dv_items;
            combo_Item_ID.SelectedValue = -1;
            combo_Item_Name.SelectedValue = -1;

            DGV.AutoGenerateColumns = false;

            #region ContextMenuStrips
            // Branches
            combo_Bill_Branches.DataSource = dv_branches;
            combo_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            contextMenuStrip_branches.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_Bill_Branches.Items.Count; i++)
            {
                contextMenuStrip_branches.Items.Add(combo_Bill_Branches.GetItemText(combo_Bill_Branches.Items[i]), Main.imageList16.Images["branche_16.png"]);
            }

            // Stores
            combo_Stores.DataSource = dv_stores;

            contextMenuStrip_stores.ForeColor = Color.MidnightBlue;
            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (combo_Stores.Items.Count > 0) { combo_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = combo_Stores.Text;

            // CC1
            combo_CC1.DataSource = dv_cc1;
            dv_cc1.RowFilter = string.Format("CC1 = True and (Branche = '" + combo_Bill_Branches.SelectedValue.ToString() + "' or Branche IS NULL)");
            combo_CC1.SelectedValue = -1;
            lbl_CC1.Text = combo_CC1.Text;
            btn_cc1_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc1.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_CC1.Items.Count; i++)
            {
                contextMenuStrip_cc1.Items.Add(combo_CC1.GetItemText(combo_CC1.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // CC2
            combo_CC2.DataSource = dv_cc2;
            dv_cc2.RowFilter = string.Format("CC2 = True and (Branche = '"+combo_Bill_Branches.SelectedValue.ToString()+ "' or Branche IS NULL)");
            combo_CC2.SelectedValue = -1;
            lbl_CC2.Text = combo_CC2.Text;
            btn_cc2_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc2.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_CC2.Items.Count; i++)
            {
                contextMenuStrip_cc2.Items.Add(combo_CC2.GetItemText(combo_CC2.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // Users
            combo_Bill_User.DataSource = dv_users;
            contextMenuStrip_users.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < combo_Bill_User.Items.Count; i++)
            {
                contextMenuStrip_users.Items.Add(combo_Bill_User.GetItemText(combo_Bill_User.Items[i]), Main.imageList16.Images["user_16.png"]);
            }
            #endregion

            #region DGV Fildes
            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "Item_ID";
            Item_ID.DataPropertyName = "Items_ID";
            Item_ID.HeaderText = "رقم الصنف";
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

            var Item_Quan = new DataGridViewTextBoxColumn();
            Item_Quan.Name = "Item_Quan";
            Item_Quan.HeaderText = "الكمية";
            Item_Quan.DataPropertyName = "Items_Quan";
            Item_Quan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_Quan.Width = 100;
            Item_Quan.Visible = true;
            DGV.Columns.Add(Item_Quan);

            var Items_PPrice = new DataGridViewTextBoxColumn();
            Items_PPrice.Name = "Items_PPrice";
            Items_PPrice.HeaderText = "سعر الشراء";
            Items_PPrice.DataPropertyName = "Items_PPrice";
            Items_PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_PPrice.Width = 100;
            Items_PPrice.Visible = true;
            DGV.Columns.Add(Items_PPrice);

            var Items_CPrice = new DataGridViewTextBoxColumn();
            Items_CPrice.Name = "Items_CPrice";
            Items_CPrice.HeaderText = "سعر التكلفة";
            Items_CPrice.DataPropertyName = "Items_CPrice";
            Items_CPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_CPrice.Width = 100;
            Items_CPrice.Visible = true;
            DGV.Columns.Add(Items_CPrice);

            var Items_SPrice = new DataGridViewTextBoxColumn();
            Items_SPrice.Name = "Items_SPrice";
            Items_SPrice.HeaderText = "سعر البيع";
            Items_SPrice.DataPropertyName = "Items_SPrice";
            Items_SPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_SPrice.Width = 100;
            Items_SPrice.Visible = true;
            DGV.Columns.Add(Items_SPrice);

            var Total_CPrice = new DataGridViewTextBoxColumn();
            Total_CPrice.Name = "Total_CPrice";
            Total_CPrice.HeaderText = "الإجمالي بسعر التكلفة";
            Total_CPrice.DataPropertyName = "Total_CPrice";
            Total_CPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total_CPrice.Width = 100;
            Total_CPrice.Visible = true;
            DGV.Columns.Add(Total_CPrice);

            var Total_SPrice = new DataGridViewTextBoxColumn();
            Total_SPrice.Name = "Total_SPrice";
            Total_SPrice.HeaderText = "الإجمالي بسعر البيع";
            Total_SPrice.DataPropertyName = "Total_SPrice";
            Total_SPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total_SPrice.Width = 100;
            Total_SPrice.Visible = true;
            DGV.Columns.Add(Total_SPrice);


            #endregion
        }

        #region Pro
        public void ChangetxtSearch(string s)
        {
            textBox_Search.Focus();
            textBox_Search.Text = s;
            KeyPressEventArgs kpea = new KeyPressEventArgs((char)Keys.Enter);
            textBox_Search_KeyPress(null, kpea);
            textBox_Search.Text = "";
            Show();
        }
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    txt_Notes.ReadOnly = true;
                    dtp_Open.Enabled = false;
                    com_Emp_Name.Enabled = false;

                    groupBox_Footer_Controls.Visible = true;
                    DGV.AllowUserToDeleteRows = false;
                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Settings.Visible = true;
                    button_Close.Visible = true;

                    txt_Barcode.Enabled = false;
                    combo_Item_ID.Visible = false;
                    combo_Item_Name.Visible = false;
                    txt_Quan.Visible = false;
                    txt_PPrice.Visible = false;
                    txt_CPrice.Visible = false;
                    txt_SPrice.Visible = false;
                    txt_Total_CPrice.Visible = false;
                    txt_Total_SPrice.Visible = false;

                    if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                    break;
                #endregion

                #region New
                case "New":

                    txt_Notes.ReadOnly = false;
                    dtp_Open.Enabled = true;
                    com_Emp_Name.Enabled = true;

                    // Clare Controls
                    // Head
                    combo_CC1.SelectedValue = "-1";
                    combo_CC2.SelectedValue = "-1";
                    
                    textBox_Bill_ID.Clear();
                    btn_Ref_No.Text = "";
                    txt_Notes.Clear();
                    com_Emp_Name.SelectedValue = -1;
                    textBox_Total_Cost_Price.Clear();
                    textBox_Total_Sal_Price.Clear();
                    dtp_Open.Value = DateTime.Today;
                    dtp_Open.Format = DateTimePickerFormat.Short;

                    DGV.DataSource = null;
                    DGV.Rows.Clear();

                    groupBox_Footer_Controls.Visible = false;
                    txt_Notes.Focus();

                    // Details
                    skip_d = true;
                    combo_Item_ID.SelectedValue = "-1";
                    combo_Item_Name.SelectedValue = "-1";
                    txt_Quan.Text = "";
                    txt_PPrice.Text = "";
                    txt_CPrice.Text = "";
                    txt_SPrice.Text = "";
                    txt_Total_CPrice.Text = "";
                    txt_Total_SPrice.Text = "";
                    textBox_Total_Cost_Price.Text = "0";
                    textBox_Total_Sal_Price.Text = "0";
                    skip_d = false;

                    txt_Barcode.Enabled = true;
                    combo_Item_ID.Visible = true;
                    combo_Item_Name.Visible = true;
                    txt_Quan.Visible = true;
                    txt_PPrice.Visible = true;
                    txt_CPrice.Visible = true;
                    txt_SPrice.Visible = true;
                    txt_Total_CPrice.Visible = true;
                    txt_Total_SPrice.Visible = true;

                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    DGV.AllowUserToDeleteRows = true;

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

                    combo_Item_ID.Focus();
                    break;
                #endregion

                #region Edit
                case "Edit":

                    txt_Notes.ReadOnly = false;
                    dtp_Open.Enabled = true;
                    com_Emp_Name.Enabled = true;

                    txt_Barcode.Enabled = true;
                    combo_Item_ID.Visible = true;
                    combo_Item_Name.Visible = true;
                    txt_Quan.Visible = true;
                    txt_PPrice.Visible = true;
                    txt_CPrice.Visible = true;
                    txt_SPrice.Visible = true;
                    txt_Total_CPrice.Visible = true;
                    txt_Total_SPrice.Visible = true;

                    DGV.DataSource = null;
                    DGV.AllowUserToDeleteRows = true;
                    DGV.AllowUserToDeleteRows = true;

                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_New.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region Empty
                case "Empty":

                    txt_Notes.ReadOnly = true;
                    dtp_Open.Enabled = false;
                    com_Emp_Name.Enabled = false;

                    //Clare Controls
                    textBox_Bill_ID.Clear();
                    btn_Ref_No.Text = "";
                    dtp_Open.Format = DateTimePickerFormat.Custom;
                    txt_Notes.Clear();
                    com_Emp_Name.SelectedValue = -1;
                    textBox_Total_Cost_Price.Clear();
                    textBox_Total_Sal_Price.Clear();
                    DGV.DataSource = null;
                    DGV.Rows.Clear();

                    groupBox_Footer_Controls.Visible = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = false;
                    button_Settings.Visible = true;
                    button_Close.Visible = true;

                    txt_Barcode.Enabled = false;
                    combo_Item_ID.Visible = false;
                    combo_Item_Name.Visible = false;
                    txt_Quan.Visible = false;
                    txt_PPrice.Visible = false;
                    txt_CPrice.Visible = false;
                    txt_SPrice.Visible = false;
                    txt_Total_CPrice.Visible = false;
                    txt_Total_SPrice.Visible = false;

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
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        private void var()
        {
            Open.Branche_ID = combo_Bill_Branches.SelectedValue.ToString();
            Open.Store_ID = Convert.ToInt32(combo_Stores.SelectedValue);
            Open.CC1_ID = Convert.ToInt32(combo_CC1.SelectedValue);
            Open.CC2_ID = Convert.ToInt32(combo_CC2.SelectedValue);
            Open.User_ID = Convert.ToInt32(combo_Bill_User.SelectedValue);
            Open.Open_ID = textBox_Bill_ID.Text;
            Open.Open_Date = dtp_Open.Value;
            Open.Open_Person = Convert.ToInt32(com_Emp_Name.SelectedValue);
            Open.Open_Notes = txt_Notes.Text;
            Open.Open_Total_CPrice = Convert.ToDecimal(textBox_Total_Cost_Price.Text);
            Open.Open_Total_SPrice = Convert.ToDecimal(textBox_Total_Sal_Price.Text);
            Open.dt_Open = table();
        }
        private void Recored()
        {
            skip_d = true;
            if (combo_Item_ID.SelectedValue == null) { skip_d = false; return; }
            if (combo_Item_ID.SelectedValue.ToString() == "-1") { skip_d = false; return; }

            if (txt_Quan.Text == "" | txt_Quan.Text == ".") { txt_Quan.Text = "1"; }
            if (Convert.ToDecimal(txt_Quan.Text) == 0) { txt_Quan.Text = "1"; }

            DGV.Rows.Add();
            DGV.CurrentCell = DGV.Rows[DGV.Rows.Count - 1].Cells[0];

            DGV.CurrentRow.Cells["Item_ID"].Value = combo_Item_ID.SelectedValue;
            DGV.CurrentRow.Cells["Item_Name"].Value = combo_Item_Name.Text;
            DGV.CurrentRow.Cells["Item_Quan"].Value = Math.Round(Convert.ToDecimal(txt_Quan.Text), 2);
            DGV.CurrentRow.Cells["Items_PPrice"].Value = Math.Round(Convert.ToDecimal(txt_PPrice.Text), 2);
            DGV.CurrentRow.Cells["Items_CPrice"].Value = Math.Round(Convert.ToDecimal(txt_CPrice.Text), 2);
            DGV.CurrentRow.Cells["Items_SPrice"].Value = Math.Round(Convert.ToDecimal(txt_SPrice.Text), 2);
            DGV.CurrentRow.Cells["Total_CPrice"].Value = Math.Round(Convert.ToDecimal(txt_Total_CPrice.Text), 2);
            DGV.CurrentRow.Cells["Total_SPrice"].Value = Math.Round(Convert.ToDecimal(txt_Total_SPrice.Text), 2);

            decimal cp = Math.Round(Convert.ToDecimal(textBox_Total_Cost_Price.Text), 2) + Convert.ToDecimal(DGV.CurrentRow.Cells["Total_CPrice"].Value);
            textBox_Total_Cost_Price.Text = cp.ToString();

            decimal sp = Math.Round(Convert.ToDecimal(textBox_Total_Sal_Price.Text), 2) + Convert.ToDecimal(DGV.CurrentRow.Cells["Total_SPrice"].Value);
            textBox_Total_Sal_Price.Text = sp.ToString();

            combo_Item_ID.SelectedValue = "-1";
            combo_Item_Name.SelectedValue = "-1";
            txt_Quan.Text = "";
            txt_PPrice.Text = "";
            txt_CPrice.Text = "";
            txt_SPrice.Text = "";
            txt_Total_CPrice.Text = "";
            txt_Total_SPrice.Text = "";

            if (combo_Item_ID.Tag.ToString() == "1") { combo_Item_ID.Select(); }
            else if (txt_Barcode.Tag.ToString() == "1") { txt_Barcode.Select(); }
            else { combo_Item_Name.Select(); }

            Console.Beep();

            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (DGV.CurrentRow.Cells["Item_ID"].Value == r.Cells["Item_ID"].Value)
                {
                    if (r == DGV.CurrentRow) { return; }
                    r.DefaultCellStyle.BackColor = Color.Yellow;
                    DGV.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    Console.Beep();
                }
            }
            skip_d = false;
        }
        private void Navigate()
        {
            combo_Stores.SelectedValue = dr_Open["Store_ID"];
            combo_CC1.SelectedValue = dr_Open["CC1_ID"];
            combo_CC2.SelectedValue = dr_Open["CC2_ID"];
            combo_Bill_User.SelectedValue = dr_Open["User_ID"];

            textBox_Bill_ID.Text = dr_Open["Open_ID"].ToString();
            btn_Ref_No.Text = dr_Open["Jor_ID"].ToString();
            dtp_Open.Value = Convert.ToDateTime(dr_Open["Open_Date"]);
            txt_Notes.Text = dr_Open["Open_Notes"].ToString();
            com_Emp_Name.SelectedValue = dr_Open["Open_Person"];
            textBox_Total_Cost_Price.Text = dr_Open["Open_Total_CPrice"].ToString();
            textBox_Total_Sal_Price.Text = dr_Open["Open_Total_SPrice"].ToString();

            DGV.DataSource = Main.dt_IO;
            Main.dt_IO.DefaultView.RowFilter = string.Format("Bill_ID ='" + textBox_Bill_ID.Text + "' and Bill_Type = 1");

            if (Tag.ToString() != "Select")
            {
                Form_Mode("Select");
                Tag = "Select";
            }
        }
        private void UpDowen()
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

        #endregion

        #region Form
        private void Opening_Balance_Enter(object sender, EventArgs e)
        {
            UpDowen();
        }
        private void Opening_Balance_Shown(object sender, EventArgs e)
        {
            panel_Item_ID.Width = DGV.Columns["Item_ID"].Width;
            panel_Item_Name.Width = DGV.Columns["Item_Name"].Width;
            panel_Item_Quan.Width = DGV.Columns["Item_Quan"].Width;
            panel_PPrice.Width = DGV.Columns["Items_PPrice"].Width;
            panel_CPrice.Width = DGV.Columns["Items_CPrice"].Width;
            panel_SPrice.Width = DGV.Columns["Items_SPrice"].Width;
            panel_Total_CPrice.Width = DGV.Columns["Total_CPrice"].Width;
            panel_Total_PPrice.Width = DGV.Columns["Total_SPrice"].Width;

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
            if (lbl_CC1.Text == "") { btn_cc1_del.Visible = false; } else { btn_cc1_del.Visible = true; }
        }

        private void lbl_CC2_TextChanged(object sender, EventArgs e)
        {
            if (lbl_CC2.Text == "") { btn_cc2_del.Visible = false; } else { btn_cc2_del.Visible = true; }
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
            combo_Stores.Visible = true;
            dv_stores.RowFilter = string.Format("Branche_ID = '" + combo_Bill_Branches.SelectedValue.ToString() + "'");
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;

            // fill stores
            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (combo_Stores.Items.Count > 0) { combo_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = combo_Stores.Text;
            combo_Stores.Visible = false;

            // cc1
            dv_cc1.RowFilter = string.Format("CC1 = True and (Branche = '" + combo_Bill_Branches.SelectedValue.ToString() + "' or Branche IS NULL)");
            contextMenuStrip_cc1.Items.Clear();
            for (int i = 0; i < combo_CC1.Items.Count; i++)
            {
                contextMenuStrip_cc1.Items.Add(combo_CC1.GetItemText(combo_CC1.Items[i]), Main.imageList16.Images["cc1_16.png"]);
            }
            combo_CC1.SelectedValue = -1;

            // cc2
            dv_cc2.RowFilter = string.Format("CC2 = True and (Branche = '" + combo_Bill_Branches.SelectedValue.ToString() + "' or Branche IS NULL)");
            contextMenuStrip_cc2.Items.Clear();
            for (int i = 0; i < combo_CC2.Items.Count; i++)
            {
                contextMenuStrip_cc2.Items.Add(combo_CC2.GetItemText(combo_CC2.Items[i]), Main.imageList16.Images["cc1_16.png"]);
            }
            combo_CC2.SelectedValue = -1;

        }
        private void combo_Stores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_Stores.Text = combo_Stores.Text;
        }
        private void combo_CC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CC1.Text = combo_CC1.Text;
        }
        private void combo_CC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CC2.Text = combo_CC2.Text;
        }
        private void combo_Bill_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_User.Text = combo_Bill_User.Text;
        }

        private void btn_Bill_Branche_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 5), 54); return; }
            if (combo_Bill_Branches.Enabled == true && up == false) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 267); }
            else if (combo_Bill_Branches.Enabled == true && up == true) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 133); }
        }
        private void btn_Stores_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 54); return; }
            if (combo_Stores.Enabled == true && up == false) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 267); }
            if (combo_Stores.Enabled == true && up == true) { contextMenuStrip_stores.Show((btn_Stores.Right - contextMenuStrip_stores.Width - 3), 133); }
        }
        private void btn_CC1_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 54); return; }
            if (combo_CC1.Enabled == true && up == false) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 267); }
            if (combo_CC1.Enabled == true && up == true) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 133); }
        }
        private void btn_cc1_del_Click(object sender, EventArgs e)
        {
            combo_CC1.SelectedValue = -1;
            btn_cc1_del.Visible = false;
        }
        private void btn_CC2_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 54); return; }
            if (combo_CC2.Enabled == true && up == false) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 267); }
            if (combo_CC2.Enabled == true && up == true) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 133); }
        }
        private void btn_cc2_del_Click(object sender, EventArgs e)
        {
            combo_CC2.SelectedValue = -1;
            btn_cc2_del.Visible = false;
        }
        private void btn_Bill_User_Click(object sender, EventArgs e)
        {
            if (Parent == null) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 54); return; }
            if (combo_Bill_User.Enabled == true && up == false) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 267); }
            if (combo_Bill_User.Enabled == true && up == true) { contextMenuStrip_users.Show((btn_Bill_User.Right - contextMenuStrip_users.Width - 3), 133); }
        }

        private void contextMenuStrip_branches_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Bill_Branches.SelectedIndex = contextMenuStrip_branches.Items.IndexOf(e.ClickedItem);
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            lbl_bill_Branches.Location = new Point(lbl_bill_Branches.Left - lbl_bill_Branches.Width, lbl_bill_Branches.Location.Y);
        }
        private void contextMenuStrip_stores_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Stores.SelectedIndex = contextMenuStrip_stores.Items.IndexOf(e.ClickedItem);
            lbl_Bill_Stores.Text = combo_Stores.Text;
            lbl_Bill_Stores.Location = new Point(lbl_Bill_Stores.Left - lbl_Bill_Stores.Width, lbl_Bill_Stores.Location.Y);
        }
        private void contextMenuStrip_cc1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_CC1.SelectedIndex = contextMenuStrip_cc1.Items.IndexOf(e.ClickedItem);
            lbl_CC1.Text = combo_CC1.Text;
            btn_cc1_del.Visible = true;
        }
        private void contextMenuStrip_cc2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_CC2.SelectedIndex = contextMenuStrip_cc2.Items.IndexOf(e.ClickedItem);
            lbl_CC2.Text = combo_CC2.Text;
            btn_cc2_del.Visible = true;
        }
        private void contextMenuStrip_users_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Bill_User.SelectedIndex = contextMenuStrip_users.Items.IndexOf(e.ClickedItem);
            lbl_Bill_User.Text = combo_Bill_User.Text;
            lbl_Bill_User.Location = new Point(lbl_Bill_User.Left - lbl_Bill_User.Width, lbl_Bill_User.Location.Y);
        }
        #endregion

        #region GroupBox Head Controls
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

        private void button_Settings_MouseEnter(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Popup;
        }

        private void button_Settings_MouseLeave(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Flat;
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
            if (Tag.ToString() == "Empty" || Tag.ToString() == "Select")
            {
                Form_Mode("New");
                Tag = "New";
                if (up == false) { UpDowen(); }
            }
            else if (Tag.ToString() == "New")
            {
                if (DGV.Rows.Count == 0) { MessageBox.Show("يجب إدخال أصناف قبل حفظ السند"); return; }

                //insert into database
                var();
                string t = Open.Insert();
                textBox_Bill_ID.Text = t.ToString();

                // Add Last Bill From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(t, 1);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_Open.Rows.Add(r.ItemArray);
                }

                // Add IO to Main.dt_IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(t, 1);
                foreach (DataRow r in p2.Rows)
                {
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }

                // Reset Cursor Position
                n = Main.dt_Open.Rows.Count - 1;
                dr_Open = Main.dt_Open.Rows[n];
                Navigate();
                // Jor
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
            if (Tag.ToString() == "Select")
            {
                Tag = "Edit";
                Temp_dgv.Rows.Clear();
                Temp_dgv = table();
                Form_Mode("Edit");
                foreach (DataRow row in Temp_dgv.Rows)
                {
                    DGV.Rows.Add();
                    DGV.CurrentCell = DGV.Rows[DGV.Rows.Count - 1].Cells[0];

                    DGV.CurrentRow.Cells["Item_ID"].Value = row["رقم الصنف"].ToString();
                    DGV.CurrentRow.Cells["Item_Name"].Value = row["أسم الصنف"].ToString();
                    DGV.CurrentRow.Cells["Item_Quan"].Value = row["الكمية"].ToString();
                    DGV.CurrentRow.Cells["Items_PPrice"].Value = row["سعر الشراء"].ToString();
                    DGV.CurrentRow.Cells["Items_CPrice"].Value = row["سعر التكلفة"].ToString();
                    DGV.CurrentRow.Cells["Items_SPrice"].Value = row["سعر البيع"].ToString();
                    DGV.CurrentRow.Cells["Total_CPrice"].Value = row["الإجمالي بسعر التكلفة"].ToString();
                    DGV.CurrentRow.Cells["Total_SPrice"].Value = row["الإجمالي بسعر البيع"].ToString();
                }
            }
            else if (Tag.ToString() == "Edit")
            {
                //insert into database
                var();
                string t = Open.Update();

                // Remove Old Bill From Datatable
                Main.dt_Open.Rows.RemoveAt(n);
                // Remove Old IO
                for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                {
                    if (Main.dt_IO.Rows[i]["Bill_ID"].ToString() == textBox_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "1")
                    {
                        Main.dt_IO.Rows.RemoveAt(i);
                        i--;
                    }
                }
                // Insert Bill From DataBase To dt_Open
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(t, 1);
                dr_Open = Main.dt_Open.NewRow();
                dr_Open.ItemArray = p1.Rows[0].ItemArray.Clone() as object[];
                Main.dt_Open.Rows.InsertAt(dr_Open, n);
                // Add IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(t, 1);
                foreach (DataRow r in p2.Rows)
                {
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }

                dr_Open = Main.dt_Open.Rows[n];
                Navigate();

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
                    // Remove old Jor_D from Main.dt_Jor_D
                    for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                    {
                        if (Main.dt_Jor_D.Rows[i]["Jor_ID"].ToString() == btn_Ref_No.Text)
                        {
                            Main.dt_Jor_D.Rows.RemoveAt(i);
                            i--;
                        }
                    }
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
                //Delete Confirm
                if (MessageBox.Show("هل بالفعل تريد حذف السند ؟", "حذف ؟", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Delete In DataBase
                    Open.Delete(textBox_Bill_ID.Text);

                    // Remove bill from Main.dt_Open
                    Main.dt_Open.Rows.RemoveAt(n);
                    // Remove Old IO
                    for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                    {
                        if (Main.dt_IO.Rows[i]["Bill_ID"].ToString() == textBox_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "1")
                        {
                            Main.dt_IO.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    if (btn_Ref_No.Text != "")
                    {
                        int n_Jor = 0;
                        // Remove old Jor from Main.dt_Jor
                        foreach (DataRow r in Main.dt_Jor.Rows)
                        {
                            if (r["Jor_ID"].ToString() == btn_Ref_No.Text)
                            { n_Jor = Main.dt_Jor.Rows.IndexOf(r); Main.dt_Jor.Rows.Remove(r); break; }
                        }
                        // Remove old Jor_D from Main.dt_Jor_D
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
            if (Tag.ToString() == "New")
            {
                Form_Mode("Empty");
                Tag = "Empty";
            }
            else if (Tag.ToString() == "Edit")
            {
                dr_Open = Main.dt_Open.Rows[n];
                Navigate();
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {         
            Main.Opening_Balance_Form_Open = false;
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
                Jor.ChangetxtSearch(t.Substring(4));
            }
        }
        #endregion

        #region GroupBox_Details

        // Barcodr
        private void txt_Barcode_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Barcode.Text == "Barcode")
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
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }
            if (e.KeyChar == 13 && txt_Barcode.Text != "")
            {
                foreach (DataRow dr in Main.dt_Items.Rows)
                {
                    if (dr["Item_ID"].ToString() == txt_Barcode.Text && Convert.ToBoolean(dr["Is_Parent"]) == false)
                    {
                        dr_Open = dr;
                    }
                }

                if (dr_Open == null) { return; }

                skip_d = true;
                combo_Item_ID.SelectedValue = txt_Barcode.Text;
                combo_Item_Name.SelectedValue = txt_Barcode.Text;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Open["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice"]).ToString();

                skip_d = false;

                dr_Open = null;

                combo_Item_ID.Tag = "0";
                combo_Item_Name.Tag = "0";
                txt_Barcode.Tag = "1";

                txt_Quan.Select();
                e.Handled = true;
            }
        }

        // Combo Item_ID
        private void combo_Item_ID_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أدخل رقم الصنف ثم أضغط  Enter";
            combo_Item_ID.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void combo_Item_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (DataRow dr in Main.ds.Tables[30].Rows)
                {
                    if (dr["Item_ID"].ToString() == combo_Item_ID.SelectedValue.ToString())
                    {
                        dr_Open = dr;
                        break;
                    }
                }

                skip_d = true;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Open["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice1"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice1"]).ToString();
                skip_d = false;

                combo_Item_ID.Tag = "1";
                combo_Item_Name.Tag = "0";
                txt_Barcode.Tag = "0";

                txt_Quan.Select();
            }
        }
        private void combo_Item_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Item_ID.SelectedValue == null) { return; }
            combo_Item_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Item_Name.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Item_Name.SelectedValue = combo_Item_ID.SelectedValue.ToString();
        }
        private void combo_Item_ID_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";
        }

        // Combo Item_Name
        private void combo_Item_Name_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أدخل أسم الصنف ثم أضغط  Enter";
            combo_Item_Name.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void combo_Item_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (DataRow dr in Main.ds.Tables[30].Rows)
                {
                    if (dr["Item_ID"].ToString() == combo_Item_Name.SelectedValue.ToString())
                    {
                        dr_Open = dr;
                    }
                }

                skip_d = true;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Open["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Open["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Open["SPrice"]).ToString();

                skip_d = false;

                combo_Item_ID.Tag = "0";
                combo_Item_Name.Tag = "1";
                txt_Barcode.Tag = "0";

                txt_Quan.Select();
            }
        }
        private void combo_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Item_Name.SelectedValue == null) { return; }
            combo_Item_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Item_Name.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Item_ID.SelectedValue = combo_Item_Name.SelectedValue.ToString();
        }
        private void combo_Item_Name_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";
        }

        // txt_Quan
        private void txt_Quan_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أضغط  Enter  للتنقل أو  +  لإضافة الصنف";
        }
        private void txt_Quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Number
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

            // if press +  if enter
            if (e.KeyChar == 043)
            {
                e.Handled = true;
                txt_Quan.Tag = "+";
                Recored();
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_PPrice.Focus();
            }
        }
        private void txt_Quan_TextChanged(object sender, EventArgs e)
        {
            if (skip_d == true || dgv_select == true) { return; }

            if (txt_Quan.Text == "" | txt_Quan.Text == "." | txt_Total_CPrice.Text == "" | txt_Total_SPrice.Text == "") { return; }

            if (Convert.ToDecimal(txt_Quan.Text) == 0 ) { return; }

            txt_Total_CPrice.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_CPrice.Text), 2)).ToString();
            txt_Total_SPrice.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_SPrice.Text), 2)).ToString();
        }
        private void txt_Quan_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";
            if (combo_Item_ID.SelectedValue == null) { return; }

            if (txt_Quan.Text == "" || txt_Quan.Text == ".") { txt_Quan.Text = "1"; }
            if (Convert.ToDecimal(txt_Quan.Text) == 0) { txt_Quan.Text = "1"; }
        }

        // txt_PPrice
        private void txt_PPrice_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أضغط  Enter  للتنقل أو  +  لإضافة الصنف";
        }
        private void txt_PPrice_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                txt_PPrice.Tag = "+";
                Recored();
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_CPrice.Focus();
            }
        }
        private void txt_PPrice_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_PPrice_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";
        }

        // txt_CPrice
        private void txt_CPrice_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أضغط  Enter  للتنقل أو  +  لإضافة الصنف";
        }
        private void txt_CPrice_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                txt_CPrice.Tag = "+";
                Recored();
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_SPrice.Focus();
            }
        }
        private void txt_CPrice_TextChanged(object sender, EventArgs e)
        {
            if (skip_d == true || dgv_select == true) { return; }

            if (txt_CPrice.Text == "" | txt_CPrice.Text == ".") { return; }

            if (Convert.ToDecimal(txt_CPrice.Text) == 0) { return; }

            txt_Total_CPrice.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_CPrice.Text), 2)).ToString();
        }
        private void txt_CPrice_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";

            if (txt_CPrice.Tag.ToString() != "+" && txt_CPrice.Text == "" || txt_CPrice.Text == ".")
            {
                txt_CPrice.Text = "0";
                txt_CPrice.Tag = "";
            }
        }

        // txt_SPrice
        private void txt_SPrice_Enter(object sender, EventArgs e)
        {
            lbl_info.Text = "أضغط  Enter  للتنقل أو  +  لإضافة الصنف";
        }
        private void txt_SPrice_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == 043 || e.KeyChar == 13)
            {
                e.Handled = true;
                txt_SPrice.Tag = "+";
                Recored();
            }
        }
        private void txt_SPrice_TextChanged(object sender, EventArgs e)
        {
            if (skip_d == true || dgv_select == true) { return; }

            if (txt_SPrice.Text == "" | txt_SPrice.Text == ".") { return; }

            if (Convert.ToDecimal(txt_SPrice.Text) == 0) { return; }

            txt_Total_SPrice.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_SPrice.Text), 2)).ToString();
        }
        private void txt_SPrice_Leave(object sender, EventArgs e)
        {
            lbl_info.Text = "";

            if (txt_SPrice.Tag.ToString() != "+" && txt_SPrice.Text == "" || txt_SPrice.Text == ".")
            {
                txt_SPrice.Text = "0";
                txt_SPrice.Tag = "";
            }
        }

        // DGV
        private void DGV_SelectionChanged(object sender, EventArgs e)
        {

            if (skip_d == true || nav == true || Tag.ToString() == "Select" || DGV.CurrentRow == null
                || dgv_select == false)
            { dgv_select = false; return; }
            if (DGV.Rows.Count > 0)
            {
                dgv_select = true;
                if (Tag.ToString().ToString() != "New")
                {
                    MessageBox.Show("DGV_SelectionChanged");

                    combo_Item_ID.SelectedValue = DGV.CurrentRow.Cells["Item_ID"].Value.ToString();
                    txt_Quan.Text = DGV.CurrentRow.Cells["Item_Quan"].Value.ToString();
                    if (DGV.CurrentRow.Cells["Items_PPrice"].Value != null) { txt_PPrice.Text = DGV.CurrentRow.Cells["Items_PPrice"].Value.ToString(); }
                    if (DGV.CurrentRow.Cells["Items_CPrice"].Value != null) { txt_CPrice.Text = DGV.CurrentRow.Cells["Items_CPrice"].Value.ToString(); }
                    if (DGV.CurrentRow.Cells["Items_SPrice"].Value != null) { txt_SPrice.Text = DGV.CurrentRow.Cells["Items_SPrice"].Value.ToString(); }
                    if (DGV.CurrentRow.Cells["Total_CPrice"].Value != null) { txt_Total_CPrice.Text = DGV.CurrentRow.Cells["Total_CPrice"].Value.ToString(); }
                    if (DGV.CurrentRow.Cells["Total_SPrice"].Value != null) { txt_Total_SPrice.Text = DGV.CurrentRow.Cells["Total_SPrice"].Value.ToString(); }
                }
            }
            dgv_select = false;
        }
        private void DGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (nav == true) { return; }

            decimal cp = Math.Round(Convert.ToDecimal(textBox_Total_Cost_Price.Text), 2) - Convert.ToDecimal(DGV.CurrentRow.Cells["Total_CPrice"].Value);
            textBox_Total_Cost_Price.Text = cp.ToString();

            decimal sp = Math.Round(Convert.ToDecimal(textBox_Total_Sal_Price.Text), 2) - Convert.ToDecimal(DGV.CurrentRow.Cells["Total_SPrice"].Value);
            textBox_Total_Sal_Price.Text = sp.ToString();
        }
        #endregion

        #region Navigation
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
            if (Main.dt_Open.Rows.Count == 0) { return; }
            nav = true;
            n = 0;
            do
            {
                if (n > Main.dt_Open.Rows.Count - 1) { n = 0; Form_Mode("Empty"); return; }
                dr_Open = Main.dt_Open.Rows[n];
                n++;
            } while (dr_Open["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
            n--;
            Navigate();
            nav = false;
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            if (Main.dt_Open.Rows.Count == 0) { return; }
            nav = true;
            n = Main.dt_Open.Rows.Count - 1;
            do
            {
                if (n < 0) { n = Main.dt_Open.Rows.Count - 1; Form_Mode("Empty"); return; }
                dr_Open = Main.dt_Open.Rows[n];
                n--;            
            } while (dr_Open["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
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
                dr_Open = Main.dt_Open.Rows[n];

            } while (dr_Open["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            Navigate();
            nav = false;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            nav = true;
            do
            {
                n++;
                if (n > Main.dt_Open.Rows.Count - 1) { n = Main.dt_Open.Rows.Count - 1; return; }
                dr_Open = Main.dt_Open.Rows[n];

            } while (dr_Open["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

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
                for (int i = 0; i < Main.dt_Open.Rows.Count; i++)
                {
                    dr = Main.dt_Open.Rows[i];
                    if (dr["ID"].ToString() == textBox_Search.Text && dr["Branche_ID"].ToString() == combo_Bill_Branches.SelectedValue.ToString())
                    {
                        e.Handled = true;
                        dr_Open = dr;
                        n = i;
                    }
                }
                if (dr_Open == null) { return; }

                Navigate();
            }
        }
        #endregion
    }
}
