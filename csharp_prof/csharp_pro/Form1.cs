﻿using csharp_pro.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        private bool isCollapsed = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.FlatStyle = FlatStyle.Flat;
            //button1.FlatAppearance.BorderSize = 0;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            //roundButton1.FlatStyle = FlatStyle.Flat;
            //roundButton1.FlatAppearance.BorderSize = 0;

        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
            
        // }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (isCollapsed)
            {
                button9.Image = Resources.collapse2;
                 panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                button9.Image = Resources.expand;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
