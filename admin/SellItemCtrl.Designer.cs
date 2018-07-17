namespace ZigZag.Admin
{
    partial class SellItemCtrl
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblqtycaption = new System.Windows.Forms.Label();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.picitem = new System.Windows.Forms.PictureBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblqty);
            this.panel4.Controls.Add(this.txtqty);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblqtycaption);
            this.panel4.Controls.Add(this.btnaddtocart);
            this.panel4.Controls.Add(this.picitem);
            this.panel4.Controls.Add(this.lblprice);
            this.panel4.Controls.Add(this.lblproductname);
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 216);
            this.panel4.TabIndex = 4;
            // 
            // lblqty
            // 
            this.lblqty.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Black;
            this.lblqty.Location = new System.Drawing.Point(38, 158);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(60, 25);
            this.lblqty.TabIndex = 7;
            this.lblqty.Text = "qty";
            this.lblqty.Visible = false;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(38, 159);
            this.txtqty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(60, 22);
            this.txtqty.TabIndex = 5;
            this.txtqty.ValueChanged += new System.EventHandler(this.txtqty_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price :";
            // 
            // lblqtycaption
            // 
            this.lblqtycaption.AutoSize = true;
            this.lblqtycaption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtycaption.ForeColor = System.Drawing.Color.Black;
            this.lblqtycaption.Location = new System.Drawing.Point(3, 161);
            this.lblqtycaption.Name = "lblqtycaption";
            this.lblqtycaption.Size = new System.Drawing.Size(35, 19);
            this.lblqtycaption.TabIndex = 3;
            this.lblqtycaption.Text = "Qty";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnaddtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddtocart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtocart.ForeColor = System.Drawing.Color.White;
            this.btnaddtocart.Location = new System.Drawing.Point(102, 159);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(93, 26);
            this.btnaddtocart.TabIndex = 2;
            this.btnaddtocart.Text = "Add to cart";
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // picitem
            // 
            this.picitem.ImageLocation = "Z:\\1.jpg";
            this.picitem.Location = new System.Drawing.Point(4, 31);
            this.picitem.Name = "picitem";
            this.picitem.Size = new System.Drawing.Size(190, 127);
            this.picitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picitem.TabIndex = 1;
            this.picitem.TabStop = false;
            // 
            // lblprice
            // 
            this.lblprice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Black;
            this.lblprice.Location = new System.Drawing.Point(58, 188);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(135, 25);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "د.إ45";
            // 
            // lblproductname
            // 
            this.lblproductname.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(8, 3);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(134, 25);
            this.lblproductname.TabIndex = 1;
            this.lblproductname.Text = "Pizza";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(98, 159);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 26);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Remove";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // SellItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "SellItemCtrl";
            this.Size = new System.Drawing.Size(197, 216);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picitem;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.NumericUpDown txtqty;
        private System.Windows.Forms.Label lblqtycaption;
        public System.Windows.Forms.Button btnaddtocart;
        public System.Windows.Forms.Label lblproductname;
        public System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblqty;
    }
}
