using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace csharp_pro
{
    public partial class splash : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // width of ellipse
        //    int nHeightEllipse // height of ellipse
        //);

            

    public splash()
        {
            InitializeComponent();
                    
                this.FormBorderStyle = FormBorderStyle.None;
               // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));          
        }
        int barValue = 0;
        private void splash_Load(object sender, EventArgs e)
        {
           // bunifuProgressBar1.Start();
            timer1.Start();

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int variable = 0;
           while (bunifuProgressBar1.Value != 100)
            {

                barValue += 1;
                variable++;
                lbl_num.Text = variable.ToString();
            }
            
            
            
            
            //bunifuCircleProgressbar1.Value = barValue;
            bunifuProgressBar1.Value = barValue;


            if(bunifuProgressBar1.Value == 100) 
            {
                timer1.Stop();
                this.Hide();
                // SignUp s = new SignUp();  
                Dashboard d = new Dashboard();
                d.Visible = true;
            }

        }
    }
}
