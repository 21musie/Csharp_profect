using csharp_pro.Properties;
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
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
            int newSize = 10;
            btn_Post.Enabled = false;
            /*button9.Font = new Font(button9.Font.FontFamily, newSize);
            button10.Font = new Font(button10.Font.FontFamily, newSize);
            button11.Font = new Font(button11.Font.FontFamily, newSize);
            button12.Font = new Font(button12.Font.FontFamily, newSize);
            button4.Font = new Font(button4.Font.FontFamily, newSize);
            button5.Font = new Font(button5.Font.FontFamily, newSize);
            button6.Font = new Font(button6.Font.FontFamily, newSize);
            button7.Font = new Font(button7.Font.FontFamily, newSize);
            button8.Font = new Font(button8.Font.FontFamily, newSize);
            button2.Font = new Font(button12.Font.FontFamily, newSize);
            button13.Font = new Font(button13.Font.FontFamily, newSize);
            button14.Font = new Font(button14.Font.FontFamily, newSize);
            button15.Font = new Font(button15.Font.FontFamily, newSize);*/


        }

        private void seller_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            loadForm(new aboutItem());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

       
        private bool nextCliked;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (nextCliked)
            { 
                label3.BackColor = Color.Transparent;
                label2.BackColor = Color.Beige;
                loadForm(new aboutItem());
                nextCliked = false;
                btn_Post.Enabled = false;
                button3.Text = "Next";

            }
            else
            {
                label3.BackColor = Color.Beige;
                label2.BackColor = Color.Transparent;
                panel3.Controls.Clear();
                loadForm(new detailPost());
                button3.Text = "Back";
                nextCliked=true;
                btn_Post.Enabled = true;

            }
        }
        public void loadForm(Object Form)
        {
            if(this.panel3.Controls.Count >0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void image1_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            loadForm(new aboutItem());
        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            dispItem di = new dispItem();
            di.populateItems();
            di.Show();
        }
    }
}
