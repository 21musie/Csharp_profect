using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_pro
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void slidePanel(Button btn)
        {
            //panelSide.Height = btn.Height;
            //panelSide.Top = btn.Top;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pnl_parent.BackColor = Color.White;
            splash s = new splash();
            //addControls(s);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pnl_parent.BackColor = Color.DarkOliveGreen;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pnl_parent.BackColor = Color.DarkSeaGreen;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pnl_parent.BackColor = Color.DarkViolet;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pnl_parent.BackColor = Color.Red;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        ///////////////////
        ///

        //private void addControls(Form f)
        //{
        //    pnl_parent.Controls.Clear();
        //    f.Dock = DockStyle.Fill;
        //    pnl_parent.Controls.Add(f);
        //    f.BringToFront();
        //}
    }
}
