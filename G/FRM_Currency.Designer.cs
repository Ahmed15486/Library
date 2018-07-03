namespace Library.G
{
    partial class FRM_Currency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Currency));
            this.grbx_DGV = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.txt_Enm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Anm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Currency_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_New = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.grbx_Details.SuspendLayout();
            this.grbx_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_DGV
            // 
            this.grbx_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbx_DGV.Controls.Add(this.DGV);
            this.grbx_DGV.Location = new System.Drawing.Point(365, 147);
            this.grbx_DGV.Name = "grbx_DGV";
            this.grbx_DGV.Size = new System.Drawing.Size(325, 292);
            this.grbx_DGV.TabIndex = 15;
            this.grbx_DGV.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle86.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle86.BackColor = System.Drawing.Color.OldLace;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle86;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle87.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle87.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle87.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle87.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle87.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle87.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle87;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Currency_Name});
            dataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle88.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle88.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle88.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle88.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle88.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle88.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle88;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 16);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle89.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle89.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle89.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle89.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle89.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle89.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle89;
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle90;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(319, 273);
            this.DGV.TabIndex = 16;
            this.DGV.CurrentCellChanged += new System.EventHandler(this.DGV_CurrentCellChanged);
            // 
            // grbx_Details
            // 
            this.grbx_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbx_Details.Controls.Add(this.txt_Enm);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_Rate);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_Anm);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_Currency_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Location = new System.Drawing.Point(30, 147);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(329, 292);
            this.grbx_Details.TabIndex = 14;
            this.grbx_Details.TabStop = false;
            // 
            // txt_Enm
            // 
            this.txt_Enm.Location = new System.Drawing.Point(86, 120);
            this.txt_Enm.Name = "txt_Enm";
            this.txt_Enm.Size = new System.Drawing.Size(141, 20);
            this.txt_Enm.TabIndex = 2;
            this.txt_Enm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "أسم العملة E";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(145, 149);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(82, 20);
            this.txt_Rate.TabIndex = 4;
            this.txt_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "سعر الصرف";
            // 
            // txt_Anm
            // 
            this.txt_Anm.Location = new System.Drawing.Point(86, 90);
            this.txt_Anm.Name = "txt_Anm";
            this.txt_Anm.Size = new System.Drawing.Size(141, 20);
            this.txt_Anm.TabIndex = 1;
            this.txt_Anm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم العملة";
            // 
            // txt_Currency_ID
            // 
            this.txt_Currency_ID.Location = new System.Drawing.Point(145, 42);
            this.txt_Currency_ID.Name = "txt_Currency_ID";
            this.txt_Currency_ID.ReadOnly = true;
            this.txt_Currency_ID.Size = new System.Drawing.Size(82, 20);
            this.txt_Currency_ID.TabIndex = 1;
            this.txt_Currency_ID.TabStop = false;
            this.txt_Currency_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود العملة";
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.button_New);
            this.grbx_Controls.Controls.Add(this.button_Cancel);
            this.grbx_Controls.Controls.Add(this.button_Delete);
            this.grbx_Controls.Controls.Add(this.button_Edit);
            this.grbx_Controls.Controls.Add(this.button_Close);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 0);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(713, 87);
            this.grbx_Controls.TabIndex = 13;
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
            // button_New
            // 
            this.button_New.FlatAppearance.BorderSize = 0;
            this.button_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New.ImageKey = "New";
            this.button_New.ImageList = this.imageList1;
            this.button_New.Location = new System.Drawing.Point(613, 7);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(70, 75);
            this.button_New.TabIndex = 6;
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
            this.button_Cancel.Location = new System.Drawing.Point(388, 7);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(70, 75);
            this.button_Cancel.TabIndex = 9;
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
            this.button_Delete.Location = new System.Drawing.Point(463, 7);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(70, 75);
            this.button_Delete.TabIndex = 8;
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
            this.button_Edit.Location = new System.Drawing.Point(538, 7);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(70, 75);
            this.button_Edit.TabIndex = 7;
            this.button_Edit.Text = "تعديل";
            this.button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            this.button_Edit.MouseEnter += new System.EventHandler(this.button_Edit_MouseEnter);
            this.button_Edit.MouseLeave += new System.EventHandler(this.button_Edit_MouseLeave);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "كود العملة";
            this.ID.MinimumWidth = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Currency_Name
            // 
            this.Currency_Name.DataPropertyName = "Anm";
            this.Currency_Name.FillWeight = 98.47716F;
            this.Currency_Name.HeaderText = "أسم العملة";
            this.Currency_Name.Name = "Currency_Name";
            this.Currency_Name.ReadOnly = true;
            // 
            // FRM_Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(713, 512);
            this.Controls.Add(this.grbx_DGV);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grbx_Controls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Currency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملة";
            this.Shown += new System.EventHandler(this.FRM_Currency_Shown);
            this.grbx_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grbx_DGV;
        public System.Windows.Forms.DataGridView DGV;
        public System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.TextBox txt_Enm;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Rate;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Anm;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Currency_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grbx_Controls;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency_Name;
    }
}