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
    public partial class FRM_Job_Type : Form
    {
        BL.CLS_Job_Type Job_Type = new BL.CLS_Job_Type();
        DataTable dt_Job_Type;
        DataRow r;

        frm_Main Main;
        public FRM_Job_Type(frm_Main main)
        {
            InitializeComponent();
            Main = main;
            DGV_Job_Type.AutoGenerateColumns = false;
        }

        private void FRM_Job_Type_Shown(object sender, EventArgs e)
        {
            dt_Job_Type = Job_Type.Job_Type_Select();
            DGV_Job_Type.DataSource = dt_Job_Type;
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
                    DGV_Job_Type.AllowUserToAddRows = false;

                    break;
                #endregion

                #region New
                case "New":
                    //Clare Controls
                    foreach (Control x in groupBox2.Controls)
                    {
                        if (x is TextBox) { x.Text = ""; }
                    }

                    groupBox2.Enabled = true;
                    groupBox3.Enabled = false;

                    textBox_Job_Type_Name.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;

                    //To Add Empty Row
                    DGV_Job_Type.AllowUserToAddRows = true;
                    //To Select This Row
                    DGV_Job_Type.CurrentCell = DGV_Job_Type.Rows[DGV_Job_Type.Rows.Count - 1].Cells[0];
                    break;
                #endregion

                #region Edit
                case "Edit":

                    groupBox2.Enabled = true;
                    groupBox3.Enabled = false;

                    textBox_Job_Type_ID.ReadOnly = true;

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
        private void DGV_Job_Type_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Job_Type.SelectedRows.Count > 0 && DGV_Job_Type.SelectedRows[0].Cells["Job_Type_ID"].Value != null)
            {
                //Find Row in Vendors
                foreach (DataRow dr in dt_Job_Type.Rows)
                {
                    if (dr[0].ToString() == DGV_Job_Type.SelectedRows[0].Cells["Job_Type_ID"].Value.ToString())
                    {
                        r = dr;
                    }
                }

                //Fill Vendors Controls
                textBox_Job_Type_ID.Text = r["Job_Type_ID"].ToString();
                textBox_Job_Type_Name.Text = r["Job_Type_Name"].ToString();
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

                if ((textBox_Job_Type_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم نوع الوظيفة");
                    return;
                }

                //Insert New Job_Type In DataBase
                Job_Type.Job_Type_Insert(
                          textBox_Job_Type_Name.Text
                        , 1
                        );

                //Fill Job_Type DGV From DataBase
                dt_Job_Type = Job_Type.Job_Type_Select();
                DGV_Job_Type.DataSource = dt_Job_Type;

                Form_Mode("Select");
                Tag = "Select";

                DGV_Job_Type.CurrentCell = DGV_Job_Type.Rows[DGV_Job_Type.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Mode("Select");
            Tag = "Select";
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            int i = DGV_Job_Type.SelectedRows[0].Index;

            if (Tag.ToString() == "Select")
            {
                Form_Mode("Edit");
                Tag = "Edit";
            }
            else if (Tag.ToString() == "Edit")
            {

                if ((textBox_Job_Type_Name.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم نوع الوظيفة");
                    return;
                }

                //Update This Job_Type In DataBase
                Job_Type.Job_Type_Update(
                     Convert.ToInt32(textBox_Job_Type_ID.Text)
                    , textBox_Job_Type_Name.Text
                    , 1
                    );

                //Fill Job_Type DGV From DataBase
                dt_Job_Type = Job_Type.Job_Type_Select();
                DGV_Job_Type.DataSource = dt_Job_Type;

                Form_Mode("Select");
                Tag = "Select";

                DGV_Job_Type.CurrentCell = DGV_Job_Type.Rows[i].Cells[0];
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف نوع الوظيفة المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Job_Type In DataBase
                Job_Type.Job_Type_Delete((textBox_Job_Type_ID.Text));

                //Fill Job_Type DGV From DataBase
                dt_Job_Type = Job_Type.Job_Type_Select();
                DGV_Job_Type.DataSource = dt_Job_Type;
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Parent.Dispose();
            Main.Job_Type_Form_Open = false;
        }
    }
}
