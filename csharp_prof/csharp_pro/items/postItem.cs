using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using csharp_pro.model;
using csharp_pro.Dash;

namespace csharp_pro.items
{
    public partial class postItem :  Home
    {
        public postItem()
        {
            InitializeComponent();
        }

        Regex Rname = new Regex(@"^[A-Za-z]{3,15}$");
        Regex Rphone = new Regex(@"^09[0-9]{8}$");
        Regex Remail = new Regex(@"^[A-Za-z0-9]+@[a-z]+\.com$");
        //Regex Rid = new Regex(@"^[A-Za-z]{2}[0-9]{4}$");
        //Regex Rprice = new Regex(@"^$");
        //Regex Rdiscription = new Regex(@"");

        private void postItem_Load(object sender, EventArgs e)
        {
            
        }

        private void dpd_catagory_onItemSelected(object sender, EventArgs e)
        {
            lbl_catagory.Text = dpd_catagory.selectedValue.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            if (Rname.IsMatch(txt_Name.Text) & Rname.IsMatch(txt_location.Text))
            {
                

                item.name = txt_Name.Text;
                item.location = txt_location.Text;
                item.price = Double.Parse(txt_price.Text);
                item.status = dpd_status.selectedValue.ToString();
                item.catagory = dpd_catagory.selectedValue.ToString();
                item.quantity = int.Parse(dpd_quantity.selectedValue.ToString());
                item.postDate = dtp1.Value;

            }
            else
            {
                //errorProvider1.SetError(txt_Name, "Incorrect Format");
                if (!Rname.IsMatch(txt_Name.Text))
                    errorProvider1.SetError(txt_Name, "Incorrect Name Format");
                if (!Rname.IsMatch(txt_location.Text))
                    errorProvider1.SetError(txt_location, "Incorrect Location Format");
                //if (dpd_status.selectedValue.ToString() == "") ;
                //    errorProvider1.SetError(dpd_status, "Choose the status");
                //if (!Rprice.IsMatch(txt_price.Text))
                //    errorProvider1.SetError(txt_price, "Incorrect Price Format");
                //if (!Rdiscription.IsMatch(txt_discription.Text))
                //    errorProvider1.SetError(txt_discription, "Incorrect discription Format");
                //if (dpd_catagory.selectedValue.ToString() == null)
                //    errorProvider1.SetError(dpd_catagory, "Choose a Catagory");
                //if (dpd_quantity.selectedValue.ToString() == null)
                //    errorProvider1.SetError(dpd_quantity, "Choose the Quantity of the item");
            }

            ItemCard card1 = new ItemCard();
            card1.Iname = item.name;
            card1.Iprice = item.price.ToString();
            Home h = new Home();

           // flp1.Controls.Add(card1);




        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dpd_quantity_onItemSelected(object sender, EventArgs e)
        {
            lbl_quantity.Text = dpd_quantity.selectedValue.ToString();
        }

        private void dpd_status_onItemSelected(object sender, EventArgs e)
        {
            lbl_status.Text = dpd_status.selectedValue.ToString();
        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pib_one.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
               
                pib_one.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
