using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class ItemModel
    {
        public int id { get; set; }
        public string itemname { get; set; }
        public string description { get; set; }
        public string imagepath { get; set; }
        public int catagoryid { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
        public double total { get; set; }
        public string controlname { get; set; }
        public Boolean isstockable { get; set; }
        public Boolean issellable { get; set; }
        public Boolean isserved { get; set; }
        public int billno { get; set; }
    }
}
