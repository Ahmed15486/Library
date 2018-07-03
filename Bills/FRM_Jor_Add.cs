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
    public partial class FRM_Jor_Add : Form
    {
        #region Declaration
        G.FRM_Search s = new G.FRM_Search();

        public frm_Main Main;
        public DataSet ds = new DataSet();
        public DataView dv_acc;
        public DataView dv_cc1;
        public DataView dv_cc2;
        public DataGridView DGV;
        public int top;
        public Image Edit;
        public Image Search;
        public int rowindex;
        #endregion

        public FRM_Jor_Add()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Jor_Add_Shown(object sender, EventArgs e)
        {
            Top = top;
            panel_ACC_ID.Visible = DGV.Columns["ACC_ID"].Visible;
            pnl_Currency.Visible = DGV.Columns["Currency"].Visible;
            pnl_Currency_Rate.Visible = DGV.Columns["Currency_Rate"].Visible;
            panel_CC1.Visible = DGV.Columns["CC1"].Visible;
            panel_CC2.Visible = DGV.Columns["CC2"].Visible;
            panel_Branche.Visible = DGV.Columns["Branche"].Visible;

            btn_Acc_Edit.Image = Edit;
            btn_Acc_Search.Image = Search;
            btn_CC1_Search.Image = Search;
            btn_CC1_Edit.Image = Edit;
            btn_CC2_Search.Image = Search;
            btn_CC2_Edit.Image = Edit;
            btn_Currency_Edit.Image = Edit;
        }
        #endregion

        #region Control
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Debit.Text = (txt_Debit.Text.Trim() == "") ? "0" : txt_Debit.Text.Trim();
            txt_Credit.Text = (txt_Credit.Text.Trim() == "") ? "0" : txt_Credit.Text.Trim();

            if (Convert.ToDecimal(txt_Debit.Text) == 0 && Convert.ToDecimal(txt_Credit.Text) == 0)
            {
                MessageBox.Show("يجب تحديد قيمة المدين أو الدائن", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Debit.Text = "";
                txt_Debit.Focus();
                return;
            }

            if (combo_ACC_ID.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد الحساب", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combo_ACC.Focus();
                combo_ACC.DroppedDown = true;
                return;
            }
            if (combo_ACC_ID.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("يجب تحديد الحساب", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combo_ACC.Focus();
                combo_ACC.DroppedDown = true;
                return;
            }

            if (btn_Add.Text != "تعديل")
            {
                DGV.Rows.Add();
            }
            else
            {
                DGV.Rows[rowindex].Cells["Debit"].Value = txt_Debit.Text;
                DGV.Rows[rowindex].Cells["Credit"].Value = txt_Credit.Text;
                DGV.Rows[rowindex].Cells["ACC_Name"].Value = combo_ACC.Text;
                DGV.Rows[rowindex].Cells["ACC_ID"].Value = combo_ACC_ID.Text;
                DGV.Rows[rowindex].Cells["Notes"].Value = txt_Notes.Text;
                int x = Convert.ToInt16(com_Currency.SelectedValue);
                DGV.Rows[rowindex].Cells["Currency"].Value = x;
                DGV.Rows[rowindex].Cells["Currency_Rate"].Value = txt_Currency_Rate.Text;
                DGV.Rows[rowindex].Cells["CC1"].Value = com_CC1.SelectedValue;
                DGV.Rows[rowindex].Cells["CC2"].Value = com_CC2.SelectedValue;
                DGV.Rows[rowindex].Cells["Branche"].Value = com_Branche.SelectedValue;

                Hide();
            }
        }
        #endregion

        #region Details
        // Debit
        private void txt_Debit_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Number
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion

            // if press enter
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_Debit.Text == "" || txt_Debit.Text == ".") { txt_Credit.Focus(); return; }
                if (Convert.ToDecimal(txt_Debit.Text) == 0) { txt_Credit.Focus(); }
                else
                {
                    combo_ACC.Focus();
                }
            }
        }
        private void txt_Debit_Leave(object sender, EventArgs e)
        {
            if (txt_Debit.Text == "" || txt_Debit.Text == ".")
            {
                txt_Debit.Text = "0";
                txt_Credit.Text = "0";
                return;
            }
            if (Convert.ToDecimal(txt_Debit.Text) == 0)
            {
                txt_Debit.Text = "0";
            }

            txt_Credit.Text = "";
        }
        //Credit
        private void txt_Credit_KeyPress(object sender, KeyPressEventArgs e)
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

            // if press enter
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_Credit.Text == "" || txt_Credit.Text == ".") { txt_Debit.Focus(); return; }
                if (Convert.ToDecimal(txt_Credit.Text) == 0) { txt_Debit.Focus(); }
                else
                {
                    combo_ACC.Focus();
                }
            }
        }
        private void txt_Credit_Leave(object sender, EventArgs e)
        {
            if (txt_Credit.Text == "" || txt_Credit.Text == ".")
            {
                txt_Credit.Text = "0";
                txt_Debit.Text = "0";
                return;
            }
            if (Convert.ToDecimal(txt_Credit.Text) == 0) { txt_Credit.Text = "0"; }
            txt_Debit.Text = "0";
        }
        // ACC_Name
        private void combo_ACC_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_ACC_ID.SelectedIndex = combo_ACC.SelectedIndex;
            dv_cc1.RowFilter = "Is_Parent = 0 and CC1 = 1";
            dv_cc2.RowFilter = "Is_Parent = 0 and CC2 = 1";
            com_CC1.SelectedValue = -1;
            com_CC2.SelectedValue = -1;

            if (combo_ACC.SelectedValue == null) { return; }
            foreach (DataRowView dr in dv_acc)
            {
                if (dr["ACC_ID"].ToString() == combo_ACC.SelectedValue.ToString())
                {
                    if (dr["CC1"].ToString() != "")
                    {
                        if (dr["CC1_Group"].ToString() == "1")
                        {
                            dv_cc1.RowFilter = "Is_Parent = 0 and CC1 = 1 and Parent_ID = '" + dr["CC1"].ToString() + "'";                          
                        }
                        com_CC1.SelectedValue = dr["CC1"].ToString();
                    }

                    if (dr["CC2"].ToString() != "")
                    {
                        if (dr["CC2_Group"].ToString() == "1")
                        {
                            dv_cc2.RowFilter = "Is_Parent = 0 and CC2 = 1 and Parent_ID = '" + dr["CC2"].ToString() + "'";
                        }
                        com_CC2.SelectedValue = dr["CC2"].ToString();
                    }
                    break;
                }
            }
        }
        private void combo_ACC_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_Notes.Select();
            }
        }
        private void btn_Acc_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن حساب";
            s.rad_Name.Checked = true;

            s.dt = Main.ds.Tables[6].Clone();
            foreach (DataRow r in Main.ds.Tables[6].Rows)
            {
                if (Convert.ToBoolean(r["Is_Parent"]) == false)
                {
                    s.dt.Rows.Add(r.ItemArray);
                }
            }

            s.DGV.Columns[0].DataPropertyName = "ACC_ID";
            s.DGV.Columns[1].DataPropertyName = "ACC_Name";

            s.DGV.AutoGenerateColumns = false;
            s.DGV.DataSource = s.dt;
            s.ShowDialog();

            combo_ACC.Text = s.txt;
        }
        private void btn_Acc_Edit_Click(object sender, EventArgs e)
        {
            BasicData.FRM_ACC acc = new BasicData.FRM_ACC(Main);
            acc.FormBorderStyle = FormBorderStyle.Sizable;

            acc.BackColor = Color.White;
            acc.Width = 975;
            acc.Height = 700;
            acc.WindowState = FormWindowState.Normal;
            acc.StartPosition = FormStartPosition.CenterScreen;
            acc.ShowDialog();
            combo_ACC.SelectedValue = acc.txt_ACC_ID.Text;
        }
        // ACC_ID
        private void combo_ACC_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_Notes.Select();
            }
        }
        // Notes
        private void txt_Notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add.Focus();
                btn_Add_Click(null,null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                com_CC1.Focus();
            }
        }
        // Currency
        private void btn_Currency_Edit_Click(object sender, EventArgs e)
        {
            G.FRM_Currency c = new G.FRM_Currency(Main);

            c.ShowDialog();

            if (c.txt_Currency_ID.Text != "")
            {
                com_Currency.SelectedValue = c.txt_Currency_ID.Text;
            }
        }
        private void com_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(com_Currency.SelectedValue == null) { return; }

            DataView dv = com_Currency.DataSource as DataView;
            foreach (DataRowView r in dv)
            {
                if (r["ID"].ToString() == com_Currency.SelectedValue.ToString())
                {
                    txt_Currency_Rate.Text = r["Rate"].ToString();
                }
            }
        }
        // CC1
        private void com_CC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                com_CC2.Focus();
            }
        }
        private void btn_CC1_Del_Click(object sender, EventArgs e)
        {
            com_CC1.SelectedValue = -1;
        }
        private void btn_CC1_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن مركز1";
            s.rad_Name.Checked = true;

            s.dt = Main.ds.Tables[3].Clone();
            foreach (DataRow r in Main.ds.Tables[3].Rows)
            {
                if (Convert.ToBoolean(r["CC1"]) == true)
                {
                    s.dt.Rows.Add(r.ItemArray);
                }
            }

            s.DGV.Columns[0].DataPropertyName = "CC_ID";
            s.DGV.Columns[1].DataPropertyName = "CC_Name";

            s.DGV.AutoGenerateColumns = false;
            s.DGV.DataSource = s.dt;
            s.ShowDialog();

            com_CC1.Text = s.txt;
        }
        private void btn_CC1_Edit_Click(object sender, EventArgs e)
        {
            BasicData.FRM_CC cc = new BasicData.FRM_CC(Main);
            cc.FormBorderStyle = FormBorderStyle.FixedSingle;

            cc.BackColor = Color.White;
            cc.Width = 1000;
            cc.WindowState = FormWindowState.Normal;
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
            com_CC1.SelectedValue = cc.txt_CC_ID.Text;
        }
        private void com_CC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_CC1_Del.Visible = (com_CC1.SelectedValue != null) ? true : false;
        }
        // CC2
        private void com_CC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                com_Branche.Focus();
            }
        }
        private void btn_CC2_Del_Click(object sender, EventArgs e)
        {
            com_CC2.SelectedValue = -1;
        }
        private void btn_CC2_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن مركز2";
            s.rad_Name.Checked = true;

            s.dt = Main.ds.Tables[3].Clone();
            foreach (DataRow r in Main.ds.Tables[3].Rows)
            {
                if (Convert.ToBoolean(r["CC2"]) == true)
                {
                    s.dt.Rows.Add(r.ItemArray);
                }
            }

            s.DGV.Columns[0].DataPropertyName = "CC_ID";
            s.DGV.Columns[1].DataPropertyName = "CC_Name";

            s.DGV.AutoGenerateColumns = false;
            s.DGV.DataSource = s.dt;
            s.ShowDialog();

            com_CC2.Text = s.txt;
        }
        private void btn_CC2_Edit_Click(object sender, EventArgs e)
        {
            BasicData.FRM_CC cc = new BasicData.FRM_CC(Main);
            cc.FormBorderStyle = FormBorderStyle.FixedSingle;

            cc.BackColor = Color.White;
            cc.Width = 1000;
            cc.WindowState = FormWindowState.Normal;
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
            com_CC2.SelectedValue = cc.txt_CC_ID.Text;
        }
        private void com_CC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_CC2_Del.Visible = (com_CC2.SelectedValue != null) ? true : false;
        }
        // Branches
        private void com_Branche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 43)
            {
                e.Handled = true;
                btn_Add_Click(null,null);
            }
        }
        private void btn_Branche_Del_Click(object sender, EventArgs e)
        {
            com_Branche.SelectedValue = -1;
        }
        #endregion
    }
}
