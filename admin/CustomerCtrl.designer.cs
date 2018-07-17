namespace ZigZag.Admin
{
    partial class CustomerCtrl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productspnl = new System.Windows.Forms.FlowLayoutPanel();
            this.toppnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addCustomer1 = new ZigZag.Admin.AddCustomer();
            this.btncontrol1 = new ZigZag.Admin.btncontrol();
            this.panel1.SuspendLayout();
            this.productspnl.SuspendLayout();
            this.toppnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.productspnl);
            this.panel1.Controls.Add(this.toppnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 505);
            this.panel1.TabIndex = 0;
            // 
            // productspnl
            // 
            this.productspnl.AutoScroll = true;
            this.productspnl.BackColor = System.Drawing.SystemColors.Control;
            this.productspnl.Controls.Add(this.addCustomer1);
            this.productspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productspnl.Location = new System.Drawing.Point(0, 53);
            this.productspnl.Name = "productspnl";
            this.productspnl.Size = new System.Drawing.Size(951, 452);
            this.productspnl.TabIndex = 1;
            this.productspnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.productspnl_ControlAdded);
            // 
            // toppnl
            // 
            this.toppnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.toppnl.Controls.Add(this.panel2);
            this.toppnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.toppnl.Location = new System.Drawing.Point(0, 0);
            this.toppnl.Name = "toppnl";
            this.toppnl.Size = new System.Drawing.Size(951, 53);
            this.toppnl.TabIndex = 0;
            this.toppnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.toppnl_ControlAdded);
            this.toppnl.Paint += new System.Windows.Forms.PaintEventHandler(this.toppnl_Paint);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btncontrol1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 44);
            this.panel2.TabIndex = 2;
            // 
            // addCustomer1
            // 
            this.addCustomer1.Location = new System.Drawing.Point(3, 3);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(915, 451);
            this.addCustomer1.TabIndex = 0;
            // 
            // btncontrol1
            // 
            this.btncontrol1.Location = new System.Drawing.Point(638, 3);
            this.btncontrol1.Name = "btncontrol1";
            this.btncontrol1.Size = new System.Drawing.Size(159, 47);
            this.btncontrol1.TabIndex = 0;
            this.btncontrol1.Visible = false;
            this.btncontrol1.Load += new System.EventHandler(this.btncontrol1_Load);
            // 
            // CustomerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerCtrl";
            this.Size = new System.Drawing.Size(951, 505);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            this.panel1.ResumeLayout(false);
            this.productspnl.ResumeLayout(false);
            this.toppnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel productspnl;
        public System.Windows.Forms.FlowLayoutPanel toppnl;
        public AddCustomer addCustomer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ZigZag.Admin.btncontrol btncontrol1;
    }
}
