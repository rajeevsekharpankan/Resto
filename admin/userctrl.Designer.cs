namespace ZigZag.Admin
{
    partial class userctrl
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
            this.btndelete = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(90, 56);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 28);
            this.btndelete.TabIndex = 8;
            this.btndelete.Tag = "delete";
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(3, 3);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 16);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(3, 56);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(79, 28);
            this.btnedit.TabIndex = 7;
            this.btnedit.Tag = "edit";
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbluserid);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 94);
            this.panel1.TabIndex = 11;
            // 
            // lbluserid
            // 
            this.lbluserid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(6, 27);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(166, 25);
            this.lbluserid.TabIndex = 10;
            this.lbluserid.Text = "which is used as a placeholder";
            // 
            // lbladdress
            // 
            this.lbladdress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(4, 34);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(166, 25);
            this.lbladdress.TabIndex = 11;
            this.lbladdress.Text = "which is used as a placeholder";
            this.lbladdress.Visible = false;
            // 
            // userctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "userctrl";
            this.Size = new System.Drawing.Size(180, 94);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Label lblname;
        public System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbluserid;
        public System.Windows.Forms.Label lbladdress;
    }
}
