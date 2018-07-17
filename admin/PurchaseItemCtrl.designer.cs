namespace ZigZag.Admin
{
    partial class PurchaseItemCtrl
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
            this.pnlmain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.ddlitems = new System.Windows.Forms.ComboBox();
            this.ddlcatagory = new System.Windows.Forms.ComboBox();
            this.btnserial = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.panel4);
            this.pnlmain.Controls.Add(this.panel3);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1059, 61);
            this.pnlmain.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Controls.Add(this.txtamount);
            this.panel4.Controls.Add(this.txtqty);
            this.panel4.Controls.Add(this.txtcost);
            this.panel4.Controls.Add(this.ddlitems);
            this.panel4.Controls.Add(this.ddlcatagory);
            this.panel4.Controls.Add(this.btnserial);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 27);
            this.panel4.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnadd.Image = global::ZigZag.Admin.Properties.Resources.plus;
            this.btnadd.ImageActive = null;
            this.btnadd.InitialImage = global::ZigZag.Admin.Properties.Resources.plus;
            this.btnadd.Location = new System.Drawing.Point(1019, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(37, 27);
            this.btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnadd.TabIndex = 7;
            this.btnadd.TabStop = false;
            this.btnadd.Zoom = 10;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtamount
            // 
            this.txtamount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtamount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(915, 0);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(104, 23);
            this.txtamount.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtqty.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(811, 0);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(104, 23);
            this.txtqty.TabIndex = 5;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // txtcost
            // 
            this.txtcost.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcost.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.Location = new System.Drawing.Point(707, 0);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(104, 23);
            this.txtcost.TabIndex = 4;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            this.txtcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcost_KeyPress);
            // 
            // ddlitems
            // 
            this.ddlitems.Dock = System.Windows.Forms.DockStyle.Left;
            this.ddlitems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlitems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlitems.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlitems.FormattingEnabled = true;
            this.ddlitems.ItemHeight = 15;
            this.ddlitems.Location = new System.Drawing.Point(326, 0);
            this.ddlitems.Name = "ddlitems";
            this.ddlitems.Size = new System.Drawing.Size(381, 23);
            this.ddlitems.TabIndex = 3;
            this.ddlitems.SelectedIndexChanged += new System.EventHandler(this.ddlitems_SelectedIndexChanged);
            // 
            // ddlcatagory
            // 
            this.ddlcatagory.Dock = System.Windows.Forms.DockStyle.Left;
            this.ddlcatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlcatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlcatagory.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlcatagory.FormattingEnabled = true;
            this.ddlcatagory.ItemHeight = 15;
            this.ddlcatagory.Location = new System.Drawing.Point(26, 0);
            this.ddlcatagory.Name = "ddlcatagory";
            this.ddlcatagory.Size = new System.Drawing.Size(300, 23);
            this.ddlcatagory.TabIndex = 2;
            this.ddlcatagory.SelectedIndexChanged += new System.EventHandler(this.ddlcatagory_SelectedIndexChanged);
            // 
            // btnserial
            // 
            this.btnserial.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnserial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
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
            this.btnserial.Size = new System.Drawing.Size(26, 27);
            this.btnserial.TabIndex = 1;
            this.btnserial.Text = "#";
            this.btnserial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnserial.Textcolor = System.Drawing.Color.White;
            this.btnserial.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 33);
            this.panel3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(915, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(811, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(707, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(326, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Items";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catagory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "#";
            // 
            // PurchaseItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.pnlmain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PurchaseItemCtrl";
            this.Size = new System.Drawing.Size(1059, 61);
            this.Load += new System.EventHandler(this.PurchaseItemCtrl_Load);
            this.pnlmain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        public System.Windows.Forms.ComboBox ddlcatagory;
        public System.Windows.Forms.ComboBox ddlitems;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcost;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuImageButton btnadd;
        public Bunifu.Framework.UI.BunifuFlatButton btnserial;
    }
}
