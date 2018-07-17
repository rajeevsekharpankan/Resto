﻿namespace ZigZag.Admin
{
    partial class OrderCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCtrl));
            this.pnlbill = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbillsubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbillno = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbill
            // 
            this.pnlbill.AutoScroll = true;
            this.pnlbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.pnlbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbill.Location = new System.Drawing.Point(0, 77);
            this.pnlbill.Name = "pnlbill";
            this.pnlbill.Size = new System.Drawing.Size(899, 425);
            this.pnlbill.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 77);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnbillsubmit);
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 77);
            this.panel2.TabIndex = 5;
            // 
            // btnbillsubmit
            // 
            this.btnbillsubmit.ActiveBorderThickness = 1;
            this.btnbillsubmit.ActiveCornerRadius = 20;
            this.btnbillsubmit.ActiveFillColor = System.Drawing.Color.Black;
            this.btnbillsubmit.ActiveForecolor = System.Drawing.Color.White;
            this.btnbillsubmit.ActiveLineColor = System.Drawing.Color.White;
            this.btnbillsubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnbillsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbillsubmit.BackgroundImage")));
            this.btnbillsubmit.ButtonText = "Serve Order";
            this.btnbillsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbillsubmit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillsubmit.ForeColor = System.Drawing.Color.White;
            this.btnbillsubmit.IdleBorderThickness = 1;
            this.btnbillsubmit.IdleCornerRadius = 20;
            this.btnbillsubmit.IdleFillColor = System.Drawing.Color.Gold;
            this.btnbillsubmit.IdleForecolor = System.Drawing.Color.Black;
            this.btnbillsubmit.IdleLineColor = System.Drawing.Color.White;
            this.btnbillsubmit.Location = new System.Drawing.Point(233, 30);
            this.btnbillsubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbillsubmit.Name = "btnbillsubmit";
            this.btnbillsubmit.Size = new System.Drawing.Size(95, 43);
            this.btnbillsubmit.TabIndex = 17;
            this.btnbillsubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbillsubmit.Click += new System.EventHandler(this.btnbillsubmit_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblbillno);
            this.splitContainer2.Size = new System.Drawing.Size(226, 77);
            this.splitContainer2.SplitterDistance = 38;
            this.splitContainer2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblbillno
            // 
            this.lblbillno.BackColor = System.Drawing.Color.Black;
            this.lblbillno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblbillno.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillno.ForeColor = System.Drawing.Color.White;
            this.lblbillno.Location = new System.Drawing.Point(0, 0);
            this.lblbillno.Name = "lblbillno";
            this.lblbillno.Size = new System.Drawing.Size(226, 35);
            this.lblbillno.TabIndex = 2;
            this.lblbillno.Text = "0";
            this.lblbillno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // OrderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlbill);
            this.Controls.Add(this.panel1);
            this.Name = "OrderCtrl";
            this.Size = new System.Drawing.Size(899, 502);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlbill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbillsubmit;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblbillno;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblamount;
    }
}