using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Rep
{
    public partial class FRM_Rep_Des : Form
    {
        frm_Main Main;
        Rep.FRM_rep rep;

        public FRM_Rep_Des(frm_Main main)
        {
            InitializeComponent();
            Main = main;
        }

        private void btn_Items_Rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Items_G_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Items_Rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_IO_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "IO_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_IO_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Pur_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Pur_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Pur_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Sal_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Sal_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Sal_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Pur_D_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Pur_D_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Pur_D_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Sal_D_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Sal_D_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Sal_D_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Ven_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Ven_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Ven_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Cust_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Cust_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Cust_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Tran_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Tran_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Tran_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }

        private void btn_Tran_D_rep_Click(object sender, EventArgs e)
        {
            Main.Rep_TABLE_NAME = "Tran_D_rep";
            Main.Rep_TABLE_SCHEMA = "dbo";

            rep = new Rep.FRM_rep(Main);

            rep.TopLevel = false;
            TabPage t = new TabPage();
            Main.tabForms.TabPages.Add(t);
            t.Controls.Add(rep);
            t.Text = "   " + btn_Tran_D_rep.Text + "   ";

            Main.tabForms.SelectedTab = t;
            Main.tabForms.SelectedTab.Name = "rep";

            Hide();
            rep.Show();
        }
    }
}
