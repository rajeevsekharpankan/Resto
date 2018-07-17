namespace Resto.UI
{
    partial class item
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
            this.btndelete = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.btnmore = new System.Windows.Forms.Button();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.picpath = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpath)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.txtqty);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnaddtocart);
            this.panel4.Controls.Add(this.btnmore);
            this.panel4.Controls.Add(this.picpath);
            this.panel4.Controls.Add(this.lbldesc);
            this.panel4.Controls.Add(this.lblprice);
            this.panel4.Controls.Add(this.lblproductname);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 274);
            this.panel4.TabIndex = 3;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(87, 245);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(107, 26);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Remove";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(37, 250);
            this.txtqty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(46, 22);
            this.txtqty.TabIndex = 5;
            this.txtqty.ValueChanged += new System.EventHandler(this.txtqty_ValueChanged);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qty";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnaddtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddtocart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtocart.ForeColor = System.Drawing.Color.White;
            this.btnaddtocart.Location = new System.Drawing.Point(87, 245);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(107, 26);
            this.btnaddtocart.TabIndex = 2;
            this.btnaddtocart.Text = "Add to cart";
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // btnmore
            // 
            this.btnmore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmore.ForeColor = System.Drawing.Color.White;
            this.btnmore.Location = new System.Drawing.Point(87, 213);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(107, 26);
            this.btnmore.TabIndex = 1;
            this.btnmore.Text = "Read More";
            this.btnmore.UseVisualStyleBackColor = false;
            this.btnmore.Visible = false;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(9, 173);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(177, 17);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Lorem ispum is a dummy text";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Black;
            this.lblprice.Location = new System.Drawing.Point(3, 210);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(57, 25);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "د.إ45";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(8, 3);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(63, 25);
            this.lblproductname.TabIndex = 1;
            this.lblproductname.Text = "Pizza";
            // 
            // picpath
            // 
            this.picpath.ImageLocation = "Z:\\1.jpg";
            this.picpath.Location = new System.Drawing.Point(4, 26);
            this.picpath.Name = "picpath";
            this.picpath.Size = new System.Drawing.Size(191, 148);
            this.picpath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpath.TabIndex = 1;
            this.picpath.TabStop = false;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "item";
            this.Size = new System.Drawing.Size(199, 279);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblprice;
        public System.Windows.Forms.PictureBox picpath;
        public System.Windows.Forms.Label lblproductname;
        public System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txtqty;
        public System.Windows.Forms.Button btndelete;
    }
}
