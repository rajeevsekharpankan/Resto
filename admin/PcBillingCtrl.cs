using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZigZag.Admin;
using Resto.Manager;
using Resto.Models;
using System.Configuration;

namespace ZigZag.Admin
{
    public partial class PcBillingCtrl : CommonCtrl
    {
        ProductManager manager = new ProductManager();
        public PcBillingCtrl()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            MessageBox.Show(categoryid.ToString());
        }
        public int categoryid { get; set; }
        public delegate void AddBillItemDelegate(CategoryModel item);
        public delegate void CatagoryDelegate(int catagoryid);

        ProductManager pmanager = new ProductManager();
        private void MySecondCustmControl_Load(object sender, EventArgs e)
        {
            //  Form1 f = (Form1)this.ParentForm;


        }
        public void FillCatagories()
        {
            List<CategoryModel> catagories = manager.GetCategories();
            toppnl.Controls.Clear();
            foreach (CategoryModel item in catagories)
            {
                btncontrol btn = new btncontrol();
                btn.btn.Text = item.name;
                btn.Tag = item;
                btn.AddItemCallbackFn = new AddBillItemDelegate(AddItemCallbackFn);
                toppnl.Controls.Add(btn);
            }
            if (catagories.Count > 0) AddItemCallbackFn(catagories.FirstOrDefault());
        }
        private void AddOrderItem(SellItemCtrl item)
        {

        }
        private void AddItemCallbackFn(CategoryModel product)
        {

            List<Control> controls = this.toppnl.Controls.Find("btncontrol", true).ToList();
            foreach (btncontrol item in controls)
            {
                item.pnlactive.Visible = false;
                item.btn.BackColor = Color.Black;
                item.btn.ForeColor = Color.White;
            }
            List<ItemModel> products = pmanager.GetItemsByCatagroy_sellable(product.Id);
            productspnl.Controls.Clear();
            string path = ConfigurationManager.AppSettings["imagepath"];
            foreach (ItemModel p in products)
            {
                SellItemCtrl newitem = new SellItemCtrl(p);
                newitem.parentform = this.parentform;
                newitem.Tag = p;
                newitem.lblproductname.Text = p.itemname;
                newitem.lblprice.Text = string.Format("{0:0.00}", p.price);
                newitem.picitem.ImageLocation = path + p.imagepath;
                productspnl.Controls.Add(newitem);

            }

        }

        private void MySecondCustmControl_ControlAdded(object sender, ControlEventArgs e)
        {

            List<Control> controls = new List<Control>();
            controls.Add((Control)sender);
        }

        private void toppnl_ControlAdded(object sender, ControlEventArgs e)
        {
            btncontrol dlg = e.Control as btncontrol;
            //dlg.AddItemCallbackFn = new AddItemDelegate(this.AddItemCallbackFn);


        }

        private void productspnl_ControlAdded(object sender, ControlEventArgs e)
        {
            SellItemCtrl dlg = e.Control as SellItemCtrl;
            //Form1 f = this.ParentForm as Form1;
            dlg.AddOrderItemCallback = new billscontrol.AddOrderItemDelegate(this.parentform.billscontrol1.AddItemCallbackFn);
            //dlg.AddItemCallback = new AddOrderDelegate();
        }

        private void toppnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryCallbackFn(int catagoryid)
        {


        }
    }
}
