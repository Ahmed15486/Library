namespace Library.G
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Item_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Add.ImageKey = "Edit_16.png";
            this.btn_Add.Location = new System.Drawing.Point(159, 182);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Add.Size = new System.Drawing.Size(77, 34);
            this.btn_Add.TabIndex = 121;
            this.btn_Add.Text = "+  إضافة";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(108, 91);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Notes.Size = new System.Drawing.Size(191, 76);
            this.txt_Notes.TabIndex = 118;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 91);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "بيان";
            // 
            // txt_Item_Name
            // 
            this.txt_Item_Name.Location = new System.Drawing.Point(108, 37);
            this.txt_Item_Name.Name = "txt_Item_Name";
            this.txt_Item_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Item_Name.Size = new System.Drawing.Size(191, 20);
            this.txt_Item_Name.TabIndex = 116;
            this.txt_Item_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 40);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "أسم العنصر";
            // 
            // FRM_Items_Des_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(375, 239);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Item_Name);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Items_Des_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة عنصر جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Item_Name;
        public System.Windows.Forms.Label label4;
    }
}