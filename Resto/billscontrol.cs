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

namespace Resto.UI
{
    public partial class billscontrol : UserControl
    {
        public delegate void AddOrderItemDelegate(item item);
        public delegate void DeleteOrderItemDelegate(item item);
        public delegate void UpdateAmountDelegate();
        billManager manager = new billManager();
        public List<Product> products = new List<Product>();
        public billscontrol()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                item item = e.Control as item;
                item.DeleteItemCallback = new DeleteOrderItemDelegate(this.DeleteCallBackfn);
                item.UpdateAmountCallback = new UpdateAmountDelegate(UpdateAmount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void AddItemCallbackFn(item orderitem)
        {
            orderitem.btndelete.Visible = true;
            orderitem.btnaddtocart.Visible = false;

            Form1 form1 = (Form1)this.ParentForm;


            int itemcount = pnlbill.Controls.Find(orderitem.product.controlname, false).Count();
            if (itemcount >= 1)
            {

                decimal qty = orderitem.txtqty.Value;
                //if (itemcount >= 1)
                //{
                //   // pnlbill.Controls.Remove(pnlbill.Controls.Find(orderitem.product.controlname, false)[1]);
                //    orderitem = pnlbill.Controls.Find(orderitem.product.controlname, false).SingleOrDefault() as item;
                //    orderitem.txtqty.Value = p.qty;
                //}
                item billitem = pnlbill.Controls.Find(orderitem.product.controlname, false).SingleOrDefault() as item;
                billitem.txtqty.Value += qty;
                orderitem.Tag = orderitem.product;
            }
            else
            {
                form1.products.Add(orderitem.product);
                orderitem.Tag = orderitem.product;
                pnlbill.Controls.Add(orderitem);
            }
            UpdateAmount();

        }

        public void DeleteCallBackfn(item orderitem)
        {
            this.pnlbill.Controls.Remove(orderitem);
            UpdateAmount();
        }
        public void UpdateAmount()
        {
            Form1 form = (Form1)this.ParentForm;
            double amount = 0;
            lblamount.Text = form.lblamount.Text = "0.00";

            foreach (Control ctrl in pnlbill.Controls)
            {
                item prod = (item)ctrl;
                amount = amount + ((int.Parse(prod.txtqty.Value.ToString())) * (prod.product.price));
            }
            lblamount.Text = form.lblamount.Text = string.Format("{0:##.##}", amount.ToString());


        }



        private void btnbillsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(double.Parse(lblamount.Text) > 0))
                {
                    Utilities.ShowInfo("Please select valid items!");
                    return;
                }
                List<billdetails> billdetails = new List<billdetails>();
                billmasterModel billmaster = new billmasterModel();
                foreach (Control item in pnlbill.Controls)
                {
                    ItemModel model = (ItemModel)item.Tag;
                    item billitem = (item)item;
                    billdetails details = new billdetails();
                    details.item = new ItemModel();
                    details.item = model;
                    details.itemid = model.id;
                    details.qty = int.Parse(billitem.txtqty.Value.ToString());
                    details.amount = model.price;
                    details.total = (model.price * int.Parse(billitem.txtqty.Value.ToString()));
                    billmaster.amount = billmaster.amount + (model.price * int.Parse(billitem.txtqty.Value.ToString()));
                    billdetails.Add(details);
                }
                billmaster.userid = Utilities.pcname;
                billmaster.ispaid = false;
                billmaster.isserved = false;
                billmaster.machinename = Environment.MachineName;
                billmaster.billdate = DateTime.Now;
                billmaster.customerid = 1;
                billmaster.customername = "test";
                billmaster.billdetails = billdetails;
                string returndata = manager.Insert(billmaster);
                lblbillno.Text = returndata;
                if (returndata != "0") Cleartexts();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        private void Cleartexts()
        {
            pnlbill.Controls.Clear();
            UpdateAmount();
        }
    }
}
