using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.DAL
{
    public partial class FRM_SERVER_INFO : Form
    {
        public FRM_SERVER_INFO()
        {
            InitializeComponent();

            textBox_Server.Text = Properties.Settings.Default.Server;
            textBox_DataBase.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode=="Windows")
            {
                radio_Windows.Checked = true;
                groupBox1.Visible = false;
            }
            else
            {
                radio_SQL.Checked = true;
                textBox_ID.Text = Properties.Settings.Default.ID;
                textBox_Password.Text = Properties.Settings.Default.Password;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = textBox_Server.Text;
            Properties.Settings.Default.DataBase = textBox_DataBase.Text;
            Properties.Settings.Default.Mode = radio_Windows.Checked == true ? "Windows" : "SQL";
            Properties.Settings.Default.ID = textBox_ID.Text;
            Properties.Settings.Default.Password = textBox_Password.Text;

            frm_Main Main = new frm_Main();
            Properties.Settings.Default.Save();
            Main.Show();
            Hide();
        }

        private void radio_Windows_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Windows.Checked==true)
            {
                groupBox1.Visible = false;
                Height = 475;
                button_OK.Location = new Point(button_OK.Location.X, button_OK.Location.Y - 125);
                button_Cancel.Location = new Point(button_Cancel.Location.X, button_Cancel.Location.Y - 125);
            }
            else
            {
                groupBox1.Visible=true;
                Height = 600;
                button_OK.Location = new Point(button_OK.Location.X, button_OK.Location.Y + 125);
                button_Cancel.Location = new Point(button_Cancel.Location.X, button_Cancel.Location.Y + 125);
            }
        }
    }
}
