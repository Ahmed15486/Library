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
    public partial class FRM_Jor : Form
    {
        #region Declaration
        CLS_Jor Jor = new CLS_Jor();
        G.CLS_G G = new G.CLS_G();
        Bills.Jor.FRM_Jor_Set js = new Bills.Jor.FRM_Jor_Set();
        FRM_Jor_Add add = new FRM_Jor_Add();

        DataTable dt_bill_branches = new DataTable();
        DataTable dt_bill_cc1 = new DataTable();
        DataTable dt_bill_cc2 = new DataTable();
        DataTable dt_users = new DataTable();

        DataTable dt_branches = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();

        DataTable Temp_dgv = new DataTable();
        DataTable dt_JorType = new DataTable();

        DataView dv_acc;
        DataView dv_currency;
        DataView dv_cc1;
        DataView dv_cc2;
        DataView dv_branche;

        DataRow dr_Jor;
        int n;
        bool nav;
        bool up = false;
        public int top;

        frm_Main Main;
        #endregion

        public FRM_Jor(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];

            dt_bill_branches = Main.ds.Tables[1].Clone();
            foreach (DataRow dr in Main.ds.Tables[1].Rows)
            {
                dt_bill_branches.Rows.Add(dr.ItemArray);
            }
            dt_bill_cc1 = Main.ds.Tables[3].Clone();
            foreach (DataRow dr in Main.ds.Tables[3].Rows)
            {
                dt_bill_cc1.Rows.Add(dr.ItemArray);
            }
            dt_bill_cc1.DefaultView.RowFilter = string.Format("CC1 = True");

            dt_bill_cc2 = Main.ds.Tables[3].Clone();
            foreach (DataRow dr in Main.ds.Tables[3].Rows)
            {
                dt_bill_cc2.Rows.Add(dr.ItemArray);
            }
            dt_bill_cc2.DefaultView.RowFilter = string.Format("CC2 = True");

            dt_users = Main.ds.Tables[0].Clone();
            foreach (DataRow dr in Main.ds.Tables[0].Rows)
            {
                dt_users.Rows.Add(dr.ItemArray);
            }

            dt_branches = Main.ds.Tables[1].Clone();
            foreach (DataRow dr in Main.ds.Tables[1].Rows)
            {
                dt_branches.Rows.Add(dr.ItemArray);
            }
            dt_cc1 = Main.ds.Tables[3].Clone();
            foreach (DataRow dr in Main.ds.Tables[3].Rows)
            {
                dt_cc1.Rows.Add(dr.ItemArray);
            }
            dt_bill_cc1.DefaultView.RowFilter = string.Format("CC1 = True");

            dt_cc2 = Main.ds.Tables[3].Clone();
            foreach (DataRow dr in Main.ds.Tables[3].Rows)
            {
                dt_cc2.Rows.Add(dr.ItemArray);
            }
            dt_bill_cc2.DefaultView.RowFilter = string.Format("CC2 = True");

            com_Ref_Type.DataSource = Main.ds.Tables[18];
            com_Ref_Type.SelectedValue = -1;

            dv_acc = new DataView(Main.ds.Tables[6]);
            dv_acc.RowFilter = "Is_Parent = 0";

            dv_currency = new DataView(Main.ds.Tables[35]);
            com_Currency.DataSource = dv_currency;

            dv_cc1 = new DataView(Main.ds.Tables[3]);
            dv_cc1.RowFilter = "CC1 = 1";

            dv_cc2 = new DataView(Main.ds.Tables[3]);
            dv_cc2.RowFilter = "CC2 = 1";

            dv_branche = new DataView(Main.ds.Tables[1]);

            com_Currency.SelectedValue = -1;
            com_JorType.DataSource = Main.ds.Tables[38];
            com_JorType.SelectedValue = -1;

            Main.ds.Tables[15].DefaultView.RowFilter = string.Format("Jor_ID ='-1'");
            DGV.AutoGenerateColumns = false;
            DGV.DataSource = Main.ds.Tables[15];

            #region DGV

            var Debit = new DataGridViewTextBoxColumn();
            Debit.Name = "Debit";
            Debit.HeaderText = "مدين";
            Debit.DataPropertyName = "Debit";
            Debit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Debit.Width = 100;
            DGV.Columns.Add(Debit);

            var Credit = new DataGridViewTextBoxColumn();
            Credit.Name = "Credit";
            Credit.HeaderText = "دائن";
            Credit.DataPropertyName = "Credit";
            Credit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Credit.Width = 100;
            DGV.Columns.Add(Credit);

            var ACC_Name = new DataGridViewTextBoxColumn();
            ACC_Name.Name = "ACC_Name";
            ACC_Name.HeaderText = "أسم الحساب";
            ACC_Name.DataPropertyName = "ACC_Name";
            ACC_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_Name.Width = 130;
            DGV.Columns.Add(ACC_Name);

            var ACC_ID = new DataGridViewTextBoxColumn();
            ACC_ID.Name = "ACC_ID";
            ACC_ID.HeaderText = "كود الحساب";
            ACC_ID.DataPropertyName = "ACC_ID";
            ACC_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_ID.Width = 100;
            ACC_ID.Visible = false;
            DGV.Columns.Add(ACC_ID);

            var Notes = new DataGridViewTextBoxColumn();
            Notes.Name = "Notes";
            Notes.HeaderText = "البيان";
            Notes.DataPropertyName = "Notes";
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.Width = 150;
            Notes.MinimumWidth = 150;
            DGV.Columns.Add(Notes);

            var Currency = new DataGridViewComboBoxColumn();
            Currency.Name = "Currency";
            Currency.DataPropertyName = "Currency";
            Currency.DataSource = dv_currency;
            Currency.ValueMember = "ID";
            Currency.DisplayMember = "anm";
            Currency.HeaderText = "العملة";
            Currency.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Currency.Width = 100;
            Currency.Visible = false;
            DGV.Columns.Add(Currency);

            var Currency_Rate = new DataGridViewTextBoxColumn();
            Currency_Rate.Name = "Currency_Rate";
            Currency_Rate.HeaderText = "سعر العملة";
            Currency_Rate.DataPropertyName = "Currency_Rate";
            Currency_Rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Currency_Rate.Width = 100;
            Currency_Rate.Visible = false;
            DGV.Columns.Add(Currency_Rate);

            var CC1 = new DataGridViewComboBoxColumn();
            CC1.Name = "CC1";
            CC1.HeaderText = "مركز 1";
            CC1.DataPropertyName = "CC1";
            CC1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CC1.Width = 130;
            CC1.FlatStyle = FlatStyle.Popup;
            CC1.DataSource = Main.ds.Tables[3];
            CC1.ValueMember = "CC_ID";
            CC1.DisplayMember = "CC_Name";
            DGV.Columns.Add(CC1);

            var CC2 = new DataGridViewComboBoxColumn();
            CC2.Name = "CC2";
            CC2.HeaderText = "مركز 2";
            CC2.DataPropertyName = "CC2";
            CC2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CC2.Width = 130;
            CC2.FlatStyle = FlatStyle.Popup;
            CC2.DataSource = Main.ds.Tables[3];
            CC2.ValueMember = "CC_ID";
            CC2.DisplayMember = "CC_Name";
            DGV.Columns.Add(CC2);

            var Branche = new DataGridViewComboBoxColumn();
            Branche.Name = "Branche";
            Branche.HeaderText = "الفرع";
            Branche.DataPropertyName = "Branche";
            Branche.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Branche.Width = 130;
            Branche.Visible = false;
            Branche.FlatStyle = FlatStyle.Popup;
            Branche.DataSource = Main.ds.Tables[1];
            Branche.ValueMember = "Branche_ID";
            Branche.DisplayMember = "Branche_Name";
            DGV.Columns.Add(Branche);

            #endregion

            js.DGV = DGV;

            #region ContextMenuStrips
            // Branches
            combo_Bill_Branches.DataSource = dt_bill_branches;
            combo_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            contextMenuStrip_branches.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < combo_Bill_Branches.Items.Count; i++)
            {
                contextMenuStrip_branches.Items.Add(combo_Bill_Branches.GetItemText(combo_Bill_Branches.Items[i]), Main.imageList16.Images["branche_16.png"]);
            }

            // CC1
            com_CC1.DataSource = dt_bill_cc1;
            dt_bill_cc1.DefaultView.RowFilter = string.Format("CC1 = True");
            com_CC1.SelectedValue = -1;
            lbl_CC1.Text = com_CC1.Text;
            btn_cc1_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc1.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < com_CC1.Items.Count; i++)
            {
                contextMenuStrip_cc1.Items.Add(com_CC1.GetItemText(com_CC1.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // CC2
            com_CC2.DataSource = dt_bill_cc2;
            dt_bill_cc2.DefaultView.RowFilter = string.Format("CC2 = True");
            com_CC2.SelectedValue = -1;
            lbl_CC2.Text = com_CC2.Text;
            btn_cc2_del.Image = Main.imageList16.Images["close_16.png"];
            contextMenuStrip_cc2.ForeColor = Color.MidnightBlue;

            for (int i = 0; i < com_CC2.Items.Count; i++)
            {
                contextMenuStrip_cc2.Items.Add(com_CC2.GetItemText(com_CC2.Items[i]), Main.imageList16.Images["center_16.png"]);
            }

            // Users
            combo_Bill_User.DataSource = dt_users;
            contextMenuStrip_users.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < combo_Bill_User.Items.Count; i++)
            {
                contextMenuStrip_users.Items.Add(combo_Bill_User.GetItemText(combo_Bill_User.Items[i]), Main.imageList16.Images["user_16.png"]);
            }
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
                    
                    combo_Bill_Branches.Enabled = false;
                    com_CC1.Enabled = false;
                    com_CC2.Enabled = false;
                    btn_cc1_del.Visible = false;
                    btn_cc2_del.Visible = false;

                    dtp_Jor_Date.Enabled = false;
                    txt_Main_Notes.ReadOnly = true;
                    com_Currency.Enabled = false;
                    txt_Currency_Rate.ReadOnly = true;
                    com_JorType.Enabled = false;

                    DGV.AllowUserToDeleteRows = false;
                    groupBox_Footer_Controls.Visible = true;

                    btn_New.Visible = true;
                    btn_New.Text = "جديد";
                    btn_New.Image = imageList1.Images["New"];
                    btn_Edit.Visible = true;
                    btn_Edit.Text = "تعديل";
                    btn_Edit.Image = imageList1.Images["Edit"];
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    btn_Print.Visible = true;
                    btn_Settings.Visible = true;
                    btn_Close.Visible = true;
                    btn_Add.Visible = false;

                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (Convert.ToDecimal(r.Cells["Debit"].Value) == 0) { r.Cells["Debit"].Style.ForeColor = Color.Transparent; }
                        if (Convert.ToDecimal(r.Cells["Credit"].Value) == 0) { r.Cells["Credit"].Style.ForeColor = Color.Transparent; }
                    }

                    if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                    break;
                #endregion

                #region New
                case "New":

                    combo_Bill_Branches.Enabled = true;
                    com_CC1.Enabled = true;
                    com_CC2.Enabled = true;
                    com_Currency.Enabled = true;
                    txt_Currency_Rate.ReadOnly = false;

                    com_CC1.SelectedValue = -1;
                    com_CC2.SelectedValue = -1;

                    dtp_Jor_Date.Enabled = true;
                    txt_Main_Notes.ReadOnly = false;
                    com_JorType.Enabled = true;


                    com_JorType.SelectedIndex = 0;
                    txt_Bill_ID.Clear();
                    dtp_Jor_Date.Value = DateTime.Today;
                    dtp_Jor_Date.Format = DateTimePickerFormat.Short;
                    txt_Main_Notes.Clear();
                    com_Ref_Type.SelectedValue = "15";
                    btn_Ref_No.Text = "";
                    com_Currency.SelectedIndex = 0;
                    txt_Total_Local_Debit.Text = "0";
                    txt_Total_Local_Credit.Text = "0";

                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    DGV.AllowUserToDeleteRows = true;

                    groupBox_Footer_Controls.Visible = false;
                    txt_Main_Notes.Focus();

                    btn_New.Text = "حفظ";
                    btn_New.Image = imageList1.Images["Save"];
                    btn_Edit.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    btn_Print.Visible = false;
                    btn_Settings.Visible = false;
                    btn_Close.Visible = false;
                    btn_Add.Visible = true;
                    break;
                #endregion

                #region Edit
                case "Edit":

                    combo_Bill_Branches.Enabled = true;
                    com_CC1.Enabled = true;
                    com_CC2.Enabled = true;
                    btn_cc1_del.Visible = (com_CC1.SelectedValue != null) ? true : false;
                    btn_cc2_del.Visible = (com_CC2.SelectedValue != null) ? true : false;

                    com_Currency.Enabled = true;
                    txt_Currency_Rate.ReadOnly = false;
                    com_JorType.Enabled = true;

                    dtp_Jor_Date.Enabled = true;
                    txt_Main_Notes.ReadOnly = false;

                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    DGV.AllowUserToDeleteRows = true;

                    groupBox_Footer_Controls.Visible = false;
                    txt_Main_Notes.Focus();

                    btn_Edit.Text = "حفظ";
                    btn_Edit.Image = imageList1.Images["Save"];
                    btn_New.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    btn_Print.Visible = false;
                    btn_Settings.Visible = false;
                    btn_Close.Visible = false;
                    btn_Add.Visible = true;
                    break;
                #endregion

                #region Empty
                case "Empty":

                    combo_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
                    combo_Bill_Branches.Enabled = false;
                    com_CC1.Enabled = false;
                    com_CC2.Enabled = false;
                    btn_cc1_del.Visible = false;
                    btn_cc2_del.Visible = false;

                    com_Currency.Enabled = false;
                    txt_Currency_Rate.ReadOnly = true;
                    com_JorType.Enabled = false;

                    dtp_Jor_Date.Enabled = false;
                    txt_Main_Notes.ReadOnly = true;

                    // Clare Controls
                    // Head
                    com_CC1.SelectedValue = "-1";
                    com_CC2.SelectedValue = "-1";

                    txt_Bill_ID.Clear();
                    dtp_Jor_Date.Value = DateTime.Today;
                    dtp_Jor_Date.Format = DateTimePickerFormat.Custom;
                    txt_Main_Notes.Clear();
                    com_Ref_Type.SelectedValue = -1;
                    btn_Ref_No.Text = "";
                    txt_Total_Local_Debit.Clear();
                    txt_Total_Local_Credit.Clear();
                    com_JorType.SelectedValue = -1;

                    DGV.DataSource = null;
                    DGV.Rows.Clear();
                    DGV.AllowUserToDeleteRows = false;

                    groupBox_Footer_Controls.Visible = true;

                    btn_New.Visible = true;
                    btn_New.Text = "جديد";
                    btn_New.Image = imageList1.Images["New"];
                    btn_Edit.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    btn_Print.Visible = false;
                    btn_Settings.Visible = true;
                    btn_Close.Visible = true;
                    btn_Add.Visible = false;

                    break;
                    #endregion
            }
        }
        private DataTable table()
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
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        private DataTable table(int t)
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
            return dt;
        }
        private void var()
        {
            Jor.Branche_ID = combo_Bill_Branches.SelectedValue.ToString();
            Jor.CC1_ID = (com_CC1.SelectedValue != null)? com_CC1.SelectedValue.ToString() : "";
            Jor.CC2_ID = (com_CC2.SelectedValue != null)? com_CC2.SelectedValue.ToString() : "";
            Jor.User_ID = Convert.ToInt16(combo_Bill_User.SelectedValue);
            Jor.Currency = Convert.ToInt16(com_Currency.SelectedValue);
            Jor.Currency_Rate = Convert.ToDecimal(txt_Currency_Rate.Text);
            Jor.Jor_ID = txt_Bill_ID.Text;
            Jor.Date = dtp_Jor_Date.Value;
            Jor.Notes = txt_Main_Notes.Text;
            Jor.Jor_Type = Convert.ToInt16(com_JorType.SelectedValue);
            Jor.dt_Jor_D = table();
        }
        private void Count_D_C_Totals()
        {
            //Count Total Debit and Total Credit
            decimal Total_Debit = 0;
            foreach (DataGridViewRow r in DGV.Rows)
            {
                Total_Debit += Convert.ToDecimal(r.Cells["Debit"].Value);
            }
            txt_Total_Local_Debit.Text = Total_Debit.ToString();

            decimal Total_Credit = 0;
            foreach (DataGridViewRow r in DGV.Rows)
            {
                Total_Credit += Convert.ToDecimal(r.Cells["Credit"].Value);
            }
            txt_Total_Local_Credit.Text = Total_Credit.ToString();
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
        private void Navigate()
        {
            Tag = "Select";
            Form_Mode("Select");

            dr_Jor = Main.ds.Tables[14].Rows[n];
            combo_Bill_Branches.SelectedValue = dr_Jor["Branche_ID"].ToString();
            com_CC1.SelectedValue = dr_Jor["CC1_ID"].ToString();
            com_CC2.SelectedValue = dr_Jor["CC2_ID"].ToString();

            txt_Bill_ID.Text = dr_Jor["Jor_ID"].ToString();
            dtp_Jor_Date.Value = Convert.ToDateTime(dr_Jor["Jor_Date"]);
            txt_Main_Notes.Text = dr_Jor["Jor_Notes"].ToString();
            com_Ref_Type.SelectedValue = Convert.ToInt16(dr_Jor["Ref_Type"]);
            btn_Ref_No.Text = dr_Jor["Ref_No"].ToString();
            com_Currency.SelectedValue = dr_Jor["Currency"];
            txt_Currency_Rate.Text = dr_Jor["Currency_Rate"].ToString();
            com_JorType.SelectedValue = Convert.ToInt16(dr_Jor["Jor_Type"]);

            DGV.DataSource = Main.ds.Tables[15];
            Main.ds.Tables[15].DefaultView.RowFilter = string.Format("Jor_ID ='" + txt_Bill_ID.Text + "'");

            decimal d = 0; decimal c = 0; decimal ld = 0; decimal lc = 0;
            foreach (DataGridViewRow r in DGV.Rows)
            {
                d += Convert.ToDecimal(r.Cells["Debit"].Value);
                c += Convert.ToDecimal(r.Cells["Credit"].Value);
                ld += Convert.ToDecimal(r.Cells["Debit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
                lc += Convert.ToDecimal(r.Cells["Credit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
                if (Convert.ToDecimal(r.Cells["Debit"].Value) == 0) { r.Cells["Debit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Credit"].Value) == 0) { r.Cells["Credit"].Style.ForeColor = Color.Transparent; }
            }

            txt_Total_Debit.Text = Math.Round(d, 2).ToString();
            txt_Total_Credit.Text = Math.Round(c, 2).ToString();
            txt_Total_Local_Debit.Text = Math.Round(ld,2).ToString();
            txt_Total_Local_Credit.Text = Math.Round(lc,2).ToString();

            pnl_Total_Local_Debit_Credit.Visible = (d == ld & c == lc) ? false : true;

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }
        }
        int width(string s)
        {
            if (s == "مدين") return 90;
            else if (s == "دائن") return 90;
            else if (s == "أسم الحساب") return 200;
            else if (s == "البيان") return 200;
            else if (s == "مركز 1") return 100;
            else if (s == "مركز 2") return 100;
            else if (s == "الفرع") return 100;
            return 100;
        }
        #endregion

        #region Form
        private void FRM_Jor_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;

            if (DGV.Rows.Count == 0)
            {
                Tag = "Empty";
                Form_Mode("Empty");
                return;
            }

            // Count total Debit & total Credit
            decimal d = 0;
            decimal c = 0;
            foreach (DataGridViewRow r in DGV.Rows)
            {
                d = d + Convert.ToDecimal(r.Cells["Debit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
                c = c + Convert.ToDecimal(r.Cells["Credit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
            }
            txt_Total_Local_Debit.Text = d.ToString();
            txt_Total_Local_Credit.Text = c.ToString();
        }
        private void FRM_Jor_Shown(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

            decimal d = 0; decimal c = 0;
            foreach (DataGridViewRow r in DGV.Rows)
            {
                d += Convert.ToDecimal(r.Cells["Debit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
                c += Convert.ToDecimal(r.Cells["Credit"].Value) * Convert.ToDecimal(r.Cells["Currency_Rate"].Value);
                if (Convert.ToDecimal(r.Cells["Debit"].Value) == 0) { r.Cells["Debit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Credit"].Value) == 0) { r.Cells["Credit"].Style.ForeColor = Color.Transparent; }
            }
            Top = (top==0)? Top: top;
        }
        private void FRM_Jor_ResizeEnd(object sender, EventArgs e)
        {
            Height = (Height < 700) ? 700 : Height;
            Width = (Width < 975) ? 975 : Width;
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
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
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
            lbl_Bill_User.Text = combo_Bill_User.Text;
        }

        private void btn_Bill_Branche_Click(object sender, EventArgs e)
        {
            if (combo_Bill_Branches.Enabled == false) return;
            Point p = btn_Bill_Branche.PointToScreen(Point.Empty);
            contextMenuStrip_branches.Show(p.X - (contextMenuStrip_branches.Width - btn_Bill_Branche.Width), p.Y + btn_Bill_Branche.Height);
        }
        private void btn_CC1_Click(object sender, EventArgs e)
        {
            if (com_CC1.Enabled == false) return;
            Point p = btn_CC1.PointToScreen(Point.Empty);
            contextMenuStrip_cc1.Show(p.X - (contextMenuStrip_cc1.Width - btn_CC1.Width), p.Y + btn_CC1.Height);
        }
        private void btn_cc1_del_Click(object sender, EventArgs e)
        {
            com_CC1.SelectedValue = -1;
            btn_cc1_del.Visible = false;
        }
        private void btn_CC2_Click(object sender, EventArgs e)
        {
            if (com_CC2.Enabled == false) return;
            Point p = btn_CC2.PointToScreen(Point.Empty);
            contextMenuStrip_cc2.Show(p.X - (contextMenuStrip_cc2.Width - btn_CC2.Width), p.Y + btn_CC2.Height);
        }
        private void btn_cc2_del_Click(object sender, EventArgs e)
        {
            com_CC2.SelectedValue = -1;
            btn_cc2_del.Visible = false;
        }
        private void btn_Bill_User_Click(object sender, EventArgs e)
        {
            if (combo_Bill_User.Enabled == false) return;
            Point p = btn_Bill_User.PointToScreen(Point.Empty);
            contextMenuStrip_users.Show(p.X - (contextMenuStrip_users.Width - btn_Bill_User.Width), p.Y + btn_Bill_User.Height);     
        }

        private void contextMenuStrip_branches_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Bill_Branches.SelectedIndex = contextMenuStrip_branches.Items.IndexOf(e.ClickedItem);
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            lbl_bill_Branches.Location = new Point(lbl_bill_Branches.Left - lbl_bill_Branches.Width, lbl_bill_Branches.Location.Y);
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
            combo_Bill_User.SelectedIndex = contextMenuStrip_users.Items.IndexOf(e.ClickedItem);
            lbl_Bill_User.Text = combo_Bill_User.Text;
            lbl_Bill_User.Location = new Point(lbl_Bill_User.Left - lbl_Bill_User.Width, lbl_Bill_User.Location.Y);
        }

        #endregion

        #region groupBox_Header
        private void comboBox_Ref_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ((20 - com_Ref_Type.Text.Length) / 2); i++)
            {
                com_Ref_Type.Text = "     " +com_Ref_Type.Text;
            }      
             if(com_Ref_Type.SelectedValue == null) { return; }
            if(com_Ref_Type.SelectedValue.ToString() == "15" | Tag.ToString() == "Empty")
            {
                lbl_Ref_Type.Visible = false;
                com_Ref_Type.Visible = false;
                lbl_Ref_no.Visible = false;
                btn_Ref_No.Visible = false;
            }   
            else
            {
                lbl_Ref_Type.Visible = true;
                com_Ref_Type.Visible = true;
                lbl_Ref_no.Visible = true;
                btn_Ref_No.Visible = true;
            }  
        }
        private void dateTimePicker_Jor_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Jor_Date.Format = DateTimePickerFormat.Short;
        }
        private void btn_Ref_No_Click(object sender, EventArgs e)
        {
            if (btn_Ref_No.Text != "")
            {
                if (com_Ref_Type.SelectedValue.ToString() == "1")
                {
                    Bills.FRM_Open Open;
                    Open = new Bills.FRM_Open(Main);
                    string t = btn_Ref_No.Text;
                    Open.ChangetxtSearch(t.Substring(4));
                }
                else if (com_Ref_Type.SelectedValue.ToString() == "3")
                {
                    Bills.FRM_Tran Tran;
                    Tran = new Bills.FRM_Tran(Main);
                    string t = btn_Ref_No.Text;
                    Tran.ChangetxtSearch(t.Substring(4));
                }
                else if (com_Ref_Type.SelectedValue.ToString() == "7")
                {
                    Bills.FRM_Pur Pur;
                    Pur = new Bills.FRM_Pur(Main);
                    string t = btn_Ref_No.Text;
                    Pur.ChangetxtSearch(t.Substring(4));
                }
                else if (com_Ref_Type.SelectedValue.ToString() == "11")
                {
                    Bills.FRM_Sal Sal;
                    Sal = new Bills.FRM_Sal(Main);
                    string t = btn_Ref_No.Text;
                    Sal.ChangetxtSearch(t.Substring(4));
                }
                else if (com_Ref_Type.SelectedValue.ToString() == "13")
                {
                    Bills.FRM_Money_Out Money_Out;
                    Money_Out = new Bills.FRM_Money_Out(Main);
                    string t = btn_Ref_No.Text;
                    Money_Out.ChangetxtSearch(t.Substring(4));
                }
                else if (com_Ref_Type.SelectedValue.ToString() == "14")
                {
                    Bills.FRM_Money_In Money_In;
                    Money_In = new Bills.FRM_Money_In(Main);
                    string t = btn_Ref_No.Text;
                    Money_In.ChangetxtSearch(t.Substring(4));
                }
            }
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
        #endregion

        #region GBX_Controls
        #region btn display
        private void btn_New_MouseLeave(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Flat;
        }
        private void btn_New_MouseEnter(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            btn_Edit.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            btn_Edit.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Delete_MouseEnter(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Print_MouseEnter(object sender, EventArgs e)
        {

        }
        private void btn_Print_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btn_Settings_MouseEnter(object sender, EventArgs e)
        {
            btn_Settings.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Settings_MouseLeave(object sender, EventArgs e)
        {
            btn_Settings.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void btn_New_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Empty" || Tag.ToString() == "Select")
            {
                Tag = "New";
                Form_Mode("New");
            }
            else if (Tag.ToString() == "New")
            {
                if (DGV.RowCount == 0)
                {
                    MessageBox.Show("يجب إدخال طرفي القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (Convert.ToDecimal(txt_Total_Local_Debit.Text) != Convert.ToDecimal(txt_Total_Local_Credit.Text))
                {
                    MessageBox.Show("يجب أن يتساوى إجمالي المدين مع إجمالي الدائن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //insert into database 
                var();
                string t = Jor.Insert();
                txt_Bill_ID.Text = t.ToString();

                // Get Jor
                DataTable j = new DataTable();
                j = G.Select_Jor(txt_Bill_ID.Text);
                foreach (DataRow dr in j.Rows)
                {
                    Main.ds.Tables[14].Rows.Add(dr.ItemArray);
                }
                // Get Jor_D
                DataTable j_d = new DataTable();
                j_d = G.Select_Jor_D(txt_Bill_ID.Text);
                foreach (DataRow dr in j_d.Rows)
                {
                    Main.ds.Tables[15].Rows.Add(dr.ItemArray);
                }

                // Reset Cursor Position
                n = Main.ds.Tables[14].Rows.Count - 1;
                dr_Jor = Main.ds.Tables[14].Rows[n];
                Navigate();
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (Tag.ToString().ToString() == "Select")
            {
                if (com_Ref_Type.SelectedValue.ToString() == "15")
                {
                    Tag = "Edit";
                    Temp_dgv = table(1);
                    Form_Mode("Edit");

                    foreach (DataRow row in Temp_dgv.Rows)
                    {
                        DGV.Rows.Add();
                        DGV.CurrentCell = DGV.Rows[DGV.Rows.Count - 1].Cells[0];

                        DGV.CurrentRow.Cells["Debit"].Value = row["مدين"].ToString();
                        DGV.CurrentRow.Cells["Credit"].Value = row["دائن"].ToString();
                        DGV.CurrentRow.Cells["ACC_Name"].Value = row["أسم الحساب"].ToString();
                        DGV.CurrentRow.Cells["ACC_ID"].Value = row["كود الحساب"].ToString();
                        DGV.CurrentRow.Cells["Notes"].Value = row["البيان"].ToString();
                        DGV.CurrentRow.Cells["Currency"].Value = row["العملة"].ToString();
                        DGV.CurrentRow.Cells["Currency_Rate"].Value = row["سعر العملة"].ToString();
                        DGV.CurrentRow.Cells["CC1"].Value = row["مركز 1"].ToString();
                        DGV.CurrentRow.Cells["CC2"].Value = row["مركز 2"].ToString();
                        DGV.CurrentRow.Cells["Branche"].Value = row["الفرع"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن تعديل هذا القيد من داخل دفتر القيود التعديل يكون من مرجع القيد", "! تعديل", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (Tag.ToString().ToString() == "Edit")
            {
                if (Convert.ToDecimal(txt_Total_Local_Debit.Text) != Convert.ToDecimal(txt_Total_Local_Credit.Text))
                {
                    MessageBox.Show("يجب أن يتساوى إجمالي المدين مع إجمالي الدائن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update database 
                var();
                string t = Jor.Update();

                // Remove old Jor from Main.ds.Tables[14]          
                Main.ds.Tables[14].Rows.RemoveAt(n);
                // Removr Old Jor_D
                for (int i = 0; i < Main.ds.Tables[15].Rows.Count; i++)
                {
                    if (Main.ds.Tables[15].Rows[i]["Jor_ID"].ToString() == txt_Bill_ID.Text)
                    {
                        Main.ds.Tables[15].Rows.RemoveAt(i);
                        i--;
                    }
                }

                // Get Jor
                DataTable j = new DataTable();
                j = G.Select_Jor(txt_Bill_ID.Text);

                DataRow dr_Jor = Main.ds.Tables[14].NewRow();
                dr_Jor.ItemArray = j.Rows[0].ItemArray.Clone() as object[];
                Main.ds.Tables[14].Rows.InsertAt(dr_Jor,n);

                // Get Jor_D
                DataTable j_d = new DataTable();
                j_d = G.Select_Jor_D(txt_Bill_ID.Text);
                foreach (DataRow dr in j_d.Rows)
                {
                    Main.ds.Tables[15].Rows.Add(dr.ItemArray);
                }
                Navigate();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                if (com_Ref_Type.SelectedValue.ToString() == "15")
                {
                    // Confirm
                    if (MessageBox.Show("هل بالفعل تريد حذف القيد ؟", "حذف ؟", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var();
                        //Delete In DataBase
                        Jor.Delete();

                        //Delete In dt_Jor
                        Main.ds.Tables[14].Rows.RemoveAt(n);

                        // Delete Jor_D
                        for (int i = 0; i < Main.ds.Tables[15].Rows.Count; i++)
                        {
                            if (Main.ds.Tables[15].Rows[i]["Jor_ID"].ToString() == txt_Bill_ID.Text)
                            {
                                Main.ds.Tables[15].Rows.RemoveAt(i);
                                i--;
                            }
                        }
                        Tag = "Empty";
                        Form_Mode("Empty");
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن حذف هذا القيد من داخل دفتر القيود الحذف يكون من مرجع القيد", "! حذف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                Form_Mode("Empty");
                Tag = "Empty";
            }
            else if (Tag.ToString() == "Edit")
            {
                dr_Jor = Main.ds.Tables[14].Rows[n];
                Navigate();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Main.Jor_Form_Open = false;
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
            if(this.Parent != null) { Parent.Dispose(); }
            else { this.Dispose(); }
        }
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            js.ShowDialog();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            add.Main = Main;
            add.dv_acc = dv_acc;
            add.dv_cc1 = dv_cc1;
            add.dv_cc2 = dv_cc2;

            add.combo_ACC_ID.DataSource = add.dv_acc;
            add.combo_ACC.DataSource = add.dv_acc;
            add.com_Currency.DataSource = dv_currency;            
            add.com_CC1.DataSource = add.dv_cc1;
            add.com_CC2.DataSource = add.dv_cc2;
            add.com_Branche.DataSource = dv_branche;

            add.top = Main.panel_Main.Height + 27 + panel_FRM_Head.Height;
            if (Main.tab_Main.Visible == true) { add.top += Main.tab_Main.Height; }
            add.Search = Main.imageList16.Images["Search_16.png"];
            add.Edit = Main.imageList16.Images["Edit_16.png"];
            add.DGV = DGV;

            add.Text = "إضافة";
            add.btn_Add.Text = "+ إضافة";

            add.txt_Debit.Text = "";
            add.txt_Credit.Text = "";
            add.combo_ACC.SelectedValue = "-1";
            add.combo_ACC_ID.SelectedValue = "-1";
            add.txt_Notes.Text = "";
            add.com_Currency.SelectedIndex = 0;
            add.com_CC1.SelectedValue = "-1";
            add.com_CC2.SelectedValue = "-1";
            add.com_Branche.SelectedValue = "-1";

            add.ShowDialog();
        }
        #endregion

        #region groupBox_Details        
        // DGV
        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (add.btn_Add.Focused)
            {
                DGV.CurrentCell = DGV.Rows[e.RowIndex].Cells[0];

                DGV.Rows[e.RowIndex].Cells["Debit"].Value = add.txt_Debit.Text;
                DGV.Rows[e.RowIndex].Cells["Credit"].Value = add.txt_Credit.Text;
                DGV.Rows[e.RowIndex].Cells["ACC_Name"].Value = add.combo_ACC.Text;
                DGV.Rows[e.RowIndex].Cells["ACC_ID"].Value = add.combo_ACC_ID.Text;
                DGV.Rows[e.RowIndex].Cells["Notes"].Value = add.txt_Notes.Text;
                int x = Convert.ToInt16(add.com_Currency.SelectedValue);
                DGV.Rows[e.RowIndex].Cells["Currency"].Value = x;
                DGV.Rows[e.RowIndex].Cells["Currency_Rate"].Value = add.txt_Currency_Rate.Text;
                DGV.Rows[e.RowIndex].Cells["CC1"].Value = add.com_CC1.SelectedValue;
                DGV.Rows[e.RowIndex].Cells["CC2"].Value = add.com_CC2.SelectedValue;
                DGV.Rows[e.RowIndex].Cells["Branche"].Value = add.com_Branche.SelectedValue;
                Console.Beep();

                if(txt_Total_Local_Debit.Text == "") { txt_Total_Local_Debit.Text = "0"; }
                decimal d = Math.Round(Convert.ToDecimal(txt_Total_Local_Debit.Text), 2) + (Convert.ToDecimal(DGV.CurrentRow.Cells["Debit"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Currency_Rate"].Value));
                txt_Total_Local_Debit.Text = d.ToString();

                if (txt_Total_Local_Credit.Text == "") { txt_Total_Local_Credit.Text = "0"; }
                decimal c = Math.Round(Convert.ToDecimal(txt_Total_Local_Credit.Text), 2) + (Convert.ToDecimal(DGV.CurrentRow.Cells["Credit"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Currency_Rate"].Value));
                txt_Total_Local_Credit.Text = c.ToString();

                add.txt_Debit.Text = "";
                add.txt_Credit.Text = "";
                add.combo_ACC.SelectedValue = -1;
                add.combo_ACC_ID.SelectedValue = -1;
                add.txt_Notes.Text = "";
                add.com_CC1.SelectedValue = -1;
                add.com_CC2.SelectedValue = -1;
                add.com_Branche.SelectedValue = -1;

                add.txt_Debit.Focus();
            }          
        }
        private void DGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            decimal d = Math.Round(Convert.ToDecimal(txt_Total_Local_Debit.Text), 2) - (Convert.ToDecimal(DGV.CurrentRow.Cells["Debit"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Currency_Rate"].Value));
            txt_Total_Local_Debit.Text = d.ToString();

            decimal c = Math.Round(Convert.ToDecimal(txt_Total_Local_Credit.Text), 2) - (Convert.ToDecimal(DGV.CurrentRow.Cells["Credit"].Value) * Convert.ToDecimal(DGV.CurrentRow.Cells["Currency_Rate"].Value));
            txt_Total_Local_Credit.Text = c.ToString();
        }
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() == "New" || Tag.ToString() == "Edit")
            {
                if (!add.ds.Tables.Contains(Main.ds.Tables[6].ToString()))
                {
                    add.ds.Tables.Add(Main.ds.Tables[6].Clone());
                    foreach (DataRow r in Main.ds.Tables[6].Rows)
                    {
                        if (Convert.ToBoolean(r["Is_Parent"]) == false)
                        {
                            add.ds.Tables[0].Rows.Add(r.ItemArray);
                        }
                    }
                }

                add.Main = Main;
                add.dv_acc = dv_acc;
                add.dv_cc1 = dv_cc1;
                add.dv_cc2 = dv_cc2;

                add.combo_ACC_ID.DataSource = dv_acc;
                add.combo_ACC.DataSource = dv_acc;
                add.com_CC1.DataSource = dv_cc1;
                add.com_CC2.DataSource = dv_cc2;
                add.com_Branche.DataSource = dv_branche;

                add.top = Main.panel_Main.Height + 27 + panel_FRM_Head.Height;
                if (Main.tab_Main.Visible == true) { add.top += Main.tab_Main.Height; }
                add.Search = Main.imageList16.Images["Search_16.png"];
                add.Edit = Main.imageList16.Images["Edit_16.png"];
                add.DGV = DGV;
                add.Text = "تعديل";
                add.btn_Add.Text = "تعديل";
                add.rowindex = e.RowIndex;
                add.txt_Debit.Text = DGV.Rows[e.RowIndex].Cells["Debit"].Value.ToString();
                add.txt_Credit.Text = DGV.Rows[e.RowIndex].Cells["Credit"].Value.ToString();
                add.combo_ACC.Text = DGV.Rows[e.RowIndex].Cells["ACC_Name"].Value.ToString();
                add.combo_ACC_ID.SelectedValue = DGV.Rows[e.RowIndex].Cells["ACC_ID"].Value.ToString();
                add.txt_Notes.Text = DGV.Rows[e.RowIndex].Cells["Notes"].Value.ToString();
                add.com_Currency.Text = DGV.Rows[e.RowIndex].Cells["Currency"].Value.ToString();
                add.txt_Currency_Rate.Text = DGV.Rows[e.RowIndex].Cells["Currency_Rate"].Value.ToString();
                add.com_CC1.SelectedValue = (DGV.Rows[e.RowIndex].Cells["CC1"].Value != null) ? DGV.Rows[e.RowIndex].Cells["CC1"].Value.ToString() : "-1";
                add.com_CC2.SelectedValue = (DGV.Rows[e.RowIndex].Cells["CC2"].Value != null) ? DGV.Rows[e.RowIndex].Cells["CC2"].Value.ToString() : "-1";
                add.com_Branche.SelectedValue = (DGV.Rows[e.RowIndex].Cells["Branche"].Value != null) ? DGV.Rows[e.RowIndex].Cells["Branche"].Value.ToString() : "-1";

                add.ShowDialog();
                FRM_Jor_Enter(null, null);
            }
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
            if (Main.ds.Tables[14].Rows.Count == 0) { return; }
            nav = true;
            n = 0;
            do
            {
                if (n > Main.ds.Tables[14].Rows.Count - 1) { n = 0; Form_Mode("Empty"); return; }
                dr_Jor = Main.ds.Tables[14].Rows[n];
                n++;
            } while (dr_Jor["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
            n--;
            Navigate();
            nav = false;
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            if (Main.ds.Tables[14].Rows.Count == 0) { return; }
            nav = true;
            n = Main.ds.Tables[14].Rows.Count - 1;
            do
            {
                if (n < 0) { n = Main.ds.Tables[14].Rows.Count - 1; Form_Mode("Empty"); return; }
                dr_Jor = Main.ds.Tables[14].Rows[n];
                n--;

            } while (dr_Jor["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
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
                dr_Jor = Main.ds.Tables[14].Rows[n];

            } while (dr_Jor["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            Navigate();
            nav = false;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            nav = true;
            do
            {
                n++;
                if (n > Main.ds.Tables[14].Rows.Count - 1) { n = Main.ds.Tables[14].Rows.Count - 1; return; }
                dr_Jor = Main.ds.Tables[14].Rows[n];

            } while (dr_Jor["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

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
                for (int i = 0; i < Main.ds.Tables[14].Rows.Count; i++)
                {
                    dr = Main.ds.Tables[14].Rows[i];
                    if (dr["ID"].ToString() == textBox_Search.Text && dr["Branche_ID"].ToString() == combo_Bill_Branches.SelectedValue.ToString())
                    {
                        e.Handled = true;
                        dr_Jor = dr;
                        n = i;
                        break;
                    }
                }
                if (dr_Jor == null) { return; }

                Navigate();
            }
        }

        #endregion

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            RepPrint.Jor j = new RepPrint.Jor();
            j.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            j.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            j.PrintToPrinter(1, false, 0, 15);
        }
    }
}
