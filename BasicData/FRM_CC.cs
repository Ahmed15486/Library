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
    public partial class FRM_CC : Form
    {
        #region Declaration
        BL.CLS_CC CC = new BL.CLS_CC();
        G.CLS_G G = new G.CLS_G();

        DataTable dt_branches = new DataTable();
        DataRow r;
        bool up;
        string s;

        frm_Main Main;
        #endregion

        public FRM_CC(frm_Main main)
        {
            InitializeComponent();
            Main=main;

            dt_branches = Main.dt_Branches.Clone();
            foreach (DataRow dr in Main.dt_Branches.Rows)
            {
                dt_branches.Rows.Add(dr.ItemArray);
            }

            combo_cc_branche.DataSource = dt_branches;
            combo_cc_branche.SelectedValue = -1;

        }

        #region Pro
        private void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select_Node
                case "Select_Node":
                    if(tree.Nodes.Count == 0)
                    {
                        Tag = "Empty";
                        Form_Mode("Empty");
                        return;
                    }
                    if (tree.SelectedNode == null) { tree.SelectedNode = tree.Nodes[0]; }
                    lbl_Path.Text = tree.SelectedNode.FullPath;
                    lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString() ;
                    ckb_Main_Group.Checked = false;
                    ckb_Main_Group.Visible = false;
                    tree.Enabled = true;
                    txt_CC_Name.ReadOnly = true;
                    combo_cc_branche.Enabled = false;
                    ckb_cc1.Enabled = false;
                    ckb_cc2.Enabled = false;
                    txt_Notes.ReadOnly = true;

                    foreach (DataRow dr in Main.dt_CC.Rows)
                    {
                        if (dr["CC_ID"].ToString() == tree.SelectedNode.Tag.ToString())
                        {
                            r = dr;
                            txt_CC_ID.Text = r["CC_ID"].ToString();
                            txt_CC_Name.Text = r["CC_Name"].ToString();
                            combo_cc_branche.SelectedValue = r["Branche"].ToString();
                            ckb_cc1.Checked = Convert.ToBoolean(r["CC1"]);
                            ckb_cc2.Checked = Convert.ToBoolean(r["CC2"]);
                            txt_Notes.Text = r["Notes"].ToString();
                        }
                    }
                    tree.SelectedNode.Text = txt_CC_Name.Text;
                    tree.SelectedNode.Tag = txt_CC_ID.Text;
                    lbl_Path.Text = tree.SelectedNode.FullPath;

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
                    txt_CC_ID.Clear();
                    txt_CC_Name.Clear();
                    combo_cc_branche.SelectedValue = -1;
                    combo_cc_branche.Text = "";
                    ckb_cc1.Checked = false;
                    ckb_cc2.Checked = false;
                    txt_Notes.Clear();

                    groupBox_CC_Data.Enabled = true;
                    tree.Enabled = false;

                    txt_CC_Name.Focus();

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
                    if (tree.Nodes.Count > 0) { ckb_Main_Group.Visible = true; }
                    else { ckb_Main_Group.Checked = true; }
                    txt_CC_ID.Clear();
                    txt_CC_Name.Clear();
                    combo_cc_branche.SelectedValue = -1;
                    combo_cc_branche.Text = "";
                    ckb_cc1.Checked = false;
                    ckb_cc2.Checked = false;
                    txt_Notes.Clear();

                    txt_CC_Name.ReadOnly = false;
                    combo_cc_branche.Enabled = true;
                    ckb_cc1.Enabled = true;
                    ckb_cc2.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    tree.Enabled = false;

                    txt_CC_Name.Focus();

                    button_New.Text = "حفظ";
                    button_New.Image = imageList1.Images["Save"];
                    button_Edit.Visible = false;
                    button_Delete.Visible = false;
                    button_Cancel.Visible = true;
                    button_Close.Visible = false;
                    break;
                #endregion

                #region Edit
                case "Edit":

                    txt_CC_Name.ReadOnly = false;
                    combo_cc_branche.Enabled = true;
                    ckb_cc1.Enabled = true;
                    ckb_cc2.Enabled = true;
                    txt_Notes.ReadOnly = false;

                    tree.Enabled = false;

                    txt_CC_ID.ReadOnly = true;

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
                    ckb_Main_Group.Checked = false;
                    txt_CC_ID.Clear();
                    txt_CC_Name.Clear();
                    combo_cc_branche.SelectedValue = -1;
                    combo_cc_branche.Text = "";
                    ckb_cc1.Checked = false;
                    ckb_cc2.Checked = false;
                    txt_Notes.Clear();
                    lbl_Level.Text = "";
                    lbl_Path.Text = "";


                    txt_CC_Name.ReadOnly = true;
                    combo_cc_branche.Enabled = false;
                    ckb_cc1.Enabled = false;
                    ckb_cc2.Enabled = false;
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
        private void Color_Nodes(TreeNode node,Color color)
        {
            if (node == null) { return; }
            node.ForeColor = color;
            if (node.Parent == null) { return; }

            node.Parent.ForeColor = color;
            Color_Nodes(node.Parent, color);
        }
        private void Fill()
        {
            foreach (DataRow dr in Main.dt_CC.Rows)
            {
                if (Convert.ToInt32(dr["CC_Level"]) == 1)
                {
                    TreeNode Pnode = new TreeNode();
                    Pnode.Name = (dr["CC_Name"].ToString());
                    Pnode.Text = (dr["CC_Name"].ToString());
                    Pnode.Tag = dr["CC_ID"].ToString();

                    if (Convert.ToBoolean(dr["Is_Parent"]) == true)
                    {
                        foreach (DataRow r in Main.dt_CC.Rows)
                        {
                            if (r["Parent_ID"].ToString() == Pnode.Tag.ToString())
                            {
                                TreeNode Cnode = new TreeNode();
                                Cnode.Name = r["CC_Name"].ToString();
                                Cnode.Text = r["CC_Name"].ToString();
                                Cnode.Tag = r["CC_ID"].ToString();
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
            CC.CC_ID = txt_CC_ID.Text;
            CC.CC_Name = txt_CC_Name.Text;
            CC.Parent_ID = (ckb_Main_Group.Checked || tree.SelectedNode.Parent==null) ? "" : tree.SelectedNode.Parent.Tag.ToString();
            CC.CC_Level = (ckb_Main_Group.Checked)?  1 : tree.SelectedNode.Level+1; 
            CC.Branche = (combo_cc_branche.SelectedValue == null) ? null : combo_cc_branche.SelectedValue.ToString();
            CC.CC1 = (ckb_cc1.Checked) ? true : false;
            CC.CC2 = (ckb_cc2.Checked) ? true : false;
            CC.Notes = txt_Notes.Text;
            CC.User_ID = Convert.ToInt16(Main.combo_Users.SelectedValue);
        }
        #endregion

        #region Form
        private void FRM_CC_Shown(object sender, EventArgs e)
        {
            try
            {
                Fill();
                if(tree.Nodes.Count > 0)
                {
                    tree.SelectedNode = tree.Nodes[0];
                    ckb_Main_Group.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if(Tag.ToString() == "Empty")
            {
                Tag = "New";
                Form_Mode("New");
                tree.Nodes.Add("");
                tree.SelectedNode = tree.Nodes[tree.Nodes.Count - 1];
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                Color_Nodes(tree.SelectedNode, Color.Red);
                s = lbl_Path.Text ;
            }
            else if(Tag.ToString() == "Select_Node")
            {
                Tag = "New";
                Form_Mode("New");
                tree.SelectedNode.Expand();
                tree.SelectedNode.Nodes.Add("");
                tree.SelectedNode = tree.SelectedNode.Nodes[tree.SelectedNode.Nodes.Count-1];
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                Color_Nodes(tree.SelectedNode, Color.Red);
                s = lbl_Path.Text + " / ";
            }
            else if (Tag.ToString() == "New")
            {
                var();
                string t= CC.Insert();

                txt_CC_ID.Text = t;
                tree.SelectedNode.Tag = t;

                // Add CC From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(t, 17);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_CC.Rows.Add(r.ItemArray);
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
                s = (tree.SelectedNode.Parent!=null)? tree.SelectedNode.Parent.FullPath + " / " : "" ;
            }
            else if (Tag.ToString() == "Edit")
            {
                var();
                CC.Update();

                // Remove Old CC
                for (int i = 0; i < Main.dt_CC.Rows.Count; i++)
                {
                    if (Main.dt_CC.Rows[i]["CC_ID"].ToString() == txt_CC_ID.Text)
                    {
                        Main.dt_CC.Rows.RemoveAt(i);
                        i--;
                        break;
                    }
                }
                // Add CC From DataBase To dt
                DataTable p1 = new DataTable();
                p1 = G.Select_LastBill(txt_CC_ID.Text, 17);
                foreach (DataRow r in p1.Rows)
                {
                    Main.dt_CC.Rows.Add(r.ItemArray);
                }

                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null && tree.SelectedNode != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف مركز التكلفة المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    string t =  CC.Delete((txt_CC_ID.Text));
                    if (t == "0") { MessageBox.Show("لايمكن حذف مجموعة تحتوي على مراكز"); return; }

                    // Remove Old CC
                    for (int i = 0; i < Main.dt_CC.Rows.Count; i++)
                    {
                        if (Main.dt_CC.Rows[i]["CC_ID"].ToString() == txt_CC_ID.Text)
                        {
                            Main.dt_CC.Rows.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                    Tag = "Empty";
                    Form_Mode("Empty");
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
                Tag = "Select_Node";
                Form_Mode("Select_Node");
            }
            else if(Tag.ToString() == "Edit")
            {
                Form_Mode("Select_Node");
                Tag = "Select_Node";
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Main.CC_Form_Open = false;
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

        #region groupBox_CC_Data
        private void ckb_Main_Group_CheckedChanged(object sender, EventArgs e)
        {
            if (tree.Nodes.Count == 0 || !ckb_Main_Group.Focused) { return; }
            if (ckb_Main_Group.Checked)
            {
                tree.SelectedNode.Remove();
                tree.CollapseAll();
                lbl_Path.Text = "";
                foreach (TreeNode n in tree.Nodes)
                {
                    n.ForeColor = Color.Black;
                }
                tree.Nodes.Add(txt_CC_Name.Text);
                tree.SelectedNode = tree.Nodes[tree.Nodes.Count - 1];
                tree.SelectedNode.ForeColor = Color.Red;
                s = "";
                lbl_Path.Text = txt_CC_Name.Text;
                lbl_Level.Text = "المستوى : " + (tree.SelectedNode.Level + 1).ToString();
                txt_CC_Name.Focus();
            }
            else if (!ckb_Main_Group.Checked)
            {
                tree.SelectedNode.Remove();
                Tag = "Select_Node";
                Form_Mode("Select_Node");          
            }
        }
        private void txt_CC_Name_TextChanged(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New" | Tag.ToString() == "Edit" && txt_CC_Name.Focused)
            {
                tree.SelectedNode.Text = txt_CC_Name.Text;
                lbl_Path.Text = s + txt_CC_Name.Text;
            }
        }
        #endregion

        #region Tree
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ckb_Main_Group.Checked || Tag.ToString() == "New") { return; }
            Form_Mode("Select_Node");
            Tag = "Select_Node";
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
            if(Tag.ToString() == "New") { return; }
            tree.SelectedNode = e.Node;
            foreach (TreeNode Pnode in tree.SelectedNode.Nodes)
            {
                Pnode.Nodes.Clear();
                foreach (DataRow r in Main.dt_CC.Rows)
                {
                    if(Pnode.Tag == null) { break; }
                    if (r["Parent_ID"].ToString() == Pnode.Tag.ToString())
                    {
                        TreeNode Cnode = new TreeNode();
                        Cnode.Name = r["CC_Name"].ToString();
                        Cnode.Text = r["CC_Name"].ToString();
                        Cnode.Tag = r["CC_ID"].ToString();
                        Pnode.Nodes.Add(Cnode);
                    }
                }
            }
        }
        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            tree.SelectedNode = e.Node;
            foreach (TreeNode Cnode in tree.SelectedNode.Nodes)
            {
                Cnode.Collapse();
            }
        }
        #endregion

    }
}
