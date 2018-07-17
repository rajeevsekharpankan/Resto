using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resto.Models;
using Resto.Data;
namespace Resto.Manager
{
    public class CustomerManager
    {
        CustomerData data = new CustomerData();
        public CustomerModel Upsert(CustomerModel customer)
        {

            customer = data.Upsert(customer);
            return customer;
        }
        public List<CustomerModel> SelectAll()
        {
            return data.SelectAll();
        }
        public Boolean Delete(CustomerModel customer)
        {
            return data.Delete(customer);
        }
        public CustomerModel UpsertSuppliers(CustomerModel customer)
        {

            customer = data.UpsertSuppliers(customer);
            return customer;
        }
        public List<CustomerModel> SelectAllSuppliers()
        {
            return data.SelectAllSuppliers();
        }
        public Boolean DeleteSupplier(CustomerModel customer)
        {
            return data.DeleteSupplier(customer);
        }
        public CustomerModel CheckUsername(string username)
        { return data.CheckUsername(username); }
    }
}
