namespace csharp_pro
{
    partial class discSeller
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
            this.lbl_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_location = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_condition = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(40, 264);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(37, 20);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Values.Text = "Price";
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(17, 13);
            this.picture1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(218, 179);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(40, 215);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 20);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Values.Text = "Name";
            this.lbl_name.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_name_Paint);
            // 
            // lbl_type
            // 
            this.lbl_type.Location = new System.Drawing.Point(40, 240);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(37, 20);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Values.Text = "Type";
            // 
            // lbl_location
            // 
            this.lbl_location.Location = new System.Drawing.Point(40, 288);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(54, 20);
            this.lbl_location.TabIndex = 5;
            this.lbl_location.Values.Text = "location";
            // 
            // lbl_condition
            // 
            this.lbl_condition.Location = new System.Drawing.Point(40, 313);
            this.lbl_condition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_condition.Name = "lbl_condition";
            this.lbl_condition.Size = new System.Drawing.Size(62, 20);
            this.lbl_condition.TabIndex = 6;
            this.lbl_condition.Values.Text = "condition";
            this.lbl_condition.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_condition_Paint);
            // 
            // discSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_condition);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.picture1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "discSeller";
            this.Size = new System.Drawing.Size(255, 355);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_price;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_type;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_location;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_condition;
    }
}
