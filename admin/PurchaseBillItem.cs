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

namespace ZigZag.Admin
{
    public partial class PurchaseBillItem : UserControl
    {

        public PurchaseItemCtrl.EditPurchaseItem EditPurchaseItemCallback;
        public PurchaseCtrl.DeletePurchaseItem DeletePurchaseItemCallback;
        public PurchaseBillItem(PurchaseItemModel purchaseitem)
        {
            InitializeComponent();
            txtitemname.Text = purchaseitem.item.itemname;
            txtcost.Text = purchaseitem.cost.ToString();
            txtqty.Text = purchaseitem.qty.ToString();
            txtamount.Text = purchaseitem.amount.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            PurchaseItemModel item = (PurchaseItemModel)this.Tag;
            item.serialno = int.Parse(this.btnserial.Text);
            EditPurchaseItemCallback(item);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeletePurchaseItemCallback(this);
        }
    }
}
