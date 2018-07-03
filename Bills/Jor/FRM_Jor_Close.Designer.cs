namespace Library.Bills.Jor
{
    partial class FRM_Jor_Close
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
            this.btn_Jor_Close = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.grbx_Branches = new System.Windows.Forms.GroupBox();
            this.lbl_Branche = new System.Windows.Forms.Label();
            this.rad_ALL_Branches = new System.Windows.Forms.RadioButton();
            this.rad_Branche = new System.Windows.Forms.RadioButton();
            this.grbx_Branches.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Jor_Close
            // 
            this.btn_Jor_Close.Location = new System.Drawing.Point(279, 377);
            this.btn_Jor_Close.Name = "btn_Jor_Close";
            this.btn_Jor_Close.Size = new System.Drawing.Size(92, 41);
            this.btn_Jor_Close.TabIndex = 0;
            this.btn_Jor_Close.Text = "إقفال";
            this.btn_Jor_Close.UseVisualStyleBackColor = true;
            this.btn_Jor_Close.Click += new System.EventHandler(this.btn_Jor_Close_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "yyyy-MM-dd";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(85, 79);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 24);
            this.dtp_Date.TabIndex = 1;
            // 
            // grbx_Branches
            // 
            this.grbx_Branches.Controls.Add(this.lbl_Branche);
            this.grbx_Branches.Controls.Add(this.rad_ALL_Branches);
            this.grbx_Branches.Controls.Add(this.rad_Branche);
            this.grbx_Branches.Location = new System.Drawing.Point(85, 149);
            this.grbx_Branches.Name = "grbx_Branches";
            this.grbx_Branches.Size = new System.Drawing.Size(200, 100);
            this.grbx_Branches.TabIndex = 2;
            this.grbx_Branches.TabStop = false;
            // 
            // lbl_Branche
            // 
            this.lbl_Branche.Location = new System.Drawing.Point(6, 25);
            this.lbl_Branche.Name = "lbl_Branche";
            this.lbl_Branche.Size = new System.Drawing.Size(155, 25);
            this.lbl_Branche.TabIndex = 2;
            this.lbl_Branche.Text = "label1";
            this.lbl_Branche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad_ALL_Branches
            // 
            this.rad_ALL_Branches.AutoSize = true;
            this.rad_ALL_Branches.Location = new System.Drawing.Point(100, 59);
            this.rad_ALL_Branches.Name = "rad_ALL_Branches";
            this.rad_ALL_Branches.Size = new System.Drawing.Size(81, 21);
            this.rad_ALL_Branches.TabIndex = 1;
            this.rad_ALL_Branches.Text = "كل الفروع";
            this.rad_ALL_Branches.UseVisualStyleBackColor = true;
            // 
            // rad_Branche
            // 
            this.rad_Branche.AutoSize = true;
            this.rad_Branche.Checked = true;
            this.rad_Branche.Location = new System.Drawing.Point(167, 31);
            this.rad_Branche.Name = "rad_Branche";
            this.rad_Branche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rad_Branche.Size = new System.Drawing.Size(14, 13);
            this.rad_Branche.TabIndex = 0;
            this.rad_Branche.TabStop = true;
            this.rad_Branche.UseVisualStyleBackColor = true;
            // 
            // FRM_Jor_Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 502);
            this.Controls.Add(this.grbx_Branches);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.btn_Jor_Close);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Jor_Close";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إقفال الحسابات";
            this.Shown += new System.EventHandler(this.FRM_Jor_Close_Shown);
            this.grbx_Branches.ResumeLayout(false);
            this.grbx_Branches.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Jor_Close;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox grbx_Branches;
        private System.Windows.Forms.RadioButton rad_ALL_Branches;
        private System.Windows.Forms.RadioButton rad_Branche;
        private System.Windows.Forms.Label lbl_Branche;
    }
}