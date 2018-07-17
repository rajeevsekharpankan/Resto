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

namespace ZigZag.Admin
{
    public partial class OrderCtrl : CommonCtrl
    {
        billManager manager = new billManager();
        public OrderCtrl()
        {
            InitializeComponent();
        }
        
        public void FillDetails(billmasterModel bill)
        {
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
                product.imgitem.ImageLocation = imagepath+ item.imagepath;
                product.btndelete.Visible = false;
                product.btnedit.Visible = false;
                product.lblprice.Visible = true;
                product.lblqty.Visible = true;
                product.lblpricecaption.Visible = true;
                product.lblqtycaption.Visible = true;
                pnlbill.Controls.Add(product);
            }
        }

        private void btnbillsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager.UpdateServed(int.Parse(lblbillno.Text)) > 0)
                {
                    Utilities.ShowInfo("Successfully placed the order!");
                    this.SendToBack();
                    this.parentform.zigzagHome1.FillOrders();
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());

            }
        }
    }
}
