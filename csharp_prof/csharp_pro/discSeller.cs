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
    public partial class discSeller : UserControl
    {
        public discSeller()
        {
            InitializeComponent();
        }
        #region Properties

        private String _name;
        private String _type;
        private String _Condition;
        private int _price;
        private String _location;
        private Image _mimage;

        [Category ("Custom Props")]
        public String Name
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = value; }
        }

        [Category("Custom Props")]

        public String Type
        {
            get { return _type; }
            set { _type = value; lbl_type.Text= value; }
        }

        [Category("Custom Props")]

        public int Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value.ToString(); ; }
        }

        [Category("Custom Props")]

        public String Location
        {
            get { return _location; }
            set { _location = value; lbl_location.Text = value; }
        }
        [Category("Custom Props")]


        public String Condition
        {
            get { return _Condition; }
            set { _Condition = value; lbl_condition.Text = value; }

        }
        [Category("Custom Props")]

        public Image mimage
        {
            get { return _mimage; }
            set { _mimage = value; picture1.Image = value; }
        }

        #endregion





        private void lbl_name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_condition_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }
    }
}
