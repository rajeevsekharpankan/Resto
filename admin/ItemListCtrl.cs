using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Manager;
using Resto.Models;
using System.IO;
using System.Configuration;
namespace ZigZag.Admin
{
    public partial class ItemListCtrl : UserControl
    {
        ProductManager manager = new ProductManager();
        public ItemListCtrl()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    picproduct.ImageLocation = ofd.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ItemListCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                FillCategories();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void FillCategories()
        {
            List<CategoryModel> categories = manager.GetCategories();
            ComboBox cmb = new ComboBox();
            categories.Insert(0, new CategoryModel() { Id = 0, name = "--Select--" });
            ddlcategories.DataSource = categories;
            ddlcategories.DisplayMember = "name";
            ddlcategories.ValueMember = "id";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ItemModel item = new ItemModel();
            item.catagoryid = int.Parse(ddlcategories.SelectedValue.ToString());
            item.itemname = txtname.Text;
            item.price = double.Parse(txtprice.Text.ToString());
            item.isstockable = chkisstockable.Checked;
            if (ofd.FileName != null || ofd.FileName.Trim() != "")
            {

                string path = ConfigurationManager.AppSettings["imagepath"].ToString() + @"\" + item.itemname + "_" + DateTime.Now.ToString("HH_mm") + ".jpg";

                File.Copy(ofd.FileName, path);
                item.imagepath = path;// @"\\DESKTOP-G5L1EU4\images\" + item.itemname + "_" + DateTime.Now.ToShortTimeString() + ".jpg";
            }
            item.description = txtdesc.Text;
            manager.Insert(item);
            clearTexts();
            FillProducts();
        }
        private void SaveItem(ItemModel item)
        {

        }
        private void clearTexts()
        {
            txtname.Text = "";
            txtdesc.Text = "";
            txtprice.Text = "";
            ddlcategories.SelectedIndex = 0;
        }
        public Boolean ValidateCtrls()
        {
            erricon.Clear();
            if (ddlcategories.SelectedIndex <= 0)
            {
                Utilities.ShowError("Please select a catagory!");
                erricon.SetError(ddlcategories, "Please select a catagory!");
                return false;
            }
            if (txtname.Text.Trim() == "")
            {
                Utilities.ShowError("Please eneter item name!");
                erricon.SetError(txtname, "Please eneter product name!");
                return false;
            }
            if (txtprice.Text.Trim() == "")
            {
                Utilities.ShowError("Please eneter item price!");
                erricon.SetError(txtprice, "Please eneter item price!");
                return false;
            }
            return true;
        }
        public void FillProducts()
        {
            List<ItemModel> items = manager.GetItems();
            pnlproducts.Controls.Clear();
            foreach (ItemModel item in items)
            {
                Productctrl product = new Productctrl();
                product.lblproductname.Text = item.itemname;
                product.imgitem.ImageLocation = item.imagepath;
                product.lbldesc.Text = item.description;
                product.lblprice.Text = item.price.ToString();
                pnlproducts.Controls.Add(product);
            }
        }
    }
}
