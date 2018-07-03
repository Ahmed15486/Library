using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.BasicData
{
    public partial class FRM_Customer : Form
    {
        #region Declaration
        BL.CLS_Cust Cust = new BL.CLS_Cust();
        BL.CLS_ACC ACC = new BL.CLS_ACC();

        DataTable dt_Cust = new DataTable();
        DataTable dt_acc_cust = new DataTable();
        DataRow dr_Cust;

        frm_Main Main;

        bool up;
        #endregion

        public FRM_Customer(frm_Main main)
        {
            InitializeComponent();
            Main = main;
            DGV.AutoGenerateColumns = false;

            dt_Cust = Cust.Select();

            dt_acc_cust = Main.dt_ACC.Clone();
            foreach (DataRow dr in Main.dt_ACC.Rows)
            {
                if(dr["ACC_Proper_ID"].ToString() == "1")
                dt_acc_cust.Rows.Add(dr.ItemArray);
            }
            com_ACC_Name.DataSource = dt_acc_cust;
            com_ACC_Name.SelectedValue = -1;

            DGV.CurrentCell = null;
        }

        #region Pro
        private void Form_Mode(string mode)
         {
             switch (mode)
             {
                 #region Select
                 case "Select":

                    //Find Row in dt_Cust
                    foreach (DataRow dr in dt_Cust.Rows)
                    {
                        if (dr[0].ToString() == DGV.SelectedRows[0].Cells["Cust_ID"].Value.ToString())
                        {
                            dr_Cust = dr;
                        }
                    }

                    //Fill Customer Controls
                    txt_Cust_ID.Text = dr_Cust["Cust_ID"].ToString();
                    txt_Cust_Name.Text = dr_Cust["Cust_Name"].ToString();
                    txt_Mobile.Text = dr_Cust["Cust_Mobile"].ToString();
                    txt_Phone.Text = dr_Cust["Cust_Phone"].ToString();
                    txt_Address.Text = dr_Cust["Cust_Address"].ToString();
                    txt_Notes.Text = dr_Cust["Cust_Notes"].ToString();
                    com_ACC_Name.SelectedValue = dr_Cust["Parent_ACC"].ToString();

                    txt_Cust_Name.ReadOnly = true;
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
                         if (x is TextBox){  x.Text = "";}
                     }
                     com_ACC_Name.SelectedIndex = 0;

                    txt_Cust_Name.ReadOnly = false;
                    txt_Address.ReadOnly = false;
                    txt_Mobile.ReadOnly = false;
                    txt_Phone.ReadOnly = false;
                    txt_Notes.ReadOnly = false;
                    com_ACC_Name.Enabled = true;

                    grbx_DGV.Enabled = false;

                     txt_Cust_Name.Focus();

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

                    txt_Cust_Name.ReadOnly = false;
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

                    txt_Cust_Name.ReadOnly = true;
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
             Cust.ID = txt_Cust_ID.Text;
             Cust.Name = txt_Cust_Name.Text;
            Cust.Address = txt_Address.Text;
             Cust.Mobile = txt_Mobile.Text;
             Cust.Phone = txt_Phone.Text;
             Cust.Notes = txt_Notes.Text;
             Cust.Cust_ACC = (com_ACC_Name.SelectedValue != null) ? com_ACC_Name.SelectedValue.ToString(): "";
             Cust.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
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
             DGV.DataSource = dt_Cust;
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

                if ((txt_Cust_Name.Text.Trim()).Length < 1) { MessageBox.Show("من فضلك أدخل أسم العميل"); return; }

                Cust.Address = txt_Address.Text;
                Cust.Mobile = txt_Mobile.Text;
                Cust.Phone = txt_Phone.Text;
                Cust.Notes = txt_Notes.Text;

                //Insert New Customer In DataBase
                var();
                string t = Cust.Insert();
                if (t.Length > 6)
                {
                    if (t.Substring(0, 6) == "SQL : ")
                    {
                        MessageBox.Show(t);
                        Tag = "Empty";
                        Form_Mode("Empty");
                        return;
                    }
                }

                //Fill Cust DGV From DataBase
                dt_Cust = Cust.Select();
                DGV.DataSource = dt_Cust;

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

                if ((txt_Cust_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم العميل");
                    return;
                }

                //Update This Customer In DataBase
                var();
                Cust.Update();

                //Fill Cust DGV From DataBase
                dt_Cust = Cust.Select();
                DGV.DataSource = dt_Cust;

                // Update ACC
                Main.dt_ACC = ACC.Select();

                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    if(DGV.Rows[i].Cells["Cust_ID"].Value.ToString() == txt_Cust_ID.Text)
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
            if(Tag.ToString() != "Select") { return; }
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف العميل المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Item In DataBase
                string t = Cust.Delete((txt_Cust_ID.Text));
                if (t.Substring(0, 12) == "SQL Error : ")
                {
                    MessageBox.Show(t, "خطأ أثناء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Tag = "Select";
                    Form_Mode("Select");
                }
                else
                {
                    //Fill Cust DGV From DataBase
                    dt_Cust = Cust.Select();
                  
                    DGV.DataSource = dt_Cust;

                    //Fill ACC DGV From DataBase
                    Main.dt_ACC = ACC.Select();                    

                    Tag = "Empty";
                    Form_Mode("Empty");

                    MessageBox.Show(t,"تم الحذف",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            Main.Cust_Form_Open = false;
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
            if(txt_Search.Text == "Search")
            {
                dt_Cust.DefaultView.RowFilter = string.Format("");
                return;
            }

            dt_Cust.DefaultView.RowFilter = string.Format("Cust_Name Like '%" + txt_Search.Text + "%'");
            if(DGV.Rows.Count > 0)
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
