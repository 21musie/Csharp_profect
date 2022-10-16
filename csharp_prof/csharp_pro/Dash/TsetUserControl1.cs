using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_pro.Dash;

namespace csharp_pro
{
    public partial class TestUserControl1 : Form
    {
        public TestUserControl1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TsetUserControl1_Load(object sender, EventArgs e)
        {
            TestUserControl1 t = new TestUserControl1();

            //            addControls(ps);
            //            t.pnl_splash ps =new t.pnl_splash();
            //pnl_splash(sUserControl2
            UserControl2 a = new UserControl2();
            splash sp = new splash();
            sp.TopLevel = false;
            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
           
            t.panel1.Controls.Add(sp);
            this.panel1.Tag = sp;
            sp.BringToFront();
            sp.Show();
        }

        private void pnl_splash_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
