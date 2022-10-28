namespace csharp_pro.items
{
    partial class ItemCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_itemPrice.ForeColor = System.Drawing.Color.Snow;
            this.lbl_itemPrice.Location = new System.Drawing.Point(44, 277);
            this.lbl_itemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(38, 18);
            this.lbl_itemPrice.TabIndex = 5;
            this.lbl_itemPrice.Text = "Price";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemName.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_itemName.ForeColor = System.Drawing.Color.Snow;
            this.lbl_itemName.Location = new System.Drawing.Point(44, 238);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(67, 18);
            this.lbl_itemName.TabIndex = 6;
            this.lbl_itemName.Text = "Item Name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(181, 238);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(67, 18);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Item Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_price.ForeColor = System.Drawing.Color.Red;
            this.lbl_price.Location = new System.Drawing.Point(181, 277);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 18);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(325, 211);
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_itemPrice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(325, 337);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
