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
    public partial class PurchaseItemCtrl : UserControl
    {
        ProductManager manager = new ProductManager();
        public PurchaseCtrl.AddPurchaseItem AddPurchaseItemCallback;
        public delegate void EditPurchaseItem(PurchaseItemModel purchaseitem);
        public Boolean editmode = false;
        public PurchaseItemCtrl()
        {
            InitializeComponent();
        }
        public Boolean fmload = true;
        private void PurchaseItemCtrl_Load(object sender, EventArgs e)
        {
            //FillCatagroy();
        }
        public void FillCatagroy()
        {

            List<CategoryModel> catagories = manager.GetCategories();
            ddlcatagory.DataSource = catagories;
            catagories.Insert(0, new CategoryModel() { Id = 0, name = "--Select--" });
            ddlcatagory.DisplayMember = "name";
            ddlcatagory.ValueMember = "Id";
            fmload = false;
        }
        public void FillItems(int catagory)
        {

            List<ItemModel> items = manager.GetItemsByCatagroy_stockbale(catagory);
            ddlitems.DataSource = items;
            //items.Insert(0, new ItemModel() { id = 0, itemname = "--Select--" });
            ddlitems.DisplayMember = "itemname";
            ddlitems.ValueMember = "id";
            fmload = false;
        }
        private void ddlcatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fmload) return;
                FillItems(int.Parse(ddlcatagory.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }

        private void txtqty_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                    AddPurchaseItemCallback(this);
                
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }

        public void ClearTexts()
        {
            this.txtcost.Text = "";
            this.txtqty.Text = "";
            this.txtamount.Text = "";
            this.ddlcatagory.SelectedIndex = 0;
            this.Tag = null;
        }
        public Boolean validate()
        {
            Boolean returnvalue = true;
            if (ddlitems.Text.Trim() == "")
            {
                ddlitems.Focus();
                Utilities.ShowInfo("Please select an item!");
                returnvalue = false;
            }
            else if (txtcost.Text.Trim() == "")
            {
                txtcost.Focus();
                Utilities.ShowInfo("Please enter cost");
                returnvalue = false;
            }
            else if (txtqty.Text.Trim() == "")
            {
                txtqty.Focus();
                Utilities.ShowInfo("Please enter quantity");
                returnvalue = false;
            }
            return returnvalue;
        }
        private void txtcost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateAmount();

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateAmount();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }
        public void CalculateAmount()
        {
            if (txtqty.Text.Trim() != "" && txtcost.Text.Trim() != "")
                txtamount.Text = string.Format("{0:0.00}", (double.Parse(txtcost.Text) * int.Parse(txtqty.Text)).ToString());
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtcost.Text.Contains('.') == true)
                {
                    if (e.KeyChar == 46)
                        e.Handled = true;
                }

                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && txtcost.Text.Contains('.') == true)
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar == 46) && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());

            }
        }
        public void EditPurchaseItemCallback(PurchaseItemModel purchaseitem)
        {
            this.editmode = true;
            this.ddlcatagory.SelectedValue = purchaseitem.item.catagoryid;
            this.ddlitems.SelectedValue = purchaseitem.item.id;
            this.txtcost.Text = purchaseitem.cost.ToString();
            this.txtqty.Text = purchaseitem.qty.ToString();
            this.txtamount.Text = purchaseitem.amount.ToString();
            this.Tag = purchaseitem;
            this.btnserial.Text = purchaseitem.serialno.ToString();

        }

        private void ddlitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
