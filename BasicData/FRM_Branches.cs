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
    public partial class FRM_Branches : Form
    {
        #region Declarations
        frm_Main Main;
        BL.Branches_Stores BS = new BL.Branches_Stores();
        DataTable dt_Branches = new DataTable();
        DataTable dt_Stores = new DataTable();
        #endregion

        public FRM_Branches(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            //Fill Branches DGV
            DGV_Branches.AutoGenerateColumns = false;         
            dt_Branches = BS.Select_All_Branches();
            DGV_Branches.DataSource = dt_Branches;

            //Fill Stores DGV
            DGV_Stores.AutoGenerateColumns = false;           
            dt_Stores = BS.Select_All_Stores();
            DGV_Stores.DataSource = dt_Stores;        
        }

        #region Pro
        public void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    //Fill Branches Controls From DGV
                    txt_Branche_ID.Text = DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString();
                    textBox_Branche_Name.Text = DGV_Branches.SelectedRows[0].Cells["Branche_Name"].Value.ToString();

                    //Fill Stores Controls From DGV
                    textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["Store_ID"].Value.ToString();
                    textBox_Store_Name.Text = DGV_Stores.SelectedRows[0].Cells["Store_Name"].Value.ToString();

                    //Filter Stores
                    dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString() + "'");

                    txt_Branche_ID.ReadOnly = true;
                    groupBox_Stores.Enabled = true;
                    DGV_Branches.Enabled = true;

                    textBox_Branche_Name.ReadOnly = true;

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

                #region New Branche
                case "New Branche":
                    //Clare Controls
                    txt_Branche_ID.Clear();
                    textBox_Branche_Name.Clear();
                    textBox_Store_ID.Clear();
                    textBox_Store_Name.Clear();

                    txt_Branche_ID.ReadOnly = false;
                    groupBox_Stores.Enabled = false;
                    DGV_Branches.Enabled = false;

                    textBox_Branche_Name.ReadOnly = false;
                    textBox_Branche_Name.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region Edit Branche
                case "Edit Branche":

                    groupBox_Stores.Enabled = false;
                    DGV_Branches.Enabled = false;

                    button_New.Visible = false;
                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;

                    textBox_Branche_Name.ReadOnly = false;
                    textBox_Branche_Name.Select();

                    break;
                #endregion

                #region New Store
                case "New Store":
                    groupBox_Main_Controls.Visible = false;
                    groupBox_Branches.Enabled = false;
                    DGV_Stores.Enabled = false;

                    button_New_Store.Text = "حفظ";
                    button_New_Store.Image = imageList1.Images["Save"];
                    button_Edit_Store.Visible = false;
                    button_Delete_Store.Visible = false;
                    button_Cancel_Store.Visible = true;

                    textBox_Store_ID.Clear();
                    textBox_Store_Name.Clear();
                    textBox_Store_Name.ReadOnly = false;
                    textBox_Store_Name.Focus();

                    label_Store_Full_Name.Visible = true;
                    break;
                #endregion

                #region Edit Store
                case "Edit Store":
                    groupBox_Main_Controls.Visible = false;
                    groupBox_Branches.Enabled = false;
                    DGV_Stores.Enabled = false;

                    button_New_Store.Visible = false;
                    button_Edit_Store.Text = "حفظ";
                    button_Edit_Store.Image = imageList1.Images["Save"];
                    button_Delete_Store.Visible = false;
                    button_Cancel_Store.Visible = true;

                    label_Store_Full_Name.Visible = true;

                    textBox_Store_Name.ReadOnly = false;
                    textBox_Store_Name.Select();
                    break;
                #endregion

                #region Select Edit
                case "Select Edit Store":
                    //Filter Stores
                    dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID=" + DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString());

                    groupBox_Main_Controls.Visible = true;
                    groupBox_Branches.Enabled = true;
                    DGV_Stores.Enabled = true;

                    button_New_Store.Visible = true;
                    button_Edit_Store.Text = "تعديل";
                    button_Edit_Store.Image = imageList1.Images["Edit"];
                    button_Delete_Store.Visible = true;
                    button_Cancel_Store.Visible = false;

                    label_Store_Full_Name.Visible = false;

                    textBox_Store_Name.ReadOnly = true;

                    break;
                #endregion

                #region Store Select
                case "Store Select":

                    //Filter Stores
                    dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString() + "'");

                    //Fill Stores Controls From DGV
                    textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["Store_ID"].Value.ToString();
                    textBox_Store_Name.Text = DGV_Stores.SelectedRows[0].Cells["Store_Name"].Value.ToString();

                    groupBox_Main_Controls.Visible = true;
                    groupBox_Branches.Enabled = true;
                    DGV_Stores.Enabled = true;

                    button_New_Store.Text = "New";
                    button_New_Store.Image = imageList1.Images["New"];
                    button_Edit_Store.Visible = true;
                    button_Delete_Store.Visible = true;
                    button_Cancel_Store.Visible = false;

                    textBox_Store_Name.ReadOnly = true;

                    label_Store_Full_Name.Visible = false;
                    break;
                    #endregion
            }
        }
        private void Fill()
        {
            //Fill Branches DGV From DataBase
            Main.dt_Branches = BS.Select_All_Branches();
            Main.combo_Branches.DataSource = Main.dt_Branches;
            Main.contextMenuStrip_Branches.Items.Clear();
            for (int i = 0; i < Main.combo_Branches.Items.Count; i++)
            {
                Main.contextMenuStrip_Branches.Items.Add(Main.combo_Branches.GetItemText(Main.combo_Branches.Items[i]), Main.imageList16.Images["branche_16.png"]);
            }
            dt_Branches = BS.Select_All_Branches();
            DGV_Branches.DataSource = dt_Branches;

            //Fill Stores DGV From DataBase
            Main.dt_Stores = BS.Select_All_Stores();
            Main.combo_Stores.DataSource = Main.dt_Stores;
            Main.contextMenuStrip_Stores.Items.Clear();
            for (int i = 0; i < Main.combo_Stores.Items.Count; i++)
            {
                Main.contextMenuStrip_Stores.Items.Add(Main.combo_Stores.GetItemText(Main.combo_Stores.Items[i]), Main.imageList16.Images["store_16.png"]);
            }
            dt_Stores = BS.Select_All_Stores();
            DGV_Stores.DataSource = dt_Stores;
        }
        private void var()
        {
            BS.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
            BS.Branche_ID = txt_Branche_ID.Text;
            BS.Branche_Name = textBox_Branche_Name.Text;
            BS.Store_ID = (textBox_Store_ID.Text == "") ? 0 : Convert.ToInt16(textBox_Store_ID.Text);
            BS.Store_Name = (textBox_Store_Name.Text == "") ? "" : textBox_Store_Name.Text;
        }

        #endregion

        #region Form
        private void FRM_Branches_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }
        private void FRM_Branches_Shown(object sender, EventArgs e)
        {
            //Filter Stores
            if (DGV_Branches.SelectedRows.Count > 0)
            {
                string s = DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString();
                dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID = '" + s + "'");

                //Fill Controls
                txt_Branche_ID.Text = DGV_Branches.Rows[0].Cells["Branche_ID"].Value.ToString();
                textBox_Branche_Name.Text = DGV_Branches.Rows[0].Cells["Branche_Name"].Value.ToString();
                textBox_Store_ID.Text = DGV_Stores.Rows[0].Cells["Store_ID"].Value.ToString();
                textBox_Store_Name.Text = DGV_Stores.Rows[0].Cells["Store_Name"].Value.ToString();
            }
        }
        #endregion

        #region Branches Controls
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
            if (Tag.ToString().ToString() == "Select")
            {
                Form_Mode("New Branche");
                Tag = "New Branche";
            }
            else if (Tag.ToString().ToString() == "New Branche")
            {
                if ((txt_Branche_ID.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل كود الفرع");
                    return;
                }
                if (txt_Branche_ID.TextLength < 3)
                {
                    MessageBox.Show("يجب أن يساوي كود الفرع 3 أحرف");
                    return;
                }
                if ((textBox_Branche_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم الفرع");
                    return;
                }

                //Insert New Branche In DataBase
                var();
                BS.Insert_Branche();

                Fill();

                Tag = "Select";
                Form_Mode("Select");
                
                DGV_Branches.CurrentCell = DGV_Branches.Rows[DGV_Branches.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Form_Mode("Edit Branche");
                Tag = "Edit Branche";
            }
            else
            {
                if (Tag.ToString() == "Edit Branche")
                {
                    if ((textBox_Branche_Name.Text.Trim()).Length < 1)
                    {
                        MessageBox.Show("من فضلك أدخل أسم الفرع");
                        return;
                    }

                    var();
                    string t = BS.Update_Branche();
                    if (t.Length > 6)
                    {
                        if (t.Substring(0, 6) == "SQL : ")
                        {
                            MessageBox.Show(t);
                            Tag = "Select";
                            Form_Mode("Select");
                            return;
                        }
                    }

                    Fill();

                    Form_Mode("Select");
                    Tag = "Select";
                }
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الفرع ؟  سيتم حذف كافة الفروع التابعة لهذا الفرع", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Branche In DataBase
                var();
                string t = BS.Delete_Branche();
                if (t.Length > 6)
                {
                    if (t.Substring(0, 6) == "SQL : ")
                    {
                        MessageBox.Show(t);
                        Tag = "Select";
                        Form_Mode("Select");
                        return;
                    }
                }

                Fill();
                Tag = "Select";
                Form_Mode("Select");
                
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Mode("Select");
            Tag = "Select";
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Main.Branches_Form_Open = false;
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

        #region Stores Controls
        #region display
        private void button_New_Store_MouseLeave(object sender, EventArgs e)
        {
            button_New_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_New_Store_MouseEnter(object sender, EventArgs e)
        {
            button_New_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Edit_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Edit_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_Delete_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Delete_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Delete_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Delete_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_Cancel_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Cancel_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Cancel_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Cancel_Store.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void button_New_Store_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Form_Mode("New Store");
                Tag = "New Store";
            }
            else if (Tag.ToString() == "New Store")
            {
                if ((textBox_Store_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم المستودع");
                    return;
                }

                //Insert New Store In DataBase
                var();
                BS.Insert_Store();

                Fill();

                Form_Mode("Store Select");
                Tag = "Select";
                //Select Last Row
                DGV_Stores.CurrentCell = DGV_Stores.Rows[DGV_Stores.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Edit_Store_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Form_Mode("Edit Store");
                Tag = "Edit Store";
            }
            else
            {
                if (Tag.ToString() == "Edit Store")
                {
                    if ((textBox_Store_Name.Text.Trim()).Length < 1)
                    {
                        MessageBox.Show("من فضلك أدخل أسم المستودع");
                        return;
                    }

                    //Update Store In DataBase
                    var();
                    BS.Update_Store();

                    Fill();

                    Tag = "Select";
                    Form_Mode("Select Edit Store");                  
                }
            }
        }
        private void button_Delete_Store_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف المستودع ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Store In DataBase
                BS.Delete_Store();

                Fill();

                Tag = "Select";
                Form_Mode("Select");              
            }
        }
        private void button_Cancel_Store_Click(object sender, EventArgs e)
        {
            Form_Mode("Select Edit Store");
            Tag = "Select";
        }
        #endregion

        #region Branches Details
        private void DGV_Branches_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Branches.SelectedRows.Count > 0)
            {
                //Fill Branches Controls
                txt_Branche_ID.Text = DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString();
                textBox_Branche_Name.Text = DGV_Branches.SelectedRows[0].Cells["Branche_Name"].Value.ToString();

                //Filter Stores
                dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["Branche_ID"].Value.ToString() + "'");

                //Fill Stores Controls From DGV
                textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["Store_ID"].Value.ToString();
                textBox_Store_Name.Text = DGV_Stores.SelectedRows[0].Cells["Store_Name"].Value.ToString();
            }
        }
        private void txt_Branche_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Branche_ID.Text = "";
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
                lbl_Branche_ID.Text = "English Only";
            }
        }
        private void txt_Branche_ID_TextChanged(object sender, EventArgs e)
        {
            if (txt_Branche_ID.TextLength > 3)
            {
                txt_Branche_ID.Text = txt_Branche_ID.Text.Substring(0, 3);
                txt_Branche_ID.Select(txt_Branche_ID.Text.Length, 0);
            }
        }
        #endregion

        #region Stores Details
        private void textBox_Store_Name_TextChanged(object sender, EventArgs e)
        {
            label_Store_Full_Name.Text = textBox_Store_Name.Text + " (" + DGV_Branches.SelectedRows[0].Cells["Branche_Name"].Value.ToString() + ")";
        }
        private void DGV_Stores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Stores.SelectedRows.Count > 0 && DGV_Stores.SelectedRows[0].Cells["Store_ID"].Value != null)
            {
                textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["Store_ID"].Value.ToString();
                textBox_Store_Name.Text = DGV_Stores.SelectedRows[0].Cells["Store_Name"].Value.ToString();
            }
        }
        #endregion
    }
}
