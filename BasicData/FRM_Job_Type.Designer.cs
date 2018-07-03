namespace Library.BasicData
{
    partial class FRM_Job_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Job_Type));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Job_Type_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Job_Type_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_New = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_Job_Type = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Job_Type_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job_Type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Job_Type)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.textBox_Job_Type_Name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Job_Type_ID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(14, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 300);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // textBox_Job_Type_Name
            // 
            this.textBox_Job_Type_Name.Location = new System.Drawing.Point(43, 149);
            this.textBox_Job_Type_Name.Name = "textBox_Job_Type_Name";
            this.textBox_Job_Type_Name.Size = new System.Drawing.Size(336, 20);
            this.textBox_Job_Type_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الوظيفة";
            // 
            // textBox_Job_Type_ID
            // 
            this.textBox_Job_Type_ID.Location = new System.Drawing.Point(238, 101);
            this.textBox_Job_Type_ID.Name = "textBox_Job_Type_ID";
            this.textBox_Job_Type_ID.ReadOnly = true;
            this.textBox_Job_Type_ID.Size = new System.Drawing.Size(141, 20);
            this.textBox_Job_Type_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز الوظيفة";
            // 
            // button_New
            // 
            this.button_New.FlatAppearance.BorderSize = 0;
            this.button_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New.ImageKey = "New";
            this.button_New.ImageList = this.imageList1;
            this.button_New.Location = new System.Drawing.Point(766, 21);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(69, 78);
            this.button_New.TabIndex = 1;
            this.button_New.Text = "جديد";
            this.button_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
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
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ImageKey = "Cancel";
            this.button_Cancel.ImageList = this.imageList1;
            this.button_Cancel.Location = new System.Drawing.Point(541, 19);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 78);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "تراجع";
            this.button_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.ImageKey = "Delete";
            this.button_Delete.ImageList = this.imageList1;
            this.button_Delete.Location = new System.Drawing.Point(616, 21);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(69, 78);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "حذف";
            this.button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_New);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Edit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ImageKey = "Close";
            this.button_Close.ImageList = this.imageList1;
            this.button_Close.Location = new System.Drawing.Point(66, 19);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(69, 78);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "إغلاق";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.FlatAppearance.BorderSize = 0;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.ImageKey = "Edit";
            this.button_Edit.ImageList = this.imageList1;
            this.button_Edit.Location = new System.Drawing.Point(691, 19);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(69, 78);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "تعديل";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.DGV_Job_Type);
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(495, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 300);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // DGV_Job_Type
            // 
            this.DGV_Job_Type.AllowUserToAddRows = false;
            this.DGV_Job_Type.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGV_Job_Type.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Job_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGV_Job_Type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Job_Type.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Job_Type.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Job_Type.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Job_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Job_Type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job_Type_ID,
            this.Job_Type_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Job_Type.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Job_Type.Location = new System.Drawing.Point(6, 42);
            this.DGV_Job_Type.MultiSelect = false;
            this.DGV_Job_Type.Name = "DGV_Job_Type";
            this.DGV_Job_Type.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Job_Type.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Job_Type.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Job_Type.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Job_Type.Size = new System.Drawing.Size(413, 252);
            this.DGV_Job_Type.TabIndex = 19;
            this.DGV_Job_Type.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Job_Type_RowEnter);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 6F);
            this.btn_Search.Location = new System.Drawing.Point(391, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(24, 20);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "A";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Search";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Job_Type_ID
            // 
            this.Job_Type_ID.DataPropertyName = "Job_Type_ID";
            this.Job_Type_ID.FillWeight = 50F;
            this.Job_Type_ID.HeaderText = "كود الوظيفة";
            this.Job_Type_ID.MinimumWidth = 2;
            this.Job_Type_ID.Name = "Job_Type_ID";
            this.Job_Type_ID.ReadOnly = true;
            // 
            // Job_Type_Name
            // 
            this.Job_Type_Name.DataPropertyName = "Job_Type_Name";
            this.Job_Type_Name.FillWeight = 98.47716F;
            this.Job_Type_Name.HeaderText = "أسم الوظيفة";
            this.Job_Type_Name.Name = "Job_Type_Name";
            this.Job_Type_Name.ReadOnly = true;
            // 
            // FRM_Job_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Job_Type";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Select";
            this.Text = "الوظائف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_Job_Type_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Job_Type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox_Job_Type_Name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_Job_Type_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button_Edit;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView DGV_Job_Type;
        private System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_Type_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_Type_Name;
    }
}