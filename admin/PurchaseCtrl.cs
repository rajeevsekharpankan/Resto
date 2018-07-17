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
    public partial class PurchaseCtrl : CommonCtrl
    {
        public delegate Boolean AddPurchaseItem(PurchaseItemCtrl item);
        public delegate void DeletePurchaseItem(PurchaseBillItem item);
        PurchaseManager manager = new PurchaseManager();
        CustomerManager cmanager = new CustomerManager();
        Boolean fmload = true;
        public PurchaseCtrl()
        {
            InitializeComponent();
         
        }
        public void FillCatagroies()
        {
            purchaseItemCtrl1.AddPurchaseItemCallback = new AddPurchaseItem(AddPurchaseItemCallback);
            purchaseItemCtrl1.FillCatagroy();
        }
        public Boolean AddPurchaseItemCallback(PurchaseItemCtrl item)
        {

            Boolean returndata = false;
            PurchaseBillItem purchaseitem;
            PurchaseItemModel purchase = new PurchaseItemModel();
            purchase.item = new ItemModel();
            purchase.item.id = int.Parse(item.ddlitems.SelectedValue.ToString());
            purchase.item.itemname = item.ddlitems.Text;
            purchase.qty = int.Parse(item.txtqty.Text);
            purchase.cost = double.Parse(item.txtcost.Text);
            purchase.amount = double.Parse(item.txtamount.Text);
            purchase.item.catagoryid = int.Parse(item.ddlcatagory.SelectedValue.ToString());
            if (item.Tag == null)
            {
                purchaseitem = new PurchaseBillItem(purchase);
                purchaseitem.Tag = purchase;
                purchase.serialno = pnlitems.Controls.Count + 1;
                purchaseitem.btnserial.Text = purchase.serialno.ToString();
                pnlitems.Controls.Add(purchaseitem);
            }
            else
            {
                purchaseitem = (PurchaseBillItem)pnlitems.Controls[int.Parse(item.btnserial.Text) - 1];
                purchaseitem.txtitemname.Text = item.ddlitems.Text;
                purchaseitem.txtqty.Text = (item.txtqty.Text);
                purchaseitem.txtcost.Text = item.txtcost.Text;
                purchaseitem.txtamount.Text = (item.txtamount.Text);
                purchaseitem.btnserial.Text = item.btnserial.Text;

            }
            purchaseitem.Tag = purchase;
            returndata = true;
            item.btnserial.Text = "#";
            CalculateTotal();
            if (returndata) item.ClearTexts();
            return returndata;
        }
        public void DeletePurchaseItemCallBack(PurchaseBillItem item)
        {
            pnlitems.Controls.Remove(item);
            CalculateTotal();
        }
        private void pnlitems_ControlAdded(object sender, ControlEventArgs e)
        {
            PurchaseBillItem item = (PurchaseBillItem)e.Control;
            item.EditPurchaseItemCallback = new PurchaseItemCtrl.EditPurchaseItem(this.purchaseItemCtrl1.EditPurchaseItemCallback);
            item.DeletePurchaseItemCallback = new PurchaseCtrl.DeletePurchaseItem(this.DeletePurchaseItemCallBack);


        }
        public void CalculateTotal()
        {
            lbltotal.Text = "0.00";
            foreach (Control item in pnlitems.Controls)
            {
                PurchaseBillItem purchaseitem = (PurchaseBillItem)item;
                purchaseitem.btnserial.Text = (pnlitems.Controls.IndexOf(item) + 1).ToString();
                lbltotal.Text = string.Format("{0:0.00}", (double.Parse(lbltotal.Text) + double.Parse(purchaseitem.txtamount.Text)));
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validatethis())
                {
                    PurchaseModel purchase = new PurchaseModel();
                    purchase.active = true;
                    purchase.forname = txtcustomername.Text;
                    purchase.paidstatus = !rbncredit.Checked;
                    purchase.paymentmode = rbncredit.Checked ? "Credit" : "Cash";
                    purchase.purchasedate = Convert.ToDateTime(dtpPurchase.Text);
                    purchase.purchaseno = txtpurchaseno.Text;
                    purchase.remarks = remarkstxt.Text;
                    purchase.supplierid = chksuppliers.Checked ? int.Parse(ddlsuppliers.SelectedValue.ToString()) : 0;
                    purchase.totalamount = double.Parse(lbltotal.Text);
                    PurchaseBillItem billitem;
                    List<PurchaseItemModel> purchaseitems = new List<PurchaseItemModel>();
                    PurchaseItemModel purchaseitem;
                    PurchaseItemModel model;
                    foreach (Control item in pnlitems.Controls)
                    {
                        model = (PurchaseItemModel)item.Tag;
                        billitem = (PurchaseBillItem)item;
                        purchaseitem = new PurchaseItemModel();
                        purchaseitem.item = new ItemModel();
                        purchaseitem.item.id = model.item.id;
                        purchaseitem.cost = double.Parse(billitem.txtcost.Text);
                        purchaseitem.qty = int.Parse(billitem.txtqty.Text);
                        purchaseitems.Add(purchaseitem);
                    }
                    purchase.purchasedetails = purchaseitems;
                    string purchaseno = manager.Insert(purchase);
                    if (int.Parse(purchaseno) > 0)
                    {
                        Utilities.ShowInfo("Saved Successfully!");
                        ClearTexts();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public Boolean Validatethis()
        {
            Boolean returndata = false;
            if (chksuppliers.Checked)
            {
                if (ddlsuppliers.Text.Trim() == "")
                {
                    Utilities.ShowInfo("Please select supplier!");
                    return returndata;
                }
            }
            if (rbncredit.Checked)
            {
                if (ddlsuppliers.SelectedText.Trim() == "")
                {
                    Utilities.ShowInfo("Please select supplier!");
                    return returndata;
                }
            }
            if (rbncash.Checked)
            {
                if (txtcustomername.Text.Trim() == "")
                {
                    Utilities.ShowInfo("Please enter supplier name");
                    return returndata;
                }
            }
            if (!(double.Parse(lbltotal.Text) > 0))
            {
                Utilities.ShowInfo("Please enter valid items!");
                return returndata;
            }
            return returndata = true;
        }
        public void ClearTexts()
        {
            pnlitems.Controls.Clear();
            txtpurchaseno.Text = "";
            txtcustomername.Text = "";
            remarkstxt.Text = "";
            lbltotal.Text = "0.00";
        }
        public void FillSuppliers()
        {
            List<CustomerModel> suppliers = cmanager.SelectAllSuppliers();
            ddlsuppliers.DataSource = suppliers;
            ddlsuppliers.DisplayMember = "name";
            ddlsuppliers.ValueMember = "id";
            fmload = false;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                ClearTexts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chksuppliers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ddlsuppliers.Enabled = chksuppliers.Checked;
            }
            catch (Exception ex)
            {

                Utilities.ShowInfo(ex.Message.ToString());
            }
        }

        private void ddlsuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!fmload)
                    txtcustomername.Text = ddlsuppliers.Text;
            }
            catch (Exception ex)
            {

                Utilities.ShowInfo(ex.Message.ToString());
            }
        }
    }
}
