using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_pro.items;


namespace csharp_pro
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //splash sp = new splash();
            //sp.TopLevel = false;
            //sp.FormBorderStyle = FormBorderStyle.None;
            //sp.Dock = DockStyle.Fill;

            //t.panel1.Controls.Add(sp);
            //this.panel1.Tag = sp;
            //sp.BringToFront();
            //sp.Show();

            ItemCard i = new ItemCard();
            flp1.BringToFront();
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);



        }
    }
}
