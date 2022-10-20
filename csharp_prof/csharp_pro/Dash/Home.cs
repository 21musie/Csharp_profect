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
using csharp_pro.model;


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



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            List<Item> ilist = new List<Item>();

            Item i1 = new Item();
            i1.name = "car";
            i1.status = "new";
            i1.price = 500000.25;
            i1.location = "aa";
            i1.catagory = "drm21;";
            ilist.Add(i1);


            foreach (var item in ilist)
            {
                //ItemCard[] card1 = new ItemCard[5];
                ItemCard card1 = new ItemCard();
                card1.Iname = item.name;
                card1.Istatus = item.status;
                card1.Icatagory = item.catagory;
                card1.Iprice = item.price.ToString();
               card1.Ilocation = item.location;

               // s.Click += studentCard_Click;
                flp1.Controls.Add(card1);

            }
            int[] i = new int[2];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            flp2.Visible = false;
            flp1.Dock = DockStyle.Fill;
            //flp1.BackColor = Color.Violet;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0)
            {
                lbl_clear_search.Visible = true;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "search anything you want...";
            lbl_clear_search.Visible = false;
            textBox1.ForeColor = Color.Gray;
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            postItem ps = new postItem();
            ps.Show();
            
        }

        private void flp1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
