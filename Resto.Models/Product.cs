using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int categoryId { get; set; }
        public string name { get; set; }
        public string imagePath { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public string controlname { get; set; }
    }
}
