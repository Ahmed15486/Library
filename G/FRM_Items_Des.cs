using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.G
{
    public partial class FRM_Items_Des : Form
    {
        #region Declarations
        public frm_Main Main = new frm_Main();
        BL.CLS_Items cls_items = new BL.CLS_Items();
        public int des_id;
        public  DataView dv;
        string item_note;
        public Label des_label;
        public ComboBox des_com = new ComboBox();

        BasicData.FRM_Items Frm_Items;
        #endregion

        public FRM_Items_Des(BasicData.FRM_Items frm_items)
        {
            InitializeComponent();
            Frm_Items = frm_items;
        }

        #region Form
        private void FRM_Items_Des_Shown(object sender, EventArgs e)
        {
            txt_Current_Des.Text = Text;
            list_items.SelectedItem = null;
            txt_Item_Name.Clear();
            txt_Notes.Clear();
        }
        private void FRM_Items_Des_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        #endregion

        #region Des_Name
        private void btn_Edit_des_Click(object sender, EventArgs e)
        { // Edit
            txt_Current_Des.ReadOnly = false;
            txt_Current_Des.Select();

            btn_Edit_des.Visible = false;
            btn_Save_des.Visible = true;
            btn_Cancel_des.Visible = true;
            grbx_Item.Enabled = false;
            pnl_Items.Enabled = false;
        }
        private void btn_Save_des_Click(object sender, EventArgs e)
        { // Save
            cls_items.des_id = des_id;
            cls_items.des_name = txt_Current_Des.Text;
            Text = cls_items.Descriptions_Names_Update();

            Main.ds.Tables[26].Rows[des_id - 1]["name"] = Text;
            Frm_Items.Main.ds.Tables[26].Rows[des_id - 1]["name"] = Text;
            des_label.Text = Text;

            txt_Current_Des.ReadOnly = true;
            btn_Edit_des.Visible = true;
            btn_Save_des.Visible = false;
            btn_Cancel_des.Visible = false;
            grbx_Item.Enabled = true;
            pnl_Items.Enabled = true;
        }
        private void btn_Cancel_des_Click(object sender, EventArgs e)
        { // Cancel
            txt_Current_Des.Text = Main.ds.Tables[26].Rows[des_id - 1]["name"].ToString();
            txt_Current_Des.ReadOnly = true;

            btn_Edit_des.Visible = true;
            btn_Save_des.Visible = false;
            btn_Cancel_des.Visible = false;
            grbx_Item.Enabled = true;
            pnl_Items.Enabled = true;
        }
        #endregion

        #region Des_Items
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            item_note = txt_Notes.Text;
            txt_Item_Name.ReadOnly = false;
            txt_Notes.ReadOnly = false;
            list_items.Enabled = false;
            txt_Item_Name.Select();

            btn_Edit.Visible = false;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Edit_des.Visible = false;
            pnl_Items.Enabled = false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            cls_items.des_item_id = Convert.ToInt16(list_items.SelectedValue);
            cls_items.des_item_name = txt_Item_Name.Text;
            cls_items.des_item_notes = txt_Notes.Text;
            cls_items.Description_Update();

            foreach (DataRow r in Main.ds.Tables[27].Rows)
            {
                if (r["des_id"].ToString() == list_items.SelectedValue.ToString())
                {
                    int i = Main.ds.Tables[27].Rows.IndexOf(r);
                    Frm_Items.Main.ds.Tables[27].Rows[i]["des_name"] = txt_Item_Name.Text;
                    Frm_Items.Main.ds.Tables[27].Rows[i]["des_Notes"] = txt_Notes.Text;
                    Main.ds = Frm_Items.Main.ds;
                    break;
                }
            }

            int s = Convert.ToInt16(list_items.SelectedValue);
            list_items.DataSource = null;
            dv = new DataView(Main.ds.Tables[27]);
            dv.RowFilter = "des_type = " + des_id + "";
                        
            list_items.DataSource = dv;
            list_items.DisplayMember = "des_name";
            list_items.ValueMember = "des_id";        
            list_items.SelectedValue = s;

                
            txt_Item_Name.ReadOnly = true;
            txt_Notes.ReadOnly = true;
            list_items.Enabled = true;

            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Edit_des.Visible = true;
            pnl_Items.Enabled = true;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Item_Name.Text = list_items.Text;
            txt_Notes.Text = item_note;

            txt_Item_Name.ReadOnly = true;
            txt_Notes.ReadOnly = true;
            list_items.Enabled = true;

            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Edit_des.Visible = true;
            pnl_Items.Enabled = true;
        }
        #endregion

        #region Items
        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_items.Focused && list_items.SelectedItem != null)
            {
                btn_Edit.Visible = true;
                txt_Item_Name.Text = list_items.Text;
                foreach (DataRowView r in dv)
                {
                    if (list_items.SelectedValue.ToString() == r["des_id"].ToString())
                    {
                        txt_Notes.Text = r["des_Notes"].ToString();
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
            G.FRM_Units frm_items_des_add = new FRM_Units(Frm_Items,this);
            frm_items_des_add.des_type = des_id;
            
            frm_items_des_add.ShowDialog();
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(list_items.SelectedItem == null)
            {
                MessageBox.Show("يجب تحديد عنصر", "حذف عنصر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("حذف العنصر يؤدي إلى إزالته من جميع الأصناف المسجل بها", "حذف عنصر ؟", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            cls_items.des_item_id = Convert.ToInt16(list_items.SelectedValue);
            cls_items.Description_Delete();

            int x = Convert.ToInt16(des_com.SelectedValue);

            foreach (DataRow r in Main.ds.Tables[27].Rows)
            {
                if (r["des_id"].ToString() == list_items.SelectedValue.ToString())
                {
                    int i = Main.ds.Tables[27].Rows.IndexOf(r);
                    Frm_Items.Main.ds.Tables[27].Rows.RemoveAt(i);
                    Main.ds = Frm_Items.Main.ds;
                    break;
                }
            }

            des_com.SelectedValue = x;
            list_items.Focus();
            list_items_SelectedIndexChanged(null, null);
            Main.ds = Frm_Items.Main.ds;
        }
        #endregion
    }
}
