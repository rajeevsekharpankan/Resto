using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Models;

namespace ZigZag.Admin
{
    public partial class item : UserControl
    {

        public CustomerCtrl.EditCustomerDelegate EditCustomerCallbackfn;
        public Suppliers.EditSupplierDelegate EditSupplierCallbackfn;

        public item()
        {
            InitializeComponent();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CustomerModel customer = this.Tag as CustomerModel;
            //customer.Id = int.Parse(this.Tag.ToString());
            //customer.name = this.lblname.Text;
            //customer.mobileno = this.lblmob.Text;
            //customer.address = this.lbladdress.Text;
            if (customer.isCustomer)
                EditCustomerCallbackfn(customer, btn.Tag.ToString() != "delete" ? RestoEnums.update : RestoEnums.delete);
            else
                EditSupplierCallbackfn(customer, btn.Tag.ToString() != "delete" ? RestoEnums.update : RestoEnums.delete);

        }
    }
}
