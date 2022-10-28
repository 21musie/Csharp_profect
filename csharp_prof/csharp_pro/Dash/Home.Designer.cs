using Guna.UI2.WinForms;

namespace csharp_pro
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sell = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_clear_search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pib_home = new System.Windows.Forms.PictureBox();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_vehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clothes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_laptop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_house = new Guna.UI2.WinForms.Guna2Button();
            this.btn_phone = new Guna.UI2.WinForms.Guna2Button();
            this.btn_shoes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pets = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cosmotics = new Guna.UI2.WinForms.Guna2Button();
            this.btn_construction = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_home)).BeginInit();
            this.flp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flp1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flp1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp1.Location = new System.Drawing.Point(199, 82);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(1567, 510);
            this.flp1.TabIndex = 1;
            this.flp1.Paint += new System.Windows.Forms.PaintEventHandler(this.flp1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImage = global::csharp_pro.Properties.Resources.img22;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_sell);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pib_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1766, 82);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_sell
            // 
            this.btn_sell.BackColor = System.Drawing.Color.Transparent;
            this.btn_sell.BorderColor = System.Drawing.Color.Transparent;
            this.btn_sell.BorderRadius = 5;
            this.btn_sell.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sell.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sell.ForeColor = System.Drawing.Color.White;
            this.btn_sell.Location = new System.Drawing.Point(828, 26);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(93, 28);
            this.btn_sell.TabIndex = 14;
            this.btn_sell.Text = "Post Item";
            this.btn_sell.UseTransparentBackground = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(118, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Controls.Add(this.lbl_clear_search);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Location = new System.Drawing.Point(387, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(318, 25);
            this.panel7.TabIndex = 13;
            // 
            // lbl_clear_search
            // 
            this.lbl_clear_search.BackColor = System.Drawing.Color.White;
            this.lbl_clear_search.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clear_search.Location = new System.Drawing.Point(281, 2);
            this.lbl_clear_search.Name = "lbl_clear_search";
            this.lbl_clear_search.Size = new System.Drawing.Size(30, 20);
            this.lbl_clear_search.TabIndex = 13;
            this.lbl_clear_search.Text = "x";
            this.lbl_clear_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_clear_search.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(18, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "search anything you want...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(215, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pib_home
            // 
            this.pib_home.BackColor = System.Drawing.Color.Transparent;
            this.pib_home.Image = ((System.Drawing.Image)(resources.GetObject("pib_home.Image")));
            this.pib_home.Location = new System.Drawing.Point(23, 12);
            this.pib_home.Name = "pib_home";
            this.pib_home.Size = new System.Drawing.Size(59, 48);
            this.pib_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pib_home.TabIndex = 0;
            this.pib_home.TabStop = false;
            this.pib_home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flp2
            // 
            this.flp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.flp2.Controls.Add(this.btn_vehicle);
            this.flp2.Controls.Add(this.btn_clothes);
            this.flp2.Controls.Add(this.btn_laptop);
            this.flp2.Controls.Add(this.btn_house);
            this.flp2.Controls.Add(this.btn_phone);
            this.flp2.Controls.Add(this.btn_shoes);
            this.flp2.Controls.Add(this.btn_pets);
            this.flp2.Controls.Add(this.btn_cosmotics);
            this.flp2.Controls.Add(this.btn_construction);
            this.flp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp2.Location = new System.Drawing.Point(0, 82);
            this.flp2.Margin = new System.Windows.Forms.Padding(2);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(199, 510);
            this.flp2.TabIndex = 2;
            this.flp2.Paint += new System.Windows.Forms.PaintEventHandler(this.flp2_Paint);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.BorderThickness = 1;
            this.btn_vehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_vehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_vehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_vehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_vehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_vehicle.ForeColor = System.Drawing.Color.White;
            this.btn_vehicle.Location = new System.Drawing.Point(2, 2);
            this.btn_vehicle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Size = new System.Drawing.Size(196, 37);
            this.btn_vehicle.TabIndex = 1;
            this.btn_vehicle.Text = "Vehicle";
            this.btn_vehicle.Click += new System.EventHandler(this.btn_vehicle_Click);
            // 
            // btn_clothes
            // 
            this.btn_clothes.BorderThickness = 1;
            this.btn_clothes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clothes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clothes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clothes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clothes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clothes.ForeColor = System.Drawing.Color.White;
            this.btn_clothes.Location = new System.Drawing.Point(2, 43);
            this.btn_clothes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clothes.Name = "btn_clothes";
            this.btn_clothes.Size = new System.Drawing.Size(196, 37);
            this.btn_clothes.TabIndex = 1;
            this.btn_clothes.Text = "Clothes";
            // 
            // btn_laptop
            // 
            this.btn_laptop.BorderThickness = 1;
            this.btn_laptop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_laptop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_laptop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_laptop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_laptop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_laptop.ForeColor = System.Drawing.Color.White;
            this.btn_laptop.Location = new System.Drawing.Point(2, 84);
            this.btn_laptop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_laptop.Name = "btn_laptop";
            this.btn_laptop.Size = new System.Drawing.Size(196, 37);
            this.btn_laptop.TabIndex = 1;
            this.btn_laptop.Text = "Laptop";
            // 
            // btn_house
            // 
            this.btn_house.BorderThickness = 1;
            this.btn_house.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_house.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_house.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_house.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_house.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_house.ForeColor = System.Drawing.Color.White;
            this.btn_house.Location = new System.Drawing.Point(2, 125);
            this.btn_house.Margin = new System.Windows.Forms.Padding(2);
            this.btn_house.Name = "btn_house";
            this.btn_house.Size = new System.Drawing.Size(196, 37);
            this.btn_house.TabIndex = 1;
            this.btn_house.Text = "House";
            // 
            // btn_phone
            // 
            this.btn_phone.BorderThickness = 1;
            this.btn_phone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_phone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_phone.ForeColor = System.Drawing.Color.White;
            this.btn_phone.Location = new System.Drawing.Point(2, 166);
            this.btn_phone.Margin = new System.Windows.Forms.Padding(2);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(196, 37);
            this.btn_phone.TabIndex = 1;
            this.btn_phone.Text = "Phone";
            // 
            // btn_shoes
            // 
            this.btn_shoes.BorderThickness = 1;
            this.btn_shoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_shoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_shoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_shoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_shoes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_shoes.ForeColor = System.Drawing.Color.White;
            this.btn_shoes.Location = new System.Drawing.Point(2, 207);
            this.btn_shoes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shoes.Name = "btn_shoes";
            this.btn_shoes.Size = new System.Drawing.Size(196, 37);
            this.btn_shoes.TabIndex = 1;
            this.btn_shoes.Text = "Shoes";
            // 
            // btn_pets
            // 
            this.btn_pets.BorderThickness = 1;
            this.btn_pets.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pets.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pets.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pets.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_pets.ForeColor = System.Drawing.Color.White;
            this.btn_pets.Location = new System.Drawing.Point(2, 248);
            this.btn_pets.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pets.Name = "btn_pets";
            this.btn_pets.Size = new System.Drawing.Size(196, 37);
            this.btn_pets.TabIndex = 1;
            this.btn_pets.Text = "Pets";
            // 
            // btn_cosmotics
            // 
            this.btn_cosmotics.BorderThickness = 1;
            this.btn_cosmotics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cosmotics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cosmotics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cosmotics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cosmotics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cosmotics.ForeColor = System.Drawing.Color.White;
            this.btn_cosmotics.Location = new System.Drawing.Point(2, 289);
            this.btn_cosmotics.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cosmotics.Name = "btn_cosmotics";
            this.btn_cosmotics.Size = new System.Drawing.Size(196, 37);
            this.btn_cosmotics.TabIndex = 1;
            this.btn_cosmotics.Text = "Cosmotics";
            // 
            // btn_construction
            // 
            this.btn_construction.BorderThickness = 1;
            this.btn_construction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_construction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_construction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_construction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_construction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_construction.ForeColor = System.Drawing.Color.White;
            this.btn_construction.Location = new System.Drawing.Point(2, 330);
            this.btn_construction.Margin = new System.Windows.Forms.Padding(2);
            this.btn_construction.Name = "btn_construction";
            this.btn_construction.Size = new System.Drawing.Size(196, 37);
            this.btn_construction.TabIndex = 1;
            this.btn_construction.Text = "Construction material";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1766, 140);
            this.panel2.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1045, 749);
            this.Controls.Add(this.flp1);
            this.Controls.Add(this.flp2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_home)).EndInit();
            this.flp2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pib_home;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_clear_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private Guna2Button btn_vehicle;
        private Guna2Button btn_clothes;
        private Guna2Button btn_laptop;
        private Guna2Button btn_house;
        private Guna2Button btn_phone;
        private Guna2Button btn_shoes;
        private Guna2Button btn_pets;
        private Guna2Button btn_cosmotics;
        private Guna2Button btn_construction;
        private Guna2Button btn_sell;
        private System.Windows.Forms.Panel panel2;

    }
}