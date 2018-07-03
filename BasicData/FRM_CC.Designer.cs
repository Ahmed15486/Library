namespace Library.BasicData
{
    partial class FRM_CC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CC));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Path = new System.Windows.Forms.Label();
            this.groupBox_CC_Data = new System.Windows.Forms.GroupBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_cc_branche = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckb_cc2 = new System.Windows.Forms.CheckBox();
            this.ckb_cc1 = new System.Windows.Forms.CheckBox();
            this.txt_CC_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CC_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_Main_Group = new System.Windows.Forms.CheckBox();
            this.groupBox_ACC_Tree = new System.Windows.Forms.GroupBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.groupBox_CC_Data.SuspendLayout();
            this.groupBox_ACC_Tree.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Parent");
            this.imageList2.Images.SetKeyName(1, "Parent2");
            this.imageList2.Images.SetKeyName(2, "Chiled");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "New");
            this.imageList1.Images.SetKeyName(1, "Delete");
            this.imageList1.Images.SetKeyName(2, "Cancel");
            this.imageList1.Images.SetKeyName(3, "Edit");
            this.imageList1.Images.SetKeyName(4, "Add");
            this.imageList1.Images.SetKeyName(5, "Update");
            this.imageList1.Images.SetKeyName(6, "Close");
            this.imageList1.Images.SetKeyName(7, "Save");
            // 
            // lbl_Path
            // 
            this.lbl_Path.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Path.Location = new System.Drawing.Point(80, 157);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(985, 20);
            this.lbl_Path.TabIndex = 24;
            this.lbl_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_CC_Data
            // 
            this.groupBox_CC_Data.Controls.Add(this.txt_Notes);
            this.groupBox_CC_Data.Controls.Add(this.label3);
            this.groupBox_CC_Data.Controls.Add(this.combo_cc_branche);
            this.groupBox_CC_Data.Controls.Add(this.label10);
            this.groupBox_CC_Data.Controls.Add(this.ckb_cc2);
            this.groupBox_CC_Data.Controls.Add(this.ckb_cc1);
            this.groupBox_CC_Data.Controls.Add(this.txt_CC_Name);
            this.groupBox_CC_Data.Controls.Add(this.label2);
            this.groupBox_CC_Data.Controls.Add(this.txt_CC_ID);
            this.groupBox_CC_Data.Controls.Add(this.label1);
            this.groupBox_CC_Data.Controls.Add(this.ckb_Main_Group);
            this.groupBox_CC_Data.Location = new System.Drawing.Point(110, 209);
            this.groupBox_CC_Data.Name = "groupBox_CC_Data";
            this.groupBox_CC_Data.Size = new System.Drawing.Size(447, 470);
            this.groupBox_CC_Data.TabIndex = 22;
            this.groupBox_CC_Data.TabStop = false;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(31, 343);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(290, 67);
            this.txt_Notes.TabIndex = 35;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "بـيـان";
            // 
            // combo_cc_branche
            // 
            this.combo_cc_branche.BackColor = System.Drawing.SystemColors.Window;
            this.combo_cc_branche.DisplayMember = "Branche_Name";
            this.combo_cc_branche.Enabled = false;
            this.combo_cc_branche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_cc_branche.FormattingEnabled = true;
            this.combo_cc_branche.Location = new System.Drawing.Point(120, 224);
            this.combo_cc_branche.Name = "combo_cc_branche";
            this.combo_cc_branche.Size = new System.Drawing.Size(201, 21);
            this.combo_cc_branche.TabIndex = 33;
            this.combo_cc_branche.ValueMember = "Branche_ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "الفرع";
            // 
            // ckb_cc2
            // 
            this.ckb_cc2.AutoSize = true;
            this.ckb_cc2.Enabled = false;
            this.ckb_cc2.Location = new System.Drawing.Point(268, 281);
            this.ckb_cc2.Name = "ckb_cc2";
            this.ckb_cc2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckb_cc2.Size = new System.Drawing.Size(53, 17);
            this.ckb_cc2.TabIndex = 31;
            this.ckb_cc2.Text = "مركز2";
            this.ckb_cc2.UseVisualStyleBackColor = true;
            // 
            // ckb_cc1
            // 
            this.ckb_cc1.AutoSize = true;
            this.ckb_cc1.Enabled = false;
            this.ckb_cc1.Location = new System.Drawing.Point(268, 259);
            this.ckb_cc1.Name = "ckb_cc1";
            this.ckb_cc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckb_cc1.Size = new System.Drawing.Size(53, 17);
            this.ckb_cc1.TabIndex = 30;
            this.ckb_cc1.Text = "مركز1";
            this.ckb_cc1.UseVisualStyleBackColor = true;
            // 
            // txt_CC_Name
            // 
            this.txt_CC_Name.Location = new System.Drawing.Point(31, 165);
            this.txt_CC_Name.Name = "txt_CC_Name";
            this.txt_CC_Name.ReadOnly = true;
            this.txt_CC_Name.Size = new System.Drawing.Size(290, 20);
            this.txt_CC_Name.TabIndex = 29;
            this.txt_CC_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CC_Name.TextChanged += new System.EventHandler(this.txt_CC_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "أسم مركز التكلفة";
            // 
            // txt_CC_ID
            // 
            this.txt_CC_ID.Location = new System.Drawing.Point(180, 117);
            this.txt_CC_ID.Name = "txt_CC_ID";
            this.txt_CC_ID.ReadOnly = true;
            this.txt_CC_ID.Size = new System.Drawing.Size(141, 20);
            this.txt_CC_ID.TabIndex = 27;
            this.txt_CC_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "رقم مركز التكلفة";
            // 
            // ckb_Main_Group
            // 
            this.ckb_Main_Group.AutoSize = true;
            this.ckb_Main_Group.Location = new System.Drawing.Point(221, 50);
            this.ckb_Main_Group.Name = "ckb_Main_Group";
            this.ckb_Main_Group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckb_Main_Group.Size = new System.Drawing.Size(100, 17);
            this.ckb_Main_Group.TabIndex = 1;
            this.ckb_Main_Group.Text = "مجموعة رئيسية";
            this.ckb_Main_Group.UseVisualStyleBackColor = true;
            this.ckb_Main_Group.Visible = false;
            this.ckb_Main_Group.CheckedChanged += new System.EventHandler(this.ckb_Main_Group_CheckedChanged);
            // 
            // groupBox_ACC_Tree
            // 
            this.groupBox_ACC_Tree.Controls.Add(this.tree);
            this.groupBox_ACC_Tree.Location = new System.Drawing.Point(563, 209);
            this.groupBox_ACC_Tree.Name = "groupBox_ACC_Tree";
            this.groupBox_ACC_Tree.Size = new System.Drawing.Size(372, 470);
            this.groupBox_ACC_Tree.TabIndex = 23;
            this.groupBox_ACC_Tree.TabStop = false;
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.SystemColors.Window;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tree.Location = new System.Drawing.Point(3, 16);
            this.tree.Name = "tree";
            this.tree.PathSeparator = " / ";
            this.tree.RightToLeftLayout = true;
            this.tree.Size = new System.Drawing.Size(366, 451);
            this.tree.TabIndex = 18;
            this.tree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
            this.tree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.tree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbl_Level
            // 
            this.lbl_Level.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Level.Location = new System.Drawing.Point(140, 126);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Level.Size = new System.Drawing.Size(145, 20);
            this.lbl_Level.TabIndex = 25;
            this.lbl_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.button_Close);
            this.groupBox_Control.Controls.Add(this.button_New);
            this.groupBox_Control.Controls.Add(this.button_Cancel);
            this.groupBox_Control.Controls.Add(this.button_Delete);
            this.groupBox_Control.Controls.Add(this.button_Edit);
            this.groupBox_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Control.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(1090, 87);
            this.groupBox_Control.TabIndex = 40;
            this.groupBox_Control.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ImageKey = "Close";
            this.button_Close.ImageList = this.imageList1;
            this.button_Close.Location = new System.Drawing.Point(3, 16);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(69, 68);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "إغلاق";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.button_Close.MouseEnter += new System.EventHandler(this.button_Close_MouseEnter);
            this.button_Close.MouseLeave += new System.EventHandler(this.button_Close_MouseLeave);
            // 
            // button_New
            // 
            this.button_New.FlatAppearance.BorderSize = 0;
            this.button_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New.ImageKey = "New";
            this.button_New.ImageList = this.imageList1;
            this.button_New.Location = new System.Drawing.Point(770, 11);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(69, 69);
            this.button_New.TabIndex = 1;
            this.button_New.Text = "جديد";
            this.button_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            this.button_New.MouseEnter += new System.EventHandler(this.button_New_MouseEnter);
            this.button_New.MouseLeave += new System.EventHandler(this.button_New_MouseLeave);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ImageKey = "Cancel";
            this.button_Cancel.ImageList = this.imageList1;
            this.button_Cancel.Location = new System.Drawing.Point(545, 11);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 69);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "تراجع";
            this.button_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            this.button_Cancel.MouseEnter += new System.EventHandler(this.button_Cancel_MouseEnter);
            this.button_Cancel.MouseLeave += new System.EventHandler(this.button_Cancel_MouseLeave);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.ImageKey = "Delete";
            this.button_Delete.ImageList = this.imageList1;
            this.button_Delete.Location = new System.Drawing.Point(620, 11);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(69, 69);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "حذف";
            this.button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Visible = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            this.button_Delete.MouseEnter += new System.EventHandler(this.button_Delete_MouseEnter);
            this.button_Delete.MouseLeave += new System.EventHandler(this.button_Delete_MouseLeave);
            // 
            // button_Edit
            // 
            this.button_Edit.FlatAppearance.BorderSize = 0;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.ImageKey = "Edit";
            this.button_Edit.ImageList = this.imageList1;
            this.button_Edit.Location = new System.Drawing.Point(695, 11);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(69, 69);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "تعديل";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Visible = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            this.button_Edit.MouseEnter += new System.EventHandler(this.button_Edit_MouseEnter);
            this.button_Edit.MouseLeave += new System.EventHandler(this.button_Edit_MouseLeave);
            // 
            // FRM_CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 760);
            this.Controls.Add(this.groupBox_Control);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.groupBox_CC_Data);
            this.Controls.Add(this.groupBox_ACC_Tree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "Empty";
            this.Text = "مراكز التكلفة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_CC_Shown);
            this.groupBox_CC_Data.ResumeLayout(false);
            this.groupBox_CC_Data.PerformLayout();
            this.groupBox_ACC_Tree.ResumeLayout(false);
            this.groupBox_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label lbl_Path;
        public System.Windows.Forms.GroupBox groupBox_CC_Data;
        public System.Windows.Forms.GroupBox groupBox_ACC_Tree;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.CheckBox ckb_Main_Group;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_cc_branche;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckb_cc2;
        private System.Windows.Forms.CheckBox ckb_cc1;
        public System.Windows.Forms.TextBox txt_CC_Name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_CC_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Level;
        public System.Windows.Forms.GroupBox groupBox_Control;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
    }
}