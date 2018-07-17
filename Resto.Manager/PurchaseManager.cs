using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resto.Models;
using Resto.Data;
namespace Resto.Manager
{
    
    public class PurchaseManager
    {
        PurchaseData data = new PurchaseData();
        public string Insert(PurchaseModel bill)
        {
            return data.Insert(bill);
        }

    }
}
