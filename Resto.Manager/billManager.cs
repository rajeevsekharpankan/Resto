using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resto.Models;
using Resto.Data;
namespace Resto.Manager
{
    public class billManager
    {
        billData data = new billData();
        public string Insert(billmasterModel bill)
        {
            return data.Insert(bill);
        }
        public List<billmasterModel> GetUnservedOrders()
        {
            return data.GetUnservedOrders();
        }
        public List<billmasterModel> GetUnservedOrders(int pcid)
        {
            return data.GetUnservedOrders(pcid);
        }
        public List<billdetails> GetBillDetails(int billno)
        {
            return data.GetBillDetails(billno);
        }
        public int GetStock(int itemid)
        {
            return data.GetStock(itemid);
        }
        public int UpdateServed(int billno)
        {
            return data.UpdateServed(billno);
        }
        public List<ItemModel> GetAllItemsNotBilledByPc(int pcid)
        {
            return data.GetAllItemsNotBilledByPc(pcid);
        }
        public string InsertFinalBill(billmasterModel bill)
        {
            return data.InsertFinalBill(bill);
        }
        public int UpdatePaidStatus(int pcid)
        {
            return data.UpdatePaidStatus(pcid);
        }
    }
}
