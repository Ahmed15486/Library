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
    public partial class FRM_ACC_St : Form
    {
        #region Declarations
        frm_Main Main;

        Rep.CLS_ACC_REP.ACC_ST ACC_St = new Rep.CLS_ACC_REP.ACC_ST();
        Bills.FRM_Jor Jor;
        Bills.FRM_Sal Sal;
        Bills.FRM_Pur Pur;
        Bills.FRM_Open Open;
        Bills.FRM_Tran Tran;
        Bills.FRM_Money_In Money_In;
        Bills.FRM_Money_Out Money_Out;

        DataTable dt_ACC;
        DataTable dt_ACC_St;
        DataTable dt_ACC_St_F;

        DataTable dt_branches = new DataTable();
        DataTable dt_cc1 = new DataTable();
        DataTable dt_cc2 = new DataTable();

        Color c;
        bool up;

        #endregion

        public FRM_ACC_St(frm_Main main)
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
                if (Convert.ToInt32(dr["Is_Parent"]) == 0) { dt_ACC.Rows.Add(dr.ItemArray); }     
            }
          
            comboBox_ACC_ID.DataSource = dt_ACC;
            comboBox_ACC_ID.SelectedValue = -1;
            comboBox_ACC_Name.DataSource = dt_ACC;
            comboBox_ACC_Name.SelectedValue = -1;

            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dt_ACC_St;

            
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

        private void lbl_bill_Branches_TextChanged(object sender, EventArgs e)
        {
            btn_branche_del.Visible = (lbl_bill_Branches.Text == "") ? false : true;
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
            Point p = btn_Bill_Branche.PointToScreen(Point.Empty);
            contextMenuStrip_branches.Show(p.X - (contextMenuStrip_branches.Width - btn_Bill_Branche.Width), p.Y + btn_Bill_Branche.Height);
        }
        private void btn_CC1_Click(object sender, EventArgs e)
        {
            Point p = btn_CC1.PointToScreen(Point.Empty);
            contextMenuStrip_cc1.Show(p.X - (contextMenuStrip_cc1.Width - btn_CC1.Width), p.Y + btn_CC1.Height);
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
            Point p = btn_CC2.PointToScreen(Point.Empty);
            contextMenuStrip_cc2.Show(p.X - (contextMenuStrip_cc2.Width - btn_CC2.Width), p.Y + btn_CC2.Height);
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
        private void FRM_ACC_St_Enter(object sender, EventArgs e)
        {
            if (Main.tab_Main.Visible == false && up == false) { up = true; }
            else if (Main.tab_Main.Visible == true && up == true) { up = false; }
            WindowState = FormWindowState.Normal;
            WindowState =(Parent != null)? FormWindowState.Maximized : WindowState;
        }
        private void FRM_ACC_St_Shown(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }
            btn_Acc_Search.Image = Main.imageList16.Images["Search_16.png"];

            if(Parent == null & DGV.RowCount > 0)
            {
                // Balance
                foreach (DataGridViewRow r in DGV.Rows)
                {
                    if (DGV.Rows[r.Index].Index >= 1)
                    {
                        r.Cells["Balance"].Value = Convert.ToDecimal(DGV.Rows[r.Index - 1].Cells["Balance"].Value) + (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                    }
                    else if (DGV.Rows[r.Index].Cells["Balance"].RowIndex >= 0)
                    {
                        r.Cells["Balance"].Value = (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                    }
                }
            }
        }
        private void FRM_ACC_St_ResizeEnd(object sender, EventArgs e)
        {
            Height = (Height < 700) ? 700 : Height;
            Width = (Width < 975) ? 975 : Width;
        }
        #endregion

        #region Controls
        private void btn_Acc_Search_Click(object sender, EventArgs e)
        {
            G.FRM_Search s = new G.FRM_Search();

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

            comboBox_ACC_Name.Text = s.txt;
        }
        public void button_Display_Click(object sender, EventArgs e)
        {
            if(comboBox_ACC_Name.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد حساب", "عرض كشف حساب", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Validate values
            if (comboBox_ACC_ID.SelectedValue == null) { ACC_St.aCC_ID = "-1"; } else { ACC_St.aCC_ID = comboBox_ACC_ID.SelectedValue.ToString(); }
            if (dtp_form.Checked == false) { ACC_St.date_From = "01/01/1753"; } else { ACC_St.date_From = dtp_form.Value.Date.ToString(); }
            if (dtp_to.Checked == false) { ACC_St.date_To = "12/31/9998"; } else { ACC_St.date_To = dtp_to.Value.Date.ToString(); }
            if (combo_Bill_Branches.SelectedValue == null) { ACC_St.Branche = "-1"; } else { ACC_St.Branche = combo_Bill_Branches.SelectedValue.ToString(); }          
            ACC_St.CC1 = (combo_CC1.SelectedValue == null)? "-1" : combo_CC1.SelectedValue.ToString();
            ACC_St.CC2 = (combo_CC2.SelectedValue == null) ? "-1" : combo_CC2.SelectedValue.ToString();

            // Get data from database
            dt_ACC_St = ACC_St.Rep_ACC_St_Select();

            // remove or leav first row of Open Balance
            if(dt_ACC_St.Rows[0]["Debit"].ToString() != "" & dt_ACC_St.Rows[0]["Credit"].ToString() != "")
            {
                if(Convert.ToDecimal(dt_ACC_St.Rows[0]["Debit"]) == 0 && Convert.ToDecimal(dt_ACC_St.Rows[0]["Credit"]) == 0)
                {
                    dt_ACC_St.Rows.RemoveAt(0);
                }
            }
            else
            {
                dt_ACC_St.Rows.RemoveAt(0);
            }


            DGV.DataSource = null;
            DGV.DataSource = dt_ACC_St;

            dt_ACC_St.DefaultView.Sort = "Jor_Date ASC";
            dt_ACC_St = dt_ACC_St.DefaultView.ToTable();

            // Balance
            foreach (DataGridViewRow r in DGV.Rows)
            {
                if (DGV.Rows[r.Index].Index >= 1)
                {
                    r.Cells["Balance"].Value = Convert.ToDecimal(DGV.Rows[r.Index - 1].Cells["Balance"].Value) + (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                }
                else if (DGV.Rows[r.Index].Cells["Balance"].RowIndex >= 0)
                {
                    r.Cells["Balance"].Value = (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                }
            }

            // Total Debit & Total Credit
            decimal d = 0;
            decimal c = 0;
            foreach (DataGridViewRow dr in DGV.Rows)
            {
                d += Convert.ToDecimal(dr.Cells["Debit"].Value);
                c += Convert.ToDecimal(dr.Cells["Credit"].Value);
            }

            textBox_Total_Debit.Text = d.ToString();
            textBox_Total_Credit.Text = c.ToString();
            textBox_Total_Balance.Text = (d - c).ToString();

            if (DGV.RowCount >= 1)
            {
                textBox_Total_Open.Text = (DGV.Rows[0].Cells["Notes"].Value.ToString() == "رصيد إفتتاحي") ? DGV.Rows[0].Cells["Balance"].Value.ToString() : "0.00";
            }

            // Rename parent tab
            if (Parent != null)
            {
                Parent.Text = "  كشف حساب  " + comboBox_ACC_Name.Text + " ";
            }
            else
            {
                Text = "  كشف حساب  " + comboBox_ACC_Name.Text + " ";
            }

            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

            Main.tab_Main.Visible = false;
            FRM_ACC_St_Enter(null, null);
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
            if (Parent != null)
            {
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
            else
            {
                Hide();
            }
        }
        #endregion

        #region Details
        private void DGV_ACC_St_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != DGV.Columns["Ref_No"].Index && DGV.CurrentRow.Cells["Jor_ID"].Value.ToString() != "")
            {
                Jor = new Bills.FRM_Jor(Main);
                string t = DGV.CurrentRow.Cells["Jor_ID"].Value.ToString();
                Jor.combo_Bill_Branches.SelectedValue = t.Substring(0, 3);
                Jor.ChangetxtSearch(t.Substring(4));
                Jor.FormBorderStyle = FormBorderStyle.Sizable;
                Jor.StartPosition = (WindowState == FormWindowState.Maximized)?FormStartPosition.CenterScreen : FormStartPosition.Manual;
                Jor.Location = (Parent == null) ? new Point(Location.X - 40, Location.Y + 45) : Jor.Location;
                Jor.Height = 700;
                Jor.Width = 975;

                Jor.Visible = false;
                Jor.ShowDialog();
            }
            else if(e.ColumnIndex == DGV.Columns["Ref_No"].Index)
            {
                if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "رصيد إفتتاحي")
                {
                    Open = new Bills.FRM_Open(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Open.ChangetxtSearch(t.Substring(4));
                }
                else if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "تحويل")
                {
                    Tran = new Bills.FRM_Tran(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Tran.ChangetxtSearch(t.Substring(4));
                }
                else if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "إستلام مشتريات")
                {
                    Pur = new Bills.FRM_Pur(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Pur.ChangetxtSearch(t.Substring(4));
                }
                else if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "فاتورة بيع")
                {
                    Sal = new Bills.FRM_Sal(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Sal.ChangetxtSearch(t.Substring(4));
                    Sal.Show();
                }
                else if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "سند قبض")
                {
                    Money_In = new Bills.FRM_Money_In(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Money_In.ChangetxtSearch(t.Substring(4));
                }
                else if (DGV.Rows[e.RowIndex].Cells["Ref_Type"].Value.ToString() == "سند صرف")
                {
                    Money_Out = new Bills.FRM_Money_Out(Main);
                    string t = DGV.CurrentRow.Cells["Ref_No"].Value.ToString();
                    Money_Out.ChangetxtSearch(t.Substring(4));
                    Money_Out.Show();
                }
            }
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
    }
}
