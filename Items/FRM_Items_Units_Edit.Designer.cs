namespace Library.Items
{
    partial class FRM_Items_Units_Edit
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_OP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.com_Unit = new System.Windows.Forms.ComboBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 130;
            this.label9.Text = "العدد من الوحدة الأولى";
            // 
            // txt_OP
            // 
            this.txt_OP.Location = new System.Drawing.Point(229, 78);
            this.txt_OP.Name = "txt_OP";
            this.txt_OP.Size = new System.Drawing.Size(92, 24);
            this.txt_OP.TabIndex = 129;
            this.txt_OP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 128;
            this.label18.Text = "الوحدة";
            // 
            // com_Unit
            // 
            this.com_Unit.DisplayMember = "anm";
            this.com_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Unit.FormattingEnabled = true;
            this.com_Unit.Location = new System.Drawing.Point(229, 48);
            this.com_Unit.Name = "com_Unit";
            this.com_Unit.Size = new System.Drawing.Size(92, 24);
            this.com_Unit.TabIndex = 127;
            this.com_Unit.ValueMember = "unit_id";
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Edit.ImageKey = "Edit_16.png";
            this.btn_Edit.Location = new System.Drawing.Point(229, 122);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Edit.Size = new System.Drawing.Size(92, 34);
            this.btn_Edit.TabIndex = 131;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // FRM_Items_Units_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 190);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_OP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.com_Unit);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Items_Units_Edit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل وحدة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.TextBox txt_OP;
        public System.Windows.Forms.ComboBox com_Unit;
    }
}