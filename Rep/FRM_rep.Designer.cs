namespace Library.Rep
{
    partial class FRM_rep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_rep));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Condition = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.EXCEL = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.btn_RepDelete = new System.Windows.Forms.Button();
            this.com_Fields = new System.Windows.Forms.ComboBox();
            this.tab_dis = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.num_FontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_index = new System.Windows.Forms.CheckBox();
            this.num_TopRecords = new System.Windows.Forms.NumericUpDown();
            this.rad_Only = new System.Windows.Forms.RadioButton();
            this.rad_AllRecords = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_MoveLast = new System.Windows.Forms.Button();
            this.btn_MoveDowen = new System.Windows.Forms.Button();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_MoveFirst = new System.Windows.Forms.Button();
            this.list_Forward = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BackAll = new System.Windows.Forms.Button();
            this.btn_ForwardAll = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.list_Back = new System.Windows.Forms.ListBox();
            this.pnl_FieldsTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.F = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.not = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_SQL = new System.Windows.Forms.TextBox();
            this.com_RepGenerator = new System.Windows.Forms.ComboBox();
            this.btn_SaveRep = new System.Windows.Forms.Button();
            this.txt_RepName = new System.Windows.Forms.TextBox();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_dis.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TopRecords)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_FieldsTitle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Details.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_Details.Controls.Add(this.DGV);
            this.groupBox_Details.Controls.Add(this.txt_Condition);
            this.groupBox_Details.Controls.Add(this.txt_Title);
            this.groupBox_Details.Location = new System.Drawing.Point(-8, 223);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1259, 516);
            this.groupBox_Details.TabIndex = 58;
            this.groupBox_Details.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 66);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1253, 447);
            this.DGV.TabIndex = 16;
            this.DGV.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellMouseEnter);
            this.DGV.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellMouseLeave);
            // 
            // Index
            // 
            this.Index.HeaderText = " # ";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            this.Index.Width = 51;
            // 
            // txt_Condition
            // 
            this.txt_Condition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Condition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Condition.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Condition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Condition.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_Condition.Location = new System.Drawing.Point(3, 41);
            this.txt_Condition.Multiline = true;
            this.txt_Condition.Name = "txt_Condition";
            this.txt_Condition.ReadOnly = true;
            this.txt_Condition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Condition.Size = new System.Drawing.Size(1253, 25);
            this.txt_Condition.TabIndex = 17;
            // 
            // txt_Title
            // 
            this.txt_Title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.ForeColor = System.Drawing.Color.Navy;
            this.txt_Title.Location = new System.Drawing.Point(3, 16);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.ReadOnly = true;
            this.txt_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Title.Size = new System.Drawing.Size(1253, 25);
            this.txt_Title.TabIndex = 18;
            this.txt_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Display);
            this.groupBox1.Controls.Add(this.EXCEL);
            this.groupBox1.Controls.Add(this.button_Print);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.btn_RepDelete);
            this.groupBox1.Controls.Add(this.com_Fields);
            this.groupBox1.Controls.Add(this.tab_dis);
            this.groupBox1.Controls.Add(this.com_RepGenerator);
            this.groupBox1.Controls.Add(this.btn_SaveRep);
            this.groupBox1.Controls.Add(this.txt_RepName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 217);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // btn_Display
            // 
            this.btn_Display.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Display.FlatAppearance.BorderSize = 0;
            this.btn_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display.ImageKey = "(none)";
            this.btn_Display.Location = new System.Drawing.Point(237, 16);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(69, 198);
            this.btn_Display.TabIndex = 12;
            this.btn_Display.Text = "عرض";
            this.btn_Display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.button_Display_Click);
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
            this.imageList1.Images.SetKeyName(13, "excel_48.png");
            // 
            // EXCEL
            // 
            this.EXCEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.EXCEL.FlatAppearance.BorderSize = 0;
            this.EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXCEL.ImageKey = "excel_48.png";
            this.EXCEL.ImageList = this.imageList1;
            this.EXCEL.Location = new System.Drawing.Point(141, 16);
            this.EXCEL.Name = "EXCEL";
            this.EXCEL.Size = new System.Drawing.Size(96, 198);
            this.EXCEL.TabIndex = 15;
            this.EXCEL.Text = "تصدير للإكسيل";
            this.EXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EXCEL.UseVisualStyleBackColor = true;
            this.EXCEL.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // button_Print
            // 
            this.button_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.ImageKey = "Print";
            this.button_Print.ImageList = this.imageList1;
            this.button_Print.Location = new System.Drawing.Point(72, 16);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(69, 198);
            this.button_Print.TabIndex = 14;
            this.button_Print.Text = "طباعة";
            this.button_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Print.UseVisualStyleBackColor = true;
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
            this.button_Close.Size = new System.Drawing.Size(69, 198);
            this.button_Close.TabIndex = 13;
            this.button_Close.Text = "إغلاق";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // btn_RepDelete
            // 
            this.btn_RepDelete.FlatAppearance.BorderSize = 0;
            this.btn_RepDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RepDelete.ImageKey = "(none)";
            this.btn_RepDelete.Location = new System.Drawing.Point(843, 189);
            this.btn_RepDelete.Name = "btn_RepDelete";
            this.btn_RepDelete.Size = new System.Drawing.Size(39, 20);
            this.btn_RepDelete.TabIndex = 10;
            this.btn_RepDelete.Text = "حذف";
            this.btn_RepDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RepDelete.UseVisualStyleBackColor = true;
            this.btn_RepDelete.Click += new System.EventHandler(this.btn_RepDelete_Click);
            // 
            // com_Fields
            // 
            this.com_Fields.DisplayMember = "Column_Name";
            this.com_Fields.FormattingEnabled = true;
            this.com_Fields.Location = new System.Drawing.Point(504, 189);
            this.com_Fields.Name = "com_Fields";
            this.com_Fields.Size = new System.Drawing.Size(174, 21);
            this.com_Fields.TabIndex = 8;
            this.com_Fields.ValueMember = "Data_Type";
            this.com_Fields.Visible = false;
            // 
            // tab_dis
            // 
            this.tab_dis.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_dis.Controls.Add(this.tabPage1);
            this.tab_dis.Controls.Add(this.tabPage2);
            this.tab_dis.Controls.Add(this.tabPage3);
            this.tab_dis.Location = new System.Drawing.Point(500, 16);
            this.tab_dis.Name = "tab_dis";
            this.tab_dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_dis.RightToLeftLayout = true;
            this.tab_dis.SelectedIndex = 0;
            this.tab_dis.Size = new System.Drawing.Size(740, 167);
            this.tab_dis.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.num_FontSize);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chk_index);
            this.tabPage1.Controls.Add(this.num_TopRecords);
            this.tabPage1.Controls.Add(this.rad_Only);
            this.tabPage1.Controls.Add(this.rad_AllRecords);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.list_Forward);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.list_Back);
            this.tabPage1.Controls.Add(this.pnl_FieldsTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  محتويات التقرير  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // num_FontSize
            // 
            this.num_FontSize.Location = new System.Drawing.Point(26, 62);
            this.num_FontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_FontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_FontSize.Name = "num_FontSize";
            this.num_FontSize.Size = new System.Drawing.Size(43, 20);
            this.num_FontSize.TabIndex = 51;
            this.num_FontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_FontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "حجم الخط";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_index
            // 
            this.chk_index.AutoSize = true;
            this.chk_index.Location = new System.Drawing.Point(74, 32);
            this.chk_index.Name = "chk_index";
            this.chk_index.Size = new System.Drawing.Size(51, 17);
            this.chk_index.TabIndex = 49;
            this.chk_index.Text = "ترقيم";
            this.chk_index.UseVisualStyleBackColor = true;
            // 
            // num_TopRecords
            // 
            this.num_TopRecords.Location = new System.Drawing.Point(201, 62);
            this.num_TopRecords.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_TopRecords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TopRecords.Name = "num_TopRecords";
            this.num_TopRecords.Size = new System.Drawing.Size(43, 20);
            this.num_TopRecords.TabIndex = 48;
            this.num_TopRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_TopRecords.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rad_Only
            // 
            this.rad_Only.AutoSize = true;
            this.rad_Only.Location = new System.Drawing.Point(247, 63);
            this.rad_Only.Name = "rad_Only";
            this.rad_Only.Size = new System.Drawing.Size(62, 17);
            this.rad_Only.TabIndex = 47;
            this.rad_Only.TabStop = true;
            this.rad_Only.Text = "فقط أول";
            this.rad_Only.UseVisualStyleBackColor = true;
            // 
            // rad_AllRecords
            // 
            this.rad_AllRecords.AutoSize = true;
            this.rad_AllRecords.Checked = true;
            this.rad_AllRecords.Location = new System.Drawing.Point(198, 32);
            this.rad_AllRecords.Name = "rad_AllRecords";
            this.rad_AllRecords.Size = new System.Drawing.Size(111, 17);
            this.rad_AllRecords.TabIndex = 46;
            this.rad_AllRecords.TabStop = true;
            this.rad_AllRecords.Text = "عرض كل السجلات";
            this.rad_AllRecords.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_MoveLast);
            this.panel2.Controls.Add(this.btn_MoveDowen);
            this.panel2.Controls.Add(this.btn_MoveUp);
            this.panel2.Controls.Add(this.btn_MoveFirst);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(339, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 108);
            this.panel2.TabIndex = 44;
            // 
            // btn_MoveLast
            // 
            this.btn_MoveLast.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoveLast.FlatAppearance.BorderSize = 0;
            this.btn_MoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoveLast.Location = new System.Drawing.Point(0, 75);
            this.btn_MoveLast.Name = "btn_MoveLast";
            this.btn_MoveLast.Size = new System.Drawing.Size(45, 25);
            this.btn_MoveLast.TabIndex = 38;
            this.btn_MoveLast.Text = "v";
            this.btn_MoveLast.UseVisualStyleBackColor = true;
            this.btn_MoveLast.Click += new System.EventHandler(this.btn_MoveLast_Click);
            // 
            // btn_MoveDowen
            // 
            this.btn_MoveDowen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoveDowen.FlatAppearance.BorderSize = 0;
            this.btn_MoveDowen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoveDowen.Location = new System.Drawing.Point(0, 50);
            this.btn_MoveDowen.Name = "btn_MoveDowen";
            this.btn_MoveDowen.Size = new System.Drawing.Size(45, 25);
            this.btn_MoveDowen.TabIndex = 39;
            this.btn_MoveDowen.Text = "v";
            this.btn_MoveDowen.UseVisualStyleBackColor = true;
            this.btn_MoveDowen.Click += new System.EventHandler(this.btn_MoveDowen_Click);
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoveUp.FlatAppearance.BorderSize = 0;
            this.btn_MoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoveUp.Location = new System.Drawing.Point(0, 25);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(45, 25);
            this.btn_MoveUp.TabIndex = 40;
            this.btn_MoveUp.Text = "^";
            this.btn_MoveUp.UseVisualStyleBackColor = true;
            this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
            // 
            // btn_MoveFirst
            // 
            this.btn_MoveFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoveFirst.FlatAppearance.BorderSize = 0;
            this.btn_MoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoveFirst.Location = new System.Drawing.Point(0, 0);
            this.btn_MoveFirst.Name = "btn_MoveFirst";
            this.btn_MoveFirst.Size = new System.Drawing.Size(45, 25);
            this.btn_MoveFirst.TabIndex = 41;
            this.btn_MoveFirst.Text = "^";
            this.btn_MoveFirst.UseVisualStyleBackColor = true;
            this.btn_MoveFirst.Click += new System.EventHandler(this.btn_MoveFirst_Click);
            // 
            // list_Forward
            // 
            this.list_Forward.Dock = System.Windows.Forms.DockStyle.Right;
            this.list_Forward.FormattingEnabled = true;
            this.list_Forward.Location = new System.Drawing.Point(384, 27);
            this.list_Forward.Name = "list_Forward";
            this.list_Forward.Size = new System.Drawing.Size(150, 108);
            this.list_Forward.TabIndex = 43;
            this.list_Forward.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Forward_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_BackAll);
            this.panel1.Controls.Add(this.btn_ForwardAll);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Forward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(534, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 108);
            this.panel1.TabIndex = 42;
            // 
            // btn_BackAll
            // 
            this.btn_BackAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BackAll.FlatAppearance.BorderSize = 0;
            this.btn_BackAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackAll.Location = new System.Drawing.Point(0, 75);
            this.btn_BackAll.Name = "btn_BackAll";
            this.btn_BackAll.Size = new System.Drawing.Size(45, 25);
            this.btn_BackAll.TabIndex = 38;
            this.btn_BackAll.Text = "<<";
            this.btn_BackAll.UseVisualStyleBackColor = true;
            this.btn_BackAll.Click += new System.EventHandler(this.btn_BackAll_Click);
            // 
            // btn_ForwardAll
            // 
            this.btn_ForwardAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ForwardAll.FlatAppearance.BorderSize = 0;
            this.btn_ForwardAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForwardAll.Location = new System.Drawing.Point(0, 50);
            this.btn_ForwardAll.Name = "btn_ForwardAll";
            this.btn_ForwardAll.Size = new System.Drawing.Size(45, 25);
            this.btn_ForwardAll.TabIndex = 39;
            this.btn_ForwardAll.Text = ">>";
            this.btn_ForwardAll.UseVisualStyleBackColor = true;
            this.btn_ForwardAll.Click += new System.EventHandler(this.btn_ForwardAll_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(0, 25);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(45, 25);
            this.btn_Back.TabIndex = 40;
            this.btn_Back.Text = "<";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Forward.FlatAppearance.BorderSize = 0;
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.Location = new System.Drawing.Point(0, 0);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(45, 25);
            this.btn_Forward.TabIndex = 41;
            this.btn_Forward.Text = ">";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // list_Back
            // 
            this.list_Back.Dock = System.Windows.Forms.DockStyle.Right;
            this.list_Back.FormattingEnabled = true;
            this.list_Back.Location = new System.Drawing.Point(579, 27);
            this.list_Back.Name = "list_Back";
            this.list_Back.Size = new System.Drawing.Size(150, 108);
            this.list_Back.TabIndex = 0;
            this.list_Back.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Back_MouseDoubleClick);
            // 
            // pnl_FieldsTitle
            // 
            this.pnl_FieldsTitle.Controls.Add(this.label2);
            this.pnl_FieldsTitle.Controls.Add(this.label1);
            this.pnl_FieldsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_FieldsTitle.Location = new System.Drawing.Point(3, 3);
            this.pnl_FieldsTitle.Name = "pnl_FieldsTitle";
            this.pnl_FieldsTitle.Size = new System.Drawing.Size(726, 24);
            this.pnl_FieldsTitle.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(381, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الحقول المختارة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(576, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الحقول المتاحة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  شرو التقرير  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV_1
            // 
            this.DGV_1.AllowUserToAddRows = false;
            this.DGV_1.AllowUserToDeleteRows = false;
            this.DGV_1.AllowUserToOrderColumns = true;
            this.DGV_1.AllowUserToResizeColumns = false;
            this.DGV_1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F,
            this.not,
            this.ma,
            this.st,
            this.logic,
            this.Group,
            this.Order,
            this.Delete});
            this.DGV_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGV_1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_1.Location = new System.Drawing.Point(33, 3);
            this.DGV_1.Name = "DGV_1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_1.Size = new System.Drawing.Size(696, 132);
            this.DGV_1.TabIndex = 0;
            this.DGV_1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGV_1_CellBeginEdit);
            this.DGV_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_1_CellClick);
            this.DGV_1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_1_CellEndEdit);
            this.DGV_1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_1_CellValueChanged);
            this.DGV_1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_1_EditingControlShowing);
            // 
            // F
            // 
            this.F.DataPropertyName = "Field";
            this.F.HeaderText = "الحقل";
            this.F.Name = "F";
            this.F.Width = 150;
            // 
            // not
            // 
            this.not.DataPropertyName = "No";
            this.not.HeaderText = "لا";
            this.not.Name = "not";
            this.not.Width = 20;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "Operator";
            this.ma.HeaderText = "المعامل";
            this.ma.Items.AddRange(new object[] {
            "أختيار",
            "يبدأ بـ",
            "مساو لـ",
            "أكبر من",
            "أقل من",
            "أكبر من أو يساوي",
            "أقل من أو يساوي",
            "يتضمن"});
            this.ma.Name = "ma";
            this.ma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ma.Width = 120;
            // 
            // st
            // 
            this.st.DataPropertyName = "Condition";
            this.st.HeaderText = "الشرط";
            this.st.Name = "st";
            this.st.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.st.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.st.Width = 120;
            // 
            // logic
            // 
            this.logic.DataPropertyName = "Logic";
            this.logic.HeaderText = "منطقي";
            this.logic.Items.AddRange(new object[] {
            "و",
            "أو"});
            this.logic.Name = "logic";
            this.logic.Width = 50;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "تجميع";
            this.Group.Name = "Group";
            this.Group.Width = 50;
            // 
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "ترتيب";
            this.Order.Items.AddRange(new object[] {
            "",
            "تصاعدياً",
            "تنازلياً"});
            this.Order.Name = "Order";
            this.Order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Order.Width = 80;
            // 
            // Delete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.Delete.HeaderText = "حذف";
            this.Delete.Name = "Delete";
            this.Delete.Text = "";
            this.Delete.Width = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_SQL);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(732, 138);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_SQL
            // 
            this.txt_SQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SQL.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt_SQL.Location = new System.Drawing.Point(3, 3);
            this.txt_SQL.Multiline = true;
            this.txt_SQL.Name = "txt_SQL";
            this.txt_SQL.ReadOnly = true;
            this.txt_SQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_SQL.Size = new System.Drawing.Size(726, 132);
            this.txt_SQL.TabIndex = 0;
            // 
            // com_RepGenerator
            // 
            this.com_RepGenerator.DisplayMember = "Rep_Name";
            this.com_RepGenerator.FormattingEnabled = true;
            this.com_RepGenerator.Location = new System.Drawing.Point(888, 188);
            this.com_RepGenerator.Name = "com_RepGenerator";
            this.com_RepGenerator.Size = new System.Drawing.Size(150, 21);
            this.com_RepGenerator.TabIndex = 7;
            this.com_RepGenerator.ValueMember = "Rep_ID";
            this.com_RepGenerator.SelectedIndexChanged += new System.EventHandler(this.com_RepGenerator_SelectedIndexChanged);
            // 
            // btn_SaveRep
            // 
            this.btn_SaveRep.FlatAppearance.BorderSize = 0;
            this.btn_SaveRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveRep.ImageKey = "(none)";
            this.btn_SaveRep.Location = new System.Drawing.Point(1038, 189);
            this.btn_SaveRep.Name = "btn_SaveRep";
            this.btn_SaveRep.Size = new System.Drawing.Size(39, 20);
            this.btn_SaveRep.TabIndex = 5;
            this.btn_SaveRep.Text = "حفظ";
            this.btn_SaveRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_SaveRep.UseVisualStyleBackColor = true;
            this.btn_SaveRep.Click += new System.EventHandler(this.btn_SaveRep_Click);
            // 
            // txt_RepName
            // 
            this.txt_RepName.Location = new System.Drawing.Point(1083, 189);
            this.txt_RepName.Name = "txt_RepName";
            this.txt_RepName.Size = new System.Drawing.Size(150, 20);
            this.txt_RepName.TabIndex = 1;
            // 
            // FRM_rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 751);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_rep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_rep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_rep_Shown);
            this.Enter += new System.EventHandler(this.FRM_rep_Enter);
            this.groupBox_Details.ResumeLayout(false);
            this.groupBox_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_dis.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TopRecords)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_FieldsTitle.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_Details;
        public System.Windows.Forms.DataGridView DGV;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tab_dis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox list_Back;
        private System.Windows.Forms.ListBox list_Forward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_ForwardAll;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_BackAll;
        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_SQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_MoveLast;
        private System.Windows.Forms.Button btn_MoveDowen;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_MoveFirst;
        private System.Windows.Forms.TextBox txt_RepName;
        public System.Windows.Forms.Button btn_SaveRep;
        private System.Windows.Forms.ComboBox com_RepGenerator;
        private System.Windows.Forms.DataGridViewComboBoxColumn F;
        private System.Windows.Forms.DataGridViewCheckBoxColumn not;
        private System.Windows.Forms.DataGridViewComboBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.DataGridViewComboBoxColumn logic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Group;
        private System.Windows.Forms.DataGridViewComboBoxColumn Order;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox com_Fields;
        public System.Windows.Forms.Button btn_RepDelete;
        private System.Windows.Forms.TextBox txt_Condition;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Panel pnl_FieldsTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_TopRecords;
        private System.Windows.Forms.RadioButton rad_Only;
        private System.Windows.Forms.RadioButton rad_AllRecords;
        public System.Windows.Forms.Button btn_Display;
        public System.Windows.Forms.Button EXCEL;
        public System.Windows.Forms.Button button_Print;
        public System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.CheckBox chk_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.NumericUpDown num_FontSize;
        private System.Windows.Forms.Label label3;
    }
}