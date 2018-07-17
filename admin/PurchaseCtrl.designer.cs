namespace ZigZag.Admin
{
    partial class PurchaseCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseCtrl));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseItemCtrl1 = new ZigZag.Admin.PurchaseItemCtrl();
            this.ddlsuppliers = new System.Windows.Forms.ComboBox();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.chksuppliers = new System.Windows.Forms.CheckBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.rbncredit = new System.Windows.Forms.RadioButton();
            this.rbncash = new System.Windows.Forms.RadioButton();
            this.companyseraillbl = new System.Windows.Forms.Label();
            this.storecbo = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.remarkstxt = new System.Windows.Forms.TextBox();
            this.txtpurchaseno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlitems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlbottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.splitContainer1);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1022, 483);
            this.pnlmain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.purchaseItemCtrl1);
            this.splitContainer1.Panel1.Controls.Add(this.ddlsuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.dtpPurchase);
            this.splitContainer1.Panel1.Controls.Add(this.chksuppliers);
            this.splitContainer1.Panel1.Controls.Add(this.txtcustomername);
            this.splitContainer1.Panel1.Controls.Add(this.rbncredit);
            this.splitContainer1.Panel1.Controls.Add(this.rbncash);
            this.splitContainer1.Panel1.Controls.Add(this.companyseraillbl);
            this.splitContainer1.Panel1.Controls.Add(this.storecbo);
            this.splitContainer1.Panel1.Controls.Add(this.Label3);
            this.splitContainer1.Panel1.Controls.Add(this.remarkstxt);
            this.splitContainer1.Panel1.Controls.Add(this.txtpurchaseno);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pnlbottom);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 483);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 411;
            this.label7.Text = "Remarks";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 411;
            this.label6.Text = "Invoice Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 411;
            this.label2.Text = "Suppliers :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 411;
            this.label4.Text = "Bill no:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchaseItemCtrl1
            // 
            this.purchaseItemCtrl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.purchaseItemCtrl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.purchaseItemCtrl1.ForeColor = System.Drawing.Color.White;
            this.purchaseItemCtrl1.Location = new System.Drawing.Point(0, 91);
            this.purchaseItemCtrl1.Name = "purchaseItemCtrl1";
            this.purchaseItemCtrl1.Size = new System.Drawing.Size(1022, 69);
            this.purchaseItemCtrl1.TabIndex = 410;
            // 
            // ddlsuppliers
            // 
            this.ddlsuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlsuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlsuppliers.DisplayMember = "customercode2";
            this.ddlsuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlsuppliers.Enabled = false;
            this.ddlsuppliers.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlsuppliers.FormattingEnabled = true;
            this.ddlsuppliers.Location = new System.Drawing.Point(748, 4);
            this.ddlsuppliers.Name = "ddlsuppliers";
            this.ddlsuppliers.Size = new System.Drawing.Size(216, 23);
            this.ddlsuppliers.TabIndex = 409;
            this.ddlsuppliers.ValueMember = "customercode2";
            this.ddlsuppliers.SelectedIndexChanged += new System.EventHandler(this.ddlsuppliers_SelectedIndexChanged);
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchase.Location = new System.Drawing.Point(178, 34);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(101, 22);
            this.dtpPurchase.TabIndex = 405;
            // 
            // chksuppliers
            // 
            this.chksuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chksuppliers.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksuppliers.ForeColor = System.Drawing.Color.White;
            this.chksuppliers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chksuppliers.Location = new System.Drawing.Point(665, 5);
            this.chksuppliers.Name = "chksuppliers";
            this.chksuppliers.Size = new System.Drawing.Size(83, 21);
            this.chksuppliers.TabIndex = 404;
            this.chksuppliers.Text = "Account";
            this.chksuppliers.UseVisualStyleBackColor = true;
            this.chksuppliers.CheckedChanged += new System.EventHandler(this.chksuppliers_CheckedChanged);
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(481, 4);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(178, 22);
            this.txtcustomername.TabIndex = 403;
            // 
            // rbncredit
            // 
            this.rbncredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbncredit.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbncredit.ForeColor = System.Drawing.Color.White;
            this.rbncredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbncredit.Location = new System.Drawing.Point(562, 36);
            this.rbncredit.Name = "rbncredit";
            this.rbncredit.Size = new System.Drawing.Size(78, 20);
            this.rbncredit.TabIndex = 402;
            this.rbncredit.Text = "Credit";
            this.rbncredit.UseVisualStyleBackColor = true;
            // 
            // rbncash
            // 
            this.rbncash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbncash.Checked = true;
            this.rbncash.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbncash.ForeColor = System.Drawing.Color.White;
            this.rbncash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbncash.Location = new System.Drawing.Point(481, 36);
            this.rbncash.Name = "rbncash";
            this.rbncash.Size = new System.Drawing.Size(78, 20);
            this.rbncash.TabIndex = 401;
            this.rbncash.TabStop = true;
            this.rbncash.Text = "Cash";
            this.rbncash.UseVisualStyleBackColor = true;
            // 
            // companyseraillbl
            // 
            this.companyseraillbl.BackColor = System.Drawing.Color.ForestGreen;
            this.companyseraillbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyseraillbl.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.companyseraillbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.companyseraillbl.Location = new System.Drawing.Point(724, 56);
            this.companyseraillbl.Name = "companyseraillbl";
            this.companyseraillbl.Size = new System.Drawing.Size(137, 27);
            this.companyseraillbl.TabIndex = 400;
            this.companyseraillbl.Text = "companyserailno";
            this.companyseraillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.companyseraillbl.Visible = false;
            // 
            // storecbo
            // 
            this.storecbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.storecbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.storecbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storecbo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.storecbo.FormattingEnabled = true;
            this.storecbo.Location = new System.Drawing.Point(795, 87);
            this.storecbo.Name = "storecbo";
            this.storecbo.Size = new System.Drawing.Size(139, 22);
            this.storecbo.TabIndex = 392;
            this.storecbo.Visible = false;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(703, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 23);
            this.Label3.TabIndex = 399;
            this.Label3.Text = "Store ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label3.Visible = false;
            // 
            // remarkstxt
            // 
            this.remarkstxt.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkstxt.Location = new System.Drawing.Point(178, 61);
            this.remarkstxt.Name = "remarkstxt";
            this.remarkstxt.Size = new System.Drawing.Size(445, 22);
            this.remarkstxt.TabIndex = 393;
            // 
            // txtpurchaseno
            // 
            this.txtpurchaseno.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurchaseno.Location = new System.Drawing.Point(178, 7);
            this.txtpurchaseno.Name = "txtpurchaseno";
            this.txtpurchaseno.Size = new System.Drawing.Size(100, 22);
            this.txtpurchaseno.TabIndex = 391;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlitems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 264);
            this.panel1.TabIndex = 2;
            // 
            // pnlitems
            // 
            this.pnlitems.AutoScroll = true;
            this.pnlitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlitems.Location = new System.Drawing.Point(0, 0);
            this.pnlitems.Name = "pnlitems";
            this.pnlitems.Size = new System.Drawing.Size(1022, 264);
            this.pnlitems.TabIndex = 0;
            this.pnlitems.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlitems_ControlAdded);
            // 
            // pnlbottom
            // 
            this.pnlbottom.Controls.Add(this.btnclose);
            this.pnlbottom.Controls.Add(this.btnsave);
            this.pnlbottom.Controls.Add(this.lbltotal);
            this.pnlbottom.Controls.Add(this.label1);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 264);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(1022, 55);
            this.pnlbottom.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnclose.Image = global::ZigZag.Admin.Properties.Resources.close;
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(438, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(60, 55);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 413;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btnsave.Image = global::ZigZag.Admin.Properties.Resources.save;
            this.btnsave.ImageActive = null;
            this.btnsave.Location = new System.Drawing.Point(351, 0);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(60, 55);
            this.btnsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsave.TabIndex = 413;
            this.btnsave.TabStop = false;
            this.btnsave.Zoom = 10;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(732, 23);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(287, 32);
            this.lbltotal.TabIndex = 412;
            this.lbltotal.Text = "0.00";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(547, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 412;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.pnlmain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PurchaseCtrl";
            this.Size = new System.Drawing.Size(1022, 483);
            this.pnlmain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlbottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ComboBox ddlsuppliers;
        internal System.Windows.Forms.DateTimePicker dtpPurchase;
        internal System.Windows.Forms.CheckBox chksuppliers;
        internal System.Windows.Forms.TextBox txtcustomername;
        internal System.Windows.Forms.RadioButton rbncredit;
        internal System.Windows.Forms.RadioButton rbncash;
        internal System.Windows.Forms.Label companyseraillbl;
        internal System.Windows.Forms.ComboBox storecbo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox remarkstxt;
        internal System.Windows.Forms.TextBox txtpurchaseno;
        private PurchaseItemCtrl purchaseItemCtrl1;
        private System.Windows.Forms.FlowLayoutPanel pnlitems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnsave;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        // private PurchaseItemCtrl purchaseItemCtrl1;
    }
}
