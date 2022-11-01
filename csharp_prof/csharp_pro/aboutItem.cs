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
    public partial class aboutItem : Form
    {
        public aboutItem()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(504, 337);
            panel2.AutoScroll = true;
            panel2.AutoScrollMinSize = new Size(504, 337);
        }

        private void aboutItem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isCollapsed = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button16.Image = Resources.collapse2;
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                button16.Image = Resources.expand;
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button1.Image = Resources.collapse2;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                button1.Image = Resources.expand;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation1 = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation1 = dialog.FileName;

                    image1.ImageLocation = imageLocation1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An,Error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation1 = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation1 = dialog.FileName;

                    image2.ImageLocation = imageLocation1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An,Error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = button12.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = button11.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = button9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = button4.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = button6.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = button5.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = button2.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = button8.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = button13.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = button14.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = button15.Text;

            //dispItem textBox2.Text = new dispItem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
