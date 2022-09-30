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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (panel1.Width < 602 ) {
                panel1.Width += 5;

            }
            else
            {
                timer1.Stop();
            }
            //progressBar1.
        }


    }
}
