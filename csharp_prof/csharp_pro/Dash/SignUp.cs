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
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label5_Leave(object sender, EventArgs e)
        {
            //label5.BackColor = Color.White;
            //label5.ForeColor = Color.Transparent;
            

        }

        private void label5_DragOver(object sender, DragEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
            //label5.ForeColor = Color.Black;
            
        }

        private void SignUp_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
            label5.BackColor = Color.Transparent;
        }
    }
}
