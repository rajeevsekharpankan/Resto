using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class PurchaseItemModel
    {
        public ItemModel item { get; set; }
        public int qty { get; set; }
        public double cost { get; set; }
        public double amount { get; set; }
        public int serialno { get; set; }
        public int purchasesubid { get; set; }

    }
    public class PurchaseModel
    {
        public string purchaseno { get; set; }
        public int purchseserialno { get; set; }
        public string remarks { get; set; }
        public DateTime purchasedate { get; set; }
        public string forname { get; set; }
        public int supplierid { get; set; }
        public double totalamount { get; set; }
        public string paymentmode { get; set; }
        public Boolean paidstatus { get; set; }
        public DateTime duedate { get; set; }
        public Boolean active { get; set; }
        public List<PurchaseItemModel> purchasedetails { get; set; }
}
}
