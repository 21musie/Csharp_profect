using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_pro.items
{
    public partial class ItemCard : UserControl
    {
        public ItemCard()
        {
            InitializeComponent();
        }

        private string _Iname;
        public string Iname
        {
            get { return _Iname; }
            set { _Iname = value; lbl_name.Text = value; }
        }

        private string _catagory;
        public string Icatagory
        {
            get { return _catagory; }
            set { _catagory = value; lbl_catagory.Text = value; }
        }

        private string _status;
        public string Istatus
        {
            get { return _status; }
            set { _status = value; lbl_status.Text = value; }
        }

        private string _price;
        public string Iprice
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value; }
        }

        private string _location;
        public string Ilocation
        {
            get { return _location; }
            set { _location = value; lbl_location.Text = value; }

        }


        }
}
