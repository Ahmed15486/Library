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
    public partial class FRM_Money_Out : Form
    {
        #region Declaration
        CLS_Money_Out Money_Out = new CLS_Money_Out();
        Bills.FRM_Jor Jor;
        G.CLS_G G = new G.CLS_G();

        DataTable dt_branches = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();
        DataTable dt_users = new DataTable();

        DataTable dt_ACC;
        DataTable dt_ACC_Ven;
        DataRow dr_Money_Out;
        bool up = false;

        frm_Main Main;
        #endregion

        public FRM_Money_Out(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];
            btn_Bill_User.Image = Main.imageList32.Images["user_32.png"];

            dt_ACC_Ven = Main.dt_ACC.Clone();
            foreach (DataRow dr in Main.dt_ACC.Rows)
            {
                dt_ACC_Ven.Rows.Add(dr.ItemArray);
            }
            dt_ACC_Ven.DefaultView.RowFilter = string.Format("Is_Parent=0");

            dt_branches = Main.dt_Branches.Clone();
            foreach (DataRow dr in Main.dt_Branches.Rows)
            {
                dt_branches.Rows.Add(dr.ItemArray);
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

            combo_Bill_User.DataSource = Main.dt_Users;
            combo_Bill_Branches.DataSource = Main.dt_Branches;
            combo_CC1.DataSource = Main.dt_CC;
            combo_CC2.DataSource = Main.dt_CC;

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
        private void var()
        {
            Money_Out.Money_Out_ID = (textBox_Bill_ID.Text != "") ? textBox_Bill_ID.Text : "";
            Money_Out.Money_Out_Date = dtp_Money_Out_Date.Value;
            Money_Out.Pay_Type = Convert.ToInt32(com_Pay_Type.SelectedValue);
            Money_Out.ACC_ID = com_ACC_ID_To.SelectedValue.ToString();
            Money_Out.Value = Convert.ToDecimal(txt_Value.Text);
            Money_Out.Notes = txt_Notes.Text;
            Money_Out.Branche_ID = combo_Bill_Branches.SelectedValue.ToString();
            Money_Out.CC1_ID = Convert.ToInt32(combo_CC1.SelectedValue);
            Money_Out.CC2_ID = Convert.ToInt32(combo_CC2.SelectedValue);
            Money_Out.User_ID = Convert.ToInt32(combo_Bill_User.SelectedValue);

        }
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    dtp_Money_Out_Date.Format = DateTimePickerFormat.Short;

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

                    dtp_Money_Out_Date.Enabled = false;
                    com_Pay_Type.Enabled = false;
                    txt_Value.ReadOnly = true;
                    com_ACC_ID_To.Enabled = false;
                    com_ACC_Name_To.Enabled = false;
                    cbx_Ven.Enabled = false;
                    txt_Notes.ReadOnly = true;

                    break;
                #endregion

                #region New
                case "New":
                    //Clare Controls
                    combo_CC1.SelectedValue = "-1";
                    combo_CC2.SelectedValue = "-1";

                    textBox_Bill_ID.Clear();
                    btn_Jor_No.Text = "";
                    com_Pay_Type.SelectedIndex = 0;
                    txt_Value.Clear();
                    com_ACC_ID_To.SelectedValue = -1;
                    com_ACC_Name_To.SelectedValue = -1;
                    txt_Notes.Clear();
                    dtp_Money_Out_Date.Format = DateTimePickerFormat.Short;

                    txt_Notes.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

                    dtp_Money_Out_Date.Enabled = true;
                    com_Pay_Type.Enabled = true;
                    txt_Value.ReadOnly = false;
                    com_ACC_ID_To.Enabled = true;
                    com_ACC_Name_To.Enabled = true;
                    cbx_Ven.Enabled = true;
                    txt_Notes.ReadOnly = false;

                    break;
                #endregion

                #region Edit
                case "Edit":

                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_New.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Print.Visible = false;
                    button_Settings.Visible = false;
                    button_Close.Visible = false;

                    dtp_Money_Out_Date.Enabled = true;
                    com_Pay_Type.Enabled = true;
                    txt_Value.ReadOnly = false;
                    com_ACC_ID_To.Enabled = true;
                    com_ACC_Name_To.Enabled = true;
                    cbx_Ven.Enabled = true;
                    txt_Notes.ReadOnly = false;

                    break;
                #endregion

                #region Empty
                case "Empty":

                    //Clare Controls
                    textBox_Bill_ID.Clear();
                    dtp_Money_Out_Date.Format = DateTimePickerFormat.Custom;
                    txt_Notes.Clear();
                    com_ACC_ID_To.SelectedValue = -1;
                    com_ACC_Name_To.SelectedIndex = -1;

                    dtp_Money_Out_Date.Format = DateTimePickerFormat.Custom;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Cancel.Visible = false;
                    button_Print.Visible = false;
                    button_Settings.Visible = true;
                    button_Close.Visible = true;

                    dtp_Money_Out_Date.Enabled = false;
                    com_Pay_Type.Enabled = false;
                    txt_Value.ReadOnly = true;
                    com_ACC_ID_To.Enabled = false;
                    com_ACC_Name_To.Enabled = false;
                    cbx_Ven.Enabled = false;
                    txt_Notes.ReadOnly = true;

                    break;
                    #endregion
            }
        }
        private void Navigate()
        {
            com_ACC_ID_To.DataSource = dt_ACC_Ven;
            com_ACC_ID_To.SelectedValue = -1;
            com_ACC_Name_To.DataSource = dt_ACC_Ven;
            com_ACC_Name_To.SelectedValue = -1;
            com_Pay_Type.DataSource = Main.dt_Pay_Type;

            combo_CC1.SelectedValue = dr_Money_Out["CC1_ID"];
            combo_CC2.SelectedValue = dr_Money_Out["CC2_ID"];
            combo_Bill_User.SelectedValue = dr_Money_Out["User_ID"];

            textBox_Bill_ID.Text = dr_Money_Out["Money_Out_ID"].ToString();
            dtp_Money_Out_Date.Value = Convert.ToDateTime(dr_Money_Out["Money_Out_Date"]);
            btn_Jor_No.Text = dr_Money_Out["Jor_ID"].ToString();
            com_Pay_Type.SelectedValue = dr_Money_Out["Pay_Type_ID"];

            txt_Notes.Text = dr_Money_Out["Notes"].ToString();
            txt_Value.Text = dr_Money_Out["Value"].ToString();
            com_ACC_ID_To.SelectedValue = dr_Money_Out["ACC_ID"].ToString();

            if (dr_Money_Out["Money_Out_Date"] != DBNull.Value)
            {
                dtp_Money_Out_Date.Value = Convert.ToDateTime(dr_Money_Out["Money_Out_Date"]);
                dtp_Money_Out_Date.Checked = true;
                dtp_Money_Out_Date.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dtp_Money_Out_Date.Checked = false;
                dtp_Money_Out_Date.Format = DateTimePickerFormat.Custom;
            }

            Form_Mode("Select");
            Tag = "Select";
        }
        #endregion

        #region Form
        private void FRM_Money_Out_Enter(object sender, EventArgs e)
        {
            if (Main.tab_Main.Visible == false && up == false) { up = true; }
            else if (Main.tab_Main.Visible == true && up == true) { up = false; }
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;

            dt_ACC = Main.dt_ACC.Clone();
            foreach (DataRow dr in Main.dt_ACC.Rows)
            {
                dt_ACC.Rows.Add(dr.ItemArray);
            }
            dt_ACC.DefaultView.RowFilter = string.Format("Is_Parent=0");

            dt_ACC_Ven = Main.dt_ACC.Clone();
            foreach (DataRow dr in Main.dt_ACC.Rows)
            {
                if (dr["ACC_Proper_ID"].ToString() == "2")
                {
                    foreach (DataRow r in Main.dt_ACC.Rows)
                    {
                        if (r["Parent_ID"].ToString() == dr["ACC_ID"].ToString())
                        {
                            dt_ACC_Ven.Rows.Add(r.ItemArray);
                        }
                    }
                }
            }
        }
        private void FRM_Money_Out_Shown(object sender, EventArgs e)
        {

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
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
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

        #region groupBox_Head_Controls
        #region Display
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
            }
            else if (Tag.ToString() == "New")
            {
                if (txt_Value.Text == "" || txt_Value.Text == "." || Convert.ToDecimal(txt_Value.Text) == 0)
                { MessageBox.Show("يجب إدخال المبلغ"); txt_Value.Focus(); return; }

                if (com_ACC_ID_To.SelectedValue == null)
                { MessageBox.Show("يجب تحديد الحساب"); com_ACC_Name_To.Focus(); com_ACC_Name_To.DroppedDown = true; return; }

                //insert into database   
                var();
                string t = Money_Out.Insert();

                textBox_Bill_ID.Text = t.ToString();

                Form_Mode("Select");
                Tag = "Select";

                // Insert Last Bill From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(textBox_Bill_ID.Text,13);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_Money_Out.Rows.Add(r.ItemArray);
                }

                // Reset Cursor Position
                n = Main.dt_Money_Out.Rows.Count - 1;
                dr_Money_Out = Main.dt_Money_Out.Rows[n];
                Navigate();

                // Jor
                if (btn_Jor_No.Text != "")
                {
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(btn_Jor_No.Text);
                    foreach (DataRow dr in j.Rows)
                    {
                        Main.dt_Jor.Rows.Add(dr.ItemArray);
                    }
                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(btn_Jor_No.Text);
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
                Form_Mode("Edit");
                Tag = "Edit";
            }
            else if (Tag.ToString() == "Edit")
            {

                // Update database   
                var();
                Money_Out.Update();

                Form_Mode("Select");
                Tag = "Select";

                // Remove Old Bill From Datatable
                Main.dt_Money_Out.Rows.RemoveAt(n);

                // Jor
                if (btn_Jor_No.Text != "")
                {
                    // Delete Jor
                    foreach (DataRow r in Main.dt_Jor.Rows)
                    {
                        if (r["Jor_ID"].ToString() == btn_Jor_No.Text)
                        { Main.dt_Jor.Rows.Remove(r); break; }
                    }
                    // Remove Jor_D
                    for (int i = 0; i < Main.dt_Jor_D.Rows.Count; i++)
                    {
                        if (Main.dt_Jor_D.Rows[i]["Jor_ID"].ToString() == btn_Jor_No.Text)
                        {
                            Main.dt_Jor_D.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }

                // Insert Last Bill From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(textBox_Bill_ID.Text,13);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_Money_Out.Rows.Add(r.ItemArray);
                }

                // Reset Cursor Position
                n = Main.dt_Money_Out.Rows.Count - 1;
                dr_Money_Out = Main.dt_Money_Out.Rows[n];
                Navigate();
                
                // Jor
                if (btn_Jor_No.Text != "")
                {
                    // Get Jor
                    DataTable j = new DataTable();
                    j = G.Select_Jor(btn_Jor_No.Text);
                    foreach (DataRow dr in j.Rows)
                    {
                        Main.dt_Jor.Rows.Add(dr.ItemArray);
                    }
                    // Get Jor_D
                    DataTable j_d = new DataTable();
                    j_d = G.Select_Jor_D(btn_Jor_No.Text);
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
                    var();
                    Money_Out.Delete();

                    //Delete In dt_Money_Out
                    Main.dt_Money_Out.Rows.RemoveAt(n);

                    Form_Mode("Empty");
                    this.Tag = "Empty";
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
                Form_Mode("Select");
                Tag = "Select";
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Main.Money_Out_Form_Open = false;
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

        #region Details
        private void btn_Jor_No_Click(object sender, EventArgs e)
        {
            if (btn_Jor_No.Text != "")
            {
                Jor = new Bills.FRM_Jor(Main);
                string t = btn_Jor_No.Text;
                Jor.ChangetxtSearch(t.Substring(4));
                Jor.Show();
            }
        }
        private void dateTimePicker_Money_Out_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Money_Out_Date.Format = DateTimePickerFormat.Short;
        }
        private void textBox_Value_KeyPress(object sender, KeyPressEventArgs e)
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
        }
        private void comboBox_ACC_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_ACC_ID_To.SelectedValue != null)
            {
            Main.dt_To_Store.DefaultView.RowFilter = string.Format("Branche_ID = " + com_ACC_ID_To.SelectedValue.ToString());
            }
        }
        private void checkBox_Ven_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Ven.Checked == true)
            {
                com_ACC_ID_To.DataSource = dt_ACC_Ven;
                com_ACC_Name_To.DataSource = dt_ACC_Ven;
            }
            else if (cbx_Ven.Checked == false)
            {
                com_ACC_ID_To.DataSource = dt_ACC;
                com_ACC_Name_To.DataSource = dt_ACC;
            }
        }
        #endregion

        #region Navigation
        int n;
        int first_n;
        int last_n;
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
            if (Main.dt_Money_Out.Rows.Count == 0) { return; }
            nav = true;
            n = 0;

            do
            {
                if (n > Main.dt_Money_Out.Rows.Count - 1) { n = 0; Form_Mode("Empty"); return; } // if there's no bills in this branche
                dr_Money_Out = Main.dt_Money_Out.Rows[n];
                n++;
            } while (dr_Money_Out["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            n--;
            Navigate();

            nav = false;
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            if (Main.dt_Money_Out.Rows.Count == 0) { return; }
            nav = true;
            n = Main.dt_Money_Out.Rows.Count - 1;

            do
            {
                if (n < 0) { n = Main.dt_Money_Out.Rows.Count - 1; Form_Mode("Empty"); return; }
                dr_Money_Out = Main.dt_Money_Out.Rows[n];
                n--;  
            } while (dr_Money_Out["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            n++;
            Navigate();

            nav = false;
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            nav = true;
            first_n = n;
            do
            {
                n--;
                if (n < 0) { n = first_n; return; }
                dr_Money_Out = Main.dt_Money_Out.Rows[n];

            } while (dr_Money_Out["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());

            dr_Money_Out = Main.dt_Money_Out.Rows[n];
            Navigate();
            nav = false;
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            nav = true;
            last_n = n;
            do
            {
                n++;
                if (n > Main.dt_Money_Out.Rows.Count - 1) { n = last_n; return; }
                dr_Money_Out = Main.dt_Money_Out.Rows[n];

            } while (dr_Money_Out["Branche_ID"].ToString() != combo_Bill_Branches.SelectedValue.ToString());
            dr_Money_Out = Main.dt_Money_Out.Rows[n];
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
                for (int i = 0; i < Main.dt_Money_Out.Rows.Count; i++)
                {
                    dr = Main.dt_Money_Out.Rows[i];
                    if (dr["ID"].ToString() == textBox_Search.Text && dr["Branche_ID"].ToString() == combo_Bill_Branches.SelectedValue.ToString())
                    {
                        e.Handled = true;
                        dr_Money_Out = dr;
                    }
                }
                if (dr_Money_Out == null) { return; }

                Navigate();
            }
        }
        #endregion
    }
}
