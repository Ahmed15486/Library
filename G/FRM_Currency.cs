using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.G
{
    public partial class FRM_Currency : Form
    {
        G.CLS_G.Currency Currency = new G.CLS_G.Currency();
        DataTable dt_Currency = new DataTable();
        DataRow dr_Currency;
        frm_Main Main;

        public FRM_Currency(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            dt_Currency = Main.ds.Tables[35].Clone();            
            foreach (DataRow dr in Main.ds.Tables[35].Rows)
            {
                dt_Currency.Rows.Add(dr.ItemArray);
            }
        }

        #region Pro
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    //Find Row in dt_Currency
                    foreach (DataRow dr in dt_Currency.Rows)
                    {
                        if (dr[0].ToString() == DGV.SelectedRows[0].Cells["ID"].Value.ToString())
                        {
                            dr_Currency = dr;
                        }
                    }

                    //Fill Customer Controls
                    txt_Currency_ID.Text = dr_Currency["ID"].ToString();
                    txt_Anm.Text = dr_Currency["Anm"].ToString();
                    txt_Enm.Text = dr_Currency["Enm"].ToString();
                    txt_Rate.Text = dr_Currency["Rate"].ToString();


                    txt_Anm.ReadOnly = true;
                    txt_Enm.ReadOnly = true;
                    txt_Rate.ReadOnly = true;

                    grbx_DGV.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    //button_Delete.Visible = true;
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
              

                    txt_Anm.ReadOnly = false;
                    txt_Enm.ReadOnly = false;
                    txt_Rate.ReadOnly = false;

                    grbx_DGV.Enabled = false;

                    txt_Anm.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    //button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;

                    break;
                #endregion

                #region Edit
                case "Edit":

                    txt_Anm.ReadOnly = false;
                    txt_Enm.ReadOnly = false;
                    txt_Rate.ReadOnly = false;

                    grbx_DGV.Enabled = false;

                    button_Edit.Text = "حفظ";
                    button_Edit.Image = imageList1.Images["Save"];
                    button_New.Visible = false;
                    //button_Delete.Visible = false;
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
              

                    txt_Anm.ReadOnly = true;
                    txt_Enm.ReadOnly = true;
                    txt_Rate.ReadOnly = true;

                    grbx_DGV.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = false;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];

                    //button_Delete.Visible = false;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;
                    break;
                    #endregion
            }
        }
        private void var()
        {
            Currency.ID = (txt_Currency_ID.Text == "") ? 0 : Convert.ToInt16(txt_Currency_ID.Text);
            Currency.Anm = txt_Anm.Text;
            Currency.Enm = txt_Enm.Text;
            Currency.Rate = txt_Rate.Text;
        }
        #endregion

        #region Form
        private void FRM_Currency_Shown(object sender, EventArgs e)
        {
            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dt_Currency;

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

                if ((txt_Anm.Text.Trim()).Length < 1) { MessageBox.Show("من فضلك أدخل العملة"); return; }

                //Insert New Currency In DataBase
                var();
                string t = Currency.Insert();
                txt_Currency_ID.Text = t;

                //Fill Currency DGV From DataBase
                dt_Currency = Currency.Select();
                DataRow[] foundRows = dt_Currency.Select("ID = " + t );
                Main.ds.Tables[35].Rows.Add(foundRows[0].ItemArray);

                DGV.DataSource = dt_Currency;

                Tag = "Select";
                Form_Mode("Select");                

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

                if ((txt_Anm.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم العملة");
                    return;
                }

                //Update This Customer In DataBase
                var();
                Currency.Update();

                //Fill Currency DGV From DataBase
                dt_Currency = Currency.Select();
                Main.ds.Tables[35].Rows.Clear();

                foreach (DataRow r in dt_Currency.Rows)
                {
                    Main.ds.Tables[35].Rows.Add(r.ItemArray);
                }

                int t = DGV.CurrentCell.RowIndex;
                DGV.DataSource = dt_Currency;
                DGV.CurrentCell = DGV.Rows[t].Cells[0];

                Tag = "Select";
                Form_Mode("Select");
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() != "Select") { return; }
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف العملة المحددة ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Item In DataBase
                Currency.Delete(Convert.ToInt16(txt_Currency_ID.Text));

                // Delete in Main_ds
                Main.ds.Tables[35].Rows.RemoveAt(DGV.CurrentCell.RowIndex);
                dt_Currency.Rows.RemoveAt(DGV.CurrentCell.RowIndex);
             
                DGV.DataSource = dt_Currency;

                Tag = "Empty";
                Form_Mode("Empty");

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
            Hide();
        }
        #endregion

        #region DGV
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
