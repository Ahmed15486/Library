/*
 * Created by SharpDevelop.
 * User: user
 * Date: 8/9/2015
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Library.Bills
{
	partial class FRM_Jor_B
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Button button_Print;
		public System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.Button button_Settings;
		public System.Windows.Forms.Button btn_Close;
		public System.Windows.Forms.Button btn_New;
		public System.Windows.Forms.Button btn_Delete;
		public System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox_Footer_Details;
		public System.Windows.Forms.GroupBox groupBox_Details;
		public System.Windows.Forms.DataGridView DGV_Jor_B;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Jor_B));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Print = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Settings = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox_Footer_Details = new System.Windows.Forms.GroupBox();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.DGV_Jor_B = new System.Windows.Forms.DataGridView();
            this.panel_FRM_Head = new System.Windows.Forms.Panel();
            this.lbl_B_Type = new System.Windows.Forms.Label();
            this.com_Bill_User = new System.Windows.Forms.ComboBox();
            this.com_Bill_Type = new System.Windows.Forms.ComboBox();
            this.com_B_Type = new System.Windows.Forms.ComboBox();
            this.com_Bill_Branches = new System.Windows.Forms.ComboBox();
            this.btn_Bill_User = new System.Windows.Forms.Button();
            this.btn_B_Type = new System.Windows.Forms.Button();
            this.lbl_Bill_Type = new System.Windows.Forms.Label();
            this.btn_Bill_Type = new System.Windows.Forms.Button();
            this.lbl_bill_Branches = new System.Windows.Forms.Label();
            this.btn_Bill_Branche = new System.Windows.Forms.Button();
            this.lbl_Bill_User = new System.Windows.Forms.Label();
            this.lbl_CC2 = new System.Windows.Forms.Label();
            this.contextMenuStrip_users = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_B_Type = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_branches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_Bill_Type = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Jor_B)).BeginInit();
            this.panel_FRM_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Print);
            this.groupBox1.Controls.Add(this.button_Settings);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_New);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 87);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Print
            // 
            this.button_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.ImageKey = "Print";
            this.button_Print.ImageList = this.imageList1;
            this.button_Print.Location = new System.Drawing.Point(141, 16);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(69, 68);
            this.button_Print.TabIndex = 8;
            this.button_Print.Text = "طباعة";
            this.button_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Visible = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            this.button_Print.MouseEnter += new System.EventHandler(this.button_Print_MouseEnter);
            this.button_Print.MouseLeave += new System.EventHandler(this.button_Print_MouseLeave);
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
            this.imageList1.Images.SetKeyName(8, "Settings");
            this.imageList1.Images.SetKeyName(9, "Print");
            // 
            // button_Settings
            // 
            this.button_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.ImageKey = "Settings";
            this.button_Settings.ImageList = this.imageList1;
            this.button_Settings.Location = new System.Drawing.Point(72, 16);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(69, 68);
            this.button_Settings.TabIndex = 7;
            this.button_Settings.Text = "إعدادات";
            this.button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            this.button_Settings.MouseEnter += new System.EventHandler(this.button_Settings_MouseEnter);
            this.button_Settings.MouseLeave += new System.EventHandler(this.button_Settings_MouseLeave);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ImageKey = "Close";
            this.btn_Close.ImageList = this.imageList1;
            this.btn_Close.Location = new System.Drawing.Point(3, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(69, 68);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "إغلاق";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // btn_New
            // 
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.ImageKey = "New";
            this.btn_New.ImageList = this.imageList1;
            this.btn_New.Location = new System.Drawing.Point(766, 11);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(69, 69);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "إضافة";
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.button_New_Click);
            this.btn_New.MouseEnter += new System.EventHandler(this.btn_New_MouseEnter);
            this.btn_New.MouseLeave += new System.EventHandler(this.btn_New_MouseLeave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ImageKey = "Delete";
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(691, 11);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 69);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            this.btn_Delete.MouseEnter += new System.EventHandler(this.btn_Delete_MouseEnter);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_Delete_MouseLeave);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ImageKey = "Save";
            this.btn_Save.ImageList = this.imageList1;
            this.btn_Save.Location = new System.Drawing.Point(616, 11);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(69, 69);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button_Save_Click);
            this.btn_Save.MouseEnter += new System.EventHandler(this.btn_Save_MouseEnter);
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_Save_MouseLeave);
            // 
            // groupBox_Footer_Details
            // 
            this.groupBox_Footer_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Footer_Details.Location = new System.Drawing.Point(0, 603);
            this.groupBox_Footer_Details.Name = "groupBox_Footer_Details";
            this.groupBox_Footer_Details.Size = new System.Drawing.Size(1243, 142);
            this.groupBox_Footer_Details.TabIndex = 69;
            this.groupBox_Footer_Details.TabStop = false;
            this.groupBox_Footer_Details.Enter += new System.EventHandler(this.groupBox_Footer_Details_Enter);
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Controls.Add(this.DGV_Jor_B);
            this.groupBox_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Details.Location = new System.Drawing.Point(0, 140);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1243, 463);
            this.groupBox_Details.TabIndex = 68;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Enter += new System.EventHandler(this.groupBox_Details_Enter);
            // 
            // DGV_Jor_B
            // 
            this.DGV_Jor_B.AllowUserToAddRows = false;
            this.DGV_Jor_B.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.DGV_Jor_B.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Jor_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGV_Jor_B.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Jor_B.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Jor_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Jor_B.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Jor_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Jor_B.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Jor_B.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_Jor_B.Location = new System.Drawing.Point(0, 16);
            this.DGV_Jor_B.MultiSelect = false;
            this.DGV_Jor_B.Name = "DGV_Jor_B";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Jor_B.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Jor_B.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Jor_B.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Jor_B.Size = new System.Drawing.Size(1253, 444);
            this.DGV_Jor_B.TabIndex = 17;
            this.DGV_Jor_B.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Jor_B_CellContentClick);
            this.DGV_Jor_B.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_Jor_B_EditingControlShowing);
            // 
            // panel_FRM_Head
            // 
            this.panel_FRM_Head.BackColor = System.Drawing.Color.Silver;
            this.panel_FRM_Head.Controls.Add(this.lbl_B_Type);
            this.panel_FRM_Head.Controls.Add(this.com_Bill_User);
            this.panel_FRM_Head.Controls.Add(this.com_Bill_Type);
            this.panel_FRM_Head.Controls.Add(this.com_B_Type);
            this.panel_FRM_Head.Controls.Add(this.com_Bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_User);
            this.panel_FRM_Head.Controls.Add(this.btn_B_Type);
            this.panel_FRM_Head.Controls.Add(this.lbl_Bill_Type);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_Type);
            this.panel_FRM_Head.Controls.Add(this.lbl_bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_Branche);
            this.panel_FRM_Head.Controls.Add(this.lbl_Bill_User);
            this.panel_FRM_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FRM_Head.Location = new System.Drawing.Point(0, 0);
            this.panel_FRM_Head.Name = "panel_FRM_Head";
            this.panel_FRM_Head.Size = new System.Drawing.Size(1243, 53);
            this.panel_FRM_Head.TabIndex = 0;
            this.panel_FRM_Head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_FRM_Head_Paint);
            // 
            // lbl_B_Type
            // 
            this.lbl_B_Type.AutoSize = true;
            this.lbl_B_Type.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_B_Type.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_B_Type.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_B_Type.Location = new System.Drawing.Point(860, 0);
            this.lbl_B_Type.Name = "lbl_B_Type";
            this.lbl_B_Type.Padding = new System.Windows.Forms.Padding(50, 18, 0, 0);
            this.lbl_B_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_B_Type.Size = new System.Drawing.Size(50, 35);
            this.lbl_B_Type.TabIndex = 39;
            this.lbl_B_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_B_Type.Click += new System.EventHandler(this.lbl_B_Type_Click);
            // 
            // com_Bill_User
            // 
            this.com_Bill_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_Bill_User.DisplayMember = "User_Name";
            this.com_Bill_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Bill_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Bill_User.FormattingEnabled = true;
            this.com_Bill_User.Location = new System.Drawing.Point(82, 0);
            this.com_Bill_User.Name = "com_Bill_User";
            this.com_Bill_User.Size = new System.Drawing.Size(118, 21);
            this.com_Bill_User.TabIndex = 33;
            this.com_Bill_User.ValueMember = "User_ID";
            this.com_Bill_User.Visible = false;
            this.com_Bill_User.SelectedIndexChanged += new System.EventHandler(this.combo_Bill_User_SelectedIndexChanged);
            // 
            // com_Bill_Type
            // 
            this.com_Bill_Type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_Bill_Type.DisplayMember = "Bill_T_Name";
            this.com_Bill_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Bill_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Bill_Type.FormattingEnabled = true;
            this.com_Bill_Type.Location = new System.Drawing.Point(830, 0);
            this.com_Bill_Type.Name = "com_Bill_Type";
            this.com_Bill_Type.Size = new System.Drawing.Size(212, 21);
            this.com_Bill_Type.TabIndex = 27;
            this.com_Bill_Type.ValueMember = "Bill_T_ID";
            this.com_Bill_Type.Visible = false;
            this.com_Bill_Type.SelectedIndexChanged += new System.EventHandler(this.com_Bill_Type_SelectedIndexChanged);
            // 
            // com_B_Type
            // 
            this.com_B_Type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_B_Type.DisplayMember = "Type_Name";
            this.com_B_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_B_Type.FormattingEnabled = true;
            this.com_B_Type.Location = new System.Drawing.Point(664, 0);
            this.com_B_Type.Name = "com_B_Type";
            this.com_B_Type.Size = new System.Drawing.Size(88, 21);
            this.com_B_Type.TabIndex = 29;
            this.com_B_Type.ValueMember = "Type_ID";
            this.com_B_Type.Visible = false;
            this.com_B_Type.SelectedIndexChanged += new System.EventHandler(this.com_B_Type_SelectedIndexChanged);
            // 
            // com_Bill_Branches
            // 
            this.com_Bill_Branches.BackColor = System.Drawing.Color.WhiteSmoke;
            this.com_Bill_Branches.DisplayMember = "Branche_Name";
            this.com_Bill_Branches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Bill_Branches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Bill_Branches.FormattingEnabled = true;
            this.com_Bill_Branches.Location = new System.Drawing.Point(1063, 0);
            this.com_Bill_Branches.Name = "com_Bill_Branches";
            this.com_Bill_Branches.Size = new System.Drawing.Size(184, 21);
            this.com_Bill_Branches.TabIndex = 25;
            this.com_Bill_Branches.ValueMember = "Branche_ID";
            this.com_Bill_Branches.Visible = false;
            this.com_Bill_Branches.SelectedIndexChanged += new System.EventHandler(this.com_Bill_Branches_SelectedIndexChanged);
            // 
            // btn_Bill_User
            // 
            this.btn_Bill_User.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Bill_User.FlatAppearance.BorderSize = 0;
            this.btn_Bill_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill_User.Location = new System.Drawing.Point(20, 0);
            this.btn_Bill_User.Name = "btn_Bill_User";
            this.btn_Bill_User.Size = new System.Drawing.Size(103, 53);
            this.btn_Bill_User.TabIndex = 42;
            this.btn_Bill_User.Text = "المستخدم : ";
            this.btn_Bill_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill_User.UseVisualStyleBackColor = true;
            this.btn_Bill_User.Click += new System.EventHandler(this.btn_Bill_User_Click);
            this.btn_Bill_User.MouseEnter += new System.EventHandler(this.btn_Bill_User_MouseEnter);
            this.btn_Bill_User.MouseLeave += new System.EventHandler(this.btn_Bill_User_MouseLeave);
            // 
            // btn_B_Type
            // 
            this.btn_B_Type.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_B_Type.FlatAppearance.BorderSize = 0;
            this.btn_B_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B_Type.Location = new System.Drawing.Point(910, 0);
            this.btn_B_Type.Name = "btn_B_Type";
            this.btn_B_Type.Size = new System.Drawing.Size(85, 53);
            this.btn_B_Type.TabIndex = 38;
            this.btn_B_Type.Text = "النوع :";
            this.btn_B_Type.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_B_Type.UseVisualStyleBackColor = true;
            this.btn_B_Type.Click += new System.EventHandler(this.btn_B_Type_Click);
            this.btn_B_Type.MouseEnter += new System.EventHandler(this.btn_B_Type_MouseEnter);
            this.btn_B_Type.MouseLeave += new System.EventHandler(this.btn_B_Type_MouseLeave);
            // 
            // lbl_Bill_Type
            // 
            this.lbl_Bill_Type.AutoSize = true;
            this.lbl_Bill_Type.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Bill_Type.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Bill_Type.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Bill_Type.Location = new System.Drawing.Point(995, 0);
            this.lbl_Bill_Type.Name = "lbl_Bill_Type";
            this.lbl_Bill_Type.Padding = new System.Windows.Forms.Padding(50, 18, 0, 0);
            this.lbl_Bill_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Bill_Type.Size = new System.Drawing.Size(50, 35);
            this.lbl_Bill_Type.TabIndex = 37;
            this.lbl_Bill_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Bill_Type.Click += new System.EventHandler(this.lbl_Bill_Type_Click);
            // 
            // btn_Bill_Type
            // 
            this.btn_Bill_Type.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Bill_Type.FlatAppearance.BorderSize = 0;
            this.btn_Bill_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill_Type.Location = new System.Drawing.Point(1045, 0);
            this.btn_Bill_Type.Name = "btn_Bill_Type";
            this.btn_Bill_Type.Size = new System.Drawing.Size(103, 53);
            this.btn_Bill_Type.TabIndex = 36;
            this.btn_Bill_Type.Text = "السند :";
            this.btn_Bill_Type.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill_Type.UseVisualStyleBackColor = true;
            this.btn_Bill_Type.Click += new System.EventHandler(this.btn_Bill_Type_Click);
            this.btn_Bill_Type.MouseEnter += new System.EventHandler(this.btn_Bill_Type_MouseEnter);
            this.btn_Bill_Type.MouseLeave += new System.EventHandler(this.btn_Bill_Type_MouseLeave);
            // 
            // lbl_bill_Branches
            // 
            this.lbl_bill_Branches.AutoSize = true;
            this.lbl_bill_Branches.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_bill_Branches.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_bill_Branches.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_bill_Branches.Location = new System.Drawing.Point(1148, 0);
            this.lbl_bill_Branches.Name = "lbl_bill_Branches";
            this.lbl_bill_Branches.Padding = new System.Windows.Forms.Padding(15, 18, 0, 0);
            this.lbl_bill_Branches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bill_Branches.Size = new System.Drawing.Size(15, 35);
            this.lbl_bill_Branches.TabIndex = 35;
            this.lbl_bill_Branches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_bill_Branches.Click += new System.EventHandler(this.lbl_bill_Branches_Click);
            // 
            // btn_Bill_Branche
            // 
            this.btn_Bill_Branche.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Bill_Branche.FlatAppearance.BorderSize = 0;
            this.btn_Bill_Branche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill_Branche.Location = new System.Drawing.Point(1163, 0);
            this.btn_Bill_Branche.Name = "btn_Bill_Branche";
            this.btn_Bill_Branche.Size = new System.Drawing.Size(80, 53);
            this.btn_Bill_Branche.TabIndex = 34;
            this.btn_Bill_Branche.Text = "الفرع :";
            this.btn_Bill_Branche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill_Branche.UseVisualStyleBackColor = true;
            this.btn_Bill_Branche.Click += new System.EventHandler(this.btn_Bill_Branche_Click);
            this.btn_Bill_Branche.MouseEnter += new System.EventHandler(this.btn_Bill_Branche_MouseEnter);
            this.btn_Bill_Branche.MouseLeave += new System.EventHandler(this.btn_Bill_Branche_MouseLeave);
            // 
            // lbl_Bill_User
            // 
            this.lbl_Bill_User.AutoSize = true;
            this.lbl_Bill_User.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Bill_User.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Bill_User.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Bill_User.Location = new System.Drawing.Point(0, 0);
            this.lbl_Bill_User.Name = "lbl_Bill_User";
            this.lbl_Bill_User.Padding = new System.Windows.Forms.Padding(20, 18, 0, 0);
            this.lbl_Bill_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Bill_User.Size = new System.Drawing.Size(20, 35);
            this.lbl_Bill_User.TabIndex = 43;
            this.lbl_Bill_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Bill_User.Click += new System.EventHandler(this.lbl_Bill_User_Click);
            // 
            // lbl_CC2
            // 
            this.lbl_CC2.Location = new System.Drawing.Point(0, 0);
            this.lbl_CC2.Name = "lbl_CC2";
            this.lbl_CC2.Size = new System.Drawing.Size(100, 23);
            this.lbl_CC2.TabIndex = 0;
            this.lbl_CC2.Click += new System.EventHandler(this.lbl_CC2_Click);
            // 
            // contextMenuStrip_users
            // 
            this.contextMenuStrip_users.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_users.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_users.Name = "contextMenuStrip_users";
            this.contextMenuStrip_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_users.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_users.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_users_Opening);
            this.contextMenuStrip_users.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_users_ItemClicked);
            // 
            // contextMenuStrip_B_Type
            // 
            this.contextMenuStrip_B_Type.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_B_Type.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_B_Type.Name = "contextMenuStrip_B_Type";
            this.contextMenuStrip_B_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_B_Type.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_B_Type.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_B_Type_Opening);
            this.contextMenuStrip_B_Type.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_B_Type_ItemClicked);
            // 
            // contextMenuStrip_branches
            // 
            this.contextMenuStrip_branches.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_branches.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_branches.Name = "contextMenuStrip_branches";
            this.contextMenuStrip_branches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_branches.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_branches.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_branches_Opening);
            this.contextMenuStrip_branches.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_branches_ItemClicked);
            // 
            // contextMenuStrip_Bill_Type
            // 
            this.contextMenuStrip_Bill_Type.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_Bill_Type.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_Bill_Type.Name = "contextMenuStrip_stores";
            this.contextMenuStrip_Bill_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_Bill_Type.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_Bill_Type.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Bill_Type_Opening);
            this.contextMenuStrip_Bill_Type.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_stores_ItemClicked);
            // 
            // FRM_Jor_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 751);
            this.Controls.Add(this.groupBox_Footer_Details);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_FRM_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Jor_B";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.FRM_Jor_B_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Jor_B)).EndInit();
            this.panel_FRM_Head.ResumeLayout(false);
            this.panel_FRM_Head.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel_FRM_Head;
        private System.Windows.Forms.ComboBox com_Bill_User;
        private System.Windows.Forms.ComboBox com_B_Type;
        private System.Windows.Forms.ComboBox com_Bill_Type;
        private System.Windows.Forms.ComboBox com_Bill_Branches;
        private System.Windows.Forms.Button btn_Bill_User;
        private System.Windows.Forms.Label lbl_CC2;
        private System.Windows.Forms.Label lbl_B_Type;
        private System.Windows.Forms.Button btn_B_Type;
        private System.Windows.Forms.Label lbl_Bill_Type;
        private System.Windows.Forms.Button btn_Bill_Type;
        private System.Windows.Forms.Label lbl_bill_Branches;
        private System.Windows.Forms.Button btn_Bill_Branche;
        private System.Windows.Forms.Label lbl_Bill_User;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_users;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_B_Type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_branches;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Bill_Type;
    }
}
