using Resto.Data;
using Resto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Manager
{
    public class ProductManager
    {
        productData pdata = new productData();
        public List<Product> GetProducts()
        {
            return pdata.GetProducts();
        }
        public List<ItemModel> GetItems()
        {
            return pdata.GetItems();
        }
        public List<ItemModel> GetItemsByCatagroy(int catagoryid)
        {
            return pdata.GetItemsByCatagroy(catagoryid);
        }
        public List<ItemModel> GetItemsByCatagroy_sellable(int catagoryid)
        {
            return pdata.GetItemsByCatagroy_sellable(catagoryid);
        }
        public List<ItemModel> GetItemsByCatagroy_stockbale(int catagoryid)
        {
            return pdata.GetItemsByCatagroy_stockbale(catagoryid);
        }
        public List<CategoryModel> GetCategories()
        {
            return pdata.GetCategories();
        }
        public Boolean Insert(ItemModel item)
        {
            return pdata.Insert(item);
        }
        public List<ItemModel> GetStocksByCatagroy(int catagoryid)
        {
            return pdata.GetStocksByCatagroy(catagoryid);
        }
    }
}
