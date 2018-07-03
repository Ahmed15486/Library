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
    public partial class FRM_ACC_Settings : Form
    {
        G.CLS_G G = new CLS_G();
        DataTable dt_Level_Set = new DataTable();

        public FRM_ACC_Settings()
        {
            InitializeComponent();

            dt_Level_Set = G.Select_Level_Set();
            #region Select
            n1.Value = Convert.ToInt16(dt_Level_Set.Rows[0][2]);
            n2.Value = Convert.ToInt16(dt_Level_Set.Rows[1][2]);
            n3.Value = Convert.ToInt16(dt_Level_Set.Rows[2][2]);
            n4.Value = Convert.ToInt16(dt_Level_Set.Rows[3][2]);
            n5.Value = Convert.ToInt16(dt_Level_Set.Rows[4][2]);
            n6.Value = Convert.ToInt16(dt_Level_Set.Rows[5][2]);
            n7.Value = Convert.ToInt16(dt_Level_Set.Rows[6][2]);
            n8.Value = Convert.ToInt16(dt_Level_Set.Rows[7][2]);
            n9.Value = Convert.ToInt16(dt_Level_Set.Rows[8][2]);
            n10.Value = Convert.ToInt16(dt_Level_Set.Rows[9][2]);

            cc1.Value = Convert.ToInt16(dt_Level_Set.Rows[10][2]);
            cc2.Value = Convert.ToInt16(dt_Level_Set.Rows[11][2]);
            cc3.Value = Convert.ToInt16(dt_Level_Set.Rows[12][2]);
            cc4.Value = Convert.ToInt16(dt_Level_Set.Rows[13][2]);
            cc5.Value = Convert.ToInt16(dt_Level_Set.Rows[14][2]);
            cc6.Value = Convert.ToInt16(dt_Level_Set.Rows[15][2]);
            cc7.Value = Convert.ToInt16(dt_Level_Set.Rows[16][2]);
            cc8.Value = Convert.ToInt16(dt_Level_Set.Rows[17][2]);
            cc9.Value = Convert.ToInt16(dt_Level_Set.Rows[18][2]);
            cc10.Value = Convert.ToInt16(dt_Level_Set.Rows[19][2]);

            i1.Value = Convert.ToInt16(dt_Level_Set.Rows[20][2]);
            i2.Value = Convert.ToInt16(dt_Level_Set.Rows[21][2]);
            i3.Value = Convert.ToInt16(dt_Level_Set.Rows[22][2]);
            i4.Value = Convert.ToInt16(dt_Level_Set.Rows[23][2]);
            i5.Value = Convert.ToInt16(dt_Level_Set.Rows[24][2]);
            i6.Value = Convert.ToInt16(dt_Level_Set.Rows[25][2]);
            i7.Value = Convert.ToInt16(dt_Level_Set.Rows[26][2]);
            i8.Value = Convert.ToInt16(dt_Level_Set.Rows[27][2]);
            i9.Value = Convert.ToInt16(dt_Level_Set.Rows[28][2]);
            i10.Value = Convert.ToInt16(dt_Level_Set.Rows[29][2]);
            #endregion
        }

        private void FRM_ACC_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد حفظ التغيرات ؟", "حفظ ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                #region var

                G.n1 = Convert.ToInt16(n1.Value);
                G.n2 = Convert.ToInt16(n2.Value);
                G.n3 = Convert.ToInt16(n3.Value);
                G.n4 = Convert.ToInt16(n4.Value);
                G.n5 = Convert.ToInt16(n5.Value);
                G.n6 = Convert.ToInt16(n6.Value);
                G.n7 = Convert.ToInt16(n7.Value);
                G.n8 = Convert.ToInt16(n8.Value);
                G.n9 = Convert.ToInt16(n9.Value);
                G.n10 = Convert.ToInt16(n10.Value);

                G.cc1 = Convert.ToInt16(cc1.Value);
                G.cc2 = Convert.ToInt16(cc2.Value);
                G.cc3 = Convert.ToInt16(cc3.Value);
                G.cc4 = Convert.ToInt16(cc4.Value);
                G.cc5 = Convert.ToInt16(cc5.Value);
                G.cc6 = Convert.ToInt16(cc6.Value);
                G.cc7 = Convert.ToInt16(cc7.Value);
                G.cc8 = Convert.ToInt16(cc8.Value);
                G.cc9 = Convert.ToInt16(cc9.Value);
                G.cc10 = Convert.ToInt16(cc10.Value);

                G.i1 = Convert.ToInt16(i1.Value);
                G.i2 = Convert.ToInt16(i2.Value);
                G.i3 = Convert.ToInt16(i3.Value);
                G.i4 = Convert.ToInt16(i4.Value);
                G.i5 = Convert.ToInt16(i5.Value);
                G.i6 = Convert.ToInt16(i6.Value);
                G.i7 = Convert.ToInt16(i7.Value);
                G.i8 = Convert.ToInt16(i8.Value);
                G.i9 = Convert.ToInt16(i9.Value);
                G.i10 = Convert.ToInt16(i10.Value);

                #endregion

                G.Update_Level_Set();
            }
        }
    }
}
