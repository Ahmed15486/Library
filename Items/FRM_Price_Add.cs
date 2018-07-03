using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Items
{
    public partial class FRM_Price_Edit : Form
    {
        public DataGridView DGV_Pricing;

        public FRM_Price_Edit()
        {
            InitializeComponent();
            
        }

        private void btn_Price_Add_Click(object sender, EventArgs e)
        {
            DGV_Pricing.SelectedRows[0].Cells[1].Value = txt_PPrice.Text;
            DGV_Pricing.SelectedRows[0].Cells[3].Value = txt_Sal1.Text;
            DGV_Pricing.SelectedRows[0].Cells[4].Value = txt_Sal2.Text;
            DGV_Pricing.SelectedRows[0].Cells[5].Value = txt_Sal3.Text;
            DGV_Pricing.SelectedRows[0].Cells[6].Value = txt_Sal4.Text;
            DGV_Pricing.SelectedRows[0].Cells[7].Value = txt_Sal5.Text;
            DGV_Pricing.SelectedRows[0].Cells[8].Value = txt_Sal6.Text;
            Hide();
        }
    }
}
