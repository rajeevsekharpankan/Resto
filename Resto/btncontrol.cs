using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Manager;
using Resto.Models;

namespace Resto.UI
{
    public partial class btncontrol : UserControl
    {

        public btncontrol()
        {
            InitializeComponent();
        }
        public Resto.UI.MySecondCustmControl.AddItemDelegate AddItemCallback;
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryModel item = (CategoryModel)this.Tag;
                //Notification subscribers
                AddItemCallback(item);
                List<Control> controls = this.Controls.Find("pnlactive", true).ToList();
                pnlactive.Visible = true;
                btn.BackColor = pnlactive.BackColor;
                btn.ForeColor = Color.Black; 
                Button btnsender = (Button)sender;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void pnlactive_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
