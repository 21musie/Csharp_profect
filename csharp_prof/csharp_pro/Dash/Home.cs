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
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);
            flp1.Controls.Add(i);



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
    }
}
