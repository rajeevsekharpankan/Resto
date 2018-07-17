namespace Resto.UI
{
    partial class billCtrl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.tmrcolor = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Controls.Add(this.lblamount);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 85);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount :";
            // 
            // lblamount
            // 
            this.lblamount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(70, 34);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(77, 23);
            this.lblamount.TabIndex = 10;
            this.lblamount.Text = "which is used as a placeholder";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Green;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(87, 3);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(60, 28);
            this.btnview.TabIndex = 8;
            this.btnview.Tag = "delete";
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(3, 3);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 16);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // tmrcolor
            // 
            this.tmrcolor.Interval = 500;
            this.tmrcolor.Tick += new System.EventHandler(this.tmrcolor_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Status :";
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.Color.Gold;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(70, 57);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(77, 23);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.Name = "billCtrl";
            this.Size = new System.Drawing.Size(150, 85);
            this.Load += new System.EventHandler(this.billCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblamount;
        public System.Windows.Forms.Button btnview;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Timer tmrcolor;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblstatus;
    }
}
