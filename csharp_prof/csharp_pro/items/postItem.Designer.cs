namespace csharp_pro.items
{
    partial class postItem
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Iname = new System.Windows.Forms.Label();
            this.lbl_catagory = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.dpd_catagory = new Bunifu.Framework.UI.BunifuDropdown();
            this.dtp1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pib_one = new System.Windows.Forms.PictureBox();
            this.dpd_status = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.dpd_quantity = new Bunifu.Framework.UI.BunifuDropdown();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_post = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_addImage = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pib_one)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(44, 142);
            this.txt_Name.MaxLength = 25;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // lbl_Iname
            // 
            this.lbl_Iname.AutoSize = true;
            this.lbl_Iname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Iname.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_Iname.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Iname.Location = new System.Drawing.Point(41, 109);
            this.lbl_Iname.Name = "lbl_Iname";
            this.lbl_Iname.Size = new System.Drawing.Size(55, 15);
            this.lbl_Iname.TabIndex = 4;
            this.lbl_Iname.Text = "Item Name";
            // 
            // lbl_catagory
            // 
            this.lbl_catagory.AutoSize = true;
            this.lbl_catagory.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catagory.ForeColor = System.Drawing.Color.Snow;
            this.lbl_catagory.Location = new System.Drawing.Point(51, 61);
            this.lbl_catagory.Name = "lbl_catagory";
            this.lbl_catagory.Size = new System.Drawing.Size(137, 18);
            this.lbl_catagory.TabIndex = 4;
            this.lbl_catagory.Text = "Choose catagory";
            this.lbl_catagory.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(44, 215);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(213, 20);
            this.txt_location.TabIndex = 5;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.BackColor = System.Drawing.Color.Transparent;
            this.lbl_location.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_location.ForeColor = System.Drawing.Color.Snow;
            this.lbl_location.Location = new System.Drawing.Point(39, 186);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(46, 15);
            this.lbl_location.TabIndex = 4;
            this.lbl_location.Text = "Location";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(44, 291);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(213, 20);
            this.txt_price.TabIndex = 5;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_description.ForeColor = System.Drawing.Color.Snow;
            this.lbl_description.Location = new System.Drawing.Point(41, 344);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 15);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(44, 377);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(213, 101);
            this.txt_description.TabIndex = 5;
            // 
            // dpd_catagory
            // 
            this.dpd_catagory.BackColor = System.Drawing.Color.Transparent;
            this.dpd_catagory.BorderRadius = 3;
            this.dpd_catagory.DisabledColor = System.Drawing.Color.Gray;
            this.dpd_catagory.ForeColor = System.Drawing.Color.Snow;
            this.dpd_catagory.Items = new string[] {
        "Car",
        "clothes",
        "Electronics",
        "shoes",
        "laptop",
        "pets",
        "cosmotics",
        "construction maretial",
        "Kidney"};
            this.dpd_catagory.Location = new System.Drawing.Point(42, 52);
            this.dpd_catagory.Margin = new System.Windows.Forms.Padding(4);
            this.dpd_catagory.Name = "dpd_catagory";
            this.dpd_catagory.NomalColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_catagory.onHoverColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_catagory.selectedIndex = -1;
            this.dpd_catagory.Size = new System.Drawing.Size(217, 35);
            this.dpd_catagory.TabIndex = 7;
            this.dpd_catagory.onItemSelected += new System.EventHandler(this.dpd_catagory_onItemSelected);
            // 
            // dtp1
            // 
            this.dtp1.BackColor = System.Drawing.Color.Transparent;
            this.dtp1.BorderRadius = 0;
            this.dtp1.ForeColor = System.Drawing.Color.Snow;
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.FormatCustom = null;
            this.dtp1.Location = new System.Drawing.Point(603, 52);
            this.dtp1.Margin = new System.Windows.Forms.Padding(4);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(157, 30);
            this.dtp1.TabIndex = 8;
            this.dtp1.Value = new System.DateTime(2022, 10, 11, 13, 20, 39, 278);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_price.ForeColor = System.Drawing.Color.Snow;
            this.lbl_price.Location = new System.Drawing.Point(39, 258);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 15);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // pib_one
            // 
            this.pib_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_one.Location = new System.Drawing.Point(570, 126);
            this.pib_one.Name = "pib_one";
            this.pib_one.Size = new System.Drawing.Size(216, 202);
            this.pib_one.TabIndex = 12;
            this.pib_one.TabStop = false;
            // 
            // dpd_status
            // 
            this.dpd_status.BackColor = System.Drawing.Color.Transparent;
            this.dpd_status.BorderRadius = 3;
            this.dpd_status.DisabledColor = System.Drawing.Color.Gray;
            this.dpd_status.ForeColor = System.Drawing.Color.Snow;
            this.dpd_status.Items = new string[] {
        "New ",
        "Slightly Used",
        "Used",
        "Old"};
            this.dpd_status.Location = new System.Drawing.Point(305, 52);
            this.dpd_status.Margin = new System.Windows.Forms.Padding(4);
            this.dpd_status.Name = "dpd_status";
            this.dpd_status.NomalColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_status.onHoverColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_status.selectedIndex = -1;
            this.dpd_status.Size = new System.Drawing.Size(217, 35);
            this.dpd_status.TabIndex = 7;
            this.dpd_status.onItemSelected += new System.EventHandler(this.dpd_status_onItemSelected);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Snow;
            this.lbl_status.Location = new System.Drawing.Point(312, 61);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(113, 18);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status of Item";
            this.lbl_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.Snow;
            this.lbl_quantity.Location = new System.Drawing.Point(312, 142);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(70, 18);
            this.lbl_quantity.TabIndex = 13;
            this.lbl_quantity.Text = "Quantity";
            // 
            // dpd_quantity
            // 
            this.dpd_quantity.BackColor = System.Drawing.Color.Transparent;
            this.dpd_quantity.BorderRadius = 3;
            this.dpd_quantity.DisabledColor = System.Drawing.Color.Gray;
            this.dpd_quantity.ForeColor = System.Drawing.Color.Snow;
            this.dpd_quantity.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"};
            this.dpd_quantity.Location = new System.Drawing.Point(305, 133);
            this.dpd_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.dpd_quantity.Name = "dpd_quantity";
            this.dpd_quantity.NomalColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_quantity.onHoverColor = System.Drawing.Color.MediumSlateBlue;
            this.dpd_quantity.selectedIndex = -1;
            this.dpd_quantity.Size = new System.Drawing.Size(217, 35);
            this.dpd_quantity.TabIndex = 14;
            this.dpd_quantity.onItemSelected += new System.EventHandler(this.dpd_quantity_onItemSelected);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // btn_post
            // 
            this.btn_post.BackColor = System.Drawing.Color.Transparent;
            this.btn_post.BorderRadius = 10;
            this.btn_post.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_post.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_post.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_post.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_post.FillColor = System.Drawing.Color.Snow;
            this.btn_post.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_post.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_post.Location = new System.Drawing.Point(570, 422);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(216, 45);
            this.btn_post.TabIndex = 11;
            this.btn_post.Text = "Post";
            this.btn_post.UseTransparentBackground = true;
            this.btn_post.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_addImage
            // 
            this.btn_addImage.BackColor = System.Drawing.Color.Transparent;
            this.btn_addImage.BorderRadius = 10;
            this.btn_addImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addImage.ForeColor = System.Drawing.Color.White;
            this.btn_addImage.Location = new System.Drawing.Point(570, 344);
            this.btn_addImage.Name = "btn_addImage";
            this.btn_addImage.Size = new System.Drawing.Size(216, 45);
            this.btn_addImage.TabIndex = 11;
            this.btn_addImage.Text = "Add Image";
            this.btn_addImage.UseTransparentBackground = true;
            this.btn_addImage.Click += new System.EventHandler(this.btn_addImage_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(755, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(315, 9);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "Auto fill";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "X";
            this.bunifuTileButton1.Location = new System.Drawing.Point(359, 277);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(46, 51);
            this.bunifuTileButton1.TabIndex = 17;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // postItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csharp_pro.Properties.Resources.img2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.dpd_quantity);
            this.Controls.Add(this.pib_one);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_addImage);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_catagory);
            this.Controls.Add(this.dpd_status);
            this.Controls.Add(this.dpd_catagory);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_Iname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "postItem";
            this.Text = "postItem";
            this.Load += new System.EventHandler(this.postItem_Load);
            this.MouseHover += new System.EventHandler(this.postItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pib_one)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.rjDropdownMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown dpd_catagory;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_catagory;
        private System.Windows.Forms.Label lbl_Iname;
        private Bunifu.Framework.UI.BunifuDatepicker dtp1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.PictureBox pib_one;
        private System.Windows.Forms.Label lbl_status;
        private Bunifu.Framework.UI.BunifuDropdown dpd_status;
        private System.Windows.Forms.Label lbl_quantity;
        private Bunifu.Framework.UI.BunifuDropdown dpd_quantity;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private global::Guna.UI2.WinForms.Guna2Button btn_post;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private global::Guna.UI2.WinForms.Guna2Button btn_addImage;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}