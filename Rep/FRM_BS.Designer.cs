namespace Library.Rep
{
    partial class FRM_BS
    {
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBox_Header = new System.Windows.Forms.GroupBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_form = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Footer_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Total_Investment = new System.Windows.Forms.Label();
            this.lbl_Working_capital = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Footer_Controls = new System.Windows.Forms.GroupBox();
            this.panel_FRM_Head = new System.Windows.Forms.Panel();
            this.combo_CC2 = new System.Windows.Forms.ComboBox();
            this.combo_CC1 = new System.Windows.Forms.ComboBox();
            this.combo_Bill_Branches = new System.Windows.Forms.ComboBox();
            this.btn_cc2_del = new System.Windows.Forms.Button();
            this.lbl_CC2 = new System.Windows.Forms.Label();
            this.btn_CC2 = new System.Windows.Forms.Button();
            this.btn_cc1_del = new System.Windows.Forms.Button();
            this.lbl_CC1 = new System.Windows.Forms.Label();
            this.btn_CC1 = new System.Windows.Forms.Button();
            this.btn_branche_del = new System.Windows.Forms.Button();
            this.lbl_bill_Branches = new System.Windows.Forms.Label();
            this.btn_Bill_Branche = new System.Windows.Forms.Button();
            this.contextMenuStrip_branches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_cc1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_cc2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_Header.SuspendLayout();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox_Footer_Details.SuspendLayout();
            this.panel_FRM_Head.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(8, "Settings");
            this.imageList1.Images.SetKeyName(9, "Print");
            this.imageList1.Images.SetKeyName(10, "Display.png");
            this.imageList1.Images.SetKeyName(11, "Display2.png");
            this.imageList1.Images.SetKeyName(12, "Display3.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Display);
            this.groupBox1.Controls.Add(this.button_Print);
            this.groupBox1.Controls.Add(this.button_Settings);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 87);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // button_Display
            // 
            this.button_Display.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Display.FlatAppearance.BorderSize = 0;
            this.button_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Display.ImageKey = "Display2.png";
            this.button_Display.ImageList = this.imageList1;
            this.button_Display.Location = new System.Drawing.Point(210, 16);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(69, 68);
            this.button_Display.TabIndex = 4;
            this.button_Display.Text = "عرض";
            this.button_Display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
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
            // 
            // groupBox_Header
            // 
            this.groupBox_Header.Controls.Add(this.dtp_to);
            this.groupBox_Header.Controls.Add(this.label1);
            this.groupBox_Header.Controls.Add(this.dtp_form);
            this.groupBox_Header.Controls.Add(this.label7);
            this.groupBox_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Header.Location = new System.Drawing.Point(0, 140);
            this.groupBox_Header.Name = "groupBox_Header";
            this.groupBox_Header.Size = new System.Drawing.Size(1259, 107);
            this.groupBox_Header.TabIndex = 54;
            this.groupBox_Header.TabStop = false;
            this.groupBox_Header.Tag = "";
            // 
            // dtp_to
            // 
            this.dtp_to.Checked = false;
            this.dtp_to.CustomFormat = " ";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(811, 19);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeftLayout = true;
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(166, 20);
            this.dtp_to.TabIndex = 36;
            this.dtp_to.Value = new System.DateTime(2015, 9, 3, 0, 0, 0, 0);
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            this.dtp_to.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtp_to_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "إلى";
            // 
            // dtp_form
            // 
            this.dtp_form.Checked = false;
            this.dtp_form.CustomFormat = " ";
            this.dtp_form.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_form.Location = new System.Drawing.Point(1013, 19);
            this.dtp_form.Name = "dtp_form";
            this.dtp_form.RightToLeftLayout = true;
            this.dtp_form.ShowCheckBox = true;
            this.dtp_form.Size = new System.Drawing.Size(166, 20);
            this.dtp_form.TabIndex = 27;
            this.dtp_form.Value = new System.DateTime(2015, 9, 3, 18, 11, 44, 0);
            this.dtp_form.ValueChanged += new System.EventHandler(this.dtp_form_ValueChanged);
            this.dtp_form.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtp_form_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1185, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "من تاريخ";
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Details.Controls.Add(this.DGV);
            this.groupBox_Details.Location = new System.Drawing.Point(0, 247);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1259, 376);
            this.groupBox_Details.TabIndex = 55;
            this.groupBox_Details.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn,
            this.ACC_Name,
            this.sub2,
            this.Main1,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 16);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV.RowTemplate.Height = 30;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1253, 357);
            this.DGV.TabIndex = 16;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_BS_CellDoubleClick);
            this.DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_BS_CellFormatting);
            this.DGV.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellMouseEnter);
            this.DGV.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellMouseLeave);
            // 
            // btn
            // 
            this.btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btn.HeaderText = "";
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            this.btn.Width = 25;
            // 
            // ACC_Name
            // 
            this.ACC_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ACC_Name.DataPropertyName = "ACC_Name";
            this.ACC_Name.HeaderText = "";
            this.ACC_Name.Name = "ACC_Name";
            this.ACC_Name.ReadOnly = true;
            this.ACC_Name.Width = 300;
            // 
            // sub2
            // 
            this.sub2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sub2.HeaderText = "فرعي";
            this.sub2.Name = "sub2";
            this.sub2.ReadOnly = true;
            this.sub2.Visible = false;
            this.sub2.Width = 120;
            // 
            // Main1
            // 
            this.Main1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Main1.HeaderText = "رئيسي";
            this.Main1.Name = "Main1";
            this.Main1.ReadOnly = true;
            this.Main1.Width = 120;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.HeaderText = "إجمالي";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // groupBox_Footer_Details
            // 
            this.groupBox_Footer_Details.Controls.Add(this.lbl_Total_Investment);
            this.groupBox_Footer_Details.Controls.Add(this.lbl_Working_capital);
            this.groupBox_Footer_Details.Controls.Add(this.label3);
            this.groupBox_Footer_Details.Controls.Add(this.label2);
            this.groupBox_Footer_Details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Details.Location = new System.Drawing.Point(0, 629);
            this.groupBox_Footer_Details.Name = "groupBox_Footer_Details";
            this.groupBox_Footer_Details.Size = new System.Drawing.Size(1259, 100);
            this.groupBox_Footer_Details.TabIndex = 68;
            this.groupBox_Footer_Details.TabStop = false;
            // 
            // lbl_Total_Investment
            // 
            this.lbl_Total_Investment.AutoSize = true;
            this.lbl_Total_Investment.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Total_Investment.Location = new System.Drawing.Point(985, 60);
            this.lbl_Total_Investment.Name = "lbl_Total_Investment";
            this.lbl_Total_Investment.Size = new System.Drawing.Size(48, 17);
            this.lbl_Total_Investment.TabIndex = 16;
            this.lbl_Total_Investment.Text = "          ";
            // 
            // lbl_Working_capital
            // 
            this.lbl_Working_capital.AutoSize = true;
            this.lbl_Working_capital.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Working_capital.Location = new System.Drawing.Point(985, 28);
            this.lbl_Working_capital.Name = "lbl_Working_capital";
            this.lbl_Working_capital.Size = new System.Drawing.Size(48, 17);
            this.lbl_Working_capital.TabIndex = 15;
            this.lbl_Working_capital.Text = "          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(1051, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "إجمالي الإستثمار = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(1051, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "رأس المال العامل = ";
            // 
            // groupBox_Footer_Controls
            // 
            this.groupBox_Footer_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Controls.Location = new System.Drawing.Point(0, 729);
            this.groupBox_Footer_Controls.Name = "groupBox_Footer_Controls";
            this.groupBox_Footer_Controls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_Footer_Controls.Size = new System.Drawing.Size(1259, 61);
            this.groupBox_Footer_Controls.TabIndex = 67;
            this.groupBox_Footer_Controls.TabStop = false;
            // 
            // panel_FRM_Head
            // 
            this.panel_FRM_Head.BackColor = System.Drawing.Color.Silver;
            this.panel_FRM_Head.Controls.Add(this.combo_CC2);
            this.panel_FRM_Head.Controls.Add(this.combo_CC1);
            this.panel_FRM_Head.Controls.Add(this.combo_Bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_cc2_del);
            this.panel_FRM_Head.Controls.Add(this.lbl_CC2);
            this.panel_FRM_Head.Controls.Add(this.btn_CC2);
            this.panel_FRM_Head.Controls.Add(this.btn_cc1_del);
            this.panel_FRM_Head.Controls.Add(this.lbl_CC1);
            this.panel_FRM_Head.Controls.Add(this.btn_CC1);
            this.panel_FRM_Head.Controls.Add(this.btn_branche_del);
            this.panel_FRM_Head.Controls.Add(this.lbl_bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_Branche);
            this.panel_FRM_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FRM_Head.Location = new System.Drawing.Point(0, 0);
            this.panel_FRM_Head.Name = "panel_FRM_Head";
            this.panel_FRM_Head.Size = new System.Drawing.Size(1259, 53);
            this.panel_FRM_Head.TabIndex = 69;
            // 
            // combo_CC2
            // 
            this.combo_CC2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_CC2.DisplayMember = "CC_Name";
            this.combo_CC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_CC2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_CC2.FormattingEnabled = true;
            this.combo_CC2.Location = new System.Drawing.Point(315, 2);
            this.combo_CC2.Name = "combo_CC2";
            this.combo_CC2.Size = new System.Drawing.Size(93, 21);
            this.combo_CC2.TabIndex = 31;
            this.combo_CC2.ValueMember = "CC_ID";
            this.combo_CC2.Visible = false;
            this.combo_CC2.SelectedIndexChanged += new System.EventHandler(this.combo_CC2_SelectedIndexChanged);
            // 
            // combo_CC1
            // 
            this.combo_CC1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_CC1.DisplayMember = "CC_Name";
            this.combo_CC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_CC1.FormattingEnabled = true;
            this.combo_CC1.Location = new System.Drawing.Point(664, 0);
            this.combo_CC1.Name = "combo_CC1";
            this.combo_CC1.Size = new System.Drawing.Size(88, 21);
            this.combo_CC1.TabIndex = 29;
            this.combo_CC1.ValueMember = "CC_ID";
            this.combo_CC1.Visible = false;
            this.combo_CC1.SelectedIndexChanged += new System.EventHandler(this.combo_CC1_SelectedIndexChanged);
            // 
            // combo_Bill_Branches
            // 
            this.combo_Bill_Branches.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_Bill_Branches.DisplayMember = "Branche_Name";
            this.combo_Bill_Branches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Bill_Branches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Bill_Branches.FormattingEnabled = true;
            this.combo_Bill_Branches.Location = new System.Drawing.Point(1063, 0);
            this.combo_Bill_Branches.Name = "combo_Bill_Branches";
            this.combo_Bill_Branches.Size = new System.Drawing.Size(184, 21);
            this.combo_Bill_Branches.TabIndex = 25;
            this.combo_Bill_Branches.ValueMember = "Branche_ID";
            this.combo_Bill_Branches.Visible = false;
            this.combo_Bill_Branches.SelectedValueChanged += new System.EventHandler(this.combo_Bill_Branches_SelectedValueChanged);
            // 
            // btn_cc2_del
            // 
            this.btn_cc2_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_cc2_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cc2_del.FlatAppearance.BorderSize = 0;
            this.btn_cc2_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_cc2_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_cc2_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cc2_del.Location = new System.Drawing.Point(858, 0);
            this.btn_cc2_del.Name = "btn_cc2_del";
            this.btn_cc2_del.Size = new System.Drawing.Size(20, 53);
            this.btn_cc2_del.TabIndex = 47;
            this.btn_cc2_del.UseVisualStyleBackColor = false;
            this.btn_cc2_del.Visible = false;
            this.btn_cc2_del.Click += new System.EventHandler(this.btn_cc2_del_Click);
            // 
            // lbl_CC2
            // 
            this.lbl_CC2.AutoSize = true;
            this.lbl_CC2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_CC2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_CC2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CC2.Location = new System.Drawing.Point(878, 0);
            this.lbl_CC2.Name = "lbl_CC2";
            this.lbl_CC2.Padding = new System.Windows.Forms.Padding(20, 18, 0, 0);
            this.lbl_CC2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CC2.Size = new System.Drawing.Size(20, 35);
            this.lbl_CC2.TabIndex = 41;
            this.lbl_CC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_CC2
            // 
            this.btn_CC2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CC2.FlatAppearance.BorderSize = 0;
            this.btn_CC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CC2.Location = new System.Drawing.Point(898, 0);
            this.btn_CC2.Name = "btn_CC2";
            this.btn_CC2.Size = new System.Drawing.Size(103, 53);
            this.btn_CC2.TabIndex = 40;
            this.btn_CC2.Text = "مركز 2 : ";
            this.btn_CC2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CC2.UseVisualStyleBackColor = true;
            this.btn_CC2.Click += new System.EventHandler(this.btn_CC2_Click);
            // 
            // btn_cc1_del
            // 
            this.btn_cc1_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_cc1_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cc1_del.FlatAppearance.BorderSize = 0;
            this.btn_cc1_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_cc1_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_cc1_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cc1_del.Location = new System.Drawing.Point(1001, 0);
            this.btn_cc1_del.Name = "btn_cc1_del";
            this.btn_cc1_del.Size = new System.Drawing.Size(20, 53);
            this.btn_cc1_del.TabIndex = 46;
            this.btn_cc1_del.UseVisualStyleBackColor = false;
            this.btn_cc1_del.Visible = false;
            this.btn_cc1_del.Click += new System.EventHandler(this.btn_cc1_del_Click);
            // 
            // lbl_CC1
            // 
            this.lbl_CC1.AutoSize = true;
            this.lbl_CC1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_CC1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_CC1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CC1.Location = new System.Drawing.Point(1021, 0);
            this.lbl_CC1.Name = "lbl_CC1";
            this.lbl_CC1.Padding = new System.Windows.Forms.Padding(20, 18, 0, 0);
            this.lbl_CC1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CC1.Size = new System.Drawing.Size(20, 35);
            this.lbl_CC1.TabIndex = 39;
            this.lbl_CC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_CC1
            // 
            this.btn_CC1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CC1.FlatAppearance.BorderSize = 0;
            this.btn_CC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CC1.Location = new System.Drawing.Point(1041, 0);
            this.btn_CC1.Name = "btn_CC1";
            this.btn_CC1.Size = new System.Drawing.Size(103, 53);
            this.btn_CC1.TabIndex = 38;
            this.btn_CC1.Text = "مركز 1 :";
            this.btn_CC1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CC1.UseVisualStyleBackColor = true;
            this.btn_CC1.Click += new System.EventHandler(this.btn_CC1_Click);
            // 
            // btn_branche_del
            // 
            this.btn_branche_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_branche_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_branche_del.FlatAppearance.BorderSize = 0;
            this.btn_branche_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_branche_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_branche_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_branche_del.Location = new System.Drawing.Point(1144, 0);
            this.btn_branche_del.Name = "btn_branche_del";
            this.btn_branche_del.Size = new System.Drawing.Size(20, 53);
            this.btn_branche_del.TabIndex = 48;
            this.btn_branche_del.UseVisualStyleBackColor = false;
            this.btn_branche_del.Click += new System.EventHandler(this.btn_branche_del_Click);
            // 
            // lbl_bill_Branches
            // 
            this.lbl_bill_Branches.AutoSize = true;
            this.lbl_bill_Branches.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_bill_Branches.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_bill_Branches.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_bill_Branches.Location = new System.Drawing.Point(1164, 0);
            this.lbl_bill_Branches.Name = "lbl_bill_Branches";
            this.lbl_bill_Branches.Padding = new System.Windows.Forms.Padding(15, 18, 0, 0);
            this.lbl_bill_Branches.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bill_Branches.Size = new System.Drawing.Size(15, 35);
            this.lbl_bill_Branches.TabIndex = 35;
            this.lbl_bill_Branches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Bill_Branche
            // 
            this.btn_Bill_Branche.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Bill_Branche.FlatAppearance.BorderSize = 0;
            this.btn_Bill_Branche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill_Branche.Location = new System.Drawing.Point(1179, 0);
            this.btn_Bill_Branche.Name = "btn_Bill_Branche";
            this.btn_Bill_Branche.Size = new System.Drawing.Size(80, 53);
            this.btn_Bill_Branche.TabIndex = 34;
            this.btn_Bill_Branche.Text = "الفرع :";
            this.btn_Bill_Branche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill_Branche.UseVisualStyleBackColor = true;
            this.btn_Bill_Branche.Click += new System.EventHandler(this.btn_Bill_Branche_Click);
            // 
            // contextMenuStrip_branches
            // 
            this.contextMenuStrip_branches.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_branches.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_branches.Name = "contextMenuStrip_branches";
            this.contextMenuStrip_branches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_branches.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_branches.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_branches_ItemClicked);
            // 
            // contextMenuStrip_cc1
            // 
            this.contextMenuStrip_cc1.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_cc1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_cc1.Name = "contextMenuStrip_cc1";
            this.contextMenuStrip_cc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_cc1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_cc1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_cc1_ItemClicked);
            // 
            // contextMenuStrip_cc2
            // 
            this.contextMenuStrip_cc2.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_cc2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_cc2.Name = "contextMenuStrip_cc2";
            this.contextMenuStrip_cc2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_cc2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_cc2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_cc2_ItemClicked);
            // 
            // FRM_BS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 790);
            this.Controls.Add(this.groupBox_Footer_Details);
            this.Controls.Add(this.groupBox_Footer_Controls);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox_Header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_FRM_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_BS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.FRM_BS_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Header.ResumeLayout(false);
            this.groupBox_Header.PerformLayout();
            this.groupBox_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox_Footer_Details.ResumeLayout(false);
            this.groupBox_Footer_Details.PerformLayout();
            this.panel_FRM_Head.ResumeLayout(false);
            this.panel_FRM_Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button_Print;
        public System.Windows.Forms.Button button_Settings;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.Button button_Display;
        public System.Windows.Forms.GroupBox groupBox_Header;
        private System.Windows.Forms.DateTimePicker dtp_form;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox_Details;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox_Footer_Details;
        private System.Windows.Forms.GroupBox groupBox_Footer_Controls;
        private System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_FRM_Head;
        private System.Windows.Forms.ComboBox combo_CC2;
        private System.Windows.Forms.ComboBox combo_CC1;
        private System.Windows.Forms.ComboBox combo_Bill_Branches;
        private System.Windows.Forms.Button btn_cc2_del;
        private System.Windows.Forms.Label lbl_CC2;
        private System.Windows.Forms.Button btn_CC2;
        private System.Windows.Forms.Button btn_cc1_del;
        private System.Windows.Forms.Label lbl_CC1;
        private System.Windows.Forms.Button btn_CC1;
        private System.Windows.Forms.Label lbl_bill_Branches;
        private System.Windows.Forms.Button btn_Bill_Branche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_branches;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_cc1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_cc2;
        private System.Windows.Forms.Button btn_branche_del;
        public System.Windows.Forms.Label lbl_Working_capital;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_Total_Investment;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}