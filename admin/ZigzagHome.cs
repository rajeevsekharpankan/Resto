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
    public partial class ZigzagHome : CommonCtrl
    {

        billManager manager = new billManager();
        public ZigzagHome()
        {
            InitializeComponent();
        }

        private  void tmrnotserved_Tick(object sender, EventArgs e)
        {
            try
            {
                 FillUnservedOrders();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }



        public async Task FillUnservedOrders()
        {

            List<billmasterModel> bills = await Task.Run(() => manager.GetUnservedOrders());
            //Task
            pnlbills.Controls.Clear();
            billCtrl bill;
            bills = bills.OrderByDescending(x => x.billno).ToList();// Where(x => x.billno != 0).ToList();
            foreach (billmasterModel item in bills)
            {
                bill = new billCtrl();
                bill.parentform = this.parentform;
                bill.lblname.Text = item.billno.ToString();
                bill.lblamount.Text = String.Format("{0:0.00}", item.amount);
                bill.Tag = item;
                pnlbills.Controls.Add(bill);
            }
            billmasterModel lastbill = bills.FirstOrDefault();
            notimessage.BalloonTipIcon = ToolTipIcon.Info;
            notimessage.BalloonTipText = "New Order arrived!!!" + Environment.NewLine + "Order no : " + lastbill.billno.ToString();
            notimessage.Tag = lastbill;
            notimessage.BalloonTipTitle = "ZigZag Message";
            notimessage.ShowBalloonTip(1000);
            notimessage.Visible = true;


        }
        public void FillOrders()
        {

            List<billmasterModel> bills = manager.GetUnservedOrders();
            //Task
            pnlbills.Controls.Clear();
            billCtrl bill;
            bills = bills.OrderByDescending(x => x.billno).ToList();// Where(x => x.billno != 0).ToList();
            foreach (billmasterModel item in bills)
            {
                bill = new billCtrl();
                bill.parentform = this.parentform;
                bill.lblname.Text = item.billno.ToString();
                bill.lblamount.Text = String.Format("{0:0.00}", item.amount);
                bill.Tag = item;
                bill.parentform = this.parentform;
                pnlbills.Controls.Add(bill);
            }


        }

        private void ZigzagHome_Load(object sender, EventArgs e)
        {
            try
            {
                tmrnotserved.Start();


            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }

        private void notimessage_BalloonTipClicked(object sender, EventArgs e)
        {
            try
            {
                billmasterModel bill = (billmasterModel)notimessage.Tag;
                this.parentform.orderCtrl1.FillDetails(bill);
                this.parentform.orderCtrl1.BringToFront();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }
    }
}
