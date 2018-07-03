namespace Library.G
{
    partial class FRM_Items_Des
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
            this.txt_Current_Des = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Item = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Item_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Edit_des = new System.Windows.Forms.Button();
            this.btn_Save_des = new System.Windows.Forms.Button();
            this.btn_Cancel_des = new System.Windows.Forms.Button();
            this.pnl_Items = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.list_items = new System.Windows.Forms.ListBox();
            this.grbx_Item.SuspendLayout();
            this.pnl_Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Current_Des
            // 
            this.txt_Current_Des.Location = new System.Drawing.Point(128, 63);
            this.txt_Current_Des.Name = "txt_Current_Des";
            this.txt_Current_Des.ReadOnly = true;
            this.txt_Current_Des.Size = new System.Drawing.Size(191, 20);
            this.txt_Current_Des.TabIndex = 5;
            this.txt_Current_Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "أسم الوصف الحالي";
            // 
            // grbx_Item
            // 
            this.grbx_Item.Controls.Add(this.btn_Cancel);
            this.grbx_Item.Controls.Add(this.btn_Save);
            this.grbx_Item.Controls.Add(this.btn_Edit);
            this.grbx_Item.Controls.Add(this.txt_Notes);
            this.grbx_Item.Controls.Add(this.label3);
            this.grbx_Item.Controls.Add(this.txt_Item_Name);
            this.grbx_Item.Controls.Add(this.label4);
            this.grbx_Item.Location = new System.Drawing.Point(31, 141);
            this.grbx_Item.Name = "grbx_Item";
            this.grbx_Item.Size = new System.Drawing.Size(323, 242);
            this.grbx_Item.TabIndex = 8;
            this.grbx_Item.TabStop = false;
            this.grbx_Item.Text = "خصائص العنصر";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageKey = "Edit_16.png";
            this.btn_Cancel.Location = new System.Drawing.Point(6, 215);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(20, 21);
            this.btn_Cancel.TabIndex = 114;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Save.ImageKey = "(none)";
            this.btn_Save.Location = new System.Drawing.Point(32, 215);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(20, 21);
            this.btn_Save.TabIndex = 111;
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ImageKey = "Edit_16.png";
            this.btn_Edit.Location = new System.Drawing.Point(58, 215);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(20, 21);
            this.btn_Edit.TabIndex = 110;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(35, 98);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(191, 76);
            this.txt_Notes.TabIndex = 11;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "بيان";
            // 
            // txt_Item_Name
            // 
            this.txt_Item_Name.Location = new System.Drawing.Point(35, 44);
            this.txt_Item_Name.Name = "txt_Item_Name";
            this.txt_Item_Name.ReadOnly = true;
            this.txt_Item_Name.Size = new System.Drawing.Size(191, 20);
            this.txt_Item_Name.TabIndex = 9;
            this.txt_Item_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "أسم العنصر";
            // 
            // btn_Edit_des
            // 
            this.btn_Edit_des.FlatAppearance.BorderSize = 0;
            this.btn_Edit_des.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit_des.ImageKey = "Edit_16.png";
            this.btn_Edit_des.Location = new System.Drawing.Point(324, 63);
            this.btn_Edit_des.Name = "btn_Edit_des";
            this.btn_Edit_des.Size = new System.Drawing.Size(20, 21);
            this.btn_Edit_des.TabIndex = 111;
            this.btn_Edit_des.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit_des.UseVisualStyleBackColor = true;
            this.btn_Edit_des.Click += new System.EventHandler(this.btn_Edit_des_Click);
            // 
            // btn_Save_des
            // 
            this.btn_Save_des.FlatAppearance.BorderSize = 0;
            this.btn_Save_des.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_des.ImageKey = "Edit_16.png";
            this.btn_Save_des.Location = new System.Drawing.Point(347, 63);
            this.btn_Save_des.Name = "btn_Save_des";
            this.btn_Save_des.Size = new System.Drawing.Size(20, 21);
            this.btn_Save_des.TabIndex = 112;
            this.btn_Save_des.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save_des.UseVisualStyleBackColor = true;
            this.btn_Save_des.Visible = false;
            this.btn_Save_des.Click += new System.EventHandler(this.btn_Save_des_Click);
            // 
            // btn_Cancel_des
            // 
            this.btn_Cancel_des.FlatAppearance.BorderSize = 0;
            this.btn_Cancel_des.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel_des.ImageKey = "Edit_16.png";
            this.btn_Cancel_des.Location = new System.Drawing.Point(373, 62);
            this.btn_Cancel_des.Name = "btn_Cancel_des";
            this.btn_Cancel_des.Size = new System.Drawing.Size(20, 21);
            this.btn_Cancel_des.TabIndex = 113;
            this.btn_Cancel_des.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel_des.UseVisualStyleBackColor = true;
            this.btn_Cancel_des.Visible = false;
            this.btn_Cancel_des.Click += new System.EventHandler(this.btn_Cancel_des_Click);
            // 
            // pnl_Items
            // 
            this.pnl_Items.Controls.Add(this.btn_Remove);
            this.pnl_Items.Controls.Add(this.btn_Add);
            this.pnl_Items.Controls.Add(this.list_items);
            this.pnl_Items.Location = new System.Drawing.Point(399, 12);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.Size = new System.Drawing.Size(227, 432);
            this.pnl_Items.TabIndex = 114;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(36, 377);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "إزالة";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(117, 377);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "إضافة";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // list_items
            // 
            this.list_items.DisplayMember = "des_name";
            this.list_items.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_items.FormattingEnabled = true;
            this.list_items.ItemHeight = 16;
            this.list_items.Location = new System.Drawing.Point(10, 31);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(211, 340);
            this.list_items.TabIndex = 11;
            this.list_items.ValueMember = "des_id";
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // FRM_Items_Des
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(638, 456);
            this.Controls.Add(this.pnl_Items);
            this.Controls.Add(this.btn_Cancel_des);
            this.Controls.Add(this.btn_Save_des);
            this.Controls.Add(this.btn_Edit_des);
            this.Controls.Add(this.grbx_Item);
            this.Controls.Add(this.txt_Current_Des);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Items_Des";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مواصفات الصنف";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Items_Des_FormClosed);
            this.Shown += new System.EventHandler(this.FRM_Items_Des_Shown);
            this.grbx_Item.ResumeLayout(false);
            this.grbx_Item.PerformLayout();
            this.pnl_Items.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_Current_Des;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Item_Name;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Button btn_Edit_des;
        public System.Windows.Forms.Button btn_Save_des;
        public System.Windows.Forms.Button btn_Cancel_des;
        public System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.ListBox list_items;
        public System.Windows.Forms.Panel pnl_Items;
        public System.Windows.Forms.GroupBox grbx_Item;
    }
}