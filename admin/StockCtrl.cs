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
    public partial class StockCtrl : CommonCtrl
    {
        ProductManager manager = new ProductManager();
        public Boolean fmload = true;
        public StockCtrl()
        {
            InitializeComponent();
        }
        public void FillCategories()
        {
            List<CategoryModel> categories = manager.GetCategories();
            ComboBox cmb = new ComboBox();
            categories.Insert(0, new CategoryModel() { Id = 0, name = "--Select--" });
            ddlcategories.DataSource = categories;
            ddlcategories.DisplayMember = "name";
            ddlcategories.ValueMember = "id";
            this.fmload = false;
        }

        private void ddlcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!fmload)
                    if (int.Parse(ddlcategories.SelectedValue.ToString()) >= 0) FillProducts();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
        public void FillProducts()
        {
            List<ItemModel> items = manager.GetStocksByCatagroy(int.Parse(ddlcategories.SelectedValue.ToString()));
            pnlproducts.Controls.Clear();
            string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            foreach (ItemModel item in items)
            {
                Productctrl product = new Productctrl();
                product.lblproductname.Text = item.itemname;
                product.imgitem.ImageLocation = imagepath + item.imagepath;
                product.lbldesc.Text = item.description;
                product.lblprice.Text = string.Format("{0:0.00}", item.price);
                product.lblqtycaption.Visible = true;
                product.lblqty.Visible = true;
                product.lblqty.Text = item.qty.ToString();
                item.catagoryid = int.Parse(ddlcategories.SelectedValue.ToString());
                pnlproducts.Controls.Add(product);
                product.btndelete.Visible = false;
                product.btnedit.Visible = false;
                product.Tag = item;
            }
        }
    }
}
