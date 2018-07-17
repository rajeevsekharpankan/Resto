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
using Resto.Manager;

namespace ZigZag.Admin
{
    public partial class Suppliers : CommonCtrl
    {
                public CustomerManager manager=new CustomerManager();

        public Boolean editmode = false;
        public CustomerModel EditItem = null;
        public delegate void EditSupplierDelegate(CustomerModel cutomer, RestoEnums mode);
        public Suppliers()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validatectrls()) return;

                manager.UpsertSuppliers(new CustomerModel()
                {
                    Id = editmode ? EditItem.Id : 0,
                    name = txtname.Text,
                    address = txtaddress.Text,
                    mobileno = txtmob.Text
                });
                cleartexts();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Boolean Validatectrls()
        {
            Boolean returndata = true;
            erricon.Clear();
            if (txtname.Text.Trim() == "")
            {
                erricon.SetError(txtname, "Enter name!");
                returndata = false;
            }

            if (txtmob.Text.Trim() == "")
            {
                erricon.SetError(txtmob, "Enter mobile!");
                returndata = false;
            }
            return returndata;
        }
        public void cleartexts()
        {
            txtname.Text = txtmob.Text = txtaddress.Text = "";
            editmode = false;
            EditItem = null;
            FillCustomer();
        }
        public void FillCustomer()
        {
            List<CustomerModel> customers = manager.SelectAllSuppliers();
            pnlcustomer.Controls.Clear();
            foreach (CustomerModel c in customers)
            {
                item customer = new item();
                customer.lblname.Text = c.name;
                customer.Tag = c;
                customer.lblmob.Text = c.mobileno;
                customer.lbladdress.Text = c.address;
                c.isCustomer = false;
                pnlcustomer.Controls.Add(customer);
            }
        }

        public Boolean Delete(CustomerModel customer)
        {
            return manager.DeleteSupplier(customer);
        }
        private void pnlcustomer_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                item customer = (item)e.Control;

                customer.EditSupplierCallbackfn += new EditSupplierDelegate(this.EditCustomerCallbackfn);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EditCustomerCallbackfn(CustomerModel customer, RestoEnums mode)
        {
            if (mode == RestoEnums.delete)
            {

                if (Utilities.Confirm("Do you want to delete!") == DialogResult.Yes)
                //if (MessageBox.Show("Do you want to delete!", "Confirm please!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Delete(customer);
                    FillCustomer();
                    return;
                }

            }
            else
            {
                this.txtname.Text = customer.name;
                this.txtmob.Text = customer.mobileno;
                this.txtaddress.Text = customer.address;
                this.Tag = customer.Id;
                this.editmode = true;
                EditItem = customer;
            }


        }
    }
}
