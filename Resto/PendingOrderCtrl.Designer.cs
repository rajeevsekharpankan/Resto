namespace Resto.UI
{
    partial class PendingOrderCtrl
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
            this.pnlbill = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrnotserved = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlbill
            // 
            this.pnlbill.AutoScroll = true;
            this.pnlbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.pnlbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbill.Location = new System.Drawing.Point(0, 0);
            this.pnlbill.Name = "pnlbill";
            this.pnlbill.Size = new System.Drawing.Size(899, 502);
            this.pnlbill.TabIndex = 5;
            // 
            // tmrnotserved
            // 
            this.tmrnotserved.Interval = 10000;
            this.tmrnotserved.Tick += new System.EventHandler(this.tmrnotserved_Tick);
            // 
            // PendingOrderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlbill);
            this.Name = "PendingOrderCtrl";
            this.Size = new System.Drawing.Size(899, 502);
            this.Load += new System.EventHandler(this.PendingOrderCtrl_Load);
            this.Move += new System.EventHandler(this.PendingOrderCtrl_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlbill;
        private System.Windows.Forms.Timer tmrnotserved;
    }
}
