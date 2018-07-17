namespace ZigZag.Admin
{
    partial class PcButtonCtrl
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
            this.btnpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpc
            // 
            this.btnpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnpc.ForeColor = System.Drawing.Color.White;
            this.btnpc.Location = new System.Drawing.Point(0, 0);
            this.btnpc.Name = "btnpc";
            this.btnpc.Size = new System.Drawing.Size(230, 45);
            this.btnpc.TabIndex = 0;
            this.btnpc.Text = "PC";
            this.btnpc.UseVisualStyleBackColor = false;
            // 
            // PcButtonCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnpc);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PcButtonCtrl";
            this.Size = new System.Drawing.Size(230, 45);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnpc;






    }
}
