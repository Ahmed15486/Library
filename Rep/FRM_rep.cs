using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Library.Rep
{
    public partial class FRM_rep : Form
    {
        #region Declarations
        CLS_REP rep = new CLS_REP();
        frm_Main Main;
        DateTimePicker dtp;
        DataTable dt_Rep_Info;
        DataTable dt_Rep;
        DataTable dt_Rep_D;
        DataTable dt_g;
        DataTable Temp_dgv;
        DataRow dr_Rep;
        DataRow dr_g;
        Microsoft.Office.Interop.Excel.Range myRange;
        Microsoft.Office.Interop.Excel.Range lastcol;
        Microsoft.Office.Interop.Excel.Range firstrow;

        string Rep_TABLE_NAME;
        string Rep_TABLE_SCHEMA;

        string select;
        string top;
        string from;
        string where;
        string condition;
        string nocondition;
        string Mcondition;
        string logcondition;
        string m;    
        string union;

        Color c;
        bool up;
        #endregion

        public FRM_rep(frm_Main main)
        {
            InitializeComponent();
            Main = main;

            btn_Display.Image = Main.imageList48.Images["display_48.png"];

            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dtp.Width = 120;
            DGV_1.Controls.Add(dtp);
            dtp.ValueChanged += this.dtp_Value_Changed;

            Rep_TABLE_NAME = Main.Rep_TABLE_NAME;
            Rep_TABLE_SCHEMA = Main.Rep_TABLE_SCHEMA;

            dt_Rep_Info = rep.Select_Rep_Info(Rep_TABLE_NAME, Rep_TABLE_SCHEMA);
            foreach (DataRow r in dt_Rep_Info.Rows)
            {
                list_Back.Items.Add(r[0].ToString());
            }


            dt_g = rep.Select_Rep("select * from Rep");
            dt_Rep_D = rep.Select_Rep("select * from Rep_D");
            dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + Main.combo_Users.SelectedValue.ToString());
            com_RepGenerator.DataSource = dt_g;
            com_RepGenerator.SelectedValue = -1;
            com_Fields.DataSource = dt_Rep_Info;

            if (com_RepGenerator.SelectedValue == null)
            {
                dt_Rep_D.DefaultView.RowFilter = string.Format("Rep_ID = -1 ");
            }
            else
            {
                dt_Rep_D.DefaultView.RowFilter = string.Format("Rep_ID = " + com_RepGenerator.SelectedValue.ToString());
            }
            DGV_1.AutoGenerateColumns = false;

            foreach (DataRow dr in dt_Rep_Info.Rows)
            {
               (DGV_1.Columns[0] as DataGridViewComboBoxColumn).Items.Add(dr[0].ToString());
            }
            

            Temp_dgv = table(1);
            DGV_1.DataSource = null;
            foreach (DataRow row in Temp_dgv.Rows)
            {
                DGV_1.Rows.Add();
                DGV_1.CurrentCell = DGV_1.Rows[0].Cells[0];

                DGV_1.CurrentRow.Cells[0].Value = row[0].ToString();
                DGV_1.CurrentRow.Cells[1].Value = row[1].ToString();
                DGV_1.CurrentRow.Cells[2].Value = row[2].ToString();
                DGV_1.CurrentRow.Cells[3].Value = row[3].ToString();
                DGV_1.CurrentRow.Cells[4].Value = row[4].ToString();
                DGV_1.CurrentRow.Cells[5].Value = row[5].ToString();
                DGV_1.CurrentRow.Cells[6].Value = row[6].ToString();

            }
            DGV_1.AllowUserToAddRows = true;     
        }

        #region Pro
        private string SELECT(int i)
        {
            select = "SELECT ";
            TOP();
            union = "";
            bool u = false;
            if (i > -1)
            {            
                foreach (string item in list_Forward.Items)
                {
                    com_Fields.Text = item;
                    if (com_Fields.SelectedValue.ToString() != "decimal" && item == DGV_1.Rows[i].Cells[0].Value.ToString())
                    {
                        select += ",[" + item + "] ";
                        union += ",null";
                    }                 
                    else
                    {
                        if (com_Fields.SelectedValue.ToString() == "decimal")
                        {
                            select += ",SUM([" + item + "]) as [" + item + "] ";

                            if(item == "الرصيد")
                            {
                                union += ",null";
                            }
                            else
                            {
                                union += ",SUM([" + item + "]) ";
                                u = true;
                            }
                        }
                    }                 
                }
            }
            else
            {              
                foreach (string item in list_Forward.Items)
                {
                    com_Fields.Text = item;
                    select += ",[" + item + "] ";
                    
                    if (com_Fields.SelectedValue.ToString() != "decimal")
                    {
                        union += ",null";
                    }
                    else
                    {
                        if (item == "الرصيد")
                        {
                            union += ",null";
                        }
                        else
                        {
                            union += ",SUM([" + item + "]) ";
                            u = true;
                        }
                    }
                }                          
            }
            if (u == false) { union = ""; }
            if(top == "")
            {
                return select.Substring(0, 7) + select.Substring(8);
            }
            else
            {
                select = select.Substring(0, 7) + top + select.Substring(8);
                return select;
            }
        }
        private string TOP()
        {
            top = "";
            if(rad_Only.Checked)
            {
                top = "TOP " + num_TopRecords.Value.ToString() + " ";
            }
            return top;
        }
        private string FROM()
        {
            return from = "\r\nFROM " + Rep_TABLE_NAME + " ";
        }
        private string WHERE()
        {
            where = "\r\nWHERE ";
            condition = "";
            for (int i = 0; i < DGV_1.Rows.Count; i++)
            {
                if(DGV_1.Rows[i].Cells[0].Value == null || DGV_1.Rows[i].Cells[2].Value == null || DGV_1.Rows[i].Cells[3].Value == null) { continue; }

                com_Fields.Text = DGV_1.Rows[i].Cells[0].Value.ToString();

                if (DGV_1.Rows[i].Cells[0].Value.ToString() != "" && DGV_1.Rows[i].Cells[2].Value.ToString() != "" && DGV_1.Rows[i].Cells[3].Value.ToString() != "")
                {
                    if (DGV_1.Rows[i].Cells[2].Value.ToString() == "يبدأ بـ")
                    {
                        where += log(i - 1) + "[" + DGV_1.Rows[i].Cells[0].Value.ToString() + "] " + no(i) + " LIKE '" + DGV_1.Rows[i].Cells[3].Value + "%' ";
                        Mcondition = "يبدأ بـ ";
                    }
                    else if (DGV_1.Rows[i].Cells[2].Value.ToString() == "يتضمن")
                    {
                        where += log(i - 1) + "[" + DGV_1.Rows[i].Cells[0].Value.ToString() + "] " + no(i) + " LIKE '%" + DGV_1.Rows[i].Cells[3].Value + "%' ";
                        Mcondition = "يتضمن ";
                    }
                    else if (com_Fields.SelectedValue.ToString() != "decimal")
                    {
                        where += log(i - 1) + "[" + DGV_1.Rows[i].Cells[0].Value.ToString() + "] " + no(i) + M(i) + "'" + DGV_1.Rows[i].Cells[3].Value + "' ";
                    }
                    else
                    {
                        where += log(i - 1) + "[" + DGV_1.Rows[i].Cells[0].Value.ToString() + "] " + no(i) + M(i) + DGV_1.Rows[i].Cells[3].Value + " ";
                    }

                    condition += logcondition + DGV_1.Rows[i].Cells[0].Value.ToString() + " " + nocondition + Mcondition + DGV_1.Rows[i].Cells[3].Value.ToString() + " ";
                }
            }

            if (where == "\r\nWHERE ") { where = ""; condition = ""; }
            return where;
        }
        private void ORDER_BY()
        {
            foreach (DataGridViewRow r in DGV_1.Rows)
            {
                if (r.Cells[6].Value != null && r.Cells[0].Value != null)
                {
                    if (r.Cells[6].Value.ToString() == "تصاعدياً")
                    {
                        dt_Rep.DefaultView.Sort = r.Cells[0].Value.ToString() + " ASC";
                        dt_Rep = dt_Rep.DefaultView.ToTable();
                    }
                    else if (r.Cells[6].Value.ToString() == "تنازلياً")
                    {
                        dt_Rep.DefaultView.Sort = r.Cells[0].Value.ToString() + " DESC";
                        dt_Rep = dt_Rep.DefaultView.ToTable();
                    }
                }
            }
        }
        private string UNION_ALL()
        {
            if (union == "")
            {
                from = "";
                where = "";
                return "";
            }
            else
            {
                return "\r\nUNION ALL \r\nSELECT " + union.Substring(1);
            }
        }

        private string no(int i)
        {
            nocondition = "";
            string n = "";
            if (i < 0) { return n; }

            if (Convert.ToBoolean(DGV_1.Rows[i].Cells[1].Value) == true)
            {
                n = "!";
                nocondition = "ليس ";
            }
            return n;
        }
        private string log(int i)
        {
            string l = "AND ";
            logcondition = "  و  ";
            if (i < 0) { l = ""; return l; }

            if (DGV_1.Rows[i].Cells[0].Value == null | DGV_1.Rows[i].Cells[2].Value == null | DGV_1.Rows[i].Cells[3].Value == null)
            {
                l = ""; return l;
            }

                if (DGV_1.Rows[i].Cells[4].Value != null)
            {
                if (DGV_1.Rows[i].Cells[4].Value.ToString() == "أو")
                {
                    l = "OR ";
                    logcondition = "  أو  ";
                }
            }
            return l;
        }
        private string M(int i)
        {
            m = "";
            switch (DGV_1.Rows[i].Cells[2].Value.ToString())
            {
                case "أختيار":
                    m = "= ";
                    Mcondition = "مساو لـ ";
                break;

                case "يبدأ بـ":
                    m = "= ";                  
                    break;

                case "مساو لـ":
                    m = "= ";
                    Mcondition = "مساو لـ ";
                    break;

                case "أكبر من":
                    m = "> ";
                    Mcondition = "أكبر من ";
                    break;

                case "أقل من":
                    m = "< ";
                    Mcondition = "أقل من ";
                    break;

                case "أكبر من أو يساوي":
                    m = ">= ";
                    Mcondition = "أكبر من أو يساوي ";
                    break;

                case "أقل من أو يساوي":
                    m = "<= ";
                    Mcondition = "أقل من أو يساوي ";
                    break;

                case "يتضمن":
                    m = "like ";                   
                    break;
            }           
            return m;
        }

        private void var()
        {
            rep.Name = txt_RepName.Text;
            rep.Content = Content();
            rep.Rep_View = Rep_TABLE_NAME;
            rep.Row_Count = (rad_Only.Checked)? Convert.ToInt16(num_TopRecords.Value) : 0;
            rep.Row_Index = chk_index.Checked;
            rep.Font_Size = Convert.ToInt16(num_FontSize.Value);
            rep.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
            rep.Rep_D = table();
        }
        private DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV_1.Columns)
            {
                if(col.Index == DGV_1.Columns.Count - 1) { break; }
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in DGV_1.Rows)
            {
                if(row.Cells[0].Value == null) { break; }
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.ColumnIndex == DGV_1.Columns.Count - 1) { break; }
                    if (cell.Value == null) { dRow[cell.ColumnIndex] = ""; }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        private string Content()
        {
            string c = "";
            foreach (string item in list_Forward.Items)
            {
                c += item + ",";
            }
            return c;
        }
        private DataTable table(int t)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in DGV_1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in DGV_1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) { dRow[cell.ColumnIndex] = null; }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            if (dt.Rows.Count > 0) { dt.Rows.RemoveAt(dt.Rows.Count - 1); }
            return dt;
        }
        private void DGV_Finish()
        {
            // حجم الخط
            DGV.DefaultCellStyle.Font = new Font("Tahoma",Convert.ToInt16(num_FontSize.Value));
            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
            DGV.RowTemplate.MinimumHeight = Convert.ToInt16(25 + (Convert.ToInt16(num_FontSize.Value) - 8));

            txt_Title.Text = txt_RepName.Text;
            if (condition == "")
            {
                txt_Condition.Visible = false;
                DGV.Dock = DockStyle.Fill;
            }
            else
            {
                txt_Condition.Visible = true;
                txt_Condition.Text = "     " + condition.Substring(5);
            }
            // الترقيم
            if (chk_index.Checked)
            {
                foreach (DataGridViewRow indexrow in DGV.Rows)
                {
                    indexrow.Cells[0].Value = indexrow.Index + 1;
                }
                DGV.Columns[0].Visible = true;
                DGV.Rows[DGV.RowCount - 1].Cells[0].Value = "";
            }
            else
            {
                DGV.Columns[0].Visible = false;
            }
        }

        #endregion

        #region Form
        private void FRM_rep_Enter(object sender, EventArgs e)
        {
            if (Main.tab_Main.Visible == false && up == false) { up = true; }
            else if (Main.tab_Main.Visible == true && up == true) { up = false; }
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }
        private void FRM_rep_Shown(object sender, EventArgs e)
        {
            if ((DGV_1.Rows[0].Cells[0] as DataGridViewComboBoxCell).Items.Count == 0)
            {
                foreach (DataRow r in dt_Rep_Info.Rows)
                {
                    list_Back.Items.Add(r[0].ToString());
                    (DGV_1.Rows[0].Cells[0] as DataGridViewComboBoxCell).Items.Add(r[0].ToString());
                }
            }
        }
        #endregion

        #region Controls

        #region fields
        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (list_Back.SelectedItem != null)
            {
                list_Forward.Items.Add(list_Back.SelectedItem);
                list_Back.Items.Remove(list_Back.SelectedItem);        
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                list_Back.Items.Add(list_Forward.SelectedItem);
                list_Forward.Items.Remove(list_Forward.SelectedItem);
            }
        }
        private void btn_ForwardAll_Click(object sender, EventArgs e)
        {
            list_Forward.Items.AddRange(list_Back.Items);
            list_Back.Items.Clear();
        }
        private void btn_BackAll_Click(object sender, EventArgs e)
        {
            list_Back.Items.AddRange(list_Forward.Items);
            list_Forward.Items.Clear();
        }
        private void list_Back_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Forward_Click(null, null);
        }
        private void list_Forward_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Back_Click(null, null);
        }

        private void btn_MoveFirst_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(0, list.Items[0]);
                list_Forward.SelectedIndex = i;
            }
        }
        private void btn_MoveLast_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(list_Forward.Items.Count, list.Items[0]);
                list_Forward.SelectedIndex = i;
            }
        }
        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            if (list_Forward.Items.Count <= 1) { return; }

            if (list_Forward.SelectedIndex >= 1)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(i - 1, list.Items[0]);
                list_Forward.SelectedIndex = i - 1;
            }
        }
        private void btn_MoveDowen_Click(object sender, EventArgs e)
        {
            if (list_Forward.Items.Count <= 1) { return; }

            if (list_Forward.SelectedIndex <= list_Forward.Items.Count - 2)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(i + 1, list.Items[0]);
                list_Forward.SelectedIndex = i + 1;
            }
        }
        #endregion

        private void btn_SaveRep_Click(object sender, EventArgs e)
        {
            if(list_Forward.Items.Count == 0) { MessageBox.Show("لا يوجد حقول بالتقرير", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            if (txt_RepName.TextLength == 0) { MessageBox.Show("من فضلك أدخل أسم للتقرير", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            if(com_RepGenerator.Text == txt_RepName.Text)
            {
                if(MessageBox.Show("سيتم تعديل التقرير الحالي", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
            }

            var();

            string t = rep.Insert();
            if (t.Length > 6)
            {
                if (t.Substring(0, 6) == "SQL : ")
                {
                    MessageBox.Show(t, "! حفظ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            // fill combo
            dt_g = rep.Select_Rep("select * from Rep");
            dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + Main.combo_Users.SelectedValue.ToString());
            dt_Rep_D = rep.Select_Rep("select * from Rep_D");
            com_RepGenerator.DataSource = dt_g;
            com_RepGenerator.Text = txt_RepName.Text;

            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_RepDelete_Click(object sender, EventArgs e)
        {
            if (com_RepGenerator.SelectedValue != null)
            {
                rep.Rep_ID = Convert.ToInt16(com_RepGenerator.SelectedValue);
                string t = rep.Delete();

                // fill combo
                dt_g = rep.Select_Rep("select * from Rep");
                dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + Main.combo_Users.SelectedValue.ToString());
                com_RepGenerator.DataSource = dt_g;
                com_RepGenerator.SelectedValue = -1;

                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void com_RepGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_RepGenerator.Focused)
            {
                txt_RepName.Text = com_RepGenerator.Text;
                foreach (DataRow r in dt_g.Rows)
                {
                    if (r["Rep_ID"].ToString() == com_RepGenerator.SelectedValue.ToString())
                    {
                        dr_g = r;
                        break;
                    }
                }
                if (dr_g == null) { return; }

                // Contents
                list_Forward.Items.Clear();
                list_Back.Items.Clear();
                foreach (DataRow r in dt_Rep_Info.Rows)
                {
                    list_Back.Items.Add(r[0].ToString());
                }

                string c = dr_g["Contents"].ToString();
                string n = "";
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == ',')
                    {
                        for (int p = 0; p < list_Back.Items.Count; p++)
                        {
                            if (list_Back.Items[p].ToString() == n)
                            {
                                list_Back.SelectedIndex = p;
                                btn_Forward_Click(null, null);
                                break;
                            }
                        }
                        n = "";
                        continue;
                    }
                    n += c[i];
                }

                // Row_Count
                if (Convert.ToInt16(dr_g["Row_Count"]) != 0)
                {
                    rad_Only.Checked = true;
                    num_TopRecords.Value = Convert.ToInt16(dr_g["Row_Count"]);
                }
                else
                {
                    rad_AllRecords.Checked = true;
                }

                // Row_Index
                chk_index.Checked = Convert.ToBoolean(dr_g["Row_Index"]);

                // Font_Size
                num_FontSize.Value = Convert.ToInt16(dr_g["Font_Size"]);

                dt_Rep_D.DefaultView.RowFilter = string.Format("Rep_ID = " + com_RepGenerator.SelectedValue.ToString());
                DGV_1.DataSource = dt_Rep_D;

                Temp_dgv = table(1);
                DGV_1.DataSource = null;

                if (Temp_dgv.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    foreach (DataRow row in Temp_dgv.Rows)
                    {
                        DGV_1.Rows.Add();
                    }
                }

                int h = 0;
                foreach (DataRow row in Temp_dgv.Rows)
                {
                    DGV_1.Rows[h].Cells[0].Value = row[0].ToString();
                    DGV_1.Rows[h].Cells[1].Value = row[1].ToString();
                    DGV_1.Rows[h].Cells[2].Value = row[2].ToString();
                    DGV_1.Rows[h].Cells[3].Value = row[3].ToString();
                    DGV_1.Rows[h].Cells[4].Value = row[4].ToString();
                    DGV_1.Rows[h].Cells[5].Value = row[5].ToString();
                    DGV_1.Rows[h].Cells[6].Value = row[6].ToString();
                    DGV_1.Rows[h].Cells[7].Value = "X";
                    h++;
                }
                DGV_1.AllowUserToAddRows = true;

                foreach (DataGridViewRow rr in DGV_1.Rows)
                {
                    if (rr.Cells[0].Value != null && rr.Cells[2].Value.ToString() == "أختيار")
                    {
                        string s = rr.Cells[3].Value.ToString();
                        rr.Cells[3] = new DataGridViewComboBoxCell();
                        DataGridViewComboBoxCell box = new DataGridViewComboBoxCell();
                        box = (DataGridViewComboBoxCell)rr.Cells[3];
                        box.DataSource = rep.Select("select DISTINCT [" + rr.Cells[0].Value.ToString() + "] from " + Rep_TABLE_NAME);
                        box.DisplayMember = rr.Cells[0].Value.ToString();
                        rr.Cells[3].Value = s;
                    }
                }
            }
        }
        private void button_Display_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_Forward.Items.Count == 0)
                {
                    DGV.Columns.Clear();
                    return;
                }

                #region Group By
                foreach (DataGridViewRow r in DGV_1.Rows)
                {
                    if (r.Cells[5].Value != null && r.Cells[0].Value != null)
                    {
                        if (Convert.ToBoolean(r.Cells[5].Value) == true)
                        {
                            txt_SQL.Text = SELECT(r.Cells[5].RowIndex) + FROM() + WHERE() + "Group By [" + r.Cells[0].Value + "] " + UNION_ALL() + from + where;

                            dt_Rep = rep.Select(txt_SQL.Text);
                            DGV.DataSource = null;

                            DataRow total_rowG = dt_Rep.NewRow();
                            total_rowG.ItemArray = dt_Rep.Rows[dt_Rep.Rows.Count - 1].ItemArray;
                            dt_Rep.Rows.RemoveAt(dt_Rep.Rows.Count - 1);
                            ORDER_BY();
                            dt_Rep.Rows.Add(total_rowG.ItemArray);
                            DGV.DataSource = dt_Rep;

                            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                            if (union == "")
                            {
                                dt_Rep.Rows.Add();
                            }

                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Silver;

                            Main.tab_Main.Visible = false;
                            FRM_rep_Enter(null, null);

                            txt_Title.Text = txt_RepName.Text;
                            if (condition == "")
                            {
                                txt_Condition.Visible = false;
                                DGV.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                txt_Condition.Visible = true;
                                txt_Condition.Text = "     " + condition.Substring(5);
                            }
                            DGV_Finish();
                            return;
                        }
                    }
                }
                #endregion

                #region Normal
                txt_SQL.Text = SELECT(-1) + FROM() + WHERE() + UNION_ALL() + from + where;

                dt_Rep = rep.Select(txt_SQL.Text);
                DGV.DataSource = null;

                DataRow total_row = dt_Rep.NewRow();
                total_row.ItemArray = dt_Rep.Rows[dt_Rep.Rows.Count - 1].ItemArray;
                dt_Rep.Rows.RemoveAt(dt_Rep.Rows.Count - 1);

                ORDER_BY();
                dt_Rep.Rows.Add(total_row.ItemArray);
                DGV.DataSource = dt_Rep;

                if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                if (union == "")
                {
                    dt_Rep.Rows.Add();
                }

                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Silver;

                Main.tab_Main.Visible = false;
                DGV_Finish();
                FRM_rep_Enter(null, null);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Report",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }         
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            if (Main.tabForms.TabPages.Count > 1)
            {
                if (Main.tabForms.SelectedIndex == Main.tabForms.TabCount - 1)
                {
                    Main.tabForms.SelectedIndex--;
                }
                else { Main.tabForms.SelectedIndex++; }
            }
            else if (Main.tabForms.TabCount == 1 && Main.tab_Main.Visible == false)
            {
                Main.btn_UpDowen_Click(null, null);
            }
            if (this.Parent != null) { Parent.Dispose(); }
            else { this.Dispose(); }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0) { return; }
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DefaultSheetDirection = (int)DGV.RightToLeft;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 4;
                int j = 0, i = 0;
                int indexcol = 0;
                if (DGV.Columns[0].Visible == true) { indexcol = 0; } else { indexcol = 1; }

                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", "Z10000"];
                myRange.RowHeight = 20;
                myRange.HorizontalAlignment = 3;
                myRange.VerticalAlignment = 2;
                myRange.Font.Name = "Tahoma";
                myRange.Font.Size = 8;

                // Report Title
                if (txt_Title.Text != "")
                {
                    lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, DGV.ColumnCount - indexcol];
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
                    myRange.MergeCells = true;
                    myRange.Value2 = txt_Title.Text;
                    myRange.RowHeight = 30;
                    myRange.HorizontalAlignment = 3;
                    myRange.VerticalAlignment = 2;
                    myRange.Interior.Color = txt_Title.BackColor;
                    myRange.Font.Name = "Tahoma";
                    myRange.Font.Color = txt_Title.ForeColor;
                    myRange.Font.Size = 12;
                }
                else
                {
                    StartRow--;
                }

                // Report Conditions
                lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, DGV.ColumnCount - indexcol];
                firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, 1];

                if (txt_Condition.Visible == true)
                {
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, lastcol];
                    myRange.MergeCells = true;
                    myRange.Value2 = txt_Condition.Text;
                    myRange.RowHeight = 30;
                    myRange.HorizontalAlignment = 1;
                    myRange.Interior.Color = txt_Condition.BackColor;
                    myRange.Font.Color = txt_Condition.ForeColor;
                }
                else
                {
                    StartRow--;
                }

                //Write Headers                
                for (j = 1; j <= DGV.Columns.Count - indexcol; j++)
                {
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 1, j];
                    myRange.Value2 = DGV.Columns[j + indexcol - 1].HeaderText;
                    myRange.RowHeight = 30;
                    myRange.ColumnWidth = DGV.Columns[j + indexcol - 1].Width / 6;
                    myRange.Font.Size = 10;
                    myRange.Font.FontStyle = FontStyle.Bold;
                    myRange.Borders.Color = Color.Gray;
                    myRange.Interior.Color = Color.Silver;
                }

                //Write datagridview content
                for (i = 0; i < DGV.Rows.Count; i++)
                {
                    for (j = 0; j < DGV.Columns.Count - indexcol; j++)
                    {
                        myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = DGV[j + indexcol, i].Value == null ? "" : DGV[j + indexcol, i].Value.ToString();

                    }

                    firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, 1];
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, myRange];
                    myRange.Borders.Color = Color.Gray;

                    if ((i % 2) > 0)
                    {
                        myRange.Interior.Color = Color.OldLace;
                    }
                    if (i == DGV.Rows.Count - 1)
                    {
                        myRange.Font.Color = Color.Navy;
                        myRange.Interior.Color = Color.Silver;
                        myRange.Font.Size = 10;
                    }
                }

                lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[DGV.RowCount + StartRow - 1, DGV.ColumnCount - indexcol];
                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
                myRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DGV_1
        private void DGV_1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(DGV_1.CurrentCell == null || DGV_1.Focused == false) { return; }

            if(e.ColumnIndex == 2 & DGV_1.CurrentRow.Cells[0].Value != null || e.ColumnIndex == 0 & DGV_1.CurrentRow.Cells[2].Value != null)
            {
                if (DGV_1.Focused)
                {
                    if (DGV_1.CurrentRow.Cells[2].Value.ToString() == "أختيار")
                    {
                        DGV_1.CurrentRow.Cells[3] = new DataGridViewComboBoxCell();
                        DataGridViewComboBoxCell box = new DataGridViewComboBoxCell();
                        box = (DataGridViewComboBoxCell)DGV_1.CurrentRow.Cells[3];
                        box.DataSource = rep.Select("select DISTINCT [" + DGV_1.CurrentRow.Cells[0].Value.ToString() + "] from " + Rep_TABLE_NAME);
                        box.DisplayMember = DGV_1.CurrentRow.Cells[0].Value.ToString();
                    }
                    else
                    {
                        DGV_1.CurrentRow.Cells[3] = new DataGridViewTextBoxCell();
                    }
                }   
            }
            else if (e.ColumnIndex == 6) // Order
            {
                if (DGV_1.CurrentCell != null)
                {
                    if (DGV_1.CurrentCell.Value != null)
                    {
                        if ((DGV_1.CurrentCell as DataGridViewComboBoxCell).Items.IndexOf(DGV_1.CurrentCell.Value) > -1)
                        {
                            for (int i = 0; i < DGV_1.Rows.Count-1; i++)
                            {
                                if(DGV_1.CurrentCell.RowIndex == i) { continue; }
                                DGV_1.Rows[i].Cells[6].Value = "";
                            }
                        }
                    }
                }
            }
        }
        private void DGV_1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox box = e.Control as ComboBox;
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.AutoCompleteSource = AutoCompleteSource.ListItems;
                box.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }
        private void DGV_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (DGV_1.CurrentRow.Index != DGV_1.Rows.Count - 1)
                {
                    DGV_1.Rows.Remove(DGV_1.CurrentRow);
                    dtp.Visible = false;
                }
            }
        }
        private void DGV_1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (DGV_1.Rows[e.RowIndex].Cells[0].Value == null || DGV_1.Rows[e.RowIndex].Cells[2].Value == null) { return; }
                if ((DGV_1.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell).Items.IndexOf(DGV_1.Rows[e.RowIndex].Cells[2].Value) == 0){ return;}

                com_Fields.Text = DGV_1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (DGV_1.Focused && DGV_1.CurrentCell.ColumnIndex == 3 && com_Fields.SelectedValue.ToString() == "datetime")
                {
                    dtp.Location = DGV_1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtp.Visible = true;

                    if (DGV_1.CurrentCell.Value != null)// إذا كان يوجد قيمة
                    {
                        DateTime temp;
                        if (DateTime.TryParse(DGV_1.CurrentCell.Value.ToString(), out temp))// هل القيمة تاريخ ؟
                        {
                            dtp.Value = temp;
                        }
                        else
                        {
                            dtp.Value = DateTime.Today;
                            dtp_Value_Changed(null, null);
                        }
                    }
                    else
                    {
                        dtp.Value = DateTime.Today;
                        dtp_Value_Changed(null, null);
                    }
                }
                else
                {
                    dtp.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV_1_CellEnter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void DGV_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
        }
        private void dtp_Value_Changed(object sender, EventArgs e)
        {
            DGV_1.CurrentCell.Value = dtp.Value.Date.ToString("yyyy/MM/dd");
        }
        #endregion

        #region DGV
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
