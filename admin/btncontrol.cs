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
namespace ZigZag.Admin
{
    public partial class btncontrol : UserControl
    {

        public btncontrol()
        {
            InitializeComponent();
        }
        public ZigZag.Admin.CustomerCtrl.AddCustomerDelegate AddCustomerCallback;
        public ZigZag.Admin.PcBillingCtrl.AddBillItemDelegate AddItemCallbackFn;
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                AddItemCallbackFn((CategoryModel)this.Tag);
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
