using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Models
{
    public class ItemCount
    {
        public int Qty { get; set; }
        public int text { get; set; }
    }
    public class ItemsCount
    {
        public List<ItemCount> counts = new List<ItemCount>()
        {
            new ItemCount(){Qty=1,text=1},
            new ItemCount(){Qty=2,text=2},

        };

    }
}
