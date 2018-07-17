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
using System.IO;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace ZigZag.Admin
{
    public partial class AddProduct : UserControl
    {
        ProductManager manager = new ProductManager();
        public delegate void EditProductDelegate(ItemModel item, RestoEnums mode);
        public Boolean editmode = false;
        public ItemModel edititem = null;
        public Boolean fmload = true;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateCtrls()) return;
            ItemModel item = new ItemModel();
            item.catagoryid = int.Parse(ddlcategories.SelectedValue.ToString());
            item.itemname = txtname.Text;
            item.price = double.Parse(txtprice.Text);
            item.isstockable = chkisstockable.Checked;
            item.issellable = chkissellable.Checked;
            if (edititem != null) item.id = edititem.id;
            SaveItem(item);
        }
        private void SaveItem(ItemModel item)
        {
            item.imagepath = "";
            if (picproduct.ImageLocation != null && picproduct.ImageLocation != "")
            {
                string destination = ConfigurationManager.AppSettings["imagepath"].ToString();
                //string path = Application.StartupPath + "/images/" + item.itemname + "_" + DateTime.Now.ToString("HH_mm") + ".jpg";

                //File.Copy(picproduct.ImageLocation, destination + ofd.SafeFileName,true);
                item.imagepath = ofd.SafeFileName;
            }
            item.description = txtdesc.Text;
            manager.Insert(item);
            clearTexts();

        }
        public void clearTexts()
        {
            txtname.Text = "";
            txtdesc.Text = "";
            txtprice.Text = "";
            editmode = false;
            edititem = null;
            //ddlcategories.SelectedIndex = 0;
            picproduct.ImageLocation = "";
            FillProducts();
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
            List<ItemModel> items = manager.GetItemsByCatagroy(int.Parse(ddlcategories.SelectedValue.ToString()));
            pnlproducts.Controls.Clear();
            string imagepath = ConfigurationManager.AppSettings["imagepath"].ToString();
            foreach (ItemModel item in items)
            {
                Productctrl product = new Productctrl();
                product.lblproductname.Text = item.itemname;
                product.imgitem.ImageLocation = imagepath + item.imagepath;
                product.lbldesc.Text = item.description;
                product.lblprice.Text = item.price.ToString();
                item.catagoryid = int.Parse(ddlcategories.SelectedValue.ToString());
                pnlproducts.Controls.Add(product);
                product.Tag = item;
            }
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

        private void pnlproducts_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                Productctrl item = (Productctrl)e.Control;
                item.EditItemCallback = new EditProductDelegate(EditItemCallbackFn);
            }
            catch (Exception ex)
            {
                Utilities.ShowError(ex.Message.ToString());
            }
        }
        private void EditItemCallbackFn(ItemModel item, RestoEnums mode)
        {

            editmode = true;
            txtname.Text = item.itemname;
            txtdesc.Text = item.description;
            txtprice.Text = item.price.ToString();
            picproduct.ImageLocation = item.imagepath;
            ddlcategories.SelectedValue = item.catagoryid;
            chkissellable.Checked = item.issellable;
            chkisstockable.Checked = item.isstockable;
            edititem = item;
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

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen1 = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mGraphics.FillRectangle(LGB, Area1);
            mGraphics.DrawRectangle(pen1, Area1);
        }

    }
}
