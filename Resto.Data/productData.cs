using Resto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Excel = Microsoft.Office.Interop.Excel;
using Dapper;
namespace Resto.Data
{
    public class productData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (DBConnection._constring.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBConnection._constring + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBConnection._constring + ";Extended Properties='Excel 12.0;HDR=Yes';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Products$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                    dtexcel.Rows.RemoveAt(0);
                    foreach (DataRow row in dtexcel.Rows)
                    {
                        products.Add(new Product() { Id = int.Parse(row["id"].ToString()), categoryId = int.Parse(row["categoryId"].ToString()), imagePath = row["imagePath"].ToString(), name = row["name"].ToString(), price = decimal.Parse(row["price"].ToString()) });
                    }

                }
                catch
                {


                }
            }

            return products;
        }
        public List<CategoryModel> GetCategories()
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                return con.Query<CategoryModel>("sp_Category", null, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<ItemModel> GetItems()
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                return con.Query<ItemModel>("sp_item_Select", null, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }

        public List<ItemModel> GetItemsByCatagroy(int catagoryid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@catagoryid", catagoryid, DbType.String);
                return con.Query<ItemModel>("sp_items_by_Catagory", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<ItemModel> GetStocksByCatagroy(int catagoryid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@catagoryid", catagoryid, DbType.String);
                return con.Query<ItemModel>("sp_stock_select", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<ItemModel> GetItemsByCatagroy_sellable(int catagoryid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@catagoryid", catagoryid, DbType.String);
                return con.Query<ItemModel>("sp_items_by_sellable", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<ItemModel> GetItemsByCatagroy_stockbale(int catagoryid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@catagoryid", catagoryid, DbType.String);
                return con.Query<ItemModel>("sp_items_by_stockable", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public Boolean Insert(ItemModel item)
        {
            Boolean returndata = false;
            OleDbTransaction transaction = null;
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            using (con)
            {
                try
                {
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;
                    DynamicParameters param = new DynamicParameters();
                    cmd.Parameters.Add("@name", item.itemname);
                    cmd.Parameters.Add("@catagoryid", item.catagoryid);
                    cmd.Parameters.Add("@description", item.description);
                    cmd.Parameters.Add("@price", item.price);
                    cmd.Parameters.Add("@imagepath", item.imagepath);
                    cmd.Parameters.Add("@isstockable", item.isstockable);
                    cmd.Parameters.Add("@issellable", item.issellable);
                    if (item.id == 0)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_Item_insert";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "SELECT @@IDENTITY";
                        cmd.CommandType = CommandType.Text;
                        string itemid = cmd.ExecuteScalar().ToString();
                        if (int.Parse(itemid) > 0 && item.isstockable)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@itemid", itemid);
                            cmd.Parameters.Add("@cost", item.price);
                            cmd.CommandText = "sp_stock_insert";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    else if (item.id > 0)
                    {
                        cmd.Parameters.Add("@id", item.id);
                        //param.Add("@id", item.id, DbType.Int16);
                        cmd.CommandText = "sp_item_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        // con.Execute("sp_item_update", param, null, null, CommandType.StoredProcedure);
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    Utilities.ShowError("Not Saved error occured");

                }

            }
            return returndata;

        }
    }
}
