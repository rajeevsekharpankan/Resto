using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class billmasterModel
    {
        public int billno { get; set; }
        public DateTime billdate { get; set; }
        public double amount { get; set; }
        public int customerid { get; set; }
        public string customername { get; set; }
        public List<billdetails> billdetails { get; set; }
        public string userid { get; set; }
        public Boolean ispaid { get; set; }
        public Boolean isserved { get; set; }
        public string machinename { get; set; }
        public int pcid { get; set; }
    }
    public class billdetails
    {
        public int billno { get; set; }
        public int itemid { get; set; }
        public int qty { get; set; }
        public double amount { get; set; }
        public double total { get; set; }
        public string itemname { get; set; }
        public string imagepath { get; set; }
        public ItemModel item { get; set; }
    }
}
