using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZag.Admin
{
    public class CommonCtrl:UserControl
    {
        public Form1 parentform { get; set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CommonCtrl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.Name = "CommonCtrl";
            this.Size = new System.Drawing.Size(227, 184);
            this.ResumeLayout(false);

        }
    }
      
}
