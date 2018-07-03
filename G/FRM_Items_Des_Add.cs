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
    public partial class FRM_Units : Form
    {
        #region Declarations
        BL.CLS_Items cls_items = new BL.CLS_Items();
        public int des_type;

        FRM_Items_Des FRM_Items_Des;
        BasicData.FRM_Items Frm_Items;
        #endregion

        public FRM_Units(BasicData.FRM_Items frm_items, FRM_Items_Des frm_items_des)
        {
            InitializeComponent();
            Frm_Items = frm_items;
            FRM_Items_Des = frm_items_des;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Name.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال أسم العنصر", "إضافة عنصر", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                cls_items.des_item_name = txt_Item_Name.Text;
                cls_items.des_item_notes = txt_Notes.Text;
                cls_items.des_item_type = des_type;

                int x = Convert.ToInt16(FRM_Items_Des.des_com.SelectedValue);

                string i = cls_items.Description_Insert();
                Frm_Items.Main.ds.Tables[27].Rows.Add(i, txt_Item_Name.Text, txt_Notes.Text, des_type);

                FRM_Items_Des.list_items.SelectedValue = i;
                FRM_Items_Des.txt_Item_Name.Text = txt_Item_Name.Text;
                FRM_Items_Des.txt_Notes.Text = txt_Notes.Text;

                FRM_Items_Des.des_com.Text = txt_Item_Name.Text;

                txt_Item_Name.Clear();
                txt_Notes.Clear();

                txt_Item_Name.Select();
            }
            catch { }
        }
    }
}
