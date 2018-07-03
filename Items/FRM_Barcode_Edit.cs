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
    public partial class FRM_Barcode_Edit : Form
    {
        public DataGridView DGV_Unit_Barcode;

        public FRM_Barcode_Edit()
        {
            InitializeComponent();
        }

        private void btn_Barcode_Add_Click(object sender, EventArgs e)
        {
            DGV_Unit_Barcode.SelectedRows[0].Cells[1].Value = com_Units_Barcode.Text;
            DGV_Unit_Barcode.SelectedRows[0].Cells[2].Value = txt_Barcode.Text;
            Hide();
        }
    }
}
