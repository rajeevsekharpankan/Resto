namespace ZigZag.Admin
{
    partial class PcBillingCtrl
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.toppnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 69);
            this.panel1.TabIndex = 0;
            // 
            // productspnl
            // 
            this.productspnl.AutoScroll = true;
            this.productspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productspnl.Location = new System.Drawing.Point(0, 69);
            this.productspnl.Name = "productspnl";
            this.productspnl.Size = new System.Drawing.Size(935, 386);
            this.productspnl.TabIndex = 1;
            this.productspnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.productspnl_ControlAdded);
            // 
            // toppnl
            // 
            this.toppnl.BackColor = System.Drawing.Color.Black;
            this.toppnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toppnl.Location = new System.Drawing.Point(0, 0);
            this.toppnl.Name = "toppnl";
            this.toppnl.Size = new System.Drawing.Size(935, 69);
            this.toppnl.TabIndex = 0;
            this.toppnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.toppnl_ControlAdded);
            this.toppnl.Paint += new System.Windows.Forms.PaintEventHandler(this.toppnl_Paint);
            // 
            // MySecondCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productspnl);
            this.Controls.Add(this.panel1);
            this.Name = "MySecondCustmControl";
            this.Size = new System.Drawing.Size(935, 455);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MySecondCustmControl_ControlAdded);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel productspnl;
        public System.Windows.Forms.FlowLayoutPanel toppnl;
    }
}
