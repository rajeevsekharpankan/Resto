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
    public partial class CustomerCtrl : CommonCtrl
    {
        public CustomerCtrl()
        {
            InitializeComponent();
        }
        public delegate void AddCustomerDelegate();
        public delegate void EditCustomerDelegate(CustomerModel cutomer, RestoEnums mode);

        public delegate void ViewAllCustomerDelegate();
        public void LoadProducts()
        {
            MessageBox.Show(categoryid.ToString());
        }
        public int categoryid { get; set; }
        //public delegate void AddOrderDelegate(item item);
        ProductManager pmanager = new ProductManager();
        private void MySecondCustmControl_Load(object sender, EventArgs e)
        {
            //  Form1 f = (Form1)this.ParentForm;
            btncontrol1.btn.Text = "Add Customer";
            btncontrol1.btn.Tag = "addcustomer";

            btncontrol1.AddCustomerCallback = new AddCustomerDelegate(this.AddItemCallbackFn);


        }

        private void AddItemCallbackFn()
        {
            addCustomer1.BringToFront();
            addCustomer1.FillCustomer();

        }
        private void ViewAllCustomerCallbackFn()
        {

            // addCustomer1.BringToFront();

        }
        private void MySecondCustmControl_ControlAdded(object sender, ControlEventArgs e)
        {

            List<Control> controls = new List<Control>();
            controls.Add((Control)sender);
        }

        private void toppnl_ControlAdded(object sender, ControlEventArgs e)
        {
            // btncontrol dlg = e.Control as btncontrol;
            // dlg.AddItemCallback = new AddItemDelegate(this.AddItemCallbackFn);


        }

        private void productspnl_ControlAdded(object sender, ControlEventArgs e)
        {
            //item dlg = e.Control as item;
            //Form1 f = this.ParentForm as Form1;
            //dlg.AddItemCallback = new billscontrol.AddOrderItemDelegate(f.billscontrol1.AddItemCallbackFn);
            //dlg.AddItemCallback = new AddOrderDelegate();
        }

        private void toppnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncontrol1_Load(object sender, EventArgs e)
        {

        }

        private void addCustomer1_Load(object sender, EventArgs e)
        {
            addCustomer1.FillCustomer();
        }
    }
}
