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
    public partial class item : UserControl
    {
        public billscontrol.AddOrderItemDelegate AddItemCallback;
        public billscontrol.DeleteOrderItemDelegate DeleteItemCallback;
        public billscontrol.UpdateAmountDelegate UpdateAmountCallback;

        public item(ItemModel product)
        {
            string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            InitializeComponent();
            picpath.ImageLocation = imagepath + product.imagepath;
            lblproductname.Text = product.itemname;
            this.product = product;
            this.product.qty = product.qty > 0 ? product.qty : 1;
            this.txtqty.Value = this.product.qty;
            this.Name = this.product.controlname = "item_" + this.product.itemname + "_" + this.product.id.ToString();
            this.lblprice.Text = string.Format("{0:0.00}", this.product.price);
            this.lbldesc.Text = this.product.description;
            this.Tag = product;
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (!(txtqty.Value > 0))
            {
                MessageBox.Show("Please enter valid quantity!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ItemModel currentitem = (ItemModel)this.Tag;
            if (currentitem.isstockable)
            {
                if (!CheckQty(currentitem)) return;
            }
            this.product.qty = int.Parse(this.txtqty.Value.ToString());
            item item = new item(this.product);
            AddItemCallback(item);
            this.txtqty.Value = 1;

        }
        public item CurrentItem { get; set; }
        public ItemModel product { get; set; }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                item deleted = this;
                DeleteItemCallback(deleted);
            }
            catch (Exception)
            {

                throw;
            }
        }
        billManager manager = new billManager();
        int currentstock = 0;
        public Boolean CheckQty(ItemModel item)
        {
            if (item.isstockable)
            {
                currentstock = manager.GetStock(item.id);
                if (currentstock < txtqty.Value)
                {
                    Utilities.ShowInfo("Current stock is :" + currentstock.ToString());
                    txtqty.Value = txtqty.Minimum;
                    /// valuechanged = false;
                    return false;
                }

            }
            return true;
        }
        public Boolean valuechanged = true;
        private void txtqty_ValueChanged(object sender, EventArgs e)
        {


            if (this.Tag == null) return;
            ItemModel item = (ItemModel)this.Tag;
            //if (item.isstockable)
            //{
            //    Utilities.ShowInfo("stockable!!");
            //}

            if (item.isstockable)
            {
                if (!CheckQty(item)) return;
            }

            if (btndelete.Visible)
            {
                Form1 form = (Form1)this.ParentForm;
                UpdateAmountCallback();
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(asc e.KeyChar==ASCIIEncoding())
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            //{
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;

            //}
        }
    }
}
