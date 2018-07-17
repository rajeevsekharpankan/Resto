namespace Resto.UI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btncollapse = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnpendingorder = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pendingOrderCtrl1 = new Resto.UI.PendingOrderCtrl();
            this.firstCustomControl1 = new Resto.UI.FirstCustomControl();
            this.mySecondCustmControl1 = new Resto.UI.MySecondCustmControl();
            this.billscontrol1 = new Resto.UI.billscontrol();
            this.orderCtrl1 = new Resto.UI.OrderCtrl();
            this.pnlmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlmenu.Controls.Add(this.btncollapse);
            this.pnlmenu.Controls.Add(this.panel4);
            this.pnlmenu.Controls.Add(this.panel2);
            this.pnlmenu.Controls.Add(this.SidePanel);
            this.pnlmenu.Controls.Add(this.button7);
            this.pnlmenu.Controls.Add(this.btnpendingorder);
            this.pnlmenu.Controls.Add(this.btnbill);
            this.pnlmenu.Controls.Add(this.button5);
            this.pnlmenu.Controls.Add(this.button4);
            this.pnlmenu.Controls.Add(this.button3);
            this.pnlmenu.Controls.Add(this.button14);
            this.pnlmenu.Controls.Add(this.button2);
            this.pnlmenu.Controls.Add(this.btnhome);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(209, 657);
            this.pnlmenu.TabIndex = 0;
            this.pnlmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncollapse
            // 
            this.btncollapse.FlatAppearance.BorderSize = 0;
            this.btncollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncollapse.Image = ((System.Drawing.Image)(resources.GetObject("btncollapse.Image")));
            this.btncollapse.Location = new System.Drawing.Point(3, 139);
            this.btncollapse.Name = "btncollapse";
            this.btncollapse.Size = new System.Drawing.Size(62, 31);
            this.btncollapse.TabIndex = 8;
            this.btncollapse.UseVisualStyleBackColor = true;
            this.btncollapse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Resto.UI.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 134);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblamount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 89);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblamount
            // 
            this.lblamount.BackColor = System.Drawing.Color.Black;
            this.lblamount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblamount.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(0, 54);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(209, 35);
            this.lblamount.TabIndex = 0;
            this.lblamount.Text = "00.00";
            this.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 202);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 54);
            this.button7.TabIndex = 4;
            this.button7.Text = "       Customers";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // btnpendingorder
            // 
            this.btnpendingorder.FlatAppearance.BorderSize = 0;
            this.btnpendingorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpendingorder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpendingorder.ForeColor = System.Drawing.Color.White;
            this.btnpendingorder.Image = ((System.Drawing.Image)(resources.GetObject("btnpendingorder.Image")));
            this.btnpendingorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpendingorder.Location = new System.Drawing.Point(9, 357);
            this.btnpendingorder.Name = "btnpendingorder";
            this.btnpendingorder.Size = new System.Drawing.Size(197, 54);
            this.btnpendingorder.TabIndex = 4;
            this.btnpendingorder.Text = "       Pending Orders";
            this.btnpendingorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpendingorder.UseVisualStyleBackColor = true;
            this.btnpendingorder.Click += new System.EventHandler(this.btnpendingorder_Click);
            // 
            // btnbill
            // 
            this.btnbill.FlatAppearance.BorderSize = 0;
            this.btnbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.ForeColor = System.Drawing.Color.White;
            this.btnbill.Image = ((System.Drawing.Image)(resources.GetObject("btnbill.Image")));
            this.btnbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbill.Location = new System.Drawing.Point(12, 297);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(197, 54);
            this.btnbill.TabIndex = 4;
            this.btnbill.Text = "       Current Order";
            this.btnbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbill.UseVisualStyleBackColor = true;
            this.btnbill.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(9, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "       Take Away";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "       Delivery";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "       Collection";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "       Eat-In";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(12, 183);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(197, 54);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "       Today\'s Speacials";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restourents";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designed By ISAC\'s";
            this.label4.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(209, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnexit);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button12);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.splitContainer1.Panel2.Controls.Add(this.pendingOrderCtrl1);
            this.splitContainer1.Panel2.Controls.Add(this.firstCustomControl1);
            this.splitContainer1.Panel2.Controls.Add(this.mySecondCustmControl1);
            this.splitContainer1.Panel2.Controls.Add(this.billscontrol1);
            this.splitContainer1.Panel2.Controls.Add(this.orderCtrl1);
            this.splitContainer1.Size = new System.Drawing.Size(865, 657);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Resto.UI.Properties.Resources.signboardpdf;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(865, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(821, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 35);
            this.btnexit.TabIndex = 4;
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(125, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 34);
            this.button8.TabIndex = 4;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(167, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 34);
            this.button9.TabIndex = 4;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(329, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 35);
            this.button12.TabIndex = 4;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(209, 62);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 34);
            this.button10.TabIndex = 4;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(291, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 35);
            this.button11.TabIndex = 4;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pendingOrderCtrl1
            // 
            this.pendingOrderCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingOrderCtrl1.Location = new System.Drawing.Point(0, 0);
            this.pendingOrderCtrl1.Name = "pendingOrderCtrl1";
            this.pendingOrderCtrl1.parentform = null;
            this.pendingOrderCtrl1.Size = new System.Drawing.Size(865, 576);
            this.pendingOrderCtrl1.TabIndex = 8;
            this.pendingOrderCtrl1.userid = null;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.firstCustomControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstCustomControl1.ForeColor = System.Drawing.Color.White;
            this.firstCustomControl1.Location = new System.Drawing.Point(0, 0);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.parentform = null;
            this.firstCustomControl1.Size = new System.Drawing.Size(865, 576);
            this.firstCustomControl1.TabIndex = 5;
            this.firstCustomControl1.userid = null;
            // 
            // mySecondCustmControl1
            // 
            this.mySecondCustmControl1.categoryid = 0;
            this.mySecondCustmControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySecondCustmControl1.Location = new System.Drawing.Point(0, 0);
            this.mySecondCustmControl1.Name = "mySecondCustmControl1";
            this.mySecondCustmControl1.Size = new System.Drawing.Size(865, 576);
            this.mySecondCustmControl1.TabIndex = 6;
            // 
            // billscontrol1
            // 
            this.billscontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billscontrol1.Location = new System.Drawing.Point(0, 0);
            this.billscontrol1.Name = "billscontrol1";
            this.billscontrol1.Size = new System.Drawing.Size(865, 576);
            this.billscontrol1.TabIndex = 7;
            // 
            // orderCtrl1
            // 
            this.orderCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderCtrl1.Location = new System.Drawing.Point(0, 0);
            this.orderCtrl1.Name = "orderCtrl1";
            this.orderCtrl1.parentform = null;
            this.orderCtrl1.Size = new System.Drawing.Size(865, 576);
            this.orderCtrl1.TabIndex = 9;
            this.orderCtrl1.userid = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(1074, 657);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZigZag-Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnexit;
        public FirstCustomControl firstCustomControl1;
        public MySecondCustmControl mySecondCustmControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public Resto.UI.billscontrol billscontrol1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblamount;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btncollapse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnpendingorder;
        public Resto.UI.OrderCtrl orderCtrl1;
        public PendingOrderCtrl pendingOrderCtrl1;
    }
}

