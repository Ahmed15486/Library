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
    public partial class FRM_Tran : Form
    {
        #region Declaration
        CLS_Tran Tran = new CLS_Tran();
        G.CLS_G G = new G.CLS_G();

        DataTable Temp_dgv = new DataTable();
        DataRow dr_Tran;
        int n;
        bool nav;
        bool up;
        bool skip_d;
        bool dgv_select;

        DataTable dt_branches = new DataTable();
        DataTable dt_stores = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();
        DataTable dt_users = new DataTable();

        frm_Main Main;
        #endregion

        public FRM_Tran(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_Stores.Image = Main.imageList32.Images["store_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];

            dt_branches = Main.dt_Branches.Clone();
            foreach (DataRow dr in Main.dt_Branches.Rows)
            {
                dt_branches.Rows.Add(dr.ItemArray);
            }
            dt_stores = Main.dt_Stores.Clone();
            foreach (DataRow dr in Main.dt_Stores.Rows)
            {
                dt_stores.Rows.Add(dr.ItemArray);
            }

            dt_cc1 = Main.dt_CC.Clone();
            foreach (DataRow dr in Main.dt_CC.Rows)
            {
                dt_cc1.Rows.Add(dr.ItemArray);
            }
            dt_cc1.DefaultView.RowFilter = string.Format("CC1 = True");

            dt_cc2 = Main.dt_CC.Clone();
            foreach (DataRow dr in Main.dt_CC.Rows)
            {
                dt_cc2.Rows.Add(dr.ItemArray);
            }
            dt_cc2.DefaultView.RowFilter = string.Format("CC2 = True");

            dt_users = Main.dt_Users.Clone();
            foreach (DataRow dr in Main.dt_Users.Rows)
            {
                dt_users.Rows.Add(dr.ItemArray);
            }

            comboBox_To_Branche.DataSource = Main.dt_To_Branche;
            comboBox_To_Branche.SelectedValue = -1;
            comboBox_To_Store.DataSource = Main.dt_To_Store;
            comboBox_To_Store.SelectedValue = -1;
            comboBox_Emp_Name.DataSource = Main.dt_Emp;
            comboBox_Emp_Name.SelectedValue = -1;

            combo_Item_ID.DataSource = Main.dt_Items;
            combo_Item_Name.DataSource = Main.dt_Items;
            combo_Item_ID.SelectedValue = -1;
            combo_Item_Name.SelectedValue = -1;

            DGV.AutoGenerateColumns = false;

            #region ContextMenuStrips
            // Branches
            combo_Bill_Branches.DataSource = dt_branches;
            combo_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            contextMenuStrip_branches.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_Bill_Branches.Items.Count; i++)
            {
                contextMenuStrip_branches.Items.Add(combo_Bill_Branches.GetItemText(combo_Bill_Branches.Items[i]), Main.imageList16.Images["branche_16.png"]);
            }

            // Stores
            combo_Stores.DataSource = dt_stores;

            contextMenuStrip_stores.ForeColor = Color.MidnightBlue;
            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (combo_Stores.Items.Count > 0) { combo_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = combo_Stores.Text;

            // CC1
            combo_CC1.DataSource = dt_cc1;
            combo_CC1.SelectedValue = -1;
            lbl_CC1.Text = combo_CC1.Text;
            btn_cc1_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc1.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_CC1.Items.Count; i++)
            {
                contextMenuStrip_cc1.Items.Add(combo_CC1.GetItemText(combo_CC1.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // CC2
            combo_CC2.DataSource = dt_cc2;
            combo_CC2.SelectedValue = -1;
            lbl_CC2.Text = combo_CC2.Text;
            btn_cc2_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc2.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_CC2.Items.Count; i++)
            {
                contextMenuStrip_cc2.Items.Add(combo_CC2.GetItemText(combo_CC2.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // Users
            combo_Bill_User.DataSource = dt_users;
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

                    groupBox_Header.Enabled = false;
                    DGV.AllowUserToDeleteRows = false;
                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Print.Visible = true;
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
                    //Clare Controls
                    textBox_Bill_ID.Clear();

                    textBox_Notes.Clear();
                    comboBox_Emp_Name.SelectedValue = -1;

                    dtp_Tran.Format = DateTimePickerFormat.Short;
                    groupBox_Header.Enabled = true;

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

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

                    textBox_Notes.Focus();

                    break;
                #endregion

                #region Edit
                case "Edit":

                    groupBox_Header.Enabled = true;

                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_New.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

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
                    break;
                #endregion

                #region Empty
                case "Empty":

                    //Clare Controls
                    textBox_Bill_ID.Clear();
                    textBox_Notes.Clear();
                    comboBox_Emp_Name.SelectedValue = -1;
                    comboBox_To_Branche.SelectedValue = -1;
                    comboBox_To_Store.SelectedIndex = -1;

                    textBox_Total_Cost_Price.Clear();
                    textBox_Total_Sal_Price.Clear();

                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    dtp_Tran.Format = DateTimePickerFormat.Custom;


                    groupBox_Header.Enabled = false;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Cancel.Visible = false;
                    button_Print.Visible = false;
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
            Tran.Branche_ID = combo_Bill_Branches.SelectedValue.ToString();
            Tran.Store_ID = Convert.ToUInt16(combo_Stores.SelectedValue);
            Tran.CC1_ID = Convert.ToUInt16(combo_CC1.SelectedValue);
            Tran.CC2_ID = Convert.ToUInt16(combo_CC2.SelectedValue);
            Tran.User_ID = Convert.ToUInt16(combo_Bill_User.SelectedValue);
            Tran.Tran_ID = textBox_Bill_ID.Text;
            Tran.Tran_Date = dtp_Tran.Value;
            Tran.To_Branche = comboBox_To_Branche.SelectedValue.ToString();
            Tran.To_Store = Convert.ToUInt16(comboBox_To_Store.SelectedValue);
            Tran.Emp_ID = Convert.ToUInt16(comboBox_Emp_Name.SelectedValue);
            Tran.Tran_Notes = textBox_Notes.Text;
            Tran.Tran_Total_CPrice = Convert.ToDecimal(textBox_Total_Cost_Price.Text);
            Tran.Tran_Total_PPrice = Convert.ToDecimal(textBox_Total_Sal_Price.Text);
            Tran.dt_IO = table();
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
            combo_Stores.SelectedValue = dr_Tran["Store_ID"];
            combo_CC1.SelectedValue = dr_Tran["CC1_ID"];
            combo_CC2.SelectedValue = dr_Tran["CC2_ID"];
            combo_Bill_User.SelectedValue = dr_Tran["User_ID"];

            txt_Jor_ID.Text = dr_Tran["Jor_ID"].ToString();

            textBox_Bill_ID.Text = dr_Tran["Tran_ID"].ToString();
            dtp_Tran.Value = Convert.ToDateTime(dr_Tran["Tran_Date"]);
            comboBox_To_Branche.SelectedValue = dr_Tran["To_Branche"];
            comboBox_To_Store.SelectedValue = dr_Tran["To_Store"];
            comboBox_Emp_Name.SelectedValue = dr_Tran["Emp_ID"];
            textBox_Notes.Text = dr_Tran["Tran_Notes"].ToString();
            textBox_Total_Cost_Price.Text = dr_Tran["Tran_Total_CPrice"].ToString();
            textBox_Total_Sal_Price.Text = dr_Tran["Tran_Total_SPrice"].ToString();

            DGV.DataSource = Main.dt_IO;
            Main.dt_IO.DefaultView.RowFilter = string.Format("Bill_ID ='" + textBox_Bill_ID.Text + "' and Bill_Type = 3");

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
                groupBox_Details.Height += Main.tab_Main.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else if (Main.tab_Main.Visible == true && up == true)
            {
                up = false;
                groupBox_Details.Height -= Main.tab_Main.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region Form
        private void FRM_Tran_Enter(object sender, EventArgs e)
        {
            UpDowen();
        }
        private void FRM_Tran_Shown(object sender, EventArgs e)
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
            dt_stores.DefaultView.RowFilter = string.Format("Branche_ID = '" + combo_Bill_Branches.SelectedValue.ToString() + "'");
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;

            contextMenuStrip_stores.Items.Clear();
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            if (combo_Stores.Items.Count > 0) { combo_Stores.SelectedIndex = 0; }
            lbl_Bill_Stores.Text = combo_Stores.Text;
            combo_Stores.Visible = false;
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
                comboBox_To_Branche.DroppedDown = true;
            }
            else if (Tag.ToString() == "New")
            {
                if(comboBox_To_Branche.SelectedValue == null) { MessageBox.Show("يجب تحديد الفرع والمستودع المحول إليه"); return; }
                if (DGV.Rows.Count == 0) { MessageBox.Show("يجب إدخال أصناف قبل حفظ السند"); return; }

                //insert into database   
                var();
                string t = Tran.Insert();
                textBox_Bill_ID.Text = t.ToString();

                // Add  Bill From DataBase To Main.dt_Tran
                DataTable p1 =new DataTable();
                p1=G.Select_LastBill(textBox_Bill_ID.Text,3);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_Tran.Rows.Add(r.ItemArray);
                }
                // Add  Bill From DataBase To Main.dt_IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(textBox_Bill_ID.Text,3);
                foreach (DataRow r in p2.Rows)
                {
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }
                // Reset Cursor Position
                n = Main.dt_Tran.Rows.Count - 1;
                dr_Tran= Main.dt_Tran.Rows[n];
                Navigate();
                // Jor
                if (txt_Jor_ID.Text != "")
                {
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(txt_Jor_ID.Text);
                    foreach (DataRow dr in j.Rows)
                    {
                        Main.dt_Jor.Rows.Add(dr.ItemArray);
                    }
                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(txt_Jor_ID.Text);
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
                // Update database   
                var();
                string t = Tran.Update();

                Form_Mode("Select");
                Tag = "Select";

                // Remove Old Bill From Datatable
                Main.dt_Tran.Rows.RemoveAt(n);
                for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                {
                    if( Main.dt_IO.Rows[i]["Bill_ID"].ToString() == textBox_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "3" | Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "16")
                    {
                        Main.dt_IO.Rows.RemoveAt(i);
                        i--;
                    }
                }
                // Insert Bill From DataBase To Main.dt_Tran
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(textBox_Bill_ID.Text,3);
                dr_Tran = Main.dt_Tran.NewRow();
                dr_Tran.ItemArray = p1.Rows[0].ItemArray.Clone() as object[];
                Main.dt_Tran.Rows.InsertAt(dr_Tran,n);
                // Add IO
                DataTable p2 = new DataTable();
                p2 = G.Select_LastIO(textBox_Bill_ID.Text,3);
                foreach (DataRow r in p2.Rows)
                { 
                    Main.dt_IO.Rows.Add(r.ItemArray);
                }
                dr_Tran = Main.dt_Tran.Rows[n];
                Navigate();

                // Jor
                if (txt_Jor_ID.Text != "")
                {
                    int n_Jor = 0;
                    // Remove old Jor from Main.dt_Jor
                    foreach (DataRow r in Main.dt_Jor.Rows)
                    {
                        if (r["Jor_ID"].ToString() == txt_Jor_ID.Text)
                        { n_Jor = Main.dt_Jor.Rows.IndexOf(r); Main.dt_Jor.Rows.Remove(r); break; }
                    }
                    // Remove old Jor_D from Main.dt_Jor_D
                    for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                    {
                        if (Main.dt_Jor_D.Rows[i]["Jor_ID"].ToString() == txt_Jor_ID.Text)
                        {
                            Main.dt_Jor_D.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(txt_Jor_ID.Text);

                    DataRow dr_Jor = Main.dt_Jor.NewRow();
                    dr_Jor.ItemArray = j.Rows[0].ItemArray.Clone() as object[];
                    Main.dt_Jor.Rows.InsertAt(dr_Jor, n_Jor);

                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(txt_Jor_ID.Text);
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
                    Tran.Delete(textBox_Bill_ID.Text);

                    // Remove bill from Main.dt_Tran
                    Main.dt_Tran.Rows.RemoveAt(n);
                    // Remove Old IO
                    for (int i = 0; i < Main.dt_IO.Rows.Count; i++)
                    {
                        if (Main.dt_IO.Rows[i]["Bill_ID"].ToString() == textBox_Bill_ID.Text && Main.dt_IO.Rows[i]["Bill_Type"].ToString() == "3")
                        {
                            Main.dt_IO.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    if (txt_Jor_ID.Text != "")
                    {
                        int n_Jor = 0;
                        // Remove old Jor from Main.dt_Jor
                        foreach (DataRow r in Main.dt_Jor.Rows)
                        {
                            if (r["Jor_ID"].ToString() == txt_Jor_ID.Text)
                            { n_Jor = Main.dt_Jor.Rows.IndexOf(r); Main.dt_Jor.Rows.Remove(r); break; }
                        }
                        // Remove old Jor_D from Main.dt_Jor_D
                        for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                        {
                            if (Main.dt_Jor_D.Rows[i]["Jor_ID"].ToString() == txt_Jor_ID.Text)
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
                dr_Tran = Main.dt_Tran.Rows[n];
                Navigate();
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Main.Tran_Form_Open = false;
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
            Parent.Dispose();
        }
        #endregion

        #region GroupBox_Header
        private void DGV_Tran_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (DGV.CurrentCell.OwningColumn.Name == "Item_ID")
            {
                foreach (DataRow dr in Main.dt_Items.Rows)
                {
                    if (dr["Item_ID"].ToString() == DGV.SelectedCells[0].Value.ToString())
                    {
                        dr_Tran = dr;
                    }
                }
                DGV.CurrentRow.Cells["Item_Name"].Value = dr_Tran["Item_Name"].ToString();
                DGV.CurrentRow.Cells["Item_Quan"].Value = 1;
                DGV.CurrentRow.Cells["Items_PPrice"].Value = dr_Tran["PPrice"].ToString();
                DGV.CurrentRow.Cells["Items_SPrice"].Value = dr_Tran["SPrice"].ToString();
                DGV.CurrentRow.Cells["Total_SPrice"].Value = (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value)).ToString();

                textBox_Total_Cost_Price.Text = (Convert.ToDecimal(textBox_Total_Cost_Price.Text) + (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_CPrice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value))).ToString();
                textBox_Total_Sal_Price.Text = (Convert.ToDecimal(textBox_Total_Sal_Price.Text) + (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value))).ToString();
            }
            else if (DGV.CurrentCell.OwningColumn.Name == "Item_Quan" | DGV.CurrentCell.OwningColumn.Name == "Items_Cprice" | DGV.CurrentCell.OwningColumn.Name == "Items_SPrice")
            {
                DGV.CurrentRow.Cells["Total_CPrice"].Value = (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_Cprice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value)).ToString();
                DGV.CurrentRow.Cells["Total_SPrice"].Value = (Convert.ToDecimal(DGV.CurrentRow.Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Item_Quan"].Value)).ToString();

                //Count Total CPrice
                decimal Total_CPrice = 0;
                for (int i = 0; i < DGV.Rows.Count - 1; i++)
                {
                    Total_CPrice += Convert.ToDecimal(DGV.Rows[i].Cells["Items_CPrice"].Value) * Convert.ToDecimal(DGV.Rows[i].Cells["Item_Quan"].Value);
                }
                textBox_Total_Cost_Price.Text = Total_CPrice.ToString();

                //Count Total SPrice
                decimal Total_SPrice = 0;
                for (int i = 0; i < DGV.Rows.Count - 1; i++)
                {
                    Total_SPrice += Convert.ToDecimal(DGV.Rows[i].Cells["Items_SPrice"].Value) * Convert.ToDecimal(DGV.Rows[i].Cells["Item_Quan"].Value);
                }
                textBox_Total_Sal_Price.Text = Total_SPrice.ToString();
            }
        }
        private void DGV_Tran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex - 1);
            }
        }
        private void dateTimePicker_Tran_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Tran.Format = DateTimePickerFormat.Short;
        }
        private void comboBox_To_Branche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_To_Branche.SelectedValue != null)
            {
                Main.dt_To_Store.DefaultView.RowFilter = string.Format("Branche_ID = '" + comboBox_To_Branche.SelectedValue.ToString() + "'");
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
                        dr_Tran = dr;
                    }
                }

                if (dr_Tran == null) { return; }

                skip_d = true;
                combo_Item_ID.SelectedValue = txt_Barcode.Text;
                combo_Item_Name.SelectedValue = txt_Barcode.Text;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Tran["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();

                skip_d = false;

                dr_Tran = null;

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
                foreach (DataRow dr in Main.dt_Items.Rows)
                {
                    if (dr["Item_ID"].ToString() == combo_Item_ID.SelectedValue.ToString())
                    {
                        dr_Tran = dr;
                    }
                }

                skip_d = true;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Tran["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();
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
                foreach (DataRow dr in Main.dt_Items.Rows)
                {
                    if (dr["Item_ID"].ToString() == combo_Item_Name.SelectedValue.ToString())
                    {
                        dr_Tran = dr;
                    }
                }

                skip_d = true;

                txt_Quan.Text = "1";
                txt_PPrice.Text = Convert.ToDecimal(dr_Tran["PPrice"]).ToString();
                txt_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();
                txt_Total_CPrice.Text = Convert.ToDecimal(dr_Tran["CPrice"]).ToString();
                txt_Total_SPrice.Text = Convert.ToDecimal(dr_Tran["SPrice"]).ToString();

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

            if (Convert.ToDecimal(txt_Quan.Text) == 0) { return; }

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
                textBox_Search.ForeColor = Color.Red;
            }
        }
        private void textBox_Search_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "Search")
            {
                textBox_Search.ForeColor = Color.Silver;
            }
        }
        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "Search")
            {
                textBox_Search.Text = "";
                textBox_Search.ForeColor = Color.Black;
            }
        }
        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            textBox_Search.Text = "Search";
            textBox_Search.ForeColor = Color.Silver;
        }
        #endregion
        private void button_First_Click(object sender, EventArgs e)
        {
            if (Main.dt_Tran.Rows.Count == 0) { return; }
            nav = true;
            n = 0;
            do
            {
                if (n > Main.dt_Tran.Rows.Count - 1) { n = 0; Form_Mode("Empty"); return; }
                dr_Tran = Main.dt_Tran.Rows[n];
                n++;
            } while (dr_Tran["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
            n--;
            Navigate();
            nav = false;
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            if (Main.dt_Tran.Rows.Count == 0) { return; }
            nav = true;
            n = Main.dt_Tran.Rows.Count - 1;
            do
            {
                if (n < 0) { n = Main.dt_Tran.Rows.Count - 1; Form_Mode("Empty"); return; }
                dr_Tran = Main.dt_Tran.Rows[n];
                n--;              

            } while (dr_Tran["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
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
                dr_Tran = Main.dt_Tran.Rows[n];

            } while (dr_Tran["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            Navigate();
            nav = false;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            nav = true;
            do
            {
                n++;
                if (n > Main.dt_Tran.Rows.Count - 1) { n = Main.dt_Tran.Rows.Count - 1; return; }
                dr_Tran = Main.dt_Tran.Rows[n];

            } while (dr_Tran["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

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
                for (int i = 0; i < Main.dt_Tran.Rows.Count; i++)
                {
                    dr = Main.dt_Tran.Rows[i];
                    if (dr["ID"].ToString() == textBox_Search.Text && dr["Branche_ID"].ToString() == combo_Bill_Branches.SelectedValue.ToString())
                    {
                        e.Handled = true;
                        dr_Tran = dr;
                        n = i;
                    }
                }
                if (dr_Tran == null) { return; }

                Navigate();
            }
        }
        #endregion
    }
}
