namespace Resto.UI
{
    partial class Productctrl
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
            this.btnedit = new System.Windows.Forms.Button();
            this.imgitem = new System.Windows.Forms.PictureBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblqtycaption = new System.Windows.Forms.Label();
            this.lblpricecaption = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnedit);
            this.panel4.Controls.Add(this.imgitem);
            this.panel4.Controls.Add(this.lbldesc);
            this.panel4.Controls.Add(this.lblqtycaption);
            this.panel4.Controls.Add(this.lblpricecaption);
            this.panel4.Controls.Add(this.lblqty);
            this.panel4.Controls.Add(this.lblprice);
            this.panel4.Controls.Add(this.lblproductname);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 224);
            this.panel4.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(143, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(61, 26);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(143, 163);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(61, 26);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Visible = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // imgitem
            // 
            this.imgitem.ImageLocation = "Z:\\1.jpg";
            this.imgitem.Location = new System.Drawing.Point(4, 26);
            this.imgitem.Name = "imgitem";
            this.imgitem.Size = new System.Drawing.Size(194, 130);
            this.imgitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgitem.TabIndex = 1;
            this.imgitem.TabStop = false;
            // 
            // lbldesc
            // 
            this.lbldesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(163, 3);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(44, 20);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Lorem ispum is a dummy text";
            this.lbldesc.Visible = false;
            // 
            // lblqtycaption
            // 
            this.lblqtycaption.AutoSize = true;
            this.lblqtycaption.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtycaption.ForeColor = System.Drawing.Color.Black;
            this.lblqtycaption.Location = new System.Drawing.Point(8, 195);
            this.lblqtycaption.Name = "lblqtycaption";
            this.lblqtycaption.Size = new System.Drawing.Size(60, 25);
            this.lblqtycaption.TabIndex = 1;
            this.lblqtycaption.Text = "Qty :";
            this.lblqtycaption.Visible = false;
            // 
            // lblpricecaption
            // 
            this.lblpricecaption.AutoSize = true;
            this.lblpricecaption.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpricecaption.ForeColor = System.Drawing.Color.Black;
            this.lblpricecaption.Location = new System.Drawing.Point(8, 164);
            this.lblpricecaption.Name = "lblpricecaption";
            this.lblpricecaption.Size = new System.Drawing.Size(74, 25);
            this.lblpricecaption.TabIndex = 1;
            this.lblpricecaption.Text = "Price :";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Black;
            this.lblqty.Location = new System.Drawing.Point(80, 193);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(57, 25);
            this.lblqty.TabIndex = 1;
            this.lblqty.Text = "د.إ45";
            this.lblqty.Visible = false;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Black;
            this.lblprice.Location = new System.Drawing.Point(80, 164);
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
            // Productctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "Productctrl";
            this.Size = new System.Drawing.Size(207, 224);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.PictureBox imgitem;
        public System.Windows.Forms.Label lblproductname;
        public System.Windows.Forms.Label lbldesc;
        public System.Windows.Forms.Label lblprice;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Label lblqtycaption;
        public System.Windows.Forms.Label lblpricecaption;
        public System.Windows.Forms.Label lblqty;
    }
}
