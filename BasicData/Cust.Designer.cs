namespace Library.BasicData
{
    partial class FRM_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.com_ACC_Name = new System.Windows.Forms.ComboBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cust_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_DGV = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            this.grbx_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
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
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.button_Close);
            this.grbx_Controls.Controls.Add(this.button_New);
            this.grbx_Controls.Controls.Add(this.button_Cancel);
            this.grbx_Controls.Controls.Add(this.button_Delete);
            this.grbx_Controls.Controls.Add(this.button_Edit);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 0);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(1280, 87);
            this.grbx_Controls.TabIndex = 6;
            this.grbx_Controls.TabStop = false;
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
            this.button_Close.TabIndex = 5;
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
            this.button_New.Location = new System.Drawing.Point(766, 10);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(70, 75);
            this.button_New.TabIndex = 0;
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
            this.button_Cancel.Location = new System.Drawing.Point(541, 10);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(70, 75);
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
            this.button_Delete.Location = new System.Drawing.Point(616, 10);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(70, 75);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "حذف";
            this.button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Delete.UseVisualStyleBackColor = true;
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
            this.button_Edit.Location = new System.Drawing.Point(691, 10);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(70, 75);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "تعديل";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            this.button_Edit.MouseEnter += new System.EventHandler(this.button_Edit_MouseEnter);
            this.button_Edit.MouseLeave += new System.EventHandler(this.button_Edit_MouseLeave);
            // 
            // grbx_Details
            // 
            this.grbx_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbx_Details.Controls.Add(this.label7);
            this.grbx_Details.Controls.Add(this.com_ACC_Name);
            this.grbx_Details.Controls.Add(this.txt_Notes);
            this.grbx_Details.Controls.Add(this.label6);
            this.grbx_Details.Controls.Add(this.txt_Mobile);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.txt_Phone);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_Address);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_Cust_Name);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_Cust_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Location = new System.Drawing.Point(122, 153);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(560, 355);
            this.grbx_Details.TabIndex = 7;
            this.grbx_Details.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "يسجل في دليل الحسابات تحت الحساب";
            // 
            // com_ACC_Name
            // 
            this.com_ACC_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_ACC_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_ACC_Name.BackColor = System.Drawing.SystemColors.Window;
            this.com_ACC_Name.DisplayMember = "ACC_Name";
            this.com_ACC_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_ACC_Name.FormattingEnabled = true;
            this.com_ACC_Name.Location = new System.Drawing.Point(239, 303);
            this.com_ACC_Name.Name = "com_ACC_Name";
            this.com_ACC_Name.Size = new System.Drawing.Size(206, 21);
            this.com_ACC_Name.TabIndex = 35;
            this.com_ACC_Name.ValueMember = "ACC_ID";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(113, 186);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(336, 89);
            this.txt_Notes.TabIndex = 5;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ملاحظات";
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(113, 123);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(141, 20);
            this.txt_Mobile.TabIndex = 3;
            this.txt_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الجوال";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(308, 120);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(141, 20);
            this.txt_Phone.TabIndex = 2;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "الهاتف";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(113, 149);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(336, 20);
            this.txt_Address.TabIndex = 4;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "العنوان";
            // 
            // txt_Cust_Name
            // 
            this.txt_Cust_Name.Location = new System.Drawing.Point(113, 90);
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(336, 20);
            this.txt_Cust_Name.TabIndex = 1;
            this.txt_Cust_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم العميل";
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Location = new System.Drawing.Point(308, 42);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.ReadOnly = true;
            this.txt_Cust_ID.Size = new System.Drawing.Size(141, 20);
            this.txt_Cust_ID.TabIndex = 1;
            this.txt_Cust_ID.TabStop = false;
            this.txt_Cust_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود العميل";
            // 
            // grbx_DGV
            // 
            this.grbx_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbx_DGV.Controls.Add(this.DGV);
            this.grbx_DGV.Controls.Add(this.txt_Search);
            this.grbx_DGV.Location = new System.Drawing.Point(688, 153);
            this.grbx_DGV.Name = "grbx_DGV";
            this.grbx_DGV.Size = new System.Drawing.Size(466, 355);
            this.grbx_DGV.TabIndex = 12;
            this.grbx_DGV.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust_ID,
            this.Cust_Name});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 36);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(460, 316);
            this.DGV.TabIndex = 16;
            this.DGV.CurrentCellChanged += new System.EventHandler(this.DGV_CurrentCellChanged);
            // 
            // Cust_ID
            // 
            this.Cust_ID.DataPropertyName = "Cust_ID";
            this.Cust_ID.FillWeight = 50F;
            this.Cust_ID.HeaderText = "كود العميل";
            this.Cust_ID.MinimumWidth = 2;
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.ReadOnly = true;
            // 
            // Cust_Name
            // 
            this.Cust_Name.DataPropertyName = "Cust_Name";
            this.Cust_Name.FillWeight = 98.47716F;
            this.Cust_Name.HeaderText = "أسم العميل";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.ReadOnly = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Search.ForeColor = System.Drawing.Color.Silver;
            this.txt_Search.Location = new System.Drawing.Point(3, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(460, 20);
            this.txt_Search.TabIndex = 13;
            this.txt_Search.Text = "Search";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            this.txt_Search.MouseEnter += new System.EventHandler(this.txt_Search_MouseEnter);
            this.txt_Search.MouseLeave += new System.EventHandler(this.txt_Search_MouseLeave);
            // 
            // FRM_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 550);
            this.Controls.Add(this.grbx_DGV);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grbx_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Empty";
            this.Text = "بيانات العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_Customer_Shown);
            this.Enter += new System.EventHandler(this.FRM_Customer_Enter);
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_DGV.ResumeLayout(false);
            this.grbx_DGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grbx_Controls;
        public System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Mobile;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Phone;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Address;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Cust_Name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Cust_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.GroupBox grbx_DGV;
        public System.Windows.Forms.TextBox txt_Search;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox com_ACC_Name;
    }
}