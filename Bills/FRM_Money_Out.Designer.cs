namespace Library.Bills
{
    partial class FRM_Money_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Money_Out));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.btn_Jor_No = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Ven = new System.Windows.Forms.CheckBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_Pay_Type = new System.Windows.Forms.ComboBox();
            this.com_ACC_ID_To = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Money_Out_Date = new System.Windows.Forms.DateTimePicker();
            this.com_ACC_Name_To = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Bill_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Footer_Controls = new System.Windows.Forms.GroupBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            this.panel_FRM_Head = new System.Windows.Forms.Panel();
            this.combo_Bill_User = new System.Windows.Forms.ComboBox();
            this.combo_CC2 = new System.Windows.Forms.ComboBox();
            this.combo_CC1 = new System.Windows.Forms.ComboBox();
            this.combo_Bill_Branches = new System.Windows.Forms.ComboBox();
            this.btn_Bill_User = new System.Windows.Forms.Button();
            this.btn_cc2_del = new System.Windows.Forms.Button();
            this.lbl_CC2 = new System.Windows.Forms.Label();
            this.btn_CC2 = new System.Windows.Forms.Button();
            this.btn_cc1_del = new System.Windows.Forms.Button();
            this.lbl_CC1 = new System.Windows.Forms.Label();
            this.btn_CC1 = new System.Windows.Forms.Button();
            this.lbl_bill_Branches = new System.Windows.Forms.Label();
            this.btn_Bill_Branche = new System.Windows.Forms.Button();
            this.lbl_Bill_User = new System.Windows.Forms.Label();
            this.contextMenuStrip_cc1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_cc2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_users = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_branches = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Details.SuspendLayout();
            this.groupBox_Footer_Controls.SuspendLayout();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_Print);
            this.groupBox1.Controls.Add(this.button_Settings);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_New);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Edit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 87);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
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
            this.button_Settings.MouseEnter += new System.EventHandler(this.button_Settings_MouseEnter);
            this.button_Settings.MouseLeave += new System.EventHandler(this.button_Settings_MouseLeave);
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
            this.button_New.Location = new System.Drawing.Point(766, 11);
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
            this.button_Cancel.Location = new System.Drawing.Point(541, 11);
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
            this.button_Delete.Location = new System.Drawing.Point(616, 11);
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
            this.button_Edit.Location = new System.Drawing.Point(691, 11);
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
            // groupBox_Details
            // 
            this.groupBox_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Details.Controls.Add(this.btn_Jor_No);
            this.groupBox_Details.Controls.Add(this.label3);
            this.groupBox_Details.Controls.Add(this.cbx_Ven);
            this.groupBox_Details.Controls.Add(this.txt_Value);
            this.groupBox_Details.Controls.Add(this.label4);
            this.groupBox_Details.Controls.Add(this.com_Pay_Type);
            this.groupBox_Details.Controls.Add(this.com_ACC_ID_To);
            this.groupBox_Details.Controls.Add(this.label5);
            this.groupBox_Details.Controls.Add(this.label2);
            this.groupBox_Details.Controls.Add(this.dtp_Money_Out_Date);
            this.groupBox_Details.Controls.Add(this.com_ACC_Name_To);
            this.groupBox_Details.Controls.Add(this.label7);
            this.groupBox_Details.Controls.Add(this.txt_Notes);
            this.groupBox_Details.Controls.Add(this.label6);
            this.groupBox_Details.Controls.Add(this.textBox_Bill_ID);
            this.groupBox_Details.Controls.Add(this.label1);
            this.groupBox_Details.Location = new System.Drawing.Point(0, 140);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1259, 594);
            this.groupBox_Details.TabIndex = 52;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Tag = "";
            // 
            // btn_Jor_No
            // 
            this.btn_Jor_No.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Jor_No.FlatAppearance.BorderSize = 0;
            this.btn_Jor_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Jor_No.ImageKey = "New";
            this.btn_Jor_No.Location = new System.Drawing.Point(1050, 44);
            this.btn_Jor_No.Name = "btn_Jor_No";
            this.btn_Jor_No.Size = new System.Drawing.Size(116, 20);
            this.btn_Jor_No.TabIndex = 50;
            this.btn_Jor_No.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Jor_No.UseVisualStyleBackColor = true;
            this.btn_Jor_No.Click += new System.EventHandler(this.btn_Jor_No_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1172, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "رقم القيد";
            // 
            // cbx_Ven
            // 
            this.cbx_Ven.AutoSize = true;
            this.cbx_Ven.Enabled = false;
            this.cbx_Ven.Location = new System.Drawing.Point(271, 230);
            this.cbx_Ven.Name = "cbx_Ven";
            this.cbx_Ven.Size = new System.Drawing.Size(87, 17);
            this.cbx_Ven.TabIndex = 38;
            this.cbx_Ven.Text = "الموردون فقط";
            this.cbx_Ven.UseVisualStyleBackColor = true;
            this.cbx_Ven.CheckedChanged += new System.EventHandler(this.checkBox_Ven_CheckedChanged);
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(594, 144);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.ReadOnly = true;
            this.txt_Value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Value.Size = new System.Drawing.Size(115, 20);
            this.txt_Value.TabIndex = 37;
            this.txt_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Value_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "المبلغ";
            // 
            // com_Pay_Type
            // 
            this.com_Pay_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_Pay_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Pay_Type.BackColor = System.Drawing.SystemColors.Window;
            this.com_Pay_Type.DisplayMember = "Pay_Type_Name";
            this.com_Pay_Type.Enabled = false;
            this.com_Pay_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Pay_Type.FormattingEnabled = true;
            this.com_Pay_Type.Location = new System.Drawing.Point(455, 19);
            this.com_Pay_Type.Name = "com_Pay_Type";
            this.com_Pay_Type.Size = new System.Drawing.Size(103, 21);
            this.com_Pay_Type.TabIndex = 35;
            this.com_Pay_Type.ValueMember = "Pay_Type_ID";
            // 
            // com_ACC_ID_To
            // 
            this.com_ACC_ID_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_ACC_ID_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_ACC_ID_To.BackColor = System.Drawing.SystemColors.Window;
            this.com_ACC_ID_To.DisplayMember = "ACC_ID";
            this.com_ACC_ID_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com_ACC_ID_To.Enabled = false;
            this.com_ACC_ID_To.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_ACC_ID_To.FormattingEnabled = true;
            this.com_ACC_ID_To.Location = new System.Drawing.Point(691, 231);
            this.com_ACC_ID_To.Name = "com_ACC_ID_To";
            this.com_ACC_ID_To.Size = new System.Drawing.Size(132, 21);
            this.com_ACC_ID_To.TabIndex = 31;
            this.com_ACC_ID_To.ValueMember = "ACC_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(829, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "صرف إلى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(564, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "طريقة الدفع";
            // 
            // dtp_Money_Out_Date
            // 
            this.dtp_Money_Out_Date.CustomFormat = " ";
            this.dtp_Money_Out_Date.Enabled = false;
            this.dtp_Money_Out_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Money_Out_Date.Location = new System.Drawing.Point(778, 19);
            this.dtp_Money_Out_Date.Name = "dtp_Money_Out_Date";
            this.dtp_Money_Out_Date.RightToLeftLayout = true;
            this.dtp_Money_Out_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Money_Out_Date.TabIndex = 27;
            // 
            // com_ACC_Name_To
            // 
            this.com_ACC_Name_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_ACC_Name_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_ACC_Name_To.BackColor = System.Drawing.SystemColors.Window;
            this.com_ACC_Name_To.DisplayMember = "ACC_Name";
            this.com_ACC_Name_To.Enabled = false;
            this.com_ACC_Name_To.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_ACC_Name_To.FormattingEnabled = true;
            this.com_ACC_Name_To.Location = new System.Drawing.Point(452, 230);
            this.com_ACC_Name_To.Name = "com_ACC_Name_To";
            this.com_ACC_Name_To.Size = new System.Drawing.Size(233, 21);
            this.com_ACC_Name_To.TabIndex = 22;
            this.com_ACC_Name_To.ValueMember = "ACC_ID";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(984, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "تاريخ السند";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(452, 341);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(371, 88);
            this.txt_Notes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "الـبـيـان";
            // 
            // textBox_Bill_ID
            // 
            this.textBox_Bill_ID.Location = new System.Drawing.Point(1050, 19);
            this.textBox_Bill_ID.Name = "textBox_Bill_ID";
            this.textBox_Bill_ID.ReadOnly = true;
            this.textBox_Bill_ID.Size = new System.Drawing.Size(116, 20);
            this.textBox_Bill_ID.TabIndex = 1;
            this.textBox_Bill_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1172, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند";
            // 
            // groupBox_Footer_Controls
            // 
            this.groupBox_Footer_Controls.Controls.Add(this.textBox_Search);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Last);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Prev);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Next);
            this.groupBox_Footer_Controls.Controls.Add(this.button_First);
            this.groupBox_Footer_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Controls.Location = new System.Drawing.Point(0, 729);
            this.groupBox_Footer_Controls.Name = "groupBox_Footer_Controls";
            this.groupBox_Footer_Controls.Size = new System.Drawing.Size(1259, 61);
            this.groupBox_Footer_Controls.TabIndex = 68;
            this.groupBox_Footer_Controls.TabStop = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_Search.Location = new System.Drawing.Point(127, 30);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(90, 13);
            this.textBox_Search.TabIndex = 38;
            this.textBox_Search.Text = "Search";
            this.textBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            this.textBox_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            this.textBox_Search.MouseEnter += new System.EventHandler(this.textBox_Search_MouseEnter);
            this.textBox_Search.MouseLeave += new System.EventHandler(this.textBox_Search_MouseLeave);
            // 
            // button_Last
            // 
            this.button_Last.FlatAppearance.BorderSize = 0;
            this.button_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Last.Location = new System.Drawing.Point(35, 21);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(40, 30);
            this.button_Last.TabIndex = 35;
            this.button_Last.Text = ">>|";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            this.button_Last.MouseEnter += new System.EventHandler(this.button_Last_MouseEnter);
            this.button_Last.MouseLeave += new System.EventHandler(this.button_Last_MouseLeave);
            // 
            // button_Prev
            // 
            this.button_Prev.FlatAppearance.BorderSize = 0;
            this.button_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Prev.Location = new System.Drawing.Point(225, 21);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(40, 30);
            this.button_Prev.TabIndex = 36;
            this.button_Prev.Text = "<";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            this.button_Prev.MouseEnter += new System.EventHandler(this.button_Prev_MouseEnter);
            this.button_Prev.MouseLeave += new System.EventHandler(this.button_Prev_MouseLeave);
            // 
            // button_Next
            // 
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Location = new System.Drawing.Point(81, 21);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(40, 30);
            this.button_Next.TabIndex = 37;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            this.button_Next.MouseEnter += new System.EventHandler(this.button_Next_MouseEnter);
            this.button_Next.MouseLeave += new System.EventHandler(this.button_Next_MouseLeave);
            // 
            // button_First
            // 
            this.button_First.FlatAppearance.BorderSize = 0;
            this.button_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_First.Location = new System.Drawing.Point(271, 21);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(40, 30);
            this.button_First.TabIndex = 34;
            this.button_First.Text = "|<<";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            this.button_First.MouseEnter += new System.EventHandler(this.button_First_MouseEnter);
            this.button_First.MouseLeave += new System.EventHandler(this.button_First_MouseLeave);
            // 
            // panel_FRM_Head
            // 
            this.panel_FRM_Head.BackColor = System.Drawing.Color.Silver;
            this.panel_FRM_Head.Controls.Add(this.combo_Bill_User);
            this.panel_FRM_Head.Controls.Add(this.combo_CC2);
            this.panel_FRM_Head.Controls.Add(this.combo_CC1);
            this.panel_FRM_Head.Controls.Add(this.combo_Bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_User);
            this.panel_FRM_Head.Controls.Add(this.btn_cc2_del);
            this.panel_FRM_Head.Controls.Add(this.lbl_CC2);
            this.panel_FRM_Head.Controls.Add(this.btn_CC2);
            this.panel_FRM_Head.Controls.Add(this.btn_cc1_del);
            this.panel_FRM_Head.Controls.Add(this.lbl_CC1);
            this.panel_FRM_Head.Controls.Add(this.btn_CC1);
            this.panel_FRM_Head.Controls.Add(this.lbl_bill_Branches);
            this.panel_FRM_Head.Controls.Add(this.btn_Bill_Branche);
            this.panel_FRM_Head.Controls.Add(this.lbl_Bill_User);
            this.panel_FRM_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FRM_Head.Location = new System.Drawing.Point(0, 0);
            this.panel_FRM_Head.Name = "panel_FRM_Head";
            this.panel_FRM_Head.Size = new System.Drawing.Size(1259, 53);
            this.panel_FRM_Head.TabIndex = 69;
            // 
            // combo_Bill_User
            // 
            this.combo_Bill_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_Bill_User.DisplayMember = "User_Name";
            this.combo_Bill_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Bill_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Bill_User.FormattingEnabled = true;
            this.combo_Bill_User.Location = new System.Drawing.Point(82, 0);
            this.combo_Bill_User.Name = "combo_Bill_User";
            this.combo_Bill_User.Size = new System.Drawing.Size(118, 21);
            this.combo_Bill_User.TabIndex = 33;
            this.combo_Bill_User.ValueMember = "User_ID";
            this.combo_Bill_User.Visible = false;
            this.combo_Bill_User.SelectedIndexChanged += new System.EventHandler(this.combo_Bill_User_SelectedIndexChanged);
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
            this.combo_Bill_Branches.SelectedIndexChanged += new System.EventHandler(this.combo_Bill_Branches_SelectedValueChanged);
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
            // btn_cc2_del
            // 
            this.btn_cc2_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_cc2_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cc2_del.FlatAppearance.BorderSize = 0;
            this.btn_cc2_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_cc2_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_cc2_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cc2_del.Location = new System.Drawing.Point(918, 0);
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
            this.lbl_CC2.Location = new System.Drawing.Point(938, 0);
            this.lbl_CC2.Name = "lbl_CC2";
            this.lbl_CC2.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lbl_CC2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CC2.Size = new System.Drawing.Size(0, 35);
            this.lbl_CC2.TabIndex = 41;
            this.lbl_CC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CC2.TextChanged += new System.EventHandler(this.lbl_CC2_TextChanged);
            // 
            // btn_CC2
            // 
            this.btn_CC2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CC2.FlatAppearance.BorderSize = 0;
            this.btn_CC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CC2.Location = new System.Drawing.Point(938, 0);
            this.btn_CC2.Name = "btn_CC2";
            this.btn_CC2.Size = new System.Drawing.Size(103, 53);
            this.btn_CC2.TabIndex = 40;
            this.btn_CC2.Text = "مركز 2 : ";
            this.btn_CC2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CC2.UseVisualStyleBackColor = true;
            this.btn_CC2.Click += new System.EventHandler(this.btn_CC2_Click);
            this.btn_CC2.MouseEnter += new System.EventHandler(this.btn_CC2_MouseEnter);
            this.btn_CC2.MouseLeave += new System.EventHandler(this.btn_CC2_MouseLeave);
            // 
            // btn_cc1_del
            // 
            this.btn_cc1_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_cc1_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cc1_del.FlatAppearance.BorderSize = 0;
            this.btn_cc1_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_cc1_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_cc1_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cc1_del.Location = new System.Drawing.Point(1041, 0);
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
            this.lbl_CC1.Location = new System.Drawing.Point(1061, 0);
            this.lbl_CC1.Name = "lbl_CC1";
            this.lbl_CC1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lbl_CC1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CC1.Size = new System.Drawing.Size(0, 35);
            this.lbl_CC1.TabIndex = 39;
            this.lbl_CC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CC1.TextChanged += new System.EventHandler(this.lbl_CC1_TextChanged);
            // 
            // btn_CC1
            // 
            this.btn_CC1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CC1.FlatAppearance.BorderSize = 0;
            this.btn_CC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CC1.Location = new System.Drawing.Point(1061, 0);
            this.btn_CC1.Name = "btn_CC1";
            this.btn_CC1.Size = new System.Drawing.Size(103, 53);
            this.btn_CC1.TabIndex = 38;
            this.btn_CC1.Text = "مركز 1 :";
            this.btn_CC1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CC1.UseVisualStyleBackColor = true;
            this.btn_CC1.Click += new System.EventHandler(this.btn_CC1_Click);
            this.btn_CC1.MouseEnter += new System.EventHandler(this.btn_CC1_MouseEnter);
            this.btn_CC1.MouseLeave += new System.EventHandler(this.btn_CC1_MouseLeave);
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
            // contextMenuStrip_users
            // 
            this.contextMenuStrip_users.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip_users.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_users.Name = "contextMenuStrip_users";
            this.contextMenuStrip_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_users.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_users.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_users_ItemClicked);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageKey = "New";
            this.button1.Location = new System.Drawing.Point(1019, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "سند صرف";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRM_Money_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 790);
            this.Controls.Add(this.groupBox_Footer_Controls);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_FRM_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Money_Out";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "Empty";
            this.Text = "FRM_Money_Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FRM_Money_Out_Shown);
            this.Enter += new System.EventHandler(this.FRM_Money_Out_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Details.ResumeLayout(false);
            this.groupBox_Details.PerformLayout();
            this.groupBox_Footer_Controls.ResumeLayout(false);
            this.groupBox_Footer_Controls.PerformLayout();
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
        public System.Windows.Forms.Button button_New;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        public System.Windows.Forms.GroupBox groupBox_Details;
        private System.Windows.Forms.CheckBox cbx_Ven;
        public System.Windows.Forms.TextBox txt_Value;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_Pay_Type;
        private System.Windows.Forms.ComboBox com_ACC_ID_To;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Money_Out_Date;
        private System.Windows.Forms.ComboBox com_ACC_Name_To;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_Bill_ID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Footer_Controls;
        public System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Panel panel_FRM_Head;
        private System.Windows.Forms.ComboBox combo_Bill_User;
        private System.Windows.Forms.ComboBox combo_CC2;
        private System.Windows.Forms.ComboBox combo_CC1;
        private System.Windows.Forms.ComboBox combo_Bill_Branches;
        private System.Windows.Forms.Button btn_Bill_User;
        private System.Windows.Forms.Button btn_cc2_del;
        private System.Windows.Forms.Label lbl_CC2;
        private System.Windows.Forms.Button btn_CC2;
        private System.Windows.Forms.Button btn_cc1_del;
        private System.Windows.Forms.Label lbl_CC1;
        private System.Windows.Forms.Button btn_CC1;
        private System.Windows.Forms.Label lbl_bill_Branches;
        private System.Windows.Forms.Button btn_Bill_Branche;
        private System.Windows.Forms.Label lbl_Bill_User;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_cc1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_cc2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_users;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_branches;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_Jor_No;
        public System.Windows.Forms.Button button1;
    }
}