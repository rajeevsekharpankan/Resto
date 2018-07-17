using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.UI;
using Resto.Manager;
using Resto.Models;

namespace Resto.UI
{
    public partial class MySecondCustmControl : UserControl
    {
        ProductManager manager = new ProductManager();
        public MySecondCustmControl()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            MessageBox.Show(categoryid.ToString());
        }
        public int categoryid { get; set; }
        public delegate void AddItemDelegate(CategoryModel item);
        public delegate void CatagoryDelegate(int catagoryid);
        //public delegate void AddOrderDelegate(item item);
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
                toppnl.Controls.Add(btn);
            }
            if (catagories.Count > 0) AddItemCallbackFn(catagories.FirstOrDefault());
        }
        private void AddOrderItem(item item)
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
            foreach (ItemModel p in products)
            {
                item newitem = new item(p);
                newitem.Tag = p;
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
            dlg.AddItemCallback = new AddItemDelegate(this.AddItemCallbackFn);


        }

        private void productspnl_ControlAdded(object sender, ControlEventArgs e)
        {
            item dlg = e.Control as item;
            Form1 f = this.ParentForm as Form1;
            dlg.AddItemCallback = new billscontrol.AddOrderItemDelegate(f.billscontrol1.AddItemCallbackFn);
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
