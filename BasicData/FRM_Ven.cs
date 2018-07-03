using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library.BasicData
{
    public partial class FRM_Ven : Form
    {
        #region Declaration
        BL.CLS_Ven Ven = new BL.CLS_Ven();
        BL.CLS_ACC ACC = new BL.CLS_ACC();

        DataTable dt_Ven = new DataTable();
        DataTable dt_acc_ven = new DataTable();
        DataRow dr_Ven;

        frm_Main Main;

        bool up;
        #endregion

        public FRM_Ven(frm_Main main)
        {
            InitializeComponent();
            Main = main;
           
            dt_Ven = Main.ds.Tables[9].Clone();
            foreach (DataRow dr in Main.ds.Tables[9].Rows)
            {
                dt_Ven.Rows.Add(dr.ItemArray);
            }

            dt_acc_ven = Main.ds.Tables[6].Clone();
            foreach (DataRow dr in Main.ds.Tables[6].Rows)
            {
                if (dr["ACC_Proper_ID"].ToString() == "2")
                    dt_acc_ven.Rows.Add(dr.ItemArray);
            }
            com_ACC_Name.DataSource = dt_acc_ven;
            com_ACC_Name.SelectedValue = -1;
        }

        #region Pro
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    //Find Row in dt_Ven
                    foreach (DataRow dr in dt_Ven.Rows)
                    {
                        if (dr[0].ToString() == DGV.SelectedRows[0].Cells["Ven_ID"].Value.ToString())
                        {
                            dr_Ven = dr;
                        }
                    }

                    //Fill Customer Controls
                    txt_Ven_ID.Text = dr_Ven["Ven_ID"].ToString();
                    txt_Ven_Name.Text = dr_Ven["Ven_Name"].ToString();
                    txt_Mobile.Text = dr_Ven["Ven_Mobile"].ToString();
                    txt_Phone.Text = dr_Ven["Ven_Phone"].ToString();
                    txt_Address.Text = dr_Ven["Ven_Address"].ToString();
                    txt_Notes.Text = dr_Ven["Ven_Notes"].ToString();
                    com_ACC_Name.SelectedValue = dr_Ven["Parent_ACC"].ToString();

                    txt_Ven_Name.ReadOnly = true;
                    txt_Address.ReadOnly = true;
                    txt_Mobile.ReadOnly = true;
                    txt_Phone.ReadOnly = true;
                    txt_Notes.ReadOnly = true;
                    com_ACC_Name.Enabled = false;

                    grbx_DGV.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;

                    break;
                #endregion

                #region New
                case "New":
                    //Clare Controls
                    foreach (Control x in grbx_Details.Controls)
                    {
                        if (x is TextBox) { x.Text = ""; }
                    }
                    com_ACC_Name.SelectedIndex = 0;

                    txt_Ven_Name.ReadOnly = false;
                    txt_Address.ReadOnly = false;
                    txt_Mobile.ReadOnly = false;
                    txt_Phone.ReadOnly = false;
                    txt_Notes.ReadOnly = false;
                    com_ACC_Name.Enabled = true;

                    grbx_DGV.Enabled = false;

                    txt_Ven_Name.Focus();

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

                    txt_Ven_Name.ReadOnly = false;
                    txt_Address.ReadOnly = false;
                    txt_Mobile.ReadOnly = false;
                    txt_Phone.ReadOnly = false;
                    txt_Notes.ReadOnly = false;
                    com_ACC_Name.Enabled = true;

                    grbx_DGV.Enabled = false;

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

                    foreach (Control c in grbx_Details.Controls)
                    {
                        if (c is TextBox) { c.Text = ""; }
                    }
                    com_ACC_Name.SelectedValue = -1;

                    txt_Ven_Name.ReadOnly = true;
                    txt_Address.ReadOnly = true;
                    txt_Mobile.ReadOnly = true;
                    txt_Phone.ReadOnly = true;
                    txt_Notes.ReadOnly = true;
                    com_ACC_Name.Enabled = false;

                    grbx_DGV.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = false;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];

                    button_Delete.Visible = false;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;
                    break;
                    #endregion
            }
        }
        private void var()
        {
            Ven.ID = txt_Ven_ID.Text;
            Ven.Name = txt_Ven_Name.Text;
            Ven.Address = txt_Address.Text;
            Ven.Mobile = txt_Mobile.Text;
            Ven.Phone = txt_Phone.Text;
            Ven.Notes = txt_Notes.Text;
            Ven.Ven_ACC = (com_ACC_Name.SelectedValue != null) ? com_ACC_Name.SelectedValue.ToString() : "";
            Ven.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
        }
        private void UpDowen()
        {
            if (Main.tab_Main.Visible == false && up == false)
            {
                up = true;
                //grbx_DGV.Height += Main.tab_Main.Height;
                //grbx_Details.Height = grbx_DGV.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else if (Main.tab_Main.Visible == true && up == true)
            {
                up = false;
                // grbx_DGV.Height -= Main.tab_Main.Height;
                //grbx_Details.Height = grbx_DGV.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region Form
        private void FRM_Customer_Enter(object sender, EventArgs e)
        {
            UpDowen();
        }
        private void FRM_Customer_Shown(object sender, EventArgs e)
        {
            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dt_Ven;
            if (DGV.Rows.Count > 0)
            {
                DGV.CurrentCell = DGV.Rows[0].Cells[0];
                DGV_CurrentCellChanged(null, null);
            }
        }
        #endregion

        #region grbx_Controls
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
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Tag = "New";
                Form_Mode("New");
            }
            else if (Tag.ToString() == "New")
            {

                if ((txt_Ven_Name.Text.Trim()).Length < 1) { MessageBox.Show("من فضلك أدخل أسم العميل"); return; }

                Ven.Address = txt_Address.Text;
                Ven.Mobile = txt_Mobile.Text;
                Ven.Phone = txt_Phone.Text;
                Ven.Notes = txt_Notes.Text;

                //Insert New Customer In DataBase
                var();
                string t = Ven.Insert();
                if (t.Length > 12)
                {
                    if (t.Substring(0, 12) == "SQL Error : ")
                    {
                        MessageBox.Show(t);
                        Form_Mode("Empty");
                        return;
                    }
                }

                //Fill Cust DGV From DataBase
                dt_Ven = Ven.Select();
                DataRow[] foundRows = dt_Ven.Select("Ven_ID = '" + t + "'");
                Main.ds.Tables[9].Rows.Add(foundRows[0].ItemArray);

                DGV.DataSource = dt_Ven;

                //Add new customer ACC to dt_ACC
                Main.dt_ACC = ACC.Select();

                Form_Mode("Select");
                Tag = "Select";

                DGV.CurrentCell = DGV.Rows[DGV.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Tag = "Edit";
                Form_Mode("Edit");
            }
            else if (Tag.ToString() == "Edit")
            {

                if ((txt_Ven_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم العميل");
                    return;
                }

                //Update This Customer In DataBase
                var();
                Ven.Update();

                //Fill Ven DGV From DataBase
                dt_Ven = Ven.Select();
                DGV.DataSource = dt_Ven;

                // Update ACC
                Main.dt_ACC = ACC.Select();

                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    if (DGV.Rows[i].Cells["Ven_ID"].Value.ToString() == txt_Ven_ID.Text)
                    {
                        DGV.CurrentCell = DGV.Rows[i].Cells[0];
                        break;
                    }
                }
                DGV_CurrentCellChanged(null, null);
                txt_Search.Text = "Search";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() != "Select") { return; }
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف العميل المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Item In DataBase
                string t = Ven.Delete((txt_Ven_ID.Text));
                if (t.Substring(0, 12) == "SQL Error : ")
                {
                    MessageBox.Show(t, "خطأ أثناء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tag = "Select";
                    Form_Mode("Select");
                }
                else
                {
                    //Fill Ven DGV From DataBase
                    dt_Ven = Ven.Select();

                    DGV.DataSource = dt_Ven;

                    //Fill ACC DGV From DataBase
                    Main.dt_ACC = ACC.Select();

                    Tag = "Empty";
                    Form_Mode("Empty");

                    MessageBox.Show(t, "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
            else if (Tag.ToString() == "Edit")
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Main.Ven_Form_Open = false;
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
            else { this.Hide(); }
        }
        #endregion

        #region DGV
        #region display
        private void txt_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.CadetBlue;
            }
        }
        private void txt_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.Silver;
            }
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
            }
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text.Trim() == "Search" || txt_Search.Text.Trim() == "")
            {
                txt_Search.Text = "Search";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        #endregion
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                dt_Ven.DefaultView.RowFilter = string.Format("");
                return;
            }

            dt_Ven.DefaultView.RowFilter = string.Format("Ven_Name Like '%" + txt_Search.Text + "%'");
            if (DGV.Rows.Count > 0)
            {
                DGV.CurrentCell = DGV.Rows[0].Cells[0];
                DGV_CurrentCellChanged(null, null);
            }
            else
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
        }
        private void DGV_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGV.CurrentCell != null && DGV.SelectedRows.Count > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
