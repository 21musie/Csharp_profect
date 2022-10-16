using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_pro.Dash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void addC()
        {
            Form2 t = new Form2();
            Form1 sp = new Form1();

            sp.FormBorderStyle = FormBorderStyle.None;
            sp.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            //sp.BringToFront();
            sp.TopLevel = false;
            t.panel1.Controls.Add(sp);
            this.panel1.Tag = sp;
            sp.BringToFront();
            sp.Show();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addC();
        }
    }
}
