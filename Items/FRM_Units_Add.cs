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
    public partial class FRM_Units_Add : Form
    {
        BL.CLS_Items items = new BL.CLS_Items();
        public DataTable dt_units;
        public ComboBox COM_UNITS;
        public ListBox LIST_Items;

        public FRM_Units_Add()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Anm.Text.Trim() == "" && txt_Enm.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال أسم وحدة", "إضافة وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            items.unit_anm = txt_Anm.Text;
            items.unit_enm = txt_Enm.Text;

            int i = Convert.ToInt16(items.Units_Insert());

            dt_units.Rows.Add(i, txt_Anm.Text, txt_Enm.Text);
          
            LIST_Items.SelectedValue = i;
            COM_UNITS.SelectedValue = i;

            txt_Anm.Clear();
            txt_Enm.Clear();
            txt_Anm.Select();
        }
    }
}
