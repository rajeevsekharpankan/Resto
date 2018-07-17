namespace ZigZag.Admin
{
    partial class billscontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billscontrol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpbill = new System.Windows.Forms.DateTimePicker();
            this.rbncash = new System.Windows.Forms.RadioButton();
            this.rbndirect = new System.Windows.Forms.RadioButton();
            this.rbnPc = new System.Windows.Forms.RadioButton();
            this.ddlitems = new System.Windows.Forms.ComboBox();
            this.btnsent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.pnlbill = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpbill);
            this.panel2.Controls.Add(this.rbncash);
            this.panel2.Controls.Add(this.rbndirect);
            this.panel2.Controls.Add(this.rbnPc);
            this.panel2.Controls.Add(this.ddlitems);
            this.panel2.Controls.Add(this.btnsent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 77);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(320, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 407;
            this.label4.Text = "Date";
            // 
            // dtpbill
            // 
            this.dtpbill.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbill.Location = new System.Drawing.Point(324, 43);
            this.dtpbill.Name = "dtpbill";
            this.dtpbill.Size = new System.Drawing.Size(123, 26);
            this.dtpbill.TabIndex = 406;
            // 
            // rbncash
            // 
            this.rbncash.AutoSize = true;
            this.rbncash.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbncash.Location = new System.Drawing.Point(92, 12);
            this.rbncash.Name = "rbncash";
            this.rbncash.Size = new System.Drawing.Size(64, 24);
            this.rbncash.TabIndex = 21;
            this.rbncash.Text = "Cash";
            this.rbncash.UseVisualStyleBackColor = true;
            this.rbncash.CheckedChanged += new System.EventHandler(this.rbnPc_CheckedChanged);
            // 
            // rbndirect
            // 
            this.rbndirect.AutoSize = true;
            this.rbndirect.Enabled = false;
            this.rbndirect.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbndirect.Location = new System.Drawing.Point(441, 12);
            this.rbndirect.Name = "rbndirect";
            this.rbndirect.Size = new System.Drawing.Size(75, 24);
            this.rbndirect.TabIndex = 21;
            this.rbndirect.Text = "Direct";
            this.rbndirect.UseVisualStyleBackColor = true;
            this.rbndirect.Visible = false;
            this.rbndirect.CheckedChanged += new System.EventHandler(this.rbnPc_CheckedChanged);
            // 
            // rbnPc
            // 
            this.rbnPc.AutoSize = true;
            this.rbnPc.Checked = true;
            this.rbnPc.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPc.Location = new System.Drawing.Point(17, 13);
            this.rbnPc.Name = "rbnPc";
            this.rbnPc.Size = new System.Drawing.Size(53, 24);
            this.rbnPc.TabIndex = 21;
            this.rbnPc.TabStop = true;
            this.rbnPc.Text = "Pcs";
            this.rbnPc.UseVisualStyleBackColor = true;
            this.rbnPc.CheckedChanged += new System.EventHandler(this.rbnPc_CheckedChanged);
            // 
            // ddlitems
            // 
            this.ddlitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.ddlitems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlitems.FormattingEnabled = true;
            this.ddlitems.Location = new System.Drawing.Point(17, 42);
            this.ddlitems.Name = "ddlitems";
            this.ddlitems.Size = new System.Drawing.Size(301, 28);
            this.ddlitems.TabIndex = 20;
            this.ddlitems.SelectedIndexChanged += new System.EventHandler(this.ddlitems_SelectedIndexChanged);
            // 
            // btnsent
            // 
            this.btnsent.ActiveBorderThickness = 1;
            this.btnsent.ActiveCornerRadius = 20;
            this.btnsent.ActiveFillColor = System.Drawing.Color.Black;
            this.btnsent.ActiveForecolor = System.Drawing.Color.White;
            this.btnsent.ActiveLineColor = System.Drawing.Color.White;
            this.btnsent.BackColor = System.Drawing.SystemColors.Control;
            this.btnsent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsent.BackgroundImage")));
            this.btnsent.ButtonText = "Submit";
            this.btnsent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsent.ForeColor = System.Drawing.Color.White;
            this.btnsent.IdleBorderThickness = 1;
            this.btnsent.IdleCornerRadius = 20;
            this.btnsent.IdleFillColor = System.Drawing.Color.Gold;
            this.btnsent.IdleForecolor = System.Drawing.Color.Black;
            this.btnsent.IdleLineColor = System.Drawing.Color.White;
            this.btnsent.Location = new System.Drawing.Point(548, 30);
            this.btnsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(118, 47);
            this.btnsent.TabIndex = 18;
            this.btnsent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsent.Click += new System.EventHandler(this.btnbillsubmit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(673, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblamount);
            this.splitContainer1.Size = new System.Drawing.Size(226, 77);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblamount
            // 
            this.lblamount.BackColor = System.Drawing.Color.Black;
            this.lblamount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblamount.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.ForeColor = System.Drawing.Color.White;
            this.lblamount.Location = new System.Drawing.Point(0, 0);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(226, 35);
            this.lblamount.TabIndex = 2;
            this.lblamount.Text = "00.00";
            this.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlbill
            // 
            this.pnlbill.AutoScroll = true;
            this.pnlbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbill.Location = new System.Drawing.Point(0, 77);
            this.pnlbill.Name = "pnlbill";
            this.pnlbill.Size = new System.Drawing.Size(899, 425);
            this.pnlbill.TabIndex = 1;
            this.pnlbill.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            // 
            // billscontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlbill);
            this.Controls.Add(this.panel1);
            this.Name = "billscontrol";
            this.Size = new System.Drawing.Size(899, 502);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlbill;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsent;
        private System.Windows.Forms.RadioButton rbndirect;
        private System.Windows.Forms.RadioButton rbnPc;
        public System.Windows.Forms.ComboBox ddlitems;
        internal System.Windows.Forms.DateTimePicker dtpbill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbncash;
    }
}
