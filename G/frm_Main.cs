using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frm_Main : Form
    {
        public bool Demo;
        #region Basic Data Forms

       BasicData.FRM_Customer Customers_Form;
       public bool Cust_Form_Open;

       public BasicData.FRM_Ven Ven_Form;
       public bool Ven_Form_Open;

       BasicData.FRM_Job_Type Job_Type_Form;
       public bool Job_Type_Form_Open;

       BasicData.FRM_Emp Emp_Form;
       public bool Emp_Form_Open;

       BasicData.FRM_ACC ACC_Form;
       public bool ACC_Form_Open;

       BasicData.FRM_Items Items_Form;
       public bool Items_Form_Open;

       BasicData.FRM_CC CC_Form;
       public bool CC_Form_Open;

       Bills.FRM_Open Opening_Balance_Form;
       public bool Opening_Balance_Form_Open;

       BasicData.FRM_Branches Branches_Form;
       public bool Branches_Form_Open;

       Bills.FRM_Pur Pur_Form;
       Bills.FRM_PurRe PurRe_Form;
       Bills.FRM_Sal Sal_Form;
       Bills.FRM_SalRe SalRe_Form;

        Bills.FRM_Tran Tran_Form;
       public bool Tran_Form_Open;

       Bills.FRM_Jor Jor_Form;
       public bool Jor_Form_Open;
       
       Bills.FRM_Jor_B Jor_B_Form;
       public bool Jor_B_Form_Open;

       Bills.FRM_Money_In Money_In_Form;
       public bool Money_In_Form_Open;

       Bills.FRM_Money_Out Money_Out_Form;
       public bool Money_Out_Form_Open;

       Rep.FRM_ACC_St ACC_St_Form;
       Rep.FRM_rep rep;

       public bool TB_Form_Open;
       public bool IL_Form_Open;
       public bool BS_Form_Open;
        #endregion

        #region Copy Classes
        BL.CLS_Users Users = new BL.CLS_Users();
       BL.Branches_Stores Branches = new BL.Branches_Stores();
       BL.CLS_CC CC = new BL.CLS_CC();
       BL.CLS_Emp Emp = new BL.CLS_Emp();
       BL.CLS_Items Items = new BL.CLS_Items();
       BL.CLS_ACC ACC = new BL.CLS_ACC();
       BL.CLS_Ven Ven = new BL.CLS_Ven();
       BL.CLS_Cust Cust = new BL.CLS_Cust();
       Bills.CLS_Open Open = new Bills.CLS_Open();
       Bills.CLS_IO IO = new Bills.CLS_IO();
       Bills.CLS_Pur Pur = new Bills.CLS_Pur();
       Bills.CLS_Sal Sal = new Bills.CLS_Sal();
       Bills.CLS_Tran Tran = new Bills.CLS_Tran();
       Bills.CLS_Jor Jor = new Bills.CLS_Jor();
       Bills.CLS_Jor_D Jor_D = new Bills.CLS_Jor_D();
       Bills.CLS_Money_In Money_In = new Bills.CLS_Money_In();
       Bills.CLS_Money_Out Money_Out = new Bills.CLS_Money_Out();
       G.CLS_Types Types = new G.CLS_Types();
       G.CLS_Bill_T Bill_T = new G.CLS_Bill_T();
       Bills.CLS_Jor_B Jor_B = new Bills.CLS_Jor_B();
       G.CLS_Value Value = new G.CLS_Value();
       G.CLS_Side Side = new G.CLS_Side();
       G.CLS_ACC_in_bill ACC_in_bill = new G.CLS_ACC_in_bill();
       G.CLS_Pay_Type Pay_Type = new G.CLS_Pay_Type();
       G.CLS_G G = new G.CLS_G();
        #endregion

        #region Declare Datatables
      public DataSet ds = new DataSet();
      public DataTable dt_Users = new DataTable();
      public DataTable dt_Branches = new DataTable();
      public DataTable dt_To_Branche = new DataTable();
      public DataTable dt_Stores = new DataTable();
      public DataTable dt_To_Store = new DataTable();
      public DataTable dt_CC = new DataTable();
      public DataTable dt_Emp = new DataTable();
      public DataTable dt_Items = new DataTable();
      public DataTable dt_ACC = new DataTable();
      public DataTable dt_ACC2 = new DataTable();
      public DataTable dt_IO = new DataTable();
      public DataTable dt_Open= new DataTable();
      public DataTable dt_Ven = new DataTable();
      public DataTable dt_Pur = new DataTable();
      public DataTable dt_Sal = new DataTable();
      public DataTable dt_Cust = new DataTable();
      public DataTable dt_Tran = new DataTable();
      public DataTable dt_Jor = new DataTable();
      public DataTable dt_Jor_D = new DataTable();
      public DataTable dt_Types = new DataTable();
      public DataTable dt_Bill_T = new DataTable();
      public DataTable dt_Jor_B = new DataTable();
      public DataTable dt_Value = new DataTable();
      public DataTable dt_Side = new DataTable();
      public DataTable dt_ACC_in_bill=new DataTable();
      public DataTable dt_Money_In = new DataTable();
      public DataTable dt_Money_Out = new DataTable();
      public DataTable dt_Pay_Type = new DataTable();
      public DataTable dt_ACC_Proper = new DataTable();
        #endregion

        public bool up;
        public string Rep_TABLE_NAME;
        public string Rep_TABLE_SCHEMA;

        public frm_Main()
        {
            InitializeComponent();

            #region Fill Datatables
            ds = G.Select_All();
            dt_Users = ds.Tables[0]; // Users
            dt_Branches = ds.Tables[1]; // Branches
            dt_To_Branche = ds.Tables[1];
            dt_Stores = ds.Tables[2];
            dt_To_Store = ds.Tables[2];
            dt_CC = ds.Tables[3];
            dt_Emp = ds.Tables[4];
            dt_Items = ds.Tables[5];
            dt_ACC = ds.Tables[6];
            dt_IO = ds.Tables[7];
            dt_Open = ds.Tables[8];
            dt_Ven = ds.Tables[9];
            dt_Cust = ds.Tables[10];
            dt_Pur = ds.Tables[11];
            dt_Sal = ds.Tables[12];
            dt_Tran = ds.Tables[13];
            dt_Jor = ds.Tables[14];
            dt_Jor_D = ds.Tables[15];
            dt_Types = ds.Tables[16];
            dt_Jor_B = ds.Tables[17];
            dt_Bill_T = ds.Tables[18];
            dt_Value = ds.Tables[19];
            dt_Side = ds.Tables[20];
            dt_ACC_in_bill = ds.Tables[21];
            dt_Pay_Type = ds.Tables[22];
            dt_Money_In = ds.Tables[23];
            dt_Money_Out = ds.Tables[24];
            dt_ACC_Proper = ds.Tables[25];

            dt_Items.DefaultView.RowFilter = string.Format("Is_Parent=0");
            dt_ACC.DefaultView.RowFilter = string.Format("Is_Parent=0");
            dt_CC.DefaultView.RowFilter = string.Format("Is_Parent=0");
            dt_CC.DefaultView.RowFilter = string.Format("Is_Parent=0");
            #endregion

            #region ContextMenuStrips
            // Branches
            combo_Branches.DataSource = dt_Branches;
            btn_branche.Text = combo_Branches.Text;
            contextMenuStrip_Branches.ForeColor = Color.White;

           for (int i = 0; i < combo_Branches.Items.Count; i++)
            {          
               contextMenuStrip_Branches.Items.Add(combo_Branches.GetItemText(combo_Branches.Items[i]),imageList16.Images["branche_16.png"]);
            }

            // Stores
            combo_Stores.DataSource = dt_Stores;
            lbl_Stores.Text = combo_Stores.Text;
            lbl_Stores.Location = new Point(btn_Stores.Left - lbl_Stores.Width, lbl_Stores.Location.Y);

            contextMenuStrip_Stores.ForeColor = Color.White;
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_Stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), imageList16.Images["store_16.png"]);
            }

            // Users
            combo_Users.DataSource = dt_Users;
            btn_user.Text = combo_Users.Text;
            contextMenuStrip_Users.ForeColor = Color.White;
            for (int i = 0; i < combo_Users.Items.Count; i++)
            {
                contextMenuStrip_Users.Items.Add(combo_Users.GetItemText(combo_Users.Items[i]), imageList16.Images["user_16.png"]);
            }
            #endregion
        }

        #region Form
        private void FRM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region panel_Main
        private void btn_branche_MouseEnter(object sender, EventArgs e)
      {
          btn_branche.FlatStyle = FlatStyle.Popup;
      }

      private void btn_branche_MouseLeave(object sender, EventArgs e)
      {
          btn_branche.FlatStyle = FlatStyle.Flat;
      }
      private void btn_Stores_MouseEnter(object sender, EventArgs e)
      {
          btn_Stores.FlatStyle = FlatStyle.Popup;
      }

      private void btn_Stores_MouseLeave(object sender, EventArgs e)
      {
          btn_Stores.FlatStyle = FlatStyle.Flat;
      }
      private void btn_user_MouseEnter(object sender, EventArgs e)
      {
          btn_user.FlatStyle = FlatStyle.Popup;
      }

      private void btn_user_MouseLeave(object sender, EventArgs e)
      {
          btn_user.FlatStyle = FlatStyle.Flat;
      }
        #endregion

        #region Buttons

        #region Display
        private void btn_ACC_MouseEnter(object sender, EventArgs e)
        {
            btn_ACC.FlatStyle = FlatStyle.Popup;
        }
        private void btn_ACC_MouseLeave(object sender, EventArgs e)
        {
            btn_ACC.FlatStyle = FlatStyle.Flat;
        }



        private void btn_Items_MouseEnter(object sender, EventArgs e)
        {
            btn_Items.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Items_MouseLeave(object sender, EventArgs e)
        {
            btn_Items.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Cust_MouseEnter(object sender, EventArgs e)
        {
            btn_Cust.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Cust_MouseLeave(object sender, EventArgs e)
        {
            btn_Cust.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Ven_MouseEnter(object sender, EventArgs e)
        {
            btn_Ven.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Ven_MouseLeave(object sender, EventArgs e)
        {
            btn_Ven.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Branches_MouseEnter(object sender, EventArgs e)
        {
            btn_Branches.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Branches_MouseLeave(object sender, EventArgs e)
        {
            btn_Branches.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Jor_MouseEnter(object sender, EventArgs e)
        {
            btn_Jor.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Jor_MouseLeave(object sender, EventArgs e)
        {
            btn_Jor.FlatStyle = FlatStyle.Flat;
        }



        private void btn_Open_MouseEnter(object sender, EventArgs e)
        {
            btn_Open.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Open_MouseLeave(object sender, EventArgs e)
        {
            btn_Open.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Tarn_MouseEnter(object sender, EventArgs e)
        {
            btn_Tarn.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Tarn_MouseLeave(object sender, EventArgs e)
        {
            btn_Tarn.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Pur_MouseEnter(object sender, EventArgs e)
        {
            btn_Pur.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Pur_MouseLeave(object sender, EventArgs e)
        {
            btn_Pur.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Pur_Re_MouseEnter(object sender, EventArgs e)
        {
            btn_PurRe.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Pur_Re_MouseLeave(object sender, EventArgs e)
        {
            btn_PurRe.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Sal_MouseEnter(object sender, EventArgs e)
        {
            btn_Sal.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Sal_MouseLeave(object sender, EventArgs e)
        {
            btn_Sal.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Sal_Re_MouseEnter(object sender, EventArgs e)
        {
            btn_SalRe.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Sal_Re_MouseLeave(object sender, EventArgs e)
        {
            btn_SalRe.FlatStyle = FlatStyle.Flat;
        }


        private void btn_Set_Server_MouseEnter(object sender, EventArgs e)
        {
            btn_Set_Server.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Set_Server_MouseLeave(object sender, EventArgs e)
        {
            btn_Set_Server.FlatStyle = FlatStyle.Flat;
        }


        #endregion

        private void btn_ACC_Click(object sender, EventArgs e)
        {
            ACC_Form = new BasicData.FRM_ACC(this);

            if (ACC_Form_Open == true)
            {
                tabForms.SelectTab("ACC");
                return;
            }

            ACC_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(ACC_Form);
            t.Text = "   " + btn_ACC.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "ACC";

            ACC_Form_Open = true;
            ACC_Form.Show();
        }


        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            DAL.FRM_SERVER_INFO server = new DAL.FRM_SERVER_INFO();
            server.ShowDialog();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            Rep_TABLE_NAME = "Items_G_rep";
            Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(this);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_RepReady.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "rep";

            rep.Show();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btn_branche_Click(object sender, EventArgs e)
        {
            if (combo_Branches.Enabled == true)
            {
                contextMenuStrip_Branches.Show((btn_branche.Right - contextMenuStrip_Branches.Width - 12), btn_branche.Bottom + 26);
            }
        }
        private void btn_Stores_Click(object sender, EventArgs e)
        {
            if (combo_Stores.Enabled == true)
            {
                contextMenuStrip_Stores.Show((btn_Stores.Right - contextMenuStrip_Stores.Width - 12), btn_Stores.Bottom + 26);
            }
        }
        private void btn_user_Click(object sender, EventArgs e)
        {
            if (combo_Users.Enabled == true)
            {
                contextMenuStrip_Users.Show((btn_user.Right - contextMenuStrip_Users.Width - 12), btn_user.Bottom + 26);
            }
        }
        private void contextMenuStrip_Branches_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Branches.SelectedIndex = contextMenuStrip_Branches.Items.IndexOf(e.ClickedItem);
            btn_branche.Text = combo_Branches.Text;

        }
        private void contextMenuStrip_Stores_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Stores.SelectedIndex = contextMenuStrip_Stores.Items.IndexOf(e.ClickedItem);
            lbl_Stores.Text = combo_Stores.Text;
        }
        private void contextMenuStrip_Users_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            combo_Users.SelectedIndex = contextMenuStrip_Users.Items.IndexOf(e.ClickedItem);
            btn_user.Text = combo_Users.Text;

        }
        private void combo_Branches_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_Stores.Visible = true;
            dt_Stores.DefaultView.RowFilter = string.Format("Branche_ID = '" + combo_Branches.SelectedValue.ToString() + "'");
            contextMenuStrip_Stores.Items.Clear();
            for (int i = 0; i < combo_Stores.Items.Count; i++)
            {
                contextMenuStrip_Stores.Items.Add(combo_Stores.GetItemText(combo_Stores.Items[i]), imageList16.Images["store_16.png"]);
            }
            if (combo_Stores.Items.Count > 0) { combo_Stores.SelectedIndex = 0; }
            lbl_Stores.Text = combo_Stores.Text;
            combo_Stores.Visible = false;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            G.FRM_ACC_Settings ACC_Set = new G.FRM_ACC_Settings();
            ACC_Set.ShowDialog();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabForms.SelectedTab == null) { return; }

            foreach (Control F in tabForms.SelectedTab.Controls)
            {
                if (F is Form) { F.Focus(); }
            }
        }
        public void btn_UpDowen_Click(object sender, EventArgs e)
        {
            if(tabForms.TabCount == 0) { return; }
            int i = tabForms.SelectedIndex;

            if(tab_Main.Visible == true)
            {
                tab_Main.Visible = false;
                btn_UpDowen.Image = imageList32.Images["dowen_32.png"];
            }
            else
            {
                tab_Main.Visible = true;
                btn_UpDowen.Image = imageList32.Images["up_32.png"];
            }
           
            tabForms.SelectedIndex = -1;
            tabForms.SelectedIndex = i;
        }
        private void btn_UpDowen_MouseEnter(object sender, EventArgs e)
        {
            btn_UpDowen.FlatStyle = FlatStyle.Popup;
        }
        private void btn_UpDowen_MouseLeave(object sender, EventArgs e)
        {
            btn_UpDowen.FlatStyle = FlatStyle.Flat;
        }

        private void btn_RepGenerator_Click(object sender, EventArgs e)
        {
            Rep.FRM_Rep_Des des = new Rep.FRM_Rep_Des(this);
            des.ShowDialog();
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            Rep.FRM_TB TB_Form = new Rep.FRM_TB(this);

            if (TB_Form_Open == true)
            {
                tabForms.SelectTab("TB");
                return;
            }

            TB_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(TB_Form);
            t.Text = "   " + btn_TB.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "TB";

            TB_Form_Open = true;
            TB_Form.Show();
        }

        private void btn_IL_Click(object sender, EventArgs e)
        {
            Rep.FRM_IL IL_Form = new Rep.FRM_IL(this);

            if (IL_Form_Open == true)
            {
                tabForms.SelectTab("IL");
                return;
            }

            IL_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(IL_Form);
            t.Text = "   " + btn_IL.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "IL";

            IL_Form_Open = true;
            IL_Form.Show();
        }

        private void btn_BS_Click(object sender, EventArgs e)
        {
            Rep.FRM_BS BS_Form = new Rep.FRM_BS(this);

            if (BS_Form_Open == true)
            {
                tabForms.SelectTab("BS");
                return;
            }

            BS_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(BS_Form);
            t.Text = "   " + btn_BS.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "BS";

            BS_Form_Open = true;
            BS_Form.Show();
        }


        private void btn_Jor_Close_Click(object sender, EventArgs e)
        {
            Bills.Jor.FRM_Jor_Close jor_close = new Bills.Jor.FRM_Jor_Close();
            jor_close.Main = this;
            jor_close.ShowDialog();
        }

        private void btn_JorB_Click(object sender, EventArgs e)
        {
            Jor_B_Form = new Bills.FRM_Jor_B(this);

            if (Jor_B_Form_Open == true)
            {
                tabForms.SelectTab("Jor_B");
                return;
            }

            Jor_B_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Jor_B_Form);
            t.Text = "   " + btn_JorB.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Jor_B";

            Jor_B_Form_Open = true;
            Jor_B_Form.Show();
        }

        private void btn_JorB_MouseEnter(object sender, EventArgs e)
        {
            btn_JorB.FlatStyle = FlatStyle.Popup;
        }

        private void btn_JorB_MouseLeave(object sender, EventArgs e)
        {
            btn_JorB.FlatStyle = FlatStyle.Flat;
        }

        private void btn_CC_Click(object sender, EventArgs e)
        {
            CC_Form = new BasicData.FRM_CC(this);

            if (CC_Form_Open == true)
            {
                tabForms.SelectTab("CC");
                return;
            }

            CC_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(CC_Form);
            t.Text = "   " + btn_CC.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "CC";

            CC_Form_Open = true;
            CC_Form.Show();
        }

        private void btn_CC_MouseEnter_1(object sender, EventArgs e)
        {
            btn_CC.FlatStyle = FlatStyle.Popup;
        }

        private void btn_CC_MouseLeave_1(object sender, EventArgs e)
        {
            btn_CC.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Jor_Click(object sender, EventArgs e)
        {
            Jor_Form = new Bills.FRM_Jor(this);

            if (Jor_Form_Open == true)
            {
                tabForms.SelectTab("Jor");
                return;
            }

            Jor_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Jor_Form);
            t.Text = "   " + btn_Jor.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Jor";

            Jor_Form_Open = true;
            Jor_Form.Show();
        }

        private void btn_PayIn_Click(object sender, EventArgs e)
        {
            Money_In_Form = new Bills.FRM_Money_In(this);

            if (Money_In_Form_Open == true)
            {
                tabForms.SelectTab("Money_In");
                return;
            }

            Money_In_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Money_In_Form);
            t.Text = "   " + btn_PayIn.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Money_In";

            Money_In_Form_Open = true;
            Money_In_Form.Show();
        }

        private void btn_PayIn_MouseEnter(object sender, EventArgs e)
        {
            btn_PayIn.FlatStyle = FlatStyle.Popup;
        }

        private void btn_PayIn_MouseLeave(object sender, EventArgs e)
        {
            btn_PayIn.FlatStyle = FlatStyle.Flat;
        }

        private void btn_PayOut_Click(object sender, EventArgs e)
        {
            Money_Out_Form = new Bills.FRM_Money_Out(this);

            if (Money_Out_Form_Open == true)
            {
                tabForms.SelectTab("Money_Out");
                return;
            }

            Money_Out_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Money_Out_Form);
            t.Text = "   " + btn_PayOut.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Money_Out";

            Money_Out_Form_Open = true;
            Money_Out_Form.Show();
        }

        private void btn_PayOut_MouseEnter(object sender, EventArgs e)
        {
            btn_PayOut.FlatStyle = FlatStyle.Popup;
        }

        private void btn_PayOut_MouseLeave(object sender, EventArgs e)
        {
            btn_PayOut.FlatStyle = FlatStyle.Flat;
        }

        private void btn_ST_Click(object sender, EventArgs e)
        {
            ACC_St_Form = new Rep.FRM_ACC_St(this);

            ACC_St_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(ACC_St_Form);
            t.Text = "   " + btn_ST.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "ACC_St";

            ACC_St_Form.Show();
        }

        private void btn_ST_MouseEnter(object sender, EventArgs e)
        {
            btn_ST.FlatStyle = FlatStyle.Popup;
        }

        private void btn_ST_MouseLeave(object sender, EventArgs e)
        {
            btn_ST.FlatStyle = FlatStyle.Flat;
        }

        private void btn_IL_Click_1(object sender, EventArgs e)
        {
            Rep.FRM_IL IL_Form = new Rep.FRM_IL(this);

            if (IL_Form_Open == true)
            {
                tabForms.SelectTab("IL");
                return;
            }

            IL_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(IL_Form);
            t.Text = "   " + btn_IL.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "IL";

            IL_Form_Open = true;
            IL_Form.Show();
        }

        private void btn_IL_MouseEnter(object sender, EventArgs e)
        {
            btn_IL.FlatStyle = FlatStyle.Popup;
        }

        private void btn_IL_MouseLeave(object sender, EventArgs e)
        {
            btn_IL.FlatStyle = FlatStyle.Flat;
        }

        private void btn_TB_Click_1(object sender, EventArgs e)
        {
            Rep.FRM_TB TB_Form = new Rep.FRM_TB(this);

            if (TB_Form_Open == true)
            {
                tabForms.SelectTab("TB");
                return;
            }

            TB_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(TB_Form);
            t.Text = "   " + btn_TB.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "TB";

            TB_Form_Open = true;
            TB_Form.Show();
        }

        private void btn_TB_MouseEnter(object sender, EventArgs e)
        {
            btn_TB.FlatStyle = FlatStyle.Popup;
        }

        private void btn_TB_MouseLeave(object sender, EventArgs e)
        {
            btn_TB.FlatStyle = FlatStyle.Flat;
        }

        private void btn_BS_MouseEnter(object sender, EventArgs e)
        {
            btn_BS.FlatStyle = FlatStyle.Popup;
        }

        private void btn_BS_MouseLeave(object sender, EventArgs e)
        {
            btn_BS.FlatStyle = FlatStyle.Flat;
        }

        private void btn_SetLevels_Click(object sender, EventArgs e)
        {
            G.FRM_ACC_Settings ACC_Set = new G.FRM_ACC_Settings();
            ACC_Set.ShowDialog();
        }

        private void btn_SetLevels_MouseEnter(object sender, EventArgs e)
        {
            btn_SetLevels.FlatStyle = FlatStyle.Popup;
        }

        private void btn_SetLevels_MouseLeave(object sender, EventArgs e)
        {
            btn_SetLevels.FlatStyle = FlatStyle.Flat;
        }

        private void btn_AccClose_Click(object sender, EventArgs e)
        {
            Bills.Jor.FRM_Jor_Close jor_close = new Bills.Jor.FRM_Jor_Close();
            jor_close.Main = this;
            jor_close.ShowDialog();
        }

        private void btn_AccClose_MouseEnter(object sender, EventArgs e)
        {
            btn_AccClose.FlatStyle = FlatStyle.Popup;
        }

        private void btn_AccClose_MouseLeave(object sender, EventArgs e)
        {
            btn_AccClose.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Cust_Click(object sender, EventArgs e)
        {
            Customers_Form = new BasicData.FRM_Customer(this);

            if (Cust_Form_Open == true)
            {
                tabForms.SelectTab("Customers_Form");
                return;
            }

            Customers_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Customers_Form);
            t.Text = "   " + btn_Cust.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Customers_Form";

            Cust_Form_Open = true;
            Customers_Form.Show();
        }

        private void btn_Ven_Click(object sender, EventArgs e)
        {
            Ven_Form = new BasicData.FRM_Ven(this);

            if (Ven_Form_Open == true)
            {
                tabForms.SelectTab("Ven_Data");
                return;
            }

            Ven_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Ven_Form);
            t.Text = "   " + btn_Ven.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Ven_Data";

            Ven_Form_Open = true;
            Ven_Form.Show();
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            BasicData.FRM_Items i = new BasicData.FRM_Items(this);
            i.FormBorderStyle = FormBorderStyle.Sizable;

            i.BackColor = Color.White;
            i.Width = 1100;
            i.Height = 800;
            i.WindowState = FormWindowState.Normal;
            i.StartPosition = FormStartPosition.CenterScreen;
            i.ShowDialog();
        }

        private void btn_Branches_Click(object sender, EventArgs e)
        {
            Branches_Form = new BasicData.FRM_Branches(this);

            if (Branches_Form_Open == true)
            {
                tabForms.SelectTab("Branches");
                return;
            }

            Branches_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Branches_Form);
            t.Text = "   " + btn_Branches.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Branches";

            Branches_Form_Open = true;
            Branches_Form.Show();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            Opening_Balance_Form = new Bills.FRM_Open(this);

            if (Opening_Balance_Form_Open == true)
            {
                tabForms.SelectTab("Opening_Balance");
                return;
            }

            Opening_Balance_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Opening_Balance_Form);
            t.Text = "" + btn_Open.Text + "";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Opening_Balance";

            Opening_Balance_Form_Open = true;
            Opening_Balance_Form.Show();
        }

        private void btn_Tarn_Click(object sender, EventArgs e)
        {
            Tran_Form = new Bills.FRM_Tran(this);

            if (Tran_Form_Open == true)
            {
                tabForms.SelectTab("Tran");
                return;
            }

            Tran_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Tran_Form);
            t.Text = "   " + btn_Tarn.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Tran";

            Tran_Form_Open = true;
            Tran_Form.Show();
        }

        private void btn_EditItems_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditItems_MouseEnter(object sender, EventArgs e)
        {
            btn_EditItems.FlatStyle = FlatStyle.Popup;
        }

        private void btn_EditItems_MouseLeave(object sender, EventArgs e)
        {
            btn_EditItems.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Pur_Click(object sender, EventArgs e)
        {
            Pur_Form = new Bills.FRM_Pur(this);

            Pur_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Pur_Form);
            t.Text = "   " + btn_Pur.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Pur";

            Pur_Form.Show();
        }


        private void btn_PurRe_Click(object sender, EventArgs e)
        {
            PurRe_Form = new Bills.FRM_PurRe(this);

            PurRe_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(PurRe_Form);
            t.Text = "   " + btn_PurRe.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "PurRe";

            PurRe_Form.Show();
        }

        private void btn_PurRe_MouseEnter(object sender, EventArgs e)
        {
            btn_PurRe.FlatStyle = FlatStyle.Popup;
        }

        private void btn_PurRe_MouseLeave(object sender, EventArgs e)
        {
            btn_PurRe.FlatStyle = FlatStyle.Flat;
        }

        private void btn_Sal_Click(object sender, EventArgs e)
        {
            Sal_Form = new Bills.FRM_Sal(this);

            Sal_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(Sal_Form);
            t.Text = "   " + btn_Sal.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "Sal";

            Sal_Form.Show();
        }



        private void btn_SalRe_Click(object sender, EventArgs e)
        {
            SalRe_Form = new Bills.FRM_SalRe(this);

            SalRe_Form.TopLevel = false;
            TabPage t = new TabPage();
            tabForms.TabPages.Add(t);
            t.Controls.Add(SalRe_Form);
            t.Text = "   " + btn_SalRe.Text + "   ";

            tabForms.SelectedTab = t;
            tabForms.SelectedTab.Name = "SalRe";

            SalRe_Form.Show();
        }

        private void btn_SalRe_MouseEnter(object sender, EventArgs e)
        {
            btn_SalRe.FlatStyle = FlatStyle.Popup;
        }

        private void btn_SalRe_MouseLeave(object sender, EventArgs e)
        {
            btn_SalRe.FlatStyle = FlatStyle.Flat;
        }
    }
}
