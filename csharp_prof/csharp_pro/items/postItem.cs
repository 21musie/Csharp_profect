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

namespace csharp_pro.items
{
    public partial class postItem : Form
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
            if (Rname.IsMatch(txt_Name.Text) & Rname.IsMatch(txt_location.Text))
            {
                Item item = new Item();

                item.name = txt_Name.Text;
                item.location = txt_location.Text;
                item.price = Double.Parse(txt_price.Text);
                item.status = dpd_status.selectedValue.ToString();
                item.catagory = dpd_catagory.selectedValue.ToString();
                item.quantity = int.Parse(dpd_quantity.selectedValue.ToString());
                item.postDate = dtp1.Value;

            }
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
    }
}
