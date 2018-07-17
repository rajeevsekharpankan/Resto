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
using System.Configuration;

namespace Resto.UI
{
    public partial class OrderCtrl : CommonCtrl
    {
        billManager manager = new billManager();
        public OrderCtrl()
        {
            InitializeComponent();
        }

        public void FillDetails(billmasterModel bill,Form1 form)
        {
            this.parentform = form;
            btnbillcancel.Visible = !bill.isserved;
            //btnback.Visible = bill.isserved;
            lblamount.Text = bill.amount.ToString();
            lblbillno.Text = bill.billno.ToString();
            Productctrl product = null;
            List<billdetails> orderdetails = manager.GetBillDetails(bill.billno);
            pnlbill.Controls.Clear();
            string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            foreach (billdetails item in orderdetails)
            {
                
                product = new Productctrl();
                product.lblproductname.Text = item.itemname;
                product.lblprice.Text = string.Format("{0:0.00}", item.amount);
                product.lblqty.Text = item.qty.ToString();
                product.imgitem.ImageLocation = imagepath + item.imagepath;
                product.btndelete.Visible = false;
                product.btnedit.Visible = false;
                product.lblprice.Visible = true;
                product.lblqty.Visible = true;
                product.lblpricecaption.Visible = true;
                product.lblqtycaption.Visible = true;
                pnlbill.Controls.Add(product);
            }
        }

        private void btnbillcancel_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.parentform.pendingOrderCtrl1.FillOrders();
            this.parentform.pendingOrderCtrl1.BringToFront();
        }
    }
}
