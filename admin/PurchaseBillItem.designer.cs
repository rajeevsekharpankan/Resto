namespace ZigZag.Admin
{
    partial class PurchaseBillItem
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
            this.btndelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnedit = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.btnserial = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btndelete);
            this.panel4.Controls.Add(this.btnedit);
            this.panel4.Controls.Add(this.txtamount);
            this.panel4.Controls.Add(this.txtqty);
            this.panel4.Controls.Add(this.txtcost);
            this.panel4.Controls.Add(this.txtitemname);
            this.panel4.Controls.Add(this.btnserial);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1096, 25);
            this.panel4.TabIndex = 9;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btndelete.Image = global::ZigZag.Admin.Properties.Resources.delete;
            this.btndelete.ImageActive = null;
            this.btndelete.InitialImage = global::ZigZag.Admin.Properties.Resources.plus;
            this.btndelete.Location = new System.Drawing.Point(1057, 0);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(38, 25);
            this.btndelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndelete.TabIndex = 12;
            this.btndelete.TabStop = false;
            this.btndelete.Zoom = 10;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnedit.Image = global::ZigZag.Admin.Properties.Resources.edit;
            this.btnedit.ImageActive = null;
            this.btnedit.InitialImage = global::ZigZag.Admin.Properties.Resources.plus;
            this.btnedit.Location = new System.Drawing.Point(1019, 0);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(38, 25);
            this.btnedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnedit.TabIndex = 11;
            this.btnedit.TabStop = false;
            this.btnedit.Zoom = 10;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.txtamount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtamount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.ForeColor = System.Drawing.Color.White;
            this.txtamount.Location = new System.Drawing.Point(915, 0);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(104, 23);
            this.txtamount.TabIndex = 10;
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.txtqty.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtqty.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.White;
            this.txtqty.Location = new System.Drawing.Point(811, 0);
            this.txtqty.Name = "txtqty";
            this.txtqty.ReadOnly = true;
            this.txtqty.Size = new System.Drawing.Size(104, 23);
            this.txtqty.TabIndex = 9;
            // 
            // txtcost
            // 
            this.txtcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.txtcost.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcost.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.ForeColor = System.Drawing.Color.White;
            this.txtcost.Location = new System.Drawing.Point(707, 0);
            this.txtcost.Name = "txtcost";
            this.txtcost.ReadOnly = true;
            this.txtcost.Size = new System.Drawing.Size(104, 23);
            this.txtcost.TabIndex = 6;
            // 
            // txtitemname
            // 
            this.txtitemname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.txtitemname.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtitemname.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.ForeColor = System.Drawing.Color.White;
            this.txtitemname.Location = new System.Drawing.Point(26, 0);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(681, 23);
            this.txtitemname.TabIndex = 4;
            // 
            // btnserial
            // 
            this.btnserial.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnserial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnserial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnserial.BorderRadius = 0;
            this.btnserial.ButtonText = "#";
            this.btnserial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnserial.DisabledColor = System.Drawing.Color.Gray;
            this.btnserial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnserial.Iconcolor = System.Drawing.Color.Transparent;
            this.btnserial.Iconimage = null;
            this.btnserial.Iconimage_right = null;
            this.btnserial.Iconimage_right_Selected = null;
            this.btnserial.Iconimage_Selected = null;
            this.btnserial.IconMarginLeft = 0;
            this.btnserial.IconMarginRight = 0;
            this.btnserial.IconRightVisible = true;
            this.btnserial.IconRightZoom = 0D;
            this.btnserial.IconVisible = true;
            this.btnserial.IconZoom = 90D;
            this.btnserial.IsTab = false;
            this.btnserial.Location = new System.Drawing.Point(0, 0);
            this.btnserial.Name = "btnserial";
            this.btnserial.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnserial.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnserial.OnHoverTextColor = System.Drawing.Color.White;
            this.btnserial.selected = false;
            this.btnserial.Size = new System.Drawing.Size(26, 25);
            this.btnserial.TabIndex = 1;
            this.btnserial.Text = "#";
            this.btnserial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnserial.Textcolor = System.Drawing.Color.White;
            this.btnserial.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PurchaseBillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.panel4);
            this.Name = "PurchaseBillItem";
            this.Size = new System.Drawing.Size(1096, 25);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtcost;
        public System.Windows.Forms.TextBox txtitemname;
        public System.Windows.Forms.TextBox txtamount;
        public System.Windows.Forms.TextBox txtqty;
        public Bunifu.Framework.UI.BunifuImageButton btndelete;
        public Bunifu.Framework.UI.BunifuImageButton btnedit;
        public Bunifu.Framework.UI.BunifuFlatButton btnserial;
    }
}
