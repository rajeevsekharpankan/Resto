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
    public partial class billscontrol : UserControl
    {
        public delegate void AddOrderItemDelegate(SellItemCtrl item);
        public delegate void DeleteOrderItemDelegate(SellItemCtrl item);
        public delegate void UpdateAmountDelegate();
        billManager manager = new billManager();
        public List<Product> products = new List<Product>();
        Boolean fmload = false;
        public Boolean isloaded = false;
        public billscontrol()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                SellItemCtrl item = e.Control as SellItemCtrl;
                item.DeleteItemCallback = new DeleteOrderItemDelegate(this.DeleteCallBackfn);
                item.UpdateAmountCallback = new UpdateAmountDelegate(UpdateAmount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void AddItemCallbackFn(SellItemCtrl orderitem)
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
                SellItemCtrl billitem = pnlbill.Controls.Find(orderitem.product.controlname, false).FirstOrDefault() as SellItemCtrl;
                billitem.txtqty.Value += qty;
                billitem.lblqty.Text += qty;
                orderitem.Tag = orderitem.product;
            }
            else
            {
                //form1.products.Add(orderitem.product);
                orderitem.Tag = orderitem.product;
                pnlbill.Controls.Add(orderitem);
            }
            UpdateAmount();

        }

        public void DeleteCallBackfn(SellItemCtrl orderitem)
        {
            this.pnlbill.Controls.Remove(orderitem);
            UpdateAmount();
        }
        public void UpdateAmount()
        {
            Form1 form = (Form1)this.ParentForm;
            double amount = 0;
            lblamount.Text = "0.00";

            foreach (Control ctrl in pnlbill.Controls)
            {
                SellItemCtrl prod = (SellItemCtrl)ctrl;
                amount = amount + ((int.Parse(prod.txtqty.Value.ToString())) * (prod.product.price));
            }
            lblamount.Text = string.Format("{0:0.00}", amount);


        }



        private void btnbillsubmit_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
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
                    SellItemCtrl billitem = (SellItemCtrl)item;
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
                billmaster.userid = Utilities.pcname = "cash";
                billmaster.ispaid = true;
                billmaster.isserved = true;
                billmaster.machinename = Environment.MachineName;
                billmaster.billdate = DateTime.Now;
                billmaster.customerid = 1;
                billmaster.customername = (rbncash.Checked) ? "cash" : "pc";
                billmaster.billdetails = billdetails;
                Utilities.currentpc = new PcModel() { id = int.Parse(ddlitems.SelectedValue.ToString()) };
                billmaster.pcid = (rbncash.Checked) ? 0 : Utilities.currentpc.id;
                string returndata = manager.InsertFinalBill(billmaster);
                // lblbillno.Text = returndata;
                if (returndata != "0") Cleartexts();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        public void FillPc()
        {
            fmload = true;
            List<PcModel> pcs = pcmanager.GetPcs();
            pcs.Insert(0, new PcModel() { id = 0, pcname = "--Select Pc--" });
            ddlitems.DataSource = pcs;
            ddlitems.DisplayMember = "pcname";
            ddlitems.ValueMember = "id";
            fmload = false;
        }
        public void FillCstomers()
        {
            List<CustomerModel> customers = cmanager.SelectAll();
            customers.Insert(0, new CustomerModel() { Id = 0, name = "--Select--" });
            ddlitems.DataSource = customers;
            ddlitems.DisplayMember = "name";
            ddlitems.ValueMember = "id";
        }
        private void Cleartexts()
        {
            pnlbill.Controls.Clear();
            UpdateAmount();
        }
        private Boolean Validate()
        {
            Boolean returndata = true;
            if (rbnPc.Checked)
            {
                if (!(int.Parse(ddlitems.SelectedValue.ToString()) > 0))
                {
                    Utilities.ShowInfo("Please select a Pc from the list");
                    ddlitems.Focus();
                    returndata = false;
                }
            }
            return returndata;
        }
        PcManager pcmanager = new PcManager();
        CustomerManager cmanager = new CustomerManager();

        private void rbnPc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //ddlitems.DataSource = null;
                //ddlitems.Items.Clear();
                ddlitems.Enabled = true;
                if (rbnPc.Checked)
                {
                    FillPc();
                }
                else if (rbndirect.Checked)
                {
                    FillCstomers();
                }
                else if (rbncash.Checked)
                {
                    ddlitems.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        billManager billmanager = new billManager();

        private void ddlitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fmload) return;
                pnlbill.Controls.Clear();
                if (rbnPc.Checked)
                {
                    List<ItemModel> unbilleditems = billmanager.GetAllItemsNotBilledByPc(int.Parse(ddlitems.SelectedValue.ToString()));
                    SellItemCtrl product = null;
                    string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();

                    foreach (ItemModel item in unbilleditems)
                    {

                        product = new SellItemCtrl(item);
                        product.lblproductname.Text = item.itemname;
                        product.lblprice.Text = string.Format("{0:0.00}", item.price);
                        product.txtqty.Value = item.qty;
                        product.txtqty.Visible = false;
                        product.lblqty.Visible = true;
                        product.lblqty.Text = item.qty.ToString();
                        product.picitem.ImageLocation = imagepath + item.imagepath;
                        product.btnaddtocart.Visible = false;
                        product.btndelete.Visible = false;
                        product.lblprice.Visible = true;

                        pnlbill.Controls.Add(product);
                    }
                }
                UpdateAmount();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
    }
}
