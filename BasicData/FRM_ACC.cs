using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library.BasicData
{
    public partial class FRM_ACC : Form
    {
        #region Declaration
        BL.CLS_ACC ACC = new BL.CLS_ACC();
        G.CLS_G G = new G.CLS_G();

        DataView dv_acc;
        DataView dv_cc1;
        DataView dv_cc2;

        DataTable ACC_Proper = new DataTable();

        DataRow r;
        bool up;
        string s;

        List<string> selected_node = new List<string>();
        bool expanded;

        frm_Main Main;
        #endregion

        public FRM_ACC(frm_Main main)
        {
            InitializeComponent();
            Main=main;
            ACC_Proper = Main.ds.Tables[25];
            com_ACC_Proper_Name.DataSource = ACC_Proper;

            dv_acc = new DataView(Main.ds.Tables[6]);
            dv_cc1 = new DataView(Main.ds.Tables[3]);
            dv_cc2 = new DataView(Main.ds.Tables[3]);

            com_Parent_ACC.DataSource = dv_acc;
            com_Parent_ACC.SelectedValue = -1;

            com_CC1.DataSource = dv_cc1;
            com_CC1.SelectedValue = -1;

            com_CC2.DataSource = dv_cc2;
            com_CC2.SelectedValue = -1;
        }

        #region Pro
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select_Node
                case "Select_Node":
                    if (tree.SelectedNode == null) { tree.SelectedNode = tree.Nodes[0]; }
                    lbl_Path.Text = tree.SelectedNode.FullPath;
                    lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                    tree.Enabled = true;
                    txt_ACC_Name.ReadOnly = true;
                    txt_Enm.ReadOnly = true;
                    com_Sheet.Enabled = false;
                    com_Sheet_Parent.Enabled = false;
                    com_ACC_Proper_Name.Enabled = false;
                    com_Parent_ACC.Enabled = false;
                    com_CC1.Enabled = false;
                    chk_CC1_Group.Enabled = false;
                    com_CC2.Enabled = false;
                    chk_CC2_Group.Enabled = false;
                    txt_Notes.ReadOnly = true;

                    foreach (DataRow dr in Main.ds.Tables[6].Rows)
                    {
                        if (dr["ACC_ID"].ToString() == tree.SelectedNode.Tag.ToString())
                        {
                            r = dr;
                            txt_ACC_ID.Text = r["ACC_ID"].ToString();
                            txt_Enm.Text = r["Enm"].ToString();
                                                       
                            chk_CC1_Group.Checked = Convert.ToBoolean(r["CC1_Group"]);
                            dv_cc1.RowFilter = "Is_Parent = " + chk_CC1_Group.Checked.ToString() + " and CC1 = 1";
                            com_CC1.SelectedValue = r["CC1"].ToString();                       
                            chk_CC2_Group.Checked = Convert.ToBoolean(r["CC2_Group"]);
                            dv_cc2.RowFilter = "Is_Parent = " + chk_CC2_Group.Checked.ToString() + " and CC2 = 1";
                            com_CC2.SelectedValue = r["CC2"].ToString();

                            com_Sheet.SelectedIndex = Convert.ToInt16(r["Sheet"]);
                            com_Sheet_Parent.SelectedIndex = (!r.IsNull("Sheet_Parent")) ? Convert.ToInt16(r["Sheet_Parent"]) : -1;
                            txt_ACC_Name.Text = r["ACC_Name"].ToString();
                            txt_Notes.Text = r["Notes"].ToString();
                            com_ACC_Proper_Name.SelectedValue = r["ACC_Proper_ID"];
                            com_Parent_ACC.SelectedValue = r["Parent_ID"];
                            break;
                        }
                    }
                    tree.SelectedNode.Text = txt_ACC_Name.Text;
                    tree.SelectedNode.Tag = txt_ACC_ID.Text;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = true;
                    button_Edit.Text = "تعديل";
                    button_Edit.Image = imageList1.Images["Edit"];
                    button_Delete.Visible = true;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;

                    Color_Nodes(tree.SelectedNode, Color.Red);

                    break;
                #endregion

                #region New_Main
                case "New_Main":
                    //Clare Controls
                    txt_ACC_ID.Clear();
                    txt_ACC_Name.Clear();
                    txt_Notes.Clear();

                    groupBox_ACC_Data.Enabled = true;
                    tree.Enabled = false;

                    txt_ACC_Name.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region New
                case "New":
                    //Clare Controls

                    txt_ACC_ID.Clear();
                    txt_ACC_Name.Clear();
                    txt_Notes.Clear();
                    com_ACC_Proper_Name.SelectedValue = -1;
                    com_Parent_ACC.SelectedValue = tree.SelectedNode.Tag;

                    txt_ACC_Name.ReadOnly = false;
                    txt_Enm.ReadOnly = false;
                    com_Sheet.Enabled = true;
                    com_Sheet_Parent.Enabled = true;
                    com_CC1.Enabled = true;
                    chk_CC1_Group.Enabled = true;
                    com_CC2.Enabled = true;
                    chk_CC2_Group.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    com_ACC_Proper_Name.Enabled = true;
                    com_Parent_ACC.Enabled = true;
                    tree.Enabled = false;

                    txt_ACC_Name.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;

                    txt_ACC_Name.Focus();
                    break;
                #endregion

                #region Edit
                case "Edit":

                    txt_ACC_Name.ReadOnly = false;
                    txt_Enm.ReadOnly = false;
                    com_Sheet.Enabled = true;
                    com_Sheet_Parent.Enabled = true;
                    com_ACC_Proper_Name.Enabled = true;
                    com_Parent_ACC.Enabled = true;
                    com_CC1.Enabled = true;
                    chk_CC1_Group.Enabled = true;
                    com_CC2.Enabled = true;
                    chk_CC2_Group.Enabled = true;
                    txt_Notes.ReadOnly = false;

                    tree.Enabled = false;

                    txt_ACC_ID.ReadOnly = true;

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

                    //Clare Controls
                    txt_ACC_ID.Clear();
                    txt_ACC_Name.Clear();
                    txt_Notes.Clear();

                    txt_ACC_Name.ReadOnly = true;
                    txt_Enm.ReadOnly = true;
                    com_Sheet.Enabled = false;
                    com_Sheet_Parent.Enabled = false;
                    com_ACC_Proper_Name.Enabled = true;
                    com_Parent_ACC.Enabled = true;
                    com_CC1.Enabled = false;
                    chk_CC1_Group.Enabled = false;
                    com_CC2.Enabled = false;
                    chk_CC2_Group.Enabled = false;
                    txt_Notes.ReadOnly = true;

                    tree.Enabled = true;

                    button_New.Visible = true;
                    button_New.Text = "جديد";
                    button_New.Image = imageList1.Images["New"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = false;
                    button_Close.Visible = true;

                    break;
                    #endregion

            }
        }
        private void Color_Nodes(TreeNode node, Color color)
        {
            if (node == null) { return; }
            node.ForeColor = color;
            if (node.Parent == null) { return; }

            node.Parent.ForeColor = color;
            Color_Nodes(node.Parent, color);
        }
        private void Fill()
        {
            tree.Nodes.Clear();
            foreach (DataRowView dr in dv_acc)
            {
                if (Convert.ToInt32(dr["ACC_Level"]) == 1)
                {
                    TreeNode Pnode = new TreeNode();
                    Pnode.Name = (dr["ACC_Name"].ToString());
                    Pnode.Text = (dr["ACC_Name"].ToString());
                    Pnode.Tag = dr["ACC_ID"].ToString();

                    if (Convert.ToBoolean(dr["Is_Parent"]) == true)
                    {
                        foreach (DataRowView r in dv_acc)
                        {
                            if (r["Parent_ID"].ToString() == Pnode.Tag.ToString())
                            {
                                TreeNode Cnode = new TreeNode();
                                Cnode.Name = r["ACC_Name"].ToString();
                                Cnode.Text = r["ACC_Name"].ToString();
                                Cnode.Tag = r["ACC_ID"].ToString();
                                Pnode.Nodes.Add(Cnode);
                            }
                        }
                    }
                    tree.Nodes.Add(Pnode);
                }
            }
        }

        private void var()
        {
            ACC.ACC_ID = txt_ACC_ID.Text;
            ACC.ACC_Name = txt_ACC_Name.Text;
            ACC.Enm = txt_Enm.Text;
            ACC.CC1 = (com_CC1.SelectedValue != null) ? com_CC1.SelectedValue.ToString() : null;
            ACC.CC2 = (com_CC2.SelectedValue != null) ? com_CC2.SelectedValue.ToString() : null;
            ACC.CC1_Group = chk_CC1_Group.Checked;
            ACC.CC2_Group = chk_CC2_Group.Checked;
            ACC.Sheet = Convert.ToInt16(com_Sheet.SelectedIndex);
            ACC.Sheet_Parent = com_Sheet_Parent.SelectedIndex.ToString();
            ACC.Notes = txt_Notes.Text;
            ACC.ACC_Proper_ID = Convert.ToInt16(com_ACC_Proper_Name.SelectedValue);
            ACC.Parent_ID = (com_Parent_ACC.SelectedValue == null) ? "" : com_Parent_ACC.SelectedValue.ToString();
            ACC.ACC_Level = (tree.SelectedNode.Level) + 1;
            ACC.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
        }
        private void select_node()
        {
            foreach (TreeNode node in tree.Nodes)
            {
                if(selected_node.Count == 0) { return; }
                if (node.Tag.ToString() == selected_node[selected_node.Count - 1])
                {
                    tree.SelectedNode = node;
                }
            }

            for (int i = selected_node.Count - 1; i >= 0; i--)
            {
                if (tree.SelectedNode.Tag.ToString() == selected_node[i] && tree.SelectedNode.Nodes.Count > 0)
                {
                    tree.SelectedNode.Expand();
                    if (i == 0) { break; }
                    foreach (TreeNode n in tree.SelectedNode.Nodes)
                    {
                        if (n.Tag.ToString() == selected_node[i - 1])
                        {
                            tree.SelectedNode = n;
                        }
                    }
                }
            }
            if (expanded == true) { tree.SelectedNode.Expand(); } else { tree.SelectedNode.Collapse(); }
        }
        private void UpDowen()
        {
            if (Main.tab_Main.Visible == false && up == false)
            {
                up = true;
                groupBox_ACC_Data.Height += Main.tab_Main.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else if (Main.tab_Main.Visible == true && up == true)
            {
                up = false;
                groupBox_ACC_Data.Height -= Main.tab_Main.Height;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region Form
        private void FRM_ACC_Enter(object sender, EventArgs e)
        {
            dv_acc = new DataView(Main.ds.Tables[6]);

            selected_node.Clear();

            if (tree.SelectedNode != null && tree.SelectedNode.Tag != null)
            {
                if (tree.SelectedNode.IsExpanded) { expanded = true; } else { expanded = false; }

                selected_node.Add(tree.SelectedNode.Tag.ToString());
                while (tree.SelectedNode.Parent != null)
                {
                    tree.SelectedNode = tree.SelectedNode.Parent;
                    selected_node.Add(tree.SelectedNode.Tag.ToString());
                }
                Fill();
                select_node();
                UpDowen();
            }
        }
        private void FRM_ACC_Shown(object sender, EventArgs e)
        {
            Fill();
            if (tree.Nodes.Count > 0)
            {
                tree.SelectedNode = tree.Nodes[0];
            }
        }
        #endregion

        #region Controls
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
            if (Tag.ToString() == "Empty")
            {
                Tag = "New";
                Form_Mode("New");
                tree.Nodes.Add("");
                if (tree.Nodes.Count > 0)
                {
                    tree.SelectedNode = tree.Nodes[tree.Nodes.Count - 1];
                    lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                    Color_Nodes(tree.SelectedNode, Color.Red);
                    s = lbl_Path.Text + " / ";
                }
            }
            else if (Tag.ToString() == "Select_Node")
            {
                Tag = "New";
                Form_Mode("New");
                tree.SelectedNode.Expand();
                tree.SelectedNode.Nodes.Add("");
                tree.SelectedNode = tree.SelectedNode.Nodes[tree.SelectedNode.Nodes.Count - 1];
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                Color_Nodes(tree.SelectedNode, Color.Red);
                s = lbl_Path.Text + " / ";
            }
            else if (Tag.ToString() == "New")
            {
                if(txt_ACC_Name.Text.Trim() =="")
                {
                    MessageBox.Show("يجب إدخال أسم الحساب", "حفظ حساب", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                var();
                string t = ACC.Insert();
                if (t.Length > 6)
                {
                    if (t.Substring(0, 6) == "SQL : ")
                    {
                        MessageBox.Show(t, "! حفظ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        button_Cancel_Click(null,null);
                        return;
                    }
                }

                txt_ACC_ID.Text = t;
                tree.SelectedNode.Tag = t;

                // Add ACC From DataBase To dt
                DataTable dt = new DataTable();
                dt = ACC.Select();
                Main.ds.Tables[6].Rows.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    Main.ds.Tables[6].Rows.Add(r.ItemArray);
                }

                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }

        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select_Node")
            {
                Form_Mode("Edit");
                Tag = "Edit";
                s = (tree.SelectedNode.Parent != null) ? tree.SelectedNode.Parent.FullPath + " / " : "";
            }
            else if (Tag.ToString() == "Edit")
            {
                if(tree.SelectedNode.Level == 0 && com_Parent_ACC.SelectedValue != null)
                {
                    MessageBox.Show("لا يمكن أن يكون لهذا الحساب  حساب رئيسي ", "! تعديل", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    com_Parent_ACC.SelectedValue = -1;
                    return;
                }
                if(tree.SelectedNode.Level > 0 & com_Parent_ACC.SelectedValue == null || tree.SelectedNode.Tag.ToString() == com_Parent_ACC.SelectedValue.ToString())
                {
                    MessageBox.Show("يجب أن يندرج هذا الحساب تحت حساب آخر ", "! تعديل", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    com_Parent_ACC.DroppedDown = true;
                    return;
                }

                var();
                string t = ACC.Update();
                if (t.Length > 6)
                {
                    if (t.Substring(0, 6) == "SQL : ")
                    {
                        MessageBox.Show(t,"! تعديل",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        button_Cancel_Click(null, null);
                        return;
                    }
                }

                // Remove Old ACC
                for (int i = 0; i < Main.ds.Tables[6].Rows.Count; i++)
                {
                    if (Main.ds.Tables[6].Rows[i]["ACC_ID"].ToString() == txt_ACC_ID.Text)
                    {
                        Main.ds.Tables[6].Rows.RemoveAt(i);
                        i--;
                        break;
                    }
                }

                // Add ACC From DataBase To dt
                DataTable dt = new DataTable();
                dt = ACC.Select();
                Main.ds.Tables[6].Rows.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    Main.ds.Tables[6].Rows.Add(r.ItemArray);
                }

                if (tree.SelectedNode.Parent.Tag.ToString() != com_Parent_ACC.SelectedValue.ToString())
                {
                    expanded = true;
                    FRM_ACC_Enter(null, null);
                }
                else
                {
                    Tag = "Select_Node";
                    Form_Mode("Select_Node");
                }
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                if(tree.SelectedNode.Level == 0) { MessageBox.Show("لا يمكن حذف حساب في المستوى الأول"); return; }
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الحساب المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    string t = ACC.Delete((txt_ACC_ID.Text));
                    if (t == "0") { MessageBox.Show("لايمكن حذف مجموعة تحتوي على حسابات"); return; }

                    if (t.Length > 6)
                    {
                        if (t.Substring(0, 6) == "SQL : ")
                        {
                            MessageBox.Show(t, "! حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Remove Old CC
                    for (int i = 0; i < Main.ds.Tables[6].Rows.Count; i++)
                    {
                        if (Main.ds.Tables[6].Rows[i]["ACC_ID"].ToString() == txt_ACC_ID.Text)
                        {
                            Main.ds.Tables[6].Rows.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    //Remove Item Form TreeView
                    tree.SelectedNode.Remove();
                }
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                tree.SelectedNode.Remove();
                Form_Mode("Select_Node");
                Tag = "Select_Node";
            }
            else if (Tag.ToString() == "Edit")
            {
                Form_Mode("Select_Node");
                Tag = "Select_Node";
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            { 
                Main.ACC_Form_Open = false;
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
            else { Hide(); }
        }
        #endregion

        #region groupBox_ACC_Data
        private void txt_ACC_Name_TextChanged(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New" | Tag.ToString() == "Edit" && txt_ACC_Name.Focused)
            {
                tree.SelectedNode.Text = txt_ACC_Name.Text;
                lbl_Path.Text = s + txt_ACC_Name.Text;
            }
        }
        private void com_Sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            com_Sheet_Parent.Items.Clear();
            if (com_Sheet.SelectedIndex == 0)
            {
                com_Sheet_Parent.Items.Add("الأصول طويلة الأجل");
                com_Sheet_Parent.Items.Add("الأصول المتداولة");
                com_Sheet_Parent.Items.Add("الإلتزامات المتداولة");
                com_Sheet_Parent.Items.Add("حقوق الملكية");
                com_Sheet_Parent.Items.Add("الإلتزامات طوية الأجل");
            }
            else if (com_Sheet.SelectedIndex == 1)
            {
                com_Sheet_Parent.Items.Add("صافي المبيعات");
                com_Sheet_Parent.Items.Add("صافي المشتريات");
                com_Sheet_Parent.Items.Add("تكلفة البضاعة المباعة");
                com_Sheet_Parent.Items.Add("مصروفات النشاط");
                com_Sheet_Parent.Items.Add("إيرادات من خارج النشاط");
                com_Sheet_Parent.Items.Add("مصروفات خارج النشاط");
                com_Sheet_Parent.Items.Add("الزكاة");
            }
        }
        private void chk_CC1_Group_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CC1_Group.Checked)
            {
                dv_cc1.RowFilter = "Is_Parent = 1 and CC1 = 1";
                if (chk_CC1_Group.Enabled)
                {
                    com_CC1.SelectedValue = -1;
                    com_CC1.DroppedDown = true;
                }
            }
            else
            {
                dv_cc1.RowFilter = "Is_Parent = 0 and CC1 = 1";
                if (chk_CC1_Group.Enabled)
                {
                    com_CC1.SelectedValue = -1;
                    com_CC1.DroppedDown = true;
                }
            }
        }
        private void chk_CC2_Group_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CC2_Group.Checked)
            {
                dv_cc2.RowFilter = "Is_Parent = 1 and CC2 = 1";
                if (chk_CC2_Group.Enabled)
                {
                    com_CC2.SelectedValue = -1;
                    com_CC2.DroppedDown = true;
                }
            }
            else
            {
                dv_cc2.RowFilter = "Is_Parent = 0 and CC1 = 2";
                if (chk_CC2_Group.Enabled)
                {
                    com_CC2.SelectedValue = -1;
                    com_CC2.DroppedDown = true;
                }
            }
        }
        #endregion

        #region Tree
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Tag.ToString() == "New") { return; }
            Tag = "Select_Node";
            Form_Mode("Select_Node");
        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                Color_Nodes(tree.SelectedNode, Color.Black);
            }
        }
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (Tag.ToString() == "New") { return; }
            tree.SelectedNode = e.Node;
            foreach (TreeNode Pnode in tree.SelectedNode.Nodes)
            {
                Pnode.Nodes.Clear();
                foreach (DataRowView dr in dv_acc)
                {
                    if (Pnode.Tag == null) { break; }
                    if (dr["Parent_ID"].ToString() == Pnode.Tag.ToString())
                    {
                        TreeNode Cnode = new TreeNode();
                        Cnode.Name = dr["ACC_Name"].ToString();
                        Cnode.Text = dr["ACC_Name"].ToString();
                        Cnode.Tag = dr["ACC_ID"].ToString();
                        Pnode.Nodes.Add(Cnode);
                    }
                }
            }
        }
        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode Cnode in e.Node.Nodes)
            {
                Cnode.Collapse();
            }
        }
        #endregion
    }
}
