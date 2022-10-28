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
    public partial class loding : Form
    {
        public loding()
        {
            InitializeComponent();
        }
        private int move = 0;
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Write the code to show Loading Animation
            timer1.Interval = 20;
            panel2.Width += 5;

            move += 5;

            //If the loading is complete then display login form and close this form
            if (move == 610)
            {
                //Stop the Timer and Close this Form
                timer1.Stop();
                this.Hide();

                //Display the Login Form
                SignUp login = new SignUp();
                login.Show();
            }
            if (i < 100)
            { i++; }
            lbl_num.Text  = i.ToString();
        }

        private void loding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_num_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
