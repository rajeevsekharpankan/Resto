namespace Resto.UI
{
    partial class btncontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btncontrol));
            this.btn = new System.Windows.Forms.Button();
            this.pnlactive = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Black;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(197, 54);
            this.btn.TabIndex = 5;
            this.btn.Text = "       Take Away";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlactive
            // 
            this.pnlactive.BackColor = System.Drawing.Color.White;
            this.pnlactive.Location = new System.Drawing.Point(1, 55);
            this.pnlactive.Name = "pnlactive";
            this.pnlactive.Size = new System.Drawing.Size(199, 14);
            this.pnlactive.TabIndex = 6;
            this.pnlactive.Visible = false;
            this.pnlactive.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlactive_Paint);
            // 
            // btncontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlactive);
            this.Controls.Add(this.btn);
            this.Name = "btncontrol";
            this.Size = new System.Drawing.Size(202, 70);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn;
        public System.Windows.Forms.Panel pnlactive;
    }
}
