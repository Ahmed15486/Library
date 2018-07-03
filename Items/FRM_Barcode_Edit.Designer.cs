namespace Library.Items
{
    partial class FRM_Barcode_Edit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.btn_Barcode_Add = new System.Windows.Forms.Button();
            this.com_Units_Barcode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 130;
            this.label8.Text = "الوحدة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 129;
            this.label7.Text = "الباركود";
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(172, 106);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(311, 24);
            this.txt_Barcode.TabIndex = 128;
            this.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Barcode_Add
            // 
            this.btn_Barcode_Add.FlatAppearance.BorderSize = 0;
            this.btn_Barcode_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Barcode_Add.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Barcode_Add.ImageKey = "Edit_16.png";
            this.btn_Barcode_Add.Location = new System.Drawing.Point(245, 177);
            this.btn_Barcode_Add.Name = "btn_Barcode_Add";
            this.btn_Barcode_Add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Barcode_Add.Size = new System.Drawing.Size(77, 34);
            this.btn_Barcode_Add.TabIndex = 127;
            this.btn_Barcode_Add.Text = "تعديل";
            this.btn_Barcode_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Barcode_Add.UseVisualStyleBackColor = true;
            this.btn_Barcode_Add.Click += new System.EventHandler(this.btn_Barcode_Add_Click);
            // 
            // com_Units_Barcode
            // 
            this.com_Units_Barcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Units_Barcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Units_Barcode.BackColor = System.Drawing.SystemColors.Window;
            this.com_Units_Barcode.DisplayMember = "anm";
            this.com_Units_Barcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Units_Barcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Units_Barcode.FormattingEnabled = true;
            this.com_Units_Barcode.Location = new System.Drawing.Point(172, 63);
            this.com_Units_Barcode.Name = "com_Units_Barcode";
            this.com_Units_Barcode.Size = new System.Drawing.Size(97, 24);
            this.com_Units_Barcode.TabIndex = 126;
            this.com_Units_Barcode.Tag = " ";
            this.com_Units_Barcode.ValueMember = "unit_id";
            // 
            // FRM_Barcode_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 270);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.btn_Barcode_Add);
            this.Controls.Add(this.com_Units_Barcode);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Barcode_Edit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل باركود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Barcode;
        public System.Windows.Forms.Button btn_Barcode_Add;
        public System.Windows.Forms.ComboBox com_Units_Barcode;
    }
}