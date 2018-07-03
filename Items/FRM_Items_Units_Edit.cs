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
    public partial class FRM_Items_Units_Edit : Form
    {
        public DataGridView DGV_UNITS;

        public FRM_Items_Units_Edit()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // If this unit add before
            foreach (DataGridViewRow r in DGV_UNITS.Rows)
            {
                if (r.Cells[1].Value.ToString() == com_Unit.SelectedValue.ToString())
                {
                    r.Selected = true;
                    MessageBox.Show("هذه الوحدة تم إضافتها سابقاً", "إضافة وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DGV_UNITS.SelectedRows[0].Cells[1].Value = com_Unit.SelectedValue;
            DGV_UNITS.SelectedRows[0].Cells[2].Value = txt_OP.Text;
            Hide();
        }
    }
}
