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
    public partial class user_registration : Form
    {
        public user_registration()
        {
            InitializeComponent();
        }
        Regex Rname = new Regex(@"^[A-Za-z]{3,15}$");
        Regex Rphone = new Regex(@"^09[0-9]{8}$");
        Regex Remail = new Regex(@"^[A-Za-z0-9]+@[a-z]+\.com$");
        //Regex Rid = new Regex(@"^[A-Za-z]{2}[0-9]{4}$");

        private void addItem_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            Seller s = new Seller();

            if (rdb_seller.Checked)
            {
                if (Rname.IsMatch(txt_Fname.Text) & Rname.IsMatch(txt_Lname.Text) & Remail.IsMatch(txt_email.Text) & Rphone.IsMatch(txt_phone.Text))
                {
                    errorProvider1.Clear();

                    s.Fname = txt_Fname.Text;
                    s.Lname = txt_Lname.Text;
                    s.age = int.Parse(txt_age.Text);
                    s.email = txt_email.Text;
                    s.phone = int.Parse(txt_phone.Text);
                    s.date = bunifuDatepicker1.Value;
                }
            }
            else if (rdb_buyer.Checked)
            {
                if (Rname.IsMatch(txt_Fname.Text) & Rname.IsMatch(txt_Lname.Text) & Remail.IsMatch(txt_email.Text) & Rphone.IsMatch(txt_phone.Text))
                {
                    c.Fname = txt_Fname.Text;
                    c.Lname = txt_Lname.Text;
                    c.age = int.Parse(txt_age.Text);
                    c.email = txt_email.Text;
                    c.phone = int.Parse(txt_phone.Text);
                    c.date = bunifuDatepicker1.Value;
                }
                else 
                {
                    if (!Rname.IsMatch(txt_Fname.Text))
                        errorProvider1.SetError(txt_Fname, "Incorrect Name Format");
                    if (!Rname.IsMatch(txt_Lname.Text))
                        errorProvider1.SetError(txt_Lname, "Incorrect Name Format");
                    if (!Remail.IsMatch(txt_email.Text))
                        errorProvider1.SetError(txt_email, "Incorrect email Format");
                    if (!Rphone.IsMatch(txt_phone.Text))
                        errorProvider1.SetError(txt_phone, "Incorrect Phone Format");
                }
            }
            else
            {
                
            }
                // validating terms and services
                if (rdb_seller.Checked)
                {
                    // s.save();      
                }


            
        }
    }
}

