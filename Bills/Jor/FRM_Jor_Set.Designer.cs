namespace Library.Bills.Jor
{
    partial class FRM_Jor_Set
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
            this.chk_Acc_ID = new System.Windows.Forms.CheckBox();
            this.chk_cc1 = new System.Windows.Forms.CheckBox();
            this.chk_cc2 = new System.Windows.Forms.CheckBox();
            this.chk_Branche = new System.Windows.Forms.CheckBox();
            this.chk_CurrencyRate = new System.Windows.Forms.CheckBox();
            this.chk_Currency = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chk_Acc_ID
            // 
            this.chk_Acc_ID.AutoSize = true;
            this.chk_Acc_ID.Location = new System.Drawing.Point(66, 34);
            this.chk_Acc_ID.Name = "chk_Acc_ID";
            this.chk_Acc_ID.Size = new System.Drawing.Size(98, 21);
            this.chk_Acc_ID.TabIndex = 0;
            this.chk_Acc_ID.Text = "كود الحساب";
            this.chk_Acc_ID.UseVisualStyleBackColor = true;
            this.chk_Acc_ID.CheckedChanged += new System.EventHandler(this.chk_Acc_ID_CheckedChanged);
            // 
            // chk_cc1
            // 
            this.chk_cc1.AutoSize = true;
            this.chk_cc1.Checked = true;
            this.chk_cc1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cc1.Location = new System.Drawing.Point(66, 160);
            this.chk_cc1.Name = "chk_cc1";
            this.chk_cc1.Size = new System.Drawing.Size(61, 21);
            this.chk_cc1.TabIndex = 1;
            this.chk_cc1.Text = "مركز1";
            this.chk_cc1.UseVisualStyleBackColor = true;
            this.chk_cc1.CheckedChanged += new System.EventHandler(this.chk_cc1_CheckedChanged);
            // 
            // chk_cc2
            // 
            this.chk_cc2.AutoSize = true;
            this.chk_cc2.Checked = true;
            this.chk_cc2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cc2.Location = new System.Drawing.Point(66, 202);
            this.chk_cc2.Name = "chk_cc2";
            this.chk_cc2.Size = new System.Drawing.Size(61, 21);
            this.chk_cc2.TabIndex = 2;
            this.chk_cc2.Text = "مركز2";
            this.chk_cc2.UseVisualStyleBackColor = true;
            this.chk_cc2.CheckedChanged += new System.EventHandler(this.chk_cc2_CheckedChanged);
            // 
            // chk_Branche
            // 
            this.chk_Branche.AutoSize = true;
            this.chk_Branche.Location = new System.Drawing.Point(66, 245);
            this.chk_Branche.Name = "chk_Branche";
            this.chk_Branche.Size = new System.Drawing.Size(55, 21);
            this.chk_Branche.TabIndex = 3;
            this.chk_Branche.Text = "الفرع";
            this.chk_Branche.UseVisualStyleBackColor = true;
            this.chk_Branche.CheckedChanged += new System.EventHandler(this.chl_Branche_CheckedChanged);
            // 
            // chk_CurrencyRate
            // 
            this.chk_CurrencyRate.AutoSize = true;
            this.chk_CurrencyRate.Location = new System.Drawing.Point(66, 115);
            this.chk_CurrencyRate.Name = "chk_CurrencyRate";
            this.chk_CurrencyRate.Size = new System.Drawing.Size(94, 21);
            this.chk_CurrencyRate.TabIndex = 5;
            this.chk_CurrencyRate.Text = "سعر العملة";
            this.chk_CurrencyRate.UseVisualStyleBackColor = true;
            this.chk_CurrencyRate.CheckedChanged += new System.EventHandler(this.chk_CurrencyRate_CheckedChanged);
            // 
            // chk_Currency
            // 
            this.chk_Currency.AutoSize = true;
            this.chk_Currency.Location = new System.Drawing.Point(66, 75);
            this.chk_Currency.Name = "chk_Currency";
            this.chk_Currency.Size = new System.Drawing.Size(63, 21);
            this.chk_Currency.TabIndex = 4;
            this.chk_Currency.Text = "العملة";
            this.chk_Currency.UseVisualStyleBackColor = true;
            this.chk_Currency.CheckedChanged += new System.EventHandler(this.chk_Currency_CheckedChanged);
            // 
            // FRM_Jor_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(486, 302);
            this.Controls.Add(this.chk_CurrencyRate);
            this.Controls.Add(this.chk_Currency);
            this.Controls.Add(this.chk_Branche);
            this.Controls.Add(this.chk_cc2);
            this.Controls.Add(this.chk_cc1);
            this.Controls.Add(this.chk_Acc_ID);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Jor_Set";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات دفتر القيود";
            this.Shown += new System.EventHandler(this.FRM_Jor_Set_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Acc_ID;
        private System.Windows.Forms.CheckBox chk_cc1;
        private System.Windows.Forms.CheckBox chk_cc2;
        private System.Windows.Forms.CheckBox chk_Branche;
        private System.Windows.Forms.CheckBox chk_CurrencyRate;
        private System.Windows.Forms.CheckBox chk_Currency;
    }
}