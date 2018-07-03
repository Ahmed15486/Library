using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Bills.Jor
{
    public partial class FRM_Jor_Close : Form
    {
        public frm_Main Main;

        public FRM_Jor_Close()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Jor_Close_Shown(object sender, EventArgs e)
        {
            lbl_Branche.Text = Main.combo_Branches.Text;
        }
        #endregion

        private void btn_Jor_Close_Click(object sender, EventArgs e)
        {
            CLS_Jor jor = new CLS_Jor();
            G.CLS_G G = new G.CLS_G();

            jor.ALL_Branches = rad_ALL_Branches.Checked;
            jor.Branche_ID = Main.combo_Branches.SelectedValue.ToString();
            jor.Date = Convert.ToDateTime(dtp_Date.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59");
            jor.Currency = 1;
            jor.Currency_Rate = 1;
            jor.Notes = "رصيد أول المدة";

            if (jor.Jor_Close() == null)
            {
                MessageBox.Show("تم إقفال الحسابات بنجاح", "إقفال الحسابات", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(jor.Jor_Close(), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            Main.ds = G.Select_All();
            for (int i = 0; i < Main.tabForms.TabPages.Count; i++)
            {
                if (Main.tabForms.TabPages[i].Name == "Jor")
                {
                    Main.Jor_Form_Open = false;
                    Main.tabForms.TabPages[i].Dispose();
                }
            }
        }
    }
}
