namespace Library.Items
{
    partial class FRM_Units_Add
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
            this.txt_Enm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Anm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Enm
            // 
            this.txt_Enm.Location = new System.Drawing.Point(144, 90);
            this.txt_Enm.Name = "txt_Enm";
            this.txt_Enm.Size = new System.Drawing.Size(191, 24);
            this.txt_Enm.TabIndex = 125;
            this.txt_Enm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "الأسم E";
            // 
            // txt_Anm
            // 
            this.txt_Anm.Location = new System.Drawing.Point(144, 60);
            this.txt_Anm.Name = "txt_Anm";
            this.txt_Anm.Size = new System.Drawing.Size(191, 24);
            this.txt_Anm.TabIndex = 123;
            this.txt_Anm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 122;
            this.label4.Text = "الأسم";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Add.ImageKey = "Edit_16.png";
            this.btn_Add.Location = new System.Drawing.Point(193, 141);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Add.Size = new System.Drawing.Size(77, 34);
            this.btn_Add.TabIndex = 126;
            this.btn_Add.Text = "+  إضافة";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // FRM_Units_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 204);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Enm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Anm);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Units_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة وحدة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Enm;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Anm;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_Add;
    }
}