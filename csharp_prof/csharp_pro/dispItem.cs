using csharp_pro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace csharp_pro
{
    public partial class dispItem : Form
    {
        public dispItem()
        {
            InitializeComponent();
            
        }

        public void populateItems()
        {
            discSeller Items = new discSeller();
            
            {
                Items.Name = "Your name";
                Items.Type = "what is it";
                Items.Price = 0;
                Items.Location = "what is it";
                Items.Condition = "Your name";
                Items.mimage = Resources.profilepics;
              
            }
            flowLayoutPanel1.Controls.Add(Items);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
