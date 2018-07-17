using Resto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Dapper;
namespace Resto.Data
{
    public class CustomerData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public CustomerModel Upsert(CustomerModel customer)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
             cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;

            using (con)
            {


                if (customer.Id > 0)
                {
                    cmd.CommandText = "update customer set name='" + customer.name + "',mobileno='" + customer.mobileno + "',address='" + customer.address + "',username='" + customer.username + "'   where id =" + customer.Id.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = "insert into customer(name,mobileno,address,createdon,updatedon,username)values('" + customer.name + "','" + customer.mobileno + "','" +
                        customer.address + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "','" + customer.username + "')";
                    //customer = con.Query<CustomerModel>("select * from customer where id = " + customer.Id.ToString(), "", null, true, null, CommandType.Text).ToList().FirstOrDefault();
                    cmd.ExecuteNonQuery();

                }
            }
            if (con.State == ConnectionState.Open)
                con.Close();
            return customer;
        }
        public Boolean Delete(CustomerModel customer)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            using (con)
            {
               // con.Execute("delete from customer where id=" + customer.Id.ToString(), null, null, null, CommandType.Text);
                cmd.CommandText = "update customer set status=0 where id =" + customer.Id.ToString();
                cmd.ExecuteNonQuery();
            }

            return true;
        }
        public List<CustomerModel> SelectAll()
        {
            OleDbConnection con = DBConnection.GetInstance().GetOleDbConnection();
            List<CustomerModel> customers;
            using (con)
            {

                customers = con.Query<CustomerModel>("select * from customer where status=1 order by id", null, null, false, null, CommandType.Text).ToList();

            }
            return customers;
        }

        public CustomerModel UpsertSuppliers(CustomerModel customer)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;

            using (con)
            {


                if (customer.Id > 0)
                {
                    cmd.CommandText = "update suppliers set name='" + customer.name + "',mobileno='" + customer.mobileno + "',address='" + customer.address + "'   where id =" + customer.Id.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = "insert into suppliers(name,mobileno,address,createdon,updatedon)values('" + customer.name + "','" + customer.mobileno + "','" +
                        customer.address + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "')";
                    //customer = con.Query<CustomerModel>("select * from customer where id = " + customer.Id.ToString(), "", null, true, null, CommandType.Text).ToList().FirstOrDefault();
                    cmd.ExecuteNonQuery();

                }
            }
            if (con.State == ConnectionState.Open)
                con.Close();
            return customer;
        }
        public Boolean DeleteSupplier(CustomerModel customer)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            using (con)
            {
                // con.Execute("delete from customer where id=" + customer.Id.ToString(), null, null, null, CommandType.Text);
                cmd.CommandText = "update suppliers set status=0 where id =" + customer.Id.ToString();
                cmd.ExecuteNonQuery();
            }

            return true;
        }
        public List<CustomerModel> SelectAllSuppliers()
        {
            OleDbConnection con = DBConnection.GetInstance().GetOleDbConnection();
            List<CustomerModel> customers;
            using (con)
            {

                customers = con.Query<CustomerModel>("select * from suppliers where status=1 order by id", null, null, false, null, CommandType.Text).ToList();

            }
            return customers;
        }
        public CustomerModel CheckUsername(string username)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@username", username);
                return con.Query<CustomerModel>("sp_check_customer_username", param, null, false, null, CommandType.StoredProcedure).ToList().FirstOrDefault();
            }
        }
    }

}
