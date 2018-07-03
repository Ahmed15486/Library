namespace Library.Items
{
    partial class FRM_Units
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
            this.pnl_Items = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.list_items = new System.Windows.Forms.ListBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_Anm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Enm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Items.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Items
            // 
            this.pnl_Items.Controls.Add(this.btn_Remove);
            this.pnl_Items.Controls.Add(this.btn_Add);
            this.pnl_Items.Controls.Add(this.list_items);
            this.pnl_Items.Location = new System.Drawing.Point(376, 43);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.Size = new System.Drawing.Size(196, 398);
            this.pnl_Items.TabIndex = 114;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(17, 349);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "إزالة";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(98, 349);
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
            this.list_items.Location = new System.Drawing.Point(3, 3);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(185, 340);
            this.list_items.TabIndex = 11;
            this.list_items.ValueMember = "des_id";
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageKey = "Edit_16.png";
            this.btn_Cancel.Location = new System.Drawing.Point(350, 94);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(20, 21);
            this.btn_Cancel.TabIndex = 119;
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
            this.btn_Save.Location = new System.Drawing.Point(324, 94);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(20, 21);
            this.btn_Save.TabIndex = 118;
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
            this.btn_Edit.Location = new System.Drawing.Point(298, 94);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(20, 21);
            this.btn_Edit.TabIndex = 117;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Anm
            // 
            this.txt_Anm.Location = new System.Drawing.Point(100, 94);
            this.txt_Anm.Name = "txt_Anm";
            this.txt_Anm.ReadOnly = true;
            this.txt_Anm.Size = new System.Drawing.Size(191, 20);
            this.txt_Anm.TabIndex = 116;
            this.txt_Anm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "الأسم";
            // 
            // txt_Enm
            // 
            this.txt_Enm.Location = new System.Drawing.Point(100, 120);
            this.txt_Enm.Name = "txt_Enm";
            this.txt_Enm.ReadOnly = true;
            this.txt_Enm.Size = new System.Drawing.Size(191, 20);
            this.txt_Enm.TabIndex = 121;
            this.txt_Enm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "الأسم E";
            // 
            // FRM_Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(603, 453);
            this.Controls.Add(this.txt_Enm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_Anm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Units";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الوحدات";
            this.Shown += new System.EventHandler(this.FRM_Items_Des_Shown);
            this.pnl_Items.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.ListBox list_items;
        public System.Windows.Forms.Panel pnl_Items;
        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.TextBox txt_Anm;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Enm;
        public System.Windows.Forms.Label label1;
    }
}