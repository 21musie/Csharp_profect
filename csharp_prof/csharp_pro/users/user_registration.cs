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
           
            
                if (Rname.IsMatch(txt_Fname.Text) & Rname.IsMatch(txt_Lname.Text) & Remail.IsMatch(txt_email.Text) & Rphone.IsMatch(txt_phone.Text))
                {
                    c.First_Name=txt_Fname.Text;  
                    c.Last_Name=txt_Lname.Text;
                    
                    c.Age = int.Parse(txt_age.Text);
                    c.Email = txt_email.Text;
                    c.Phone = txt_phone.Text;
                    c.Date = bunifuDatepicker1.Value;
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
            
            
        }
    }


