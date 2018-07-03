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
    public partial class FRM_Pur_Add : Form
    {
        #region Declarations
        public frm_Main Main;
        G.FRM_Search s = new G.FRM_Search();
        DataRowView dr_Pur;

        public DataView dv_Items;
        public DataView dv_Item_Units;
        public DataView dv_Item_Prices;

        public DataGridView DGV;
        public int top;
        public Image Edit;
        public Image Search;
        public int rowindex;

        public bool edit;
        #endregion

        public FRM_Pur_Add()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Pur_Add_Shown(object sender, EventArgs e)
        {
            if (edit != true)
            {
                com_Item_Name.DataSource = dv_Items;
                com_Item_Name.SelectedValue = -1;
                com_Unit.DataSource = dv_Item_Units;
                com_Unit.SelectedValue = -1;
            }

            Top = top;
            btn_Item_Edit.Image = Edit;
            btn_Item_Search.Image = Search;

            edit = false;

            com_Item_Name.Focus();
        }
        #endregion

        #region GroupBox_Details

        // Itam_Name
        private void com_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Item_Name.SelectedValue == null ) { return; }
            foreach (DataRowView dr in dv_Items)
            {
                if (dr["Item_ID"].ToString() == com_Item_Name.SelectedValue.ToString())
                {
                    dr_Pur = dr;
                }
            }

            txt_Quan.Text = "1";
            dv_Item_Units.RowFilter = "Item_ID = '" + com_Item_Name.SelectedValue.ToString() + "'";
            com_Unit.SelectedIndex = (com_Unit.Items.Count > 0) ? 0 : -1;

            txt_Bonus.Text = "0";
            dv_Item_Prices.RowFilter = "Item_ID = '" + com_Item_Name.SelectedValue.ToString() + "' and Unit_ID = " + Convert.ToInt16(com_Unit.SelectedValue);
            txt_PPrice.Text = ((dv_Item_Prices.ToTable()).Rows.Count > 0) ? Convert.ToDecimal(dv_Item_Prices[0]["PPrice"]).ToString() : "";
            txt_SPrice.Text = ((dv_Item_Prices.ToTable()).Rows.Count > 0) ? Convert.ToDecimal(dv_Item_Prices[0]["SPrice1"]).ToString() : "";
            txt_Total.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal((txt_PPrice.Text) == "" ? "0" : txt_PPrice.Text), 2)).ToString();

            txt_Dis_Rate.Text = "0";
            txt_Dis_Value.Text = "0";

            txt_Quan.Select();
        }
        private void btn_Item_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن صنف";
            s.rad_Name.Checked = true;

            s.dt = dv_Items.ToTable();


            s.DGV.Columns[0].DataPropertyName = "Item_ID";
            s.DGV.Columns[1].DataPropertyName = "Anm";

            s.DGV.AutoGenerateColumns = false;
            s.DGV.DataSource = s.dt;
            s.ShowDialog();

            com_Item_Name.Text = s.txt;
        }
        private void com_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(edit == true) { return; }
            if (com_Item_Name.SelectedValue == null | com_Unit.SelectedValue == null) { return; }
            dv_Item_Prices.RowFilter = "Item_ID = '" + com_Item_Name.SelectedValue.ToString() + "' and Unit_ID = " + Convert.ToInt16(com_Unit.SelectedValue);
            txt_PPrice.Text = ((dv_Item_Prices.ToTable()).Rows.Count > 0) ? Convert.ToDecimal(dv_Item_Prices[0]["PPrice"]).ToString() : "";
            txt_SPrice.Text = ((dv_Item_Prices.ToTable()).Rows.Count > 0) ? Convert.ToDecimal(dv_Item_Prices[0]["SPrice1"]).ToString() : "";
        }
        private void com_Item_Name_Leave(object sender, EventArgs e)
        {
            //if (com_Item_Name.SelectedValue == null)
            //{
            //    MessageBox.Show("لم يتم تحديد صنف معين", "أختيار صنف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    com_Item_Name.Select();
            //}
        }
        // Quan
        private void txt_Quan_KeyPress(object sender, KeyPressEventArgs e)
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

            // if press +  if enter
            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Bonus.Focus();
            }
        }
        private void txt_Quan_TextChanged(object sender, EventArgs e)
        {
            if (edit == true) { return; }
            if (txt_Quan.Text == "" | txt_Quan.Text == ".") { return; }
            if (txt_PPrice.Text == "" | txt_PPrice.Text == ".") { return; }

            txt_Total.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_PPrice.Text), 2)).ToString();
        }
        private void txt_Quan_Leave(object sender, EventArgs e)
        {
            if (com_Item_Name.SelectedValue == null) { return; }

            if (txt_Quan.Text == "" || txt_Quan.Text == ".") { txt_Quan.Text = "1"; }
            if (Convert.ToDecimal(txt_Quan.Text) == 0) { txt_Quan.Text = "1"; }
            if (txt_Quan.Text == "1") { txt_Total.Text = txt_PPrice.Text; }
        }

        // Bonus
        private void txt_Bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_PPrice.Focus();
            }
        }
        private void txt_Bonus_Leave(object sender, EventArgs e)
        {

            if (txt_Bonus.Tag.ToString() != "+" && txt_Bonus.Text == "" || txt_Bonus.Text == ".")
            {
                txt_Bonus.Text = "0";
            }
            else
            {
                txt_Bonus.Tag = "";
            }
        }

        // PPrice
        private void txt_PPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);

            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_SPrice.Focus();
            }
        }
        private void txt_PPrice_TextChanged(object sender, EventArgs e)
        {
            if (edit == true) { return; }
            if (txt_PPrice.Text == "" | txt_PPrice.Text == ".") { return; }

            if (Convert.ToDecimal(txt_PPrice.Text) == 0) { return; }

            txt_Total.Text = (Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_PPrice.Text), 2)).ToString();
        }
        private void txt_PPrice_Leave(object sender, EventArgs e)
        {

            if (txt_PPrice.Tag.ToString() != "+" && txt_PPrice.Text == "" || txt_PPrice.Text == ".")
            {
                txt_PPrice.Text = "0";
                txt_PPrice.Tag = "";
            }
        }

        // SPrice
        private void txt_SPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Numbers Only
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Dis_Rate.Focus();
            }
        }
        private void txt_SPrice_Leave(object sender, EventArgs e)
        {

            if (txt_SPrice.Tag.ToString() != "+" && txt_SPrice.Text == "" || txt_SPrice.Text == ".")
            {
                txt_SPrice.Text = "0";
                txt_SPrice.Tag = "";
            }
        }

        // Total
        private void txt_Total_TextChanged(object sender, EventArgs e)
        {
            if (edit == true) { return; }
            if (txt_Total.Text == "" | txt_Total.Text == ".") { return; }
                if (Convert.ToDecimal(txt_Total.Text) != 0)
            {
                if (txt_Dis_Value.Text == "" | txt_Dis_Value.Text == ".")
                {
                    txt_Dis_Value.Text = "0";
                    txt_Dis_Rate.Text = "0";
                }
                else
                {
                    txt_Dis_Rate.Text = (Math.Round((Convert.ToDecimal(txt_Dis_Value.Text) / Convert.ToDecimal(txt_Total.Text)) * 100, 2)).ToString();
                }
                txt_Item_Net.Text = (Math.Round((Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_Dis_Value.Text)), 2)).ToString();
            }
        }

        // Dis_Rate
        private void txt_Dis_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
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

            if (e.KeyChar == 043)
            {
                e.Handled = true;

                if (txt_Dis_Rate.Text == "" | txt_Dis_Rate.Text == ".")
                {
                    txt_Dis_Rate.Text = "0";
                }
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Dis_Value.Focus();
            }
        }
        private void txt_Dis_Rate_TextChanged(object sender, EventArgs e)
        {
            if (edit == true) { return; }
            if (txt_Dis_Rate.Focused && txt_Dis_Rate.Text != "" && txt_Dis_Rate.Text != ".")
            {
                if (Convert.ToDecimal(txt_Dis_Rate.Text) == 0)
                {
                    txt_Dis_Value.Text = "0";
                    txt_Item_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total.Text), 2)).ToString();
                }
                else
                {
                    txt_Dis_Value.Text = (Math.Round((Convert.ToDecimal(txt_Dis_Rate.Text) / 100) * Convert.ToDecimal(txt_Total.Text), 2)).ToString();
                    txt_Item_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_Dis_Value.Text), 2)).ToString();
                }
            }
        }
        private void txt_Dis_Rate_Leave(object sender, EventArgs e)
        {
            if (txt_Dis_Rate.Text == "" || txt_Dis_Rate.Text == ".")
            {
                txt_Dis_Rate.Text = "0";
                txt_Dis_Value.Text = "0";
            }
        }

        // Dis_Value
        private void txt_Dis_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
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

            if (e.KeyChar == 043 | e.KeyChar == 13)
            {
                e.Handled = true;

                if (txt_Dis_Value.Text == "" || txt_Dis_Value.Text == ".")
                {
                    txt_Dis_Value.Text = "0";
                }
                btn_Add_Click(null, null);
            }
        }
        private void txt_Dis_Value_TextChanged(object sender, EventArgs e)
        {
            if (edit == true) { return; }
            if (txt_Dis_Value.Focused && txt_Dis_Value.Text != "" && txt_Dis_Value.Text != ".")
            {
                if (Convert.ToDecimal(txt_Dis_Value.Text) == 0)
                {
                    txt_Dis_Rate.Text = "0";
                    txt_Item_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total.Text), 2)).ToString();
                }
                else
                {
                    txt_Dis_Rate.Text = (Math.Round((Convert.ToDecimal(txt_Dis_Value.Text) / Convert.ToDecimal(txt_Total.Text)) * 100, 2)).ToString();
                    txt_Item_Net.Text = (Math.Round(Convert.ToDecimal(txt_Total.Text) - Convert.ToDecimal(txt_Dis_Value.Text), 2)).ToString();
                }
            }
        }
        private void txt_Dis_Value_Leave(object sender, EventArgs e)
        {

            if (txt_Dis_Value.Text == "" || txt_Dis_Value.Text == ".")
            {
                txt_Dis_Value.Text = "0";
                txt_Dis_Rate.Text = "0";
            }
        }

        // txt_Item_Net
        private void txt_Item_Net_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 043)
            {
                e.Handled = true;
                
            }
        }

        #endregion

        #region Controls

        private void btn_Item_Edit_Click(object sender, EventArgs e)
        {
            BasicData.FRM_Items i = new BasicData.FRM_Items(Main);
            i.FormBorderStyle = FormBorderStyle.Sizable;

            i.BackColor = Color.White;
            i.Width = 1100;
            i.Height = 800;
            i.WindowState = FormWindowState.Normal;
            i.StartPosition = FormStartPosition.CenterScreen;
            i.ShowDialog();
            com_Item_Name.SelectedValue = i.txt_Item_ID.Text;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Quan.Text = (txt_Quan.Text.Trim() == "" | txt_Quan.Text.Trim() == ".") ? "1" : txt_Quan.Text.Trim();
            txt_Bonus.Text = (txt_Bonus.Text.Trim() == "" | txt_Bonus.Text.Trim() == ".") ? "0" : txt_Bonus.Text.Trim();
            txt_PPrice.Text = (txt_PPrice.Text.Trim() == "" | txt_PPrice.Text.Trim() == ".") ? "0" : txt_PPrice.Text.Trim();
            txt_SPrice.Text = (txt_SPrice.Text.Trim() == "" | txt_SPrice.Text.Trim() == ".") ? "0" : txt_SPrice.Text.Trim();
            txt_Dis_Rate.Text = (txt_Dis_Rate.Text.Trim() == "" | txt_Dis_Rate.Text.Trim() == ".") ? "0" : txt_Dis_Rate.Text.Trim();
            txt_Dis_Value.Text = (txt_Dis_Value.Text.Trim() == "" | txt_Dis_Value.Text.Trim() == ".") ? "0" : txt_Dis_Value.Text.Trim();

            if (com_Item_Name.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد الصنف", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Item_Name.Focus();
                com_Item_Name.DroppedDown = true;
                return;
            }

            if (Convert.ToDecimal(txt_PPrice.Text) == 0)
            {
                MessageBox.Show("يجب تحديد سعر الشراء", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_PPrice.Text = "";
                txt_PPrice.Focus();
                return;
            }

            if (btn_Add.Text != "تعديل")
            {
                DGV.Rows.Add();

                com_Item_Name.SelectedValue = -1;
                com_Unit.SelectedValue = -1;
                txt_Quan.Text = "";
                txt_Bonus.Text = "";
                txt_PPrice.Text = "";
                txt_SPrice.Text = "";
                txt_Total.Text = "";
                txt_Dis_Rate.Text = "";
                txt_Dis_Value.Text = "";
                txt_Dis_Value.Text = "";
                txt_Item_Net.Text = "";
            }
            else
            {
                DGV.Rows[rowindex].Cells["Item_ID"].Value = com_Item_Name.SelectedValue.ToString();
                DGV.Rows[rowindex].Cells["Item_Name"].Value = com_Item_Name.Text;
                DGV.Rows[rowindex].Cells["Unit"].Value = com_Unit.SelectedValue;
                DGV.Rows[rowindex].Cells["Item_Quan"].Value = txt_Quan.Text;
                DGV.Rows[rowindex].Cells["Bonus"].Value = txt_Bonus.Text;
                DGV.Rows[rowindex].Cells["Items_PPrice"].Value = txt_PPrice.Text;
                DGV.Rows[rowindex].Cells["Items_SPrice"].Value = txt_SPrice.Text;
                DGV.Rows[rowindex].Cells["Items_Total"].Value = txt_Total.Text;
                DGV.Rows[rowindex].Cells["Items_Dis_Rate"].Value = txt_Dis_Rate.Text;
                DGV.Rows[rowindex].Cells["Items_Dis_Value"].Value = txt_Dis_Value.Text;
                DGV.Rows[rowindex].Cells["Net"].Value = txt_Item_Net.Text;

                Hide();
            }
            com_Item_Name.Focus();
        }
        #endregion
    }
}
