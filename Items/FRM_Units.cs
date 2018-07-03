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
    public partial class FRM_Units : Form
    {
        #region Declarations
        BL.CLS_Items cls_items = new BL.CLS_Items();
        public Image Image_Edit;
        public Image Image_Save;
        public Image Image_Cancel;
        public DataTable dt_units;
        public ComboBox COM_UNITS;
        #endregion

        public FRM_Units()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Items_Des_Shown(object sender, EventArgs e)
        {
            list_items.SelectedItem = null;
            btn_Edit.Image = Image_Edit;
            btn_Save.Image = Image_Save;
            btn_Cancel.Image = Image_Cancel;
            list_items.DataSource = dt_units;
            list_items.DisplayMember = "anm";
            list_items.ValueMember = "unit_id";
            list_items.SelectedItem = null;
        }
        #endregion

        #region Units
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            cls_items.unit_anm = txt_Anm.Text;
            cls_items.unit_enm = txt_Enm.Text;

            txt_Anm.ReadOnly = false;
            txt_Enm.ReadOnly = false;
            txt_Anm.Select();

            btn_Edit.Visible = false;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            pnl_Items.Enabled = false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            cls_items.unit_id = Convert.ToInt16(list_items.SelectedValue);
            cls_items.unit_anm = txt_Anm.Text;
            cls_items.unit_enm = txt_Enm.Text;
            cls_items.Units_Update();

            foreach (DataRow r in dt_units.Rows)
            {
                if (r["unit_id"].ToString() == list_items.SelectedValue.ToString())
                {
                    int i = dt_units.Rows.IndexOf(r);
                    dt_units.Rows[i]["anm"] = txt_Anm.Text;
                    dt_units.Rows[i]["enm"] = txt_Enm.Text;                    
                    break;
                }
            }

            txt_Anm.ReadOnly = true;
            txt_Enm.ReadOnly = true;

            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            pnl_Items.Enabled = true;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Anm.Text = cls_items.unit_anm;
            txt_Enm.Text = cls_items.unit_enm;

            txt_Anm.ReadOnly = true;
            txt_Enm.ReadOnly = true;

            list_items.Enabled = true;

            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
        
            pnl_Items.Enabled = true;
        }
        #endregion

        #region Items
        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_items.SelectedItem != null)
            {
                btn_Edit.Visible = true;
                
                foreach (DataRow r in dt_units.Rows)
                {
                    if (list_items.SelectedValue.ToString() == r["unit_id"].ToString())
                    {
                        txt_Anm.Text = r["anm"].ToString();
                        txt_Enm.Text = r["enm"].ToString();
                        return;
                    }
                }
            }
            else
            {
                btn_Edit.Visible = false;
            }

        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Items.FRM_Units_Add unit_add = new FRM_Units_Add();
            unit_add.dt_units = dt_units;
            unit_add.LIST_Items = list_items;
            unit_add.COM_UNITS = COM_UNITS;
            unit_add.ShowDialog();
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (list_items.SelectedItem == null)
            {
                MessageBox.Show("يجب تحديد وحدة", "حذف وحدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("حذف الوحدة يؤدي إلى إزالتها من جميع الأصناف المسجلة بها", "حذف وحدة ؟", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            cls_items.unit_id = Convert.ToInt16(list_items.SelectedValue);
            cls_items.Units_Delete();

            var x = COM_UNITS.SelectedValue;
            foreach (DataRow r in dt_units.Rows)
            {
                if (r["unit_id"].ToString() == list_items.SelectedValue.ToString())
                {
                    int i = dt_units.Rows.IndexOf(r);
                    dt_units.Rows.RemoveAt(i);
                    break;
                }
            }
            COM_UNITS.SelectedValue = (x == null)? -1 : x;
            list_items_SelectedIndexChanged(null, null);

        }
        #endregion
    }
}
