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
    public partial class FRM_TB : Form
    {
        #region Declarations
        frm_Main Main;

        Rep.CLS_ACC_REP.TB TB = new Rep.CLS_ACC_REP.TB();


        DataTable dt_ACC;
        DataTable dt_TB;

        DataTable dt_branches = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();

        Color c;
        bool up;

        #endregion

        public FRM_TB(frm_Main main)
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

            dt_ACC = Main.dt_ACC.Clone();
            foreach (DataRow dr in Main.dt_ACC.Rows)
            {
                if (Convert.ToInt32(dr["Is_Parent"]) == 1) { dt_ACC.Rows.Add(dr.ItemArray); }
            }

            comboBox_ACC_ID.DataSource = dt_ACC;
            comboBox_ACC_ID.SelectedValue = -1;
            comboBox_ACC_Name.DataSource = dt_ACC;
            comboBox_ACC_Name.SelectedValue = -1;
            com_Level.SelectedIndex = 4;

            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dt_TB;


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
        private void chk_Only_Balances_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns[2].Visible = (chk_Only_Balances.Checked == false) ? true : false;
            DGV.Columns[3].Visible = (chk_Only_Balances.Checked == false) ? true : false;
            DGV.Columns[4].Visible = (chk_Only_Balances.Checked == false) ? true : false;
            DGV.Columns[5].Visible = (chk_Only_Balances.Checked == false) ? true : false;
        }
        #endregion

        #region Form
        private void FRM_TB_Enter(object sender, EventArgs e)
        {
            if (Main.tab_Main.Visible == false && up == false) { up = true; }
            else if (Main.tab_Main.Visible == true && up == true) { up = false; }
            WindowState = FormWindowState.Normal;
            WindowState = (Parent != null) ? FormWindowState.Maximized : WindowState;
        }
        private void FRM_TB_Shown(object sender, EventArgs e)
        {
            btn_com_acc_Delete.Image = Main.imageList16.Images["close_16.png"];
            btn_com_acc_Search.Image = Main.imageList16.Images["Search_16.png"];
        }
        #endregion

        #region Controls
        private void button_Display_Click(object sender, EventArgs e)
        {
            // Validate values
            TB.aCC_ID = (comboBox_ACC_Name.SelectedValue == null)? "-1": comboBox_ACC_Name.SelectedValue.ToString();
            TB.date_From = (dtp_form.Checked == false)? "01/01/1753" : dtp_form.Value.Date.ToString();
            TB.date_To = (dtp_to.Checked == false)? "12/31/9998" : dtp_to.Value.Date.ToString();
            TB.Branche = (combo_Bill_Branches.SelectedValue == null)? "-1" : combo_Bill_Branches.SelectedValue.ToString();
            TB.CC1 = (combo_CC1.SelectedValue == null) ? "-1" : combo_CC1.SelectedValue.ToString();
            TB.CC2 = (combo_CC2.SelectedValue == null) ? "-1" : combo_CC2.SelectedValue.ToString();
            TB.Level = (com_Level.SelectedIndex + 1).ToString();

            // Get data from database
            dt_TB = TB.View_TB_Select();


            DGV.DataSource = null;
            DGV.DataSource = dt_TB;

            // Balance & Record Colors
            foreach (DataGridViewRow r in DGV.Rows)
            {
                r.Cells["Balance_Debit"].Value = Convert.ToDecimal(r.Cells["Open_Debit"].Value) + Convert.ToDecimal(r.Cells["Debit"].Value);
                r.Cells["Balance_Credit"].Value = Convert.ToDecimal(r.Cells["Open_Credit"].Value) + Convert.ToDecimal(r.Cells["Credit"].Value);

                if(r.Cells["P"].Value.ToString() == "1" )
                {
                    r.DefaultCellStyle.BackColor = Color.OldLace;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
            }

            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (Convert.ToDecimal(r.Cells["Open_Debit"].Value) == 0) { r.Cells["Open_Debit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Open_Credit"].Value) == 0) { r.Cells["Open_Credit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Debit"].Value) == 0) { r.Cells["Debit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Credit"].Value) == 0) { r.Cells["Credit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Balance_Debit"].Value) == 0) { r.Cells["Balance_Debit"].Style.ForeColor = Color.Transparent; }
                if (Convert.ToDecimal(r.Cells["Balance_Credit"].Value) == 0) { r.Cells["Balance_Credit"].Style.ForeColor = Color.Transparent; }
            }

            // Total Debit & Total Credit
            decimal od = 0;
            decimal oc = 0;
            decimal d = 0;
            decimal c = 0;
            decimal bd = 0;
            decimal bc = 0;
            foreach (DataGridViewRow dr in DGV.Rows)
            {
                od += Convert.ToDecimal(dr.Cells["Open_Debit"].Value);
                oc += Convert.ToDecimal(dr.Cells["Open_Credit"].Value);
                d += Convert.ToDecimal(dr.Cells["Debit"].Value);
                c += Convert.ToDecimal(dr.Cells["Credit"].Value);
                bd += Convert.ToDecimal(dr.Cells["Balance_Debit"].Value);
                bc += Convert.ToDecimal(dr.Cells["Balance_Credit"].Value);
            }

            txt_Total_Open_Debit.Text = od.ToString();
            txt_Total_Open_Credit.Text = oc.ToString();
            txt_Total_Debit.Text = d.ToString();
            txt_Total_Credit.Text = c.ToString();
            txt_Total_Balance_Debit.Text = bd.ToString();
            txt_Total_Balance_Credit.Text = bc.ToString();
            

            if (DGV.RowCount >= 1)
            {
               
            }

            // Rename parent tab
            if (Parent != null)
            {
                Parent.Text = "  ميزان المراجعة  " + comboBox_ACC_Name.Text + " ";
            }
            else
            {
                Text = "  ميزان المراجعة  " + comboBox_ACC_Name.Text + " ";
            }

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

            Main.tab_Main.Visible = false;
            FRM_TB_Enter(null, null);
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
            Main.TB_Form_Open = false;
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
        private void comboBox_ACC_Name_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_com_acc_Delete.Visible = (comboBox_ACC_Name.SelectedValue != null) ? true : false;
        }
        private void btn_com_acc_Delete_Click(object sender, EventArgs e)
        {
            comboBox_ACC_Name.SelectedValue = -1;
            btn_com_acc_Delete.Visible = false;
        }
        private void btn_com_acc_Search_Click(object sender, EventArgs e)
        {
            G.FRM_Search s = new G.FRM_Search();

            s.Text = "بحث عن حساب";
            s.rad_Name.Checked = true;

            s.dt = Main.ds.Tables[6].Clone();
            foreach (DataRow r in Main.ds.Tables[6].Rows)
            {
                if (Convert.ToBoolean(r["Is_Parent"]) == true)
                {
                    s.dt.Rows.Add(r.ItemArray);
                }
            }

            s.DGV.Columns[0].DataPropertyName = "ACC_ID";
            s.DGV.Columns[1].DataPropertyName = "ACC_Name";

            s.DGV.AutoGenerateColumns = false;
            s.DGV.DataSource = s.dt;
            s.ShowDialog();

            comboBox_ACC_Name.Text = s.txt;
        }
        #endregion

        #region Details
        private void DGV_TB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Rep.FRM_ACC_St ACC_Set = new Rep.FRM_ACC_St(Main);
            ACC_Set.FormBorderStyle = FormBorderStyle.Sizable;
            ACC_Set.StartPosition = FormStartPosition.CenterScreen;
            ACC_Set.Height = 700;
            ACC_Set.Width = 975;

            string t = DGV.CurrentRow.Cells["ACC_ID"].Value.ToString();
            ACC_Set.comboBox_ACC_ID.SelectedValue = t;
            ACC_Set.button_Display_Click(null, null);

            ACC_Set.ShowDialog();           
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
        private void textBox_Total_Balance_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(textBox_Total_Balance.Text) < 0)
            //{ 
            //    textBox_Total_Balance.ForeColor = Color.Red;
            //    textBox_Total_Balance.BackColor = Color.WhiteSmoke;
            //}
        }

        #endregion
    }
}
