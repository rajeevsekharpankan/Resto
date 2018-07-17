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
using System.Media;

namespace Resto.UI
{
    public partial class PendingOrderCtrl : CommonCtrl
    {
        billManager manager = new billManager();
        //SoundPlayer simpleSound = new SoundPlayer(@"D:\Personal Projects\naveen\RestoNew\sounds\barebear.wav");
        public PendingOrderCtrl()
        {
            InitializeComponent();
        }
        
        private void lblamount_Move(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void PendingOrderCtrl_Move(object sender, EventArgs e)
        {
            try
            {
                // btnbillsubmit.Left = lblamount.Right - lblamount.Width;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private async void tmrnotserved_Tick(object sender, EventArgs e)
        {
            try
            {
                // simpleSound.Stop();
                await FillUnservedOrders();
            }
            catch (Exception ex)
            {

                //Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
        public async Task FillUnservedOrders()
        {

            List<billmasterModel> bills = await Task.Run(() => manager.GetUnservedOrders(Utilities.currentpc.id));
            //Task
            pnlbill.Controls.Clear();
            billCtrl bill;
            bills = bills.OrderByDescending(x => x.billno).ToList();// Where(x => x.billno != 0).ToList();
            foreach (billmasterModel item in bills)
            {
                bill = new billCtrl();
                bill.parentform = this.parentform;
                bill.lblname.Text = item.billno.ToString();
                bill.lblamount.Text = String.Format("{0:0.00}", item.amount);
                bill.Tag = item;
                if (item.isserved)
                {
                    bill.lblstatus.BackColor = Color.Red;
                    bill.lblstatus.Text = "Processed";
                }
                else
                {
                    bill.lblstatus.BackColor = Color.Yellow;
                    bill.lblstatus.Text = "Processing";
                }
                bill.parentform = this.parentform;
                pnlbill.Controls.Add(bill);
            }




        }
        public void FillOrders()
        {

            List<billmasterModel> bills = manager.GetUnservedOrders(Utilities.currentpc.id);
            //Task
            pnlbill.Controls.Clear();
            billCtrl bill;
            bills = bills.OrderByDescending(x => x.billno).ToList();// Where(x => x.billno != 0).ToList();
            foreach (billmasterModel item in bills)
            {
                bill = new billCtrl();
                bill.parentform = this.parentform;
                bill.lblname.Text = item.billno.ToString();
                bill.lblamount.Text = String.Format("{0:0.00}", item.amount);
                bill.Tag = item;
                if (item.isserved)
                {
                    bill.lblstatus.BackColor = Color.Red;
                    bill.lblstatus.Text = "Processed";
                }
                else
                {
                    bill.lblstatus.BackColor = Color.Yellow;
                    bill.lblstatus.Text = "Processing";
                }
                bill.parentform = (Form1)this.ParentForm;
                pnlbill.Controls.Add(bill);
            }


        }

        private void PendingOrderCtrl_Load(object sender, EventArgs e)
        {
            tmrnotserved.Start();
        }
    }
}
