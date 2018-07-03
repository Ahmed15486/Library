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
    public partial class FRM_Jor_Set : Form
    {
        public DataGridView DGV;

        public FRM_Jor_Set()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Jor_Set_Shown(object sender, EventArgs e)
        {
            chk_Acc_ID.Checked = DGV.Columns["ACC_ID"].Visible;
            chk_Currency.Checked = DGV.Columns["Currency"].Visible;
            chk_CurrencyRate.Checked = DGV.Columns["Currency_Rate"].Visible;
            chk_Branche.Checked = DGV.Columns["Branche"].Visible;
        }
        #endregion

        private void chk_Acc_ID_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["ACC_ID"].Visible = chk_Acc_ID.Checked;
        }
        private void chk_cc1_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["CC1"].Visible = chk_cc1.Checked;
        }
        private void chk_cc2_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["CC2"].Visible = chk_cc2.Checked;
        }
        private void chl_Branche_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["Branche"].Visible = chk_Branche.Checked;
        }
        private void chk_Currency_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["Currency"].Visible = chk_Currency.Checked;
        }
        private void chk_CurrencyRate_CheckedChanged(object sender, EventArgs e)
        {
            DGV.Columns["Currency_Rate"].Visible = chk_CurrencyRate.Checked;
        }


    }
}
