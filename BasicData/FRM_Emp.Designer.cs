namespace Library.BasicData
{
    partial class FRM_Emp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Emp));
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.textBox_Notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Mobile = new System.Windows.Forms.TextBox();
            this.DGV_Emp = new System.Windows.Forms.DataGridView();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Emp_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Emp_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Job_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Emp_Basic_Salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Emp_Personal_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Search.Location = new System.Drawing.Point(10, 19);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(413, 20);
            this.textBox_Search.TabIndex = 13;
            this.textBox_Search.Text = "Search";
            this.textBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Notes
            // 
            this.textBox_Notes.Location = new System.Drawing.Point(113, 426);
            this.textBox_Notes.Multiline = true;
            this.textBox_Notes.Name = "textBox_Notes";
            this.textBox_Notes.Size = new System.Drawing.Size(336, 80);
            this.textBox_Notes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(455, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ملاحظات";
            // 
            // textBox_Mobile
            // 
            this.textBox_Mobile.Location = new System.Drawing.Point(113, 199);
            this.textBox_Mobile.Name = "textBox_Mobile";
            this.textBox_Mobile.Size = new System.Drawing.Size(141, 20);
            this.textBox_Mobile.TabIndex = 9;
            // 
            // DGV_Emp
            // 
            this.DGV_Emp.AllowUserToAddRows = false;
            this.DGV_Emp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGV_Emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGV_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Emp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Emp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_ID,
            this.Emp_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Emp.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Emp.Location = new System.Drawing.Point(10, 45);
            this.DGV_Emp.MultiSelect = false;
            this.DGV_Emp.Name = "DGV_Emp";
            this.DGV_Emp.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Emp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Emp.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Emp.Size = new System.Drawing.Size(450, 499);
            this.DGV_Emp.TabIndex = 16;
            this.DGV_Emp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Emp_RowEnter);
            // 
            // Emp_ID
            // 
            this.Emp_ID.DataPropertyName = "Emp_ID";
            this.Emp_ID.FillWeight = 50F;
            this.Emp_ID.HeaderText = "كود الموظف";
            this.Emp_ID.MinimumWidth = 2;
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.ReadOnly = true;
            // 
            // Emp_Name
            // 
            this.Emp_Name.DataPropertyName = "Emp_Name";
            this.Emp_Name.FillWeight = 98.47716F;
            this.Emp_Name.HeaderText = "أسم الموظف";
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(260, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الجوال";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(308, 196);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(141, 20);
            this.textBox_Phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(455, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "الهاتف";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(113, 258);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(336, 20);
            this.textBox_Address.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.DGV_Emp);
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.textBox_Search);
            this.groupBox3.Location = new System.Drawing.Point(580, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 550);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 6F);
            this.btn_Search.Location = new System.Drawing.Point(429, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(24, 20);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "A";
            this.btn_Search.UseVisualStyleBackColor = true;
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
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "إغلاق";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.textBox_Emp_Basic_Salary);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_Emp_Personal_ID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox_Job_Type);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Notes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Mobile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_Phone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Address);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Emp_Name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Emp_ID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(14, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 550);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(455, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "العنوان";
            // 
            // textBox_Emp_Name
            // 
            this.textBox_Emp_Name.Location = new System.Drawing.Point(113, 146);
            this.textBox_Emp_Name.Name = "textBox_Emp_Name";
            this.textBox_Emp_Name.Size = new System.Drawing.Size(336, 20);
            this.textBox_Emp_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(455, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الموظف";
            // 
            // textBox_Emp_ID
            // 
            this.textBox_Emp_ID.Location = new System.Drawing.Point(320, 98);
            this.textBox_Emp_ID.Name = "textBox_Emp_ID";
            this.textBox_Emp_ID.Size = new System.Drawing.Size(116, 20);
            this.textBox_Emp_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(455, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الموظف";
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
            this.groupBox1.Size = new System.Drawing.Size(1064, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(254, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "كود الوظيفة";
            // 
            // comboBox_Job_Type
            // 
            this.comboBox_Job_Type.DisplayMember = "Job_Type_Name";
            this.comboBox_Job_Type.FormattingEnabled = true;
            this.comboBox_Job_Type.Location = new System.Drawing.Point(113, 97);
            this.comboBox_Job_Type.Name = "comboBox_Job_Type";
            this.comboBox_Job_Type.Size = new System.Drawing.Size(135, 21);
            this.comboBox_Job_Type.TabIndex = 13;
            this.comboBox_Job_Type.ValueMember = "Job_Type_ID";
            // 
            // textBox_Emp_Basic_Salary
            // 
            this.textBox_Emp_Basic_Salary.Location = new System.Drawing.Point(308, 365);
            this.textBox_Emp_Basic_Salary.Name = "textBox_Emp_Basic_Salary";
            this.textBox_Emp_Basic_Salary.Size = new System.Drawing.Size(141, 20);
            this.textBox_Emp_Basic_Salary.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "الراتب الأساسي";
            // 
            // textBox_Emp_Personal_ID
            // 
            this.textBox_Emp_Personal_ID.Location = new System.Drawing.Point(308, 315);
            this.textBox_Emp_Personal_ID.Name = "textBox_Emp_Personal_ID";
            this.textBox_Emp_Personal_ID.Size = new System.Drawing.Size(141, 20);
            this.textBox_Emp_Personal_ID.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "الرقم القومي";
            // 
            // FRM_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Emp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "Select";
            this.Text = "بيانات الموظفين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_Vendors_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Search;
        public System.Windows.Forms.TextBox textBox_Notes;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_Mobile;
        public System.Windows.Forms.DataGridView DGV_Emp;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_Phone;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_Address;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_Emp_Name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_Emp_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Name;
        private System.Windows.Forms.ComboBox comboBox_Job_Type;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_Emp_Basic_Salary;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox_Emp_Personal_ID;
        public System.Windows.Forms.Label label9;
    }
}