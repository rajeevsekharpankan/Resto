namespace ZigZag.Admin
{
    partial class ZigzagHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZigzagHome));
            this.tmrnotserved = new System.Windows.Forms.Timer(this.components);
            this.pnlbills = new System.Windows.Forms.FlowLayoutPanel();
            this.notimessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tmrnotserved
            // 
            this.tmrnotserved.Interval = 10000;
            this.tmrnotserved.Tick += new System.EventHandler(this.tmrnotserved_Tick);
            // 
            // pnlbills
            // 
            this.pnlbills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbills.Location = new System.Drawing.Point(0, 0);
            this.pnlbills.Name = "pnlbills";
            this.pnlbills.Size = new System.Drawing.Size(931, 507);
            this.pnlbills.TabIndex = 0;
            // 
            // notimessage
            // 
            this.notimessage.Icon = ((System.Drawing.Icon)(resources.GetObject("notimessage.Icon")));
            this.notimessage.Text = "ZigZag";
            this.notimessage.Visible = true;
            this.notimessage.BalloonTipClicked += new System.EventHandler(this.notimessage_BalloonTipClicked);
            // 
            // ZigzagHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.pnlbills);
            this.Name = "ZigzagHome";
            this.Size = new System.Drawing.Size(931, 507);
            this.Load += new System.EventHandler(this.ZigzagHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrnotserved;
        private System.Windows.Forms.FlowLayoutPanel pnlbills;
        private System.Windows.Forms.NotifyIcon notimessage;

    }
}
