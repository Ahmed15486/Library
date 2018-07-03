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
    public partial class FRM_Emp : Form
    {
        BL.CLS_Emp Emp = new BL.CLS_Emp();
        BL.CLS_Job_Type Job_Type = new BL.CLS_Job_Type();
        DataTable dt_Emp;
        DataTable dt_Job_Type;
        DataRow r;

        frm_Main Main;
        public FRM_Emp(frm_Main main)
        {
            InitializeComponent();
            Main = main;
            DGV_Emp.AutoGenerateColumns = false;
        }
        private void FRM_Vendors_Shown(object sender, EventArgs e)
        {
            //Fill Emp DGV
            dt_Emp = Emp.Emp_Select();
            DGV_Emp.DataSource = dt_Emp;

            //Fill Job Type ComboBox
            dt_Job_Type = Job_Type.Job_Type_Select();
            comboBox_Job_Type.DataSource = dt_Job_Type;
            comboBox_Job_Type.Text = "";
        }       
        private void Form_Mode(string mode)
         {
             switch (mode)
             {
                 #region Select
                 case "Select":

                     groupBox2.Enabled = false;
                     groupBox3.Enabled = true;

                     button_New.Visible = true;
                     button_New.Text = "جديد";
                     button_New.Image = imageList1.Images["New"];
                     button_Edit.Visible = true;
                     button_Edit.Text = "تعديل";
                     button_Edit.Image = imageList1.Images["Edit"];
                     button_Delete.Visible = true;
                     button_Cancel.Visible = false;
                     button_Close.Visible = true;

                     //To Remove The Last Empty Row
                     DGV_Emp.AllowUserToAddRows = false;

                     break;
                 #endregion

                 #region New
                 case "New":
                     //Clare Controls
                     foreach (Control x in groupBox2.Controls)
                     {
                         if (x is TextBox){  x.Text = "";}
                     }

                     groupBox2.Enabled = true;
                     groupBox3.Enabled = false;

                     textBox_Emp_Name.Focus();

                     button_New.Text = "حفظ";
                     button_New.Image = imageList1.Images["Save"];
                     button_Edit.Visible = false;
                     button_Delete.Visible = false;
                     button_Cancel.Visible = true;
                     button_Close.Visible = false;

                     //To Add Empty Row
                     DGV_Emp.AllowUserToAddRows = true;
                     //To Select This Row
                     DGV_Emp.CurrentCell = DGV_Emp.Rows[DGV_Emp.Rows.Count - 1].Cells[0];
                     break;
                 #endregion

                 #region Edit
                 case "Edit":

                     groupBox2.Enabled = true;
                     groupBox3.Enabled = false;

                     textBox_Emp_ID.ReadOnly = true;

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

                     break;
                 #endregion
             }
         }
        private void DGV_Emp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Emp.SelectedRows.Count > 0 && DGV_Emp.SelectedRows[0].Cells["Emp_ID"].Value != null)
            {
                //Find Row in Emp
                foreach (DataRow dr in dt_Emp.Rows)
                {
                    if (dr[0].ToString() == DGV_Emp.SelectedRows[0].Cells["Emp_ID"].Value.ToString())
                    {
                        r = dr;
                    }
                }

                //Fill Vendors Controls
                textBox_Emp_ID.Text = r["Emp_ID"].ToString();
                comboBox_Job_Type.SelectedValue = r["Job_ID"];
                textBox_Emp_Name.Text = r["Emp_Name"].ToString();
                textBox_Mobile.Text = r["Emp_Mobile"].ToString();
                textBox_Phone.Text = r["Emp_Phone"].ToString();
                textBox_Address.Text = r["Emp_Address"].ToString();
                textBox_Emp_Personal_ID.Text = r["Emp_Personal_ID"].ToString();
                textBox_Emp_Basic_Salary.Text = r["Emp_Basic_Salary"].ToString();
                textBox_Notes.Text = r["Emp_Notes"].ToString();
            }         
        }
        private void button_New_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                Form_Mode("New");
                Tag = "New";
            }
            else if (Tag.ToString() == "New")
            {

                if ((textBox_Emp_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم الموظف");
                    return;
                }

                //Insert New Emp In DataBase
                Emp.Emp_Insert(
                         textBox_Emp_Name.Text
                        , Convert.ToInt32(comboBox_Job_Type.SelectedValue)
                        , Convert.ToInt32(textBox_Phone.Text)
                        , Convert.ToInt32(textBox_Mobile.Text)
                        , textBox_Address.Text
                        , Convert.ToInt32(textBox_Emp_Personal_ID.Text)
                        , Convert.ToDecimal(textBox_Emp_Basic_Salary.Text)
                        , textBox_Notes.Text
                        , 1
                        );

                //Fill Emp DGV From DataBase
                dt_Emp = Emp.Emp_Select();
                DGV_Emp.DataSource = dt_Emp;

                Form_Mode("Select");
                Tag = "Select";

                DGV_Emp.CurrentCell = DGV_Emp.Rows[DGV_Emp.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Mode("Select");
            Tag = "Select";
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            int i = DGV_Emp.SelectedRows[0].Index;

            if (Tag.ToString() == "Select")
            {
                Form_Mode("Edit");
                Tag = "Edit";           
            }
            else if (Tag.ToString() == "Edit")
            {

                if ((textBox_Emp_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم الموظف");
                    return;
                }

                //Update This Emp In DataBase
                Emp.Emp_Update(
                          Convert.ToInt32(textBox_Emp_ID.Text)
                        , textBox_Emp_Name.Text
                        , Convert.ToInt32(comboBox_Job_Type.SelectedValue)
                        , Convert.ToInt32(textBox_Phone.Text)
                        , Convert.ToInt32(textBox_Mobile.Text)
                        , textBox_Address.Text
                        , Convert.ToInt32(textBox_Emp_Personal_ID.Text)
                        , Convert.ToDecimal(textBox_Emp_Basic_Salary.Text)
                        , textBox_Notes.Text
                        , 1
                       );

                //Fill Emp DGV From DataBase
                dt_Emp = Emp.Emp_Select();
                DGV_Emp.DataSource = dt_Emp;

                Form_Mode("Select");
                Tag = "Select";

                DGV_Emp.CurrentCell = DGV_Emp.Rows[i].Cells[0];
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الموظف المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Emp In DataBase
                Emp.Emp_Delete((textBox_Emp_ID.Text));

                //Fill Emp DGV From DataBase
                dt_Emp = Emp.Emp_Select();
                DGV_Emp.DataSource = dt_Emp;
            }                      
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Parent.Dispose();
            Main.Emp_Form_Open = false;
        }
    }
}
