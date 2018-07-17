using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string mobileno { get; set; }
        public string address { get; set; }
        public Boolean isCustomer { get; set; }
        public string  username { get; set; }

    }
}
