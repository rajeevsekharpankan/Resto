namespace ZigZag.Admin
{
    partial class ItemListCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemListCtrl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ddlcategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.picproduct = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlproducts = new System.Windows.Forms.FlowLayoutPanel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.erricon = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkisstockable = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erricon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkisstockable);
            this.splitContainer1.Panel1.Controls.Add(this.ddlcategories);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnsave);
            this.splitContainer1.Panel1.Controls.Add(this.txtname);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtprice);
            this.splitContainer1.Panel1.Controls.Add(this.txtdesc);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlproducts);
            this.splitContainer1.Size = new System.Drawing.Size(920, 517);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 2;
            // 
            // ddlcategories
            // 
            this.ddlcategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.ddlcategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlcategories.FormattingEnabled = true;
            this.ddlcategories.Location = new System.Drawing.Point(16, 53);
            this.ddlcategories.Name = "ddlcategories";
            this.ddlcategories.Size = new System.Drawing.Size(301, 28);
            this.ddlcategories.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer2.Location = new System.Drawing.Point(699, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picproduct);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnbrowse);
            this.splitContainer2.Size = new System.Drawing.Size(221, 198);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 10;
            // 
            // picproduct
            // 
            this.picproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picproduct.Location = new System.Drawing.Point(0, 0);
            this.picproduct.Name = "picproduct";
            this.picproduct.Size = new System.Drawing.Size(221, 148);
            this.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picproduct.TabIndex = 0;
            this.picproduct.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.ActiveBorderThickness = 1;
            this.btnbrowse.ActiveCornerRadius = 20;
            this.btnbrowse.ActiveFillColor = System.Drawing.Color.Black;
            this.btnbrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnbrowse.ActiveLineColor = System.Drawing.Color.White;
            this.btnbrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnbrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbrowse.BackgroundImage")));
            this.btnbrowse.ButtonText = "Browse";
            this.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnbrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.IdleBorderThickness = 1;
            this.btnbrowse.IdleCornerRadius = 20;
            this.btnbrowse.IdleFillColor = System.Drawing.Color.White;
            this.btnbrowse.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnbrowse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnbrowse.Location = new System.Drawing.Point(133, 0);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(88, 46);
            this.btnbrowse.TabIndex = 9;
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // btnsave
            // 
            this.btnsave.ActiveBorderThickness = 1;
            this.btnsave.ActiveCornerRadius = 20;
            this.btnsave.ActiveFillColor = System.Drawing.Color.Black;
            this.btnsave.ActiveForecolor = System.Drawing.Color.White;
            this.btnsave.ActiveLineColor = System.Drawing.Color.White;
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.ButtonText = "Submit";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleCornerRadius = 20;
            this.btnsave.IdleFillColor = System.Drawing.Color.White;
            this.btnsave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnsave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnsave.Location = new System.Drawing.Point(16, 148);
            this.btnsave.Margin = new System.Windows.Forms.Padding(5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 46);
            this.btnsave.TabIndex = 9;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(322, 40);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(352, 39);
            this.txtname.TabIndex = 3;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtprice.LineThickness = 3;
            this.txtprice.Location = new System.Drawing.Point(16, 109);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(157, 39);
            this.txtprice.TabIndex = 5;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtdesc
            // 
            this.txtdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdesc.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdesc.HintForeColor = System.Drawing.Color.Empty;
            this.txtdesc.HintText = "";
            this.txtdesc.isPassword = false;
            this.txtdesc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtdesc.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtdesc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtdesc.LineThickness = 3;
            this.txtdesc.Location = new System.Drawing.Point(322, 114);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(354, 45);
            this.txtdesc.TabIndex = 7;
            this.txtdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // pnlproducts
            // 
            this.pnlproducts.AutoScroll = true;
            this.pnlproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlproducts.Location = new System.Drawing.Point(0, 0);
            this.pnlproducts.Name = "pnlproducts";
            this.pnlproducts.Size = new System.Drawing.Size(920, 315);
            this.pnlproducts.TabIndex = 10;
            // 
            // erricon
            // 
            this.erricon.ContainerControl = this;
            // 
            // chkisstockable
            // 
            this.chkisstockable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkisstockable.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkisstockable.Checked = true;
            this.chkisstockable.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkisstockable.ForeColor = System.Drawing.Color.White;
            this.chkisstockable.Location = new System.Drawing.Point(324, 166);
            this.chkisstockable.Name = "chkisstockable";
            this.chkisstockable.Size = new System.Drawing.Size(20, 20);
            this.chkisstockable.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(350, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Is Stockable";
            // 
            // ItemListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemListCtrl";
            this.Size = new System.Drawing.Size(920, 517);
            this.Load += new System.EventHandler(this.ItemListCtrl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erricon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlproducts;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbrowse;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox picproduct;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox ddlcategories;
        private System.Windows.Forms.ErrorProvider erricon;
        private Bunifu.Framework.UI.BunifuCheckbox chkisstockable;
        private System.Windows.Forms.Label label5;
    }
}
