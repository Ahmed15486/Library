using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Rep
{
    public partial class FRM_BS : Form
    {
        #region Declarations
        frm_Main Main;

        Rep.CLS_ACC_REP.BS BS = new Rep.CLS_ACC_REP.BS();


        DataTable dt_ACC;
        DataTable dt_BS;
        DataTable dt_BS_F;

        DataTable dt_branches = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();

        Color c;
        bool up;

        #endregion

        public FRM_BS(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Bill_Branche.Image = Main.imageList32.Images["branche_32.png"];
            btn_CC1.Image = Main.imageList32.Images["center1_32.png"];
            btn_CC2.Image = Main.imageList32.Images["center1_32.png"];

            button_Display.Image = Main.imageList48.Images["display_48.png"];

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

            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dt_BS;


            #region ContextMenuStrips
            // Branches
            combo_Bill_Branches.DataSource = dt_branches;
            lbl_bill_Branches.Text = combo_Bill_Branches.Text;
            btn_branche_del.Image = Main.imageList16.Images["close_16.png"];
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
            #endregion
            combo_Bill_Branches.SelectedValue = Main.combo_Branches.SelectedValue;

        }

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
            if (lbl_CC1.Text == "") { btn_cc1_del.Visible = false; }
        }

        private void lbl_CC2_TextChanged(object sender, EventArgs e)
        {
            if (lbl_CC2.Text == "") { btn_cc2_del.Visible = false; }
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

        private void btn_Bill_Branche_Click(object sender, EventArgs e)
        {
            if (combo_Bill_Branches.Enabled == true && up == false) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 267); }
            else if (combo_Bill_Branches.Enabled == true && up == true) { contextMenuStrip_branches.Show((btn_Bill_Branche.Right - contextMenuStrip_branches.Width - 3), 133); }
            btn_branche_del.Visible = true;
        }
        private void btn_CC1_Click(object sender, EventArgs e)
        {
            if (combo_CC1.Enabled == true && up == false) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 267); }
            if (combo_CC1.Enabled == true && up == true) { contextMenuStrip_cc1.Show((btn_CC1.Right - contextMenuStrip_cc1.Width - 3), 133); }
        }
        private void btn_branche_del_Click(object sender, EventArgs e)
        {
            combo_Bill_Branches.SelectedValue = -1;
            btn_branche_del.Visible = false;
        }
        private void btn_cc1_del_Click(object sender, EventArgs e)
        {
            combo_CC1.SelectedValue = -1;
            btn_cc1_del.Visible = false;
        }
        private void btn_CC2_Click(object sender, EventArgs e)
        {
            if (combo_CC2.Enabled == true && up == false) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 267); }
            if (combo_CC2.Enabled == true && up == true) { contextMenuStrip_cc2.Show((btn_CC2.Right - contextMenuStrip_cc2.Width - 3), 133); }
        }
        private void btn_cc2_del_Click(object sender, EventArgs e)
        {
            combo_CC2.SelectedValue = -1;
            btn_cc2_del.Visible = false;
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

        #endregion

        #region Form
        private void FRM_BS_Enter(object sender, EventArgs e)
        {
            if (Main.tab_Main.Visible == false && up == false) { up = true; }
            else if (Main.tab_Main.Visible == true && up == true) { up = false; }
            WindowState = FormWindowState.Normal;
            WindowState = (Parent != null) ? FormWindowState.Maximized : WindowState;

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }
            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (r.Cells["sub2"].Value != "")
                {
                    if (Convert.ToDecimal(r.Cells["sub2"].Value) == 0) { r.Cells["sub2"].Style.ForeColor = Color.Transparent; }
                }
                if (r.Cells["Main1"].Value != "")
                {
                    if (Convert.ToDecimal(r.Cells["Main1"].Value) == 0) { r.Cells["Main1"].Style.ForeColor = Color.Transparent; }
                }
            }
        }
        #endregion

        #region Controls
        private void button_Display_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            DGV.Columns[2].Visible = false;

            // Validate values
            if (dtp_form.Checked == false) { BS.date_From = "01/01/1753"; } else { BS.date_From = dtp_form.Value.Date.ToShortDateString(); }
            if (dtp_to.Checked == false) { BS.date_To = "12/31/9998"; } else { BS.date_To = dtp_to.Value.Date.ToShortDateString(); }
            if (combo_Bill_Branches.SelectedValue == null) { BS.Branche = "-1"; } else { BS.Branche = combo_Bill_Branches.SelectedValue.ToString(); }
            BS.CC1 = (combo_CC1.SelectedValue == null) ? "-1" : combo_CC1.SelectedValue.ToString();
            BS.CC2 = (combo_CC2.SelectedValue == null) ? "-1" : combo_CC2.SelectedValue.ToString();


            // Get data from database
            dt_BS = BS.View_BS_Select();

            #region الأصول المتداولة
            decimal d = 0;
            decimal c = 0;
            foreach (DataRow r in dt_BS.Rows)
            {
                if (r["Sheet_Parent"].ToString() == "1")
                {
                    DGV.Rows.Add("", r["ACC_Name"], Convert.ToDecimal(r["Debit"]) - Convert.ToDecimal(r["Credit"]), "", "");
                    d += Convert.ToDecimal(r["Debit"]);
                    c += Convert.ToDecimal(r["Credit"]);

                    DGV.Rows[DGV.Rows.Count - 1].Tag = "1";
                    DGV.Rows[DGV.Rows.Count - 1].Visible = false;
                }
            }
            decimal sa = d - c;
            DGV.Rows.Add("+", "الأصول المتداولة", "", sa, "");
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
            #endregion

            #region الأصول طويلة الأجل
            d = 0;
            c = 0;
            foreach (DataRow r in dt_BS.Rows)
            {
                if (r["Sheet_Parent"].ToString() == "0")
                {
                    DGV.Rows.Add("", r["ACC_Name"], Convert.ToDecimal(r["Debit"]) - Convert.ToDecimal(r["Credit"]), "", "");
                    d += Convert.ToDecimal(r["Debit"]);
                    c += Convert.ToDecimal(r["Credit"]);

                    DGV.Rows[DGV.Rows.Count - 1].Tag = "0";
                    DGV.Rows[DGV.Rows.Count - 1].Visible = false;
                }
            }
            decimal la = d - c;
            DGV.Rows.Add("+", "الأصول طويلة الأجل", "", la, "");
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
            #endregion

            #region إجمالي الأصول
            decimal Total_Assest = sa + la;
            DGV.Rows.Add("", "إجمالي الأصول", "", la, Total_Assest);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            #endregion

            #region الإلتزامات المتداولة
            d = 0;
            c = 0;
            foreach (DataRow r in dt_BS.Rows)
            {
                if (r["Sheet_Parent"].ToString() == "2")
                {
                    DGV.Rows.Add("", r["ACC_Name"], Convert.ToDecimal(r["Credit"]) - Convert.ToDecimal(r["Debit"]), "", "");
                    d += Convert.ToDecimal(r["Debit"]);
                    c += Convert.ToDecimal(r["Credit"]);

                    DGV.Rows[DGV.Rows.Count - 1].Tag = "2";
                    DGV.Rows[DGV.Rows.Count - 1].Visible = false;
                }
            }
            decimal sl = c - d;
            DGV.Rows.Add("+", "الإلتزامات المتداولة", "", sl, "");
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.IndianRed;
            #endregion

            #region حقوق الملكية
            d = 0;
            c = 0;
            foreach (DataRow r in dt_BS.Rows)
            {
                if (r["Sheet_Parent"].ToString() == "3")
                {
                    DGV.Rows.Add("", r["ACC_Name"], Convert.ToDecimal(r["Credit"]) - Convert.ToDecimal(r["Debit"]), "", "");
                    d += Convert.ToDecimal(r["Debit"]);
                    c += Convert.ToDecimal(r["Credit"]);

                    DGV.Rows[DGV.Rows.Count - 1].Tag = "3";
                    DGV.Rows[DGV.Rows.Count - 1].Visible = false;
                }
            }
            decimal Property_rights = c - d;
            DGV.Rows.Add("+", "حقوق الملكية", "", Property_rights, "");
            int pr_index = DGV.RowCount - 1;
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
            #endregion

            #region الإلتزامات طويلة الأجل
            d = 0;
            c = 0;
            foreach (DataRow r in dt_BS.Rows)
            {
                if (r["Sheet_Parent"].ToString() == "4")
                {
                    DGV.Rows.Add("", r["ACC_Name"], Convert.ToDecimal(r["Credit"]) - Convert.ToDecimal(r["Debit"]), "", "");
                    d += Convert.ToDecimal(r["Debit"]);
                    c += Convert.ToDecimal(r["Credit"]);

                    DGV.Rows[DGV.Rows.Count - 1].Tag = "4";
                    DGV.Rows[DGV.Rows.Count - 1].Visible = false;
                }
            }
            decimal ll = c - d;
            DGV.Rows.Add("+", "الإلتزامات طويلة الأجل", "", ll, "");
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.IndianRed;
            #endregion

            #region إجمالي الخصوم
            decimal Total_liabilities = sl + Property_rights + ll;
            DGV.Rows.Add("", "إجمالي الخصوم", "", la, Total_liabilities);
            int TL_Index = DGV.RowCount - 1;
            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 10);
            #endregion

            #region صافي الدخل
            decimal Net_Income;
            Net_Income = Total_Assest - Total_liabilities;
            DataGridViewRow row = (DataGridViewRow)DGV.RowTemplate.Clone();
            row.CreateCells(DGV, "", "صافي الدخل", Net_Income,"", "");
            row.Tag = "3";
            row.Visible = false;

            // تعديل حقوق الملكية بصافي الدخل
            Property_rights += Net_Income;
            DGV.Rows[pr_index].Cells[3].Value = Property_rights;

            // تعديل الخصوم بصافي الدخل
            Total_liabilities += Net_Income;
            DGV.Rows[TL_Index].Cells[4].Value = Total_liabilities;

            DGV.Rows.Insert(pr_index, row);

            #endregion

            #region رأس المال العامل وإجمالي الإستثمار
            decimal Working_capital = sa - sl;
            lbl_Working_capital.Text = Working_capital.ToString();

            decimal Total_Investment = la + Working_capital;
            lbl_Total_Investment.Text = Total_Investment.ToString();
            #endregion

            DGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

            Main.tab_Main.Visible = false;
            FRM_BS_Enter(null, null);
        }
        private void dtp_form_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_form.Checked == true) { dtp_form.Format = DateTimePickerFormat.Short; }
        }
        private void dtp_form_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtp_form.Checked == true) { dtp_form.Format = DateTimePickerFormat.Short; }
            if (dtp_form.Checked == false) { dtp_form.Format = DateTimePickerFormat.Custom; }
        }
        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_to.Checked == true) { dtp_to.Format = DateTimePickerFormat.Short; }
        }
        private void dtp_to_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtp_to.Checked == true) { dtp_to.Format = DateTimePickerFormat.Short; }
            if (dtp_to.Checked == false) { dtp_to.Format = DateTimePickerFormat.Custom; }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Main.BS_Form_Open = false;
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
        private void DGV_BS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (DGV.Columns[e.ColumnIndex].DataPropertyName == "Debit" || DGV.Columns[e.ColumnIndex].DataPropertyName == "Credit")
            //{
            //    decimal value = (decimal)e.Value;
            //    if (value == 0)
            //    {
            //        e.Value = string.Empty;
            //        e.FormattingApplied = true;
            //    }
            //}
        }
        private void DGV_BS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Rep.FRM_ACC_St ACC_Set = new Rep.FRM_ACC_St(Main);
            //ACC_Set.FormBorderStyle = FormBorderStyle.Sizable;
            //ACC_Set.StartPosition = FormStartPosition.CenterScreen;
            //ACC_Set.Height = 700;
            //ACC_Set.Width = 975;

            //string t = DGV.CurrentRow.Cells["ACC_ID"].Value.ToString();
            //ACC_Set.comboBox_ACC_ID.SelectedValue = t;
            //ACC_Set.button_Display_Click(null, null);
            //ACC_Set.ShowDialog();
        }
        private void DGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            c = DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
        }
        private void DGV_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = c;
        }
        #endregion

        #region Footer
        private void TextBox_Total_Balance_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(TextBox_Total_Balance.Text) < 0)
            //{ 
            //    TextBox_Total_Balance.ForeColor = Color.Red;
            //    TextBox_Total_Balance.BackColor = Color.WhiteSmoke;
            //}
        }
        #endregion

        #region DGV
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region الأصول ويلة الأجل
            if (e.ColumnIndex == 0 & DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "الأصول ويلة الأجل")
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "+")
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "0") { r.Visible = true; }
                    }
                    DGV.Columns[2].Visible = true;
                }
                else
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "+";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "0") { r.Visible = false; }
                    }
                }
            }
            #endregion

            #region الأصول المتداولة
            else if (e.ColumnIndex == 0 & DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "الأصول المتداولة")
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "+")
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "1") { r.Visible = true; }
                    }
                    DGV.Columns[2].Visible = true;
                }
                else
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "+";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "1") { r.Visible = false; }
                    }
                }
            }
            #endregion

            #region الإلتزامات المتداولة
            else if (e.ColumnIndex == 0 & DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "الإلتزامات المتداولة")
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "+")
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "2") { r.Visible = true; }                       
                    }
                    DGV.Columns[2].Visible = true;
                }
                else
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "+";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "2") { r.Visible = false; }
                    }
                }
            }
            #endregion

            #region حقوق الملكية
            else if (e.ColumnIndex == 0 & DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "حقوق الملكية")
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "+")
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "3") { r.Visible = true; }
                    }
                    DGV.Columns[2].Visible = false;
                }
                else
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "+";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "3") { r.Visible = false; }
                    }
                }
            }
            #endregion

            #region الإلتزامات طويلة الأجل
            else if (e.ColumnIndex == 0 & DGV.Rows[e.RowIndex].Cells[1].Value.ToString() == "الإلتزامات طويلة الأجل")
            {
                if (DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "+")
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "4") { r.Visible = true; }
                    }
                    DGV.Columns[2].Visible = false;
                }
                else
                {
                    DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "+";
                    foreach (DataGridViewRow r in DGV.Rows)
                    {
                        if (r.Tag == "4") { r.Visible = false; }
                    }
                }
            }
            #endregion

            DGV.CurrentRow.Selected = false;

            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (r.Cells[0].Value.ToString() != "-")
                {
                    continue;
                }
                else
                {
                    DGV.Columns[2].Visible = true;
                    break;
                }
            }
        }
        #endregion
    }
}
