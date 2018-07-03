using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Bills
{
	public partial class FRM_Jor_B : Form
	{
		CLS_Jor_B Jor_B = new CLS_Jor_B();
        DataRow dr_Jor_B;

        bool up;

        frm_Main Main;
        public FRM_Jor_B(frm_Main main)
		{   
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_Bill_Type.Image = Main.imageList32.Images["Bill_Type_32.png"];
            btn_B_Type.Image = Main.imageList32.Images["B_Type_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];
        
            DGV_Jor_B.AutoGenerateColumns = false;
            DGV_Jor_B.DataSource = Main.ds.Tables[17];

            #region ContextMenuStrips
            // Branches
            com_Bill_Branches.DataSource = Main.dt_Branches;
            com_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;
            lbl_bill_Branches.Text = com_Bill_Branches.Text;
            contextMenuStrip_branches.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_Bill_Branches.Items.Count; i++)
            {
                contextMenuStrip_branches.Items.Add(com_Bill_Branches.GetItemText(com_Bill_Branches.Items[i]), Main.imageList16.Images["branche_16.png"]);
            }
            // Bill_Type
            com_Bill_Type.DataSource = Main.dt_Bill_T;
            Main.dt_Bill_T.DefaultView.RowFilter = string.Format("ACC = True");
            contextMenuStrip_Bill_Type.ForeColor = Color.MidnightBlue;
            contextMenuStrip_Bill_Type.Items.Clear();
            for (int i = 0; i < com_Bill_Type.Items.Count; i++)
            {
                contextMenuStrip_Bill_Type.Items.Add(com_Bill_Type.GetItemText(com_Bill_Type.Items[i]), Main.imageList16.Images["Bill_Type_16.png"]);
            }
            // B_Type
            com_B_Type.DataSource = Main.dt_Types;
            contextMenuStrip_B_Type.ForeColor = Color.MidnightBlue;
            contextMenuStrip_B_Type.Items.Clear();
            for (int i = 0; i < com_B_Type.Items.Count; i++)
            {
                if (i == 0) { contextMenuStrip_B_Type.Items.Add(com_B_Type.GetItemText(com_B_Type.Items[i]), Main.imageList16.Images["B_Type_16.png"]); }
                if (i == 1) { contextMenuStrip_B_Type.Items.Add(com_B_Type.GetItemText(com_B_Type.Items[i]), Main.imageList16.Images["B_Type2_16.png"]); }
            }
            // Users
            com_Bill_User.DataSource = Main.dt_Users;
            com_Bill_User.SelectedValue = Main.combo_Users.SelectedValue;
            contextMenuStrip_users.ForeColor = Color.MidnightBlue;
            for (int i = 0; i < com_Bill_User.Items.Count; i++)
            {
                contextMenuStrip_users.Items.Add(com_Bill_User.GetItemText(com_Bill_User.Items[i]), Main.imageList16.Images["user_16.png"]);
            }
            #endregion

            #region DGV
            var Value = new DataGridViewComboBoxColumn();
            Value.HeaderText = "القيمة";
            Value.DataPropertyName = "Value";
            Value.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Value.Width=150;
            Value.FlatStyle = FlatStyle.Popup;
            Value.DataSource = Main.dt_Value;
            Value.ValueMember = "Value_ID";
            Value.DisplayMember = "Value_Name";
			DGV_Jor_B.Columns.Add( Value );

            var Rate = new DataGridViewTextBoxColumn();
            Rate.HeaderText = "النسبة %";
            Rate.DataPropertyName = "Rate";
            Rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Rate.Width = 100;
            DGV_Jor_B.Columns.Add(Rate);

            var Side = new DataGridViewComboBoxColumn();
            Side.HeaderText = "الجانب";
            Side.DataPropertyName = "Side";
            Side.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Side.Width = 100;
            Side.FlatStyle = FlatStyle.Popup;
            Side.DataSource = Main.dt_Side;
            Side.ValueMember = "Side_ID";
            Side.DisplayMember = "Side_Name";
            DGV_Jor_B.Columns.Add(Side);

            var ACC_Name = new DataGridViewComboBoxColumn();
            ACC_Name.HeaderText = "أسم الحساب";
            ACC_Name.DataPropertyName = "ACC_ID";
            ACC_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_Name.Width = 130;
            ACC_Name.FlatStyle = FlatStyle.Popup;
            ACC_Name.DataSource = Main.dt_ACC;
            ACC_Name.ValueMember = "ACC_ID";
            ACC_Name.DisplayMember = "ACC_Name";
            DGV_Jor_B.Columns.Add(ACC_Name);

            var ACC_Bill_Name = new DataGridViewComboBoxColumn();
            ACC_Bill_Name.HeaderText = "حساب بالسند";
            ACC_Bill_Name.DataPropertyName = "ACC_in_bill";
            ACC_Bill_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_Bill_Name.Width = 130;
            ACC_Bill_Name.FlatStyle = FlatStyle.Popup;
            ACC_Bill_Name.DataSource = Main.dt_ACC_in_bill;
            ACC_Bill_Name.ValueMember = "ACC_in_bill_ID";
            ACC_Bill_Name.DisplayMember = "ACC_in_bill_Name";
            DGV_Jor_B.Columns.Add(ACC_Bill_Name);
			
			var Notes = new DataGridViewTextBoxColumn();
            Notes.HeaderText = "البيان";
            Notes.DataPropertyName = "Notes";
            Notes.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Notes.Width=200;
			DGV_Jor_B.Columns.Add( Notes );

            var Ref_Add = new DataGridViewComboBoxColumn();
            Ref_Add.HeaderText = "مرجع يضاف إلى البيان";
            //Ref_Add.DataPropertyName = "Ref_Add";
            Ref_Add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ref_Add.Width = 100;
            Ref_Add.FlatStyle = FlatStyle.Popup;
            DGV_Jor_B.Columns.Add(Ref_Add);		
			
            var Branche = new DataGridViewComboBoxColumn();
            Branche.HeaderText = "الفرع";
            Branche.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Branche.Width=130;
            Branche.FlatStyle = FlatStyle.Popup;
            Branche.DataSource = Main.dt_Branches;
			Branche.ValueMember = "Branche_ID";
			Branche.DisplayMember = "Branche_Name";
			DGV_Jor_B.Columns.Add( Branche );
			
			var B_Type = new DataGridViewComboBoxColumn();
            B_Type.HeaderText = "مركز 1";
            Branche.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Branche.Width=130;
            B_Type.FlatStyle = FlatStyle.Popup;
            B_Type.DataSource = Main.dt_CC;
			B_Type.ValueMember = "CC_ID";
			B_Type.DisplayMember = "CC_Name";
			DGV_Jor_B.Columns.Add( B_Type );
			
		    var CC2 = new DataGridViewComboBoxColumn();
            CC2.HeaderText = "مركز 2";
            Branche.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Branche.Width=130;
            CC2.FlatStyle = FlatStyle.Popup;
            CC2.DataSource = Main.dt_CC;
			CC2.ValueMember = "CC_ID";
			CC2.DisplayMember = "CC_Name";
			DGV_Jor_B.Columns.Add( CC2 );
            #endregion

            //Filter DGV
            com_Bill_Type.SelectedValue = 1;
            com_B_Type.SelectedValue = 1;
            Main.ds.Tables[17].DefaultView.RowFilter = string.Format("Branche ='" + com_Bill_Branches.SelectedValue + "' and Bill_Type =" +
                                                                        com_Bill_Type.SelectedValue + "and B_Type =" + com_B_Type.SelectedValue);
            GET_Val();
        }

        #region Pro
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    DGV_Jor_B.ReadOnly = true;

                    btn_New.Visible = true;
                    btn_New.Text = "جديد";
                    btn_New.Image = imageList1.Images["New"];
                    btn_Save.Visible = true;
                    btn_Save.Text = "تعديل";
                    btn_Save.Image = imageList1.Images["Edit"];
                    btn_Delete.Visible = true;
                    button_Print.Visible = true;
                    button_Settings.Visible = true;
                    btn_Close.Visible = true;

                    break;
                #endregion

                #region New
                case "New":
                    //Clare Controls


                    DGV_Jor_B.DataSource = null;
                    DGV_Jor_B.Rows.Clear();

                    DGV_Jor_B.ReadOnly = false;

                    btn_New.Text = "حفظ";
                    btn_New.Image = imageList1.Images["Save"];
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    btn_Close.Visible = false;

                    DGV_Jor_B.AllowUserToAddRows = true;
                    DGV_Jor_B.ReadOnly = false;
                    break;
                #endregion

                #region Edit
                case "Edit":

                    DGV_Jor_B.ReadOnly = false;
                    DGV_Jor_B.AllowUserToAddRows = true;
                    DGV_Jor_B.AllowUserToDeleteRows = true;
                    DGV_Jor_B.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    btn_Save.Text = "حفظ";
                    btn_Save.Image = imageList1.Images["Save"];
                    btn_New.Visible = false;
                    btn_Delete.Visible = false;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    btn_Close.Visible = false;
                    break;
                #endregion

                #region Empty
                case "Empty":

                    //Clare Controls

                    DGV_Jor_B.DataSource = null;
                    DGV_Jor_B.Rows.Clear();

                    //Remove The Last Empty Row In DGV
                    DGV_Jor_B.AllowUserToAddRows = false;

                    DGV_Jor_B.ReadOnly = true;

                    btn_New.Visible = true;
                    btn_New.Text = "جديد";
                    btn_New.Image = imageList1.Images["New"];
                    button_Print.Visible = false;
                    button_Settings.Visible = true;
                    btn_Close.Visible = true;

                    break;
                    #endregion
            }
        }
        private DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV_Jor_B.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in DGV_Jor_B.Rows)
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
        private void GET_Val()
        {
            com_B_Type.SelectedIndex = 0;
            if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 1) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Open] = True"); btn_B_Type.Visible = false; lbl_B_Type.Visible = false; }
            else if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 3) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Tran] = True"); btn_B_Type.Visible = false; lbl_B_Type.Visible = false; }
            else if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 7) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Pur] = True"); btn_B_Type.Visible = true; lbl_B_Type.Visible = true; }
            else if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 11) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Sal] = True"); btn_B_Type.Visible = true; lbl_B_Type.Visible = true; }
            else if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 13) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Money_Out] = True"); btn_B_Type.Visible = false; lbl_B_Type.Visible = false; }
            else if (Convert.ToInt16(com_Bill_Type.SelectedValue) == 14) { Main.dt_Value.DefaultView.RowFilter = string.Format("[Money_In] = True"); btn_B_Type.Visible = false; lbl_B_Type.Visible = false; }
            else { Main.dt_Value.DefaultView.RowFilter = string.Format("Value_ID = -1"); btn_B_Type.Visible = false; lbl_B_Type.Visible = false; }
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
        private void FRM_Jor_B_Enter(object sender, EventArgs e)
        {
            UpDowen();
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

        private void btn_Bill_Type_MouseEnter(object sender, EventArgs e)
        {
            btn_Bill_Type.FlatStyle = FlatStyle.Popup;
        }

        private void btn_Bill_Type_MouseLeave(object sender, EventArgs e)
        {
            btn_Bill_Type.FlatStyle = FlatStyle.Flat;
        }

        private void btn_B_Type_MouseEnter(object sender, EventArgs e)
        {
            btn_B_Type.FlatStyle = FlatStyle.Popup;
        }
        private void btn_B_Type_MouseLeave(object sender, EventArgs e)
        {
            btn_B_Type.FlatStyle = FlatStyle.Flat;
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

        private void combo_Bill_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_User.Text = com_Bill_User.Text;
        }

        private void btn_Bill_Branche_Click(object sender, EventArgs e)
        {
            if (com_Bill_Branches.Enabled == true && up == false) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 267); }
            else if (com_Bill_Branches.Enabled == true && up == true) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 133); }
        }
        private void btn_Bill_Type_Click(object sender, EventArgs e)
        {
            if (com_Bill_Type.Enabled == true && up == false) { contextMenuStrip_Bill_Type.Show((btn_Bill_Type.Right - contextMenuStrip_Bill_Type.Width - 3), 267); }
            if (com_Bill_Type.Enabled == true && up == true) { contextMenuStrip_Bill_Type.Show((btn_Bill_Type.Right - contextMenuStrip_Bill_Type.Width - 3), 133); }
        }
        private void btn_B_Type_Click(object sender, EventArgs e)
        {
            if (com_B_Type.Enabled == true && up == false) { contextMenuStrip_B_Type.Show((btn_B_Type.Right - contextMenuStrip_B_Type.Width - 3), 267); }
            if (com_B_Type.Enabled == true && up == true) { contextMenuStrip_B_Type.Show((btn_B_Type.Right - contextMenuStrip_B_Type.Width - 3), 133); }
        }
        private void btn_B_Type_del_Click(object sender, EventArgs e)
        {
            com_B_Type.SelectedValue = -1;
        }


        private void btn_Bill_User_Click(object sender, EventArgs e)
        {
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
            com_Bill_Type.SelectedIndex = contextMenuStrip_Bill_Type.Items.IndexOf(e.ClickedItem);
            lbl_Bill_Type.Text = com_Bill_Type.Text;
            lbl_Bill_Type.Location = new Point(lbl_Bill_Type.Left - lbl_Bill_Type.Width, lbl_Bill_Type.Location.Y);
        }
        private void contextMenuStrip_B_Type_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_B_Type.SelectedIndex = contextMenuStrip_B_Type.Items.IndexOf(e.ClickedItem);
            lbl_B_Type.Text = com_B_Type.Text;
        }

        private void contextMenuStrip_users_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            com_Bill_User.SelectedIndex = contextMenuStrip_users.Items.IndexOf(e.ClickedItem);
            lbl_Bill_User.Text = com_Bill_User.Text;
            lbl_Bill_User.Location = new Point(lbl_Bill_User.Left - lbl_Bill_User.Width, lbl_Bill_User.Location.Y);
        }
        #endregion

        #region Controls
        #region btn display
        private void btn_New_MouseLeave(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Flat;
        }
        private void btn_New_MouseEnter(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Delete_MouseEnter(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Save_MouseEnter(object sender, EventArgs e)
        {
            btn_Save.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.FlatStyle = FlatStyle.Flat;
        }

        private void button_Print_MouseEnter(object sender, EventArgs e)
        {
            button_Print.FlatStyle = FlatStyle.Popup;
        }
        private void button_Print_MouseLeave(object sender, EventArgs e)
        {
            button_Print.FlatStyle = FlatStyle.Flat;
        }
        private void button_Settings_MouseEnter(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Popup;
        }
        private void button_Settings_MouseLeave(object sender, EventArgs e)
        {
            button_Settings.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void button_New_Click(object sender, EventArgs e)
        {
            DataTable dt = DGV_Jor_B.DataSource as DataTable;
            //Create the new row
            DataRow row = dt.NewRow();

            //Populate the row with data
            row[0] = com_Bill_Branches.SelectedValue;
            row[1] = com_Bill_Type.SelectedValue;
            row[2] = com_B_Type.SelectedValue;
            row["Rate"] = 100;

            //Add the row to data table
            dt.Rows.Add(row);

            btn_Save.Visible = true;
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Jor_B.SelectedCells.Count > 0) { DGV_Jor_B.Rows.Remove(DGV_Jor_B.CurrentRow); }
            btn_Save.Visible = true;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            DataTable dt_Jor_B = table();

            string t = Jor_B.Jor_B_Insert(
                 com_Bill_Branches.SelectedValue.ToString()
                , Convert.ToInt32(com_Bill_Type.SelectedValue)
                , Convert.ToInt32(com_B_Type.SelectedValue)
                , Convert.ToInt32(Main.combo_Users.SelectedValue)
                , dt_Jor_B
                );

            if (t == "1") { MessageBox.Show("تم حفظ التغييرات بنجاح"); }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Main.Jor_B_Form_Open = false;
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

        #region Combo Selected Changed

        private void com_Bill_Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_bill_Branches.Text = com_Bill_Branches.Text;
            if (com_Bill_Type.Text != "" && com_B_Type.Text != "")
            {
                Main.ds.Tables[17].DefaultView.RowFilter = string.Format("Branche ='" + com_Bill_Branches.SelectedValue + "' and Bill_Type =" +
                                                                        com_Bill_Type.SelectedValue + "and B_Type =" + com_B_Type.SelectedValue);
            }
        }
        private void com_Bill_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Bill_Type.Text = com_Bill_Type.Text;
            if (com_Bill_Branches.Text != "" && com_B_Type.Text != "")
            {
                Main.ds.Tables[17].DefaultView.RowFilter = string.Format("Branche ='" + com_Bill_Branches.SelectedValue + "' and Bill_Type =" +
                                                                        com_Bill_Type.SelectedValue + "and B_Type =" + com_B_Type.SelectedValue);

                GET_Val();
            }
        }
        private void com_B_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_B_Type.Text = com_B_Type.Text;
            if (com_Bill_Branches.Text != "" && com_Bill_Type.Text != "")
            {
                Main.ds.Tables[17].DefaultView.RowFilter = string.Format("Branche ='" + com_Bill_Branches.SelectedValue + "' and Bill_Type =" +
                                                                        com_Bill_Type.SelectedValue + "and B_Type =" + com_B_Type.SelectedValue);
                if(com_B_Type.SelectedIndex == 0)
                {
                    btn_B_Type.Image = Main.imageList32.Images["B_Type_32.png"];
                }
                else
                {
                    btn_B_Type.Image = Main.imageList32.Images["B_Type2_32.png"];
                }
            }
        }

        #endregion

        #region DGV
        private void DGV_Jor_B_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox box = e.Control as ComboBox;
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.AutoCompleteSource = AutoCompleteSource.ListItems;
                box.AutoCompleteMode = AutoCompleteMode.Suggest;
                box.FlatStyle = FlatStyle.Flat;
            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Print_Click(object sender, EventArgs e)
        {

        }

        private void button_Settings_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Jor_B_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox_Footer_Details_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_Details_Enter(object sender, EventArgs e)
        {

        }

        private void panel_FRM_Head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_B_Type_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Bill_Type_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bill_Branches_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Bill_User_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CC2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_users_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip_B_Type_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip_branches_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip_Bill_Type_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
