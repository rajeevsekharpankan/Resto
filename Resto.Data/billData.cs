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
    public class billData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public string Insert(billmasterModel bill)
        {
            string returndata = "0";
            OleDbTransaction transaction = null;
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand("sp_billmaster_insert");
            cmd.Connection = con;
            con.Open();
            using (con)
            {
                try
                {
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;

                    //DynamicParameters param = new DynamicParameters();
                    //param.Add("@customerid", bill.customerid, DbType.Int16);
                    //param.Add("@customername", bill.customername, DbType.String);
                    //param.Add("@amount", bill.amount, DbType.Decimal);
                    //param.Add("@billdate", bill.billdate.ToShortDateString(), DbType.String);
                    cmd.Parameters.Add("@customerid", "0");
                    cmd.Parameters.Add("@customername", "");
                    cmd.Parameters.Add("@amount", bill.amount);
                    cmd.Parameters.Add("@billdate", bill.billdate.ToShortDateString());
                    cmd.Parameters.Add("@userid", "from pc");
                    cmd.Parameters.Add("@ispaid", bill.ispaid);
                    cmd.Parameters.Add("@isserved", bill.isserved);
                    cmd.Parameters.Add("@pcid", Utilities.currentpc.id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    cmd.CommandType = CommandType.Text;
                    returndata = cmd.ExecuteScalar().ToString();
                    ////
                    int stock = 0;
                    foreach (billdetails item in bill.billdetails)
                    {
                        if (item.item.isstockable)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@itemid", item.itemid);
                            cmd.CommandText = "sp_check_stock";
                            cmd.CommandType = CommandType.StoredProcedure;
                            stock = int.Parse(cmd.ExecuteScalar().ToString());
                            if (stock < item.qty)
                            {
                                throw new Exception("Invalid Quantity for :" + item.itemname);
                            }
                        }
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@billno", returndata);
                        cmd.Parameters.Add("@itemid", item.itemid);
                        cmd.Parameters.Add("@qty", item.qty);
                        cmd.Parameters.Add("@amount", item.amount);
                        cmd.Parameters.Add("@total", item.total);
                        cmd.CommandText = "sp_billdetails_insert";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        if (item.item.isstockable)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@quantity", item.qty);
                            cmd.Parameters.Add("@itemid", item.itemid);
                            cmd.CommandText = "sp_Stock_update_by_sales";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Utilities.ShowError("Not Saved error occured" + Environment.NewLine + ex.Message.ToString());

                }
                return returndata;
                //con.Execute("sp_billmaster_insert", param, null, null, CommandType.StoredProcedure);
                // string returndata = con.ExecuteScalar("SELECT @@IDENTITY", null, null, null, CommandType.Text).ToString();

            }
        }

        public string InsertFinalBill(billmasterModel bill)
        {
            string returndata = "0";
            OleDbTransaction transaction = null;
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand("sp_finalbillmaster_insert");
            cmd.Connection = con;
            con.Open();
            using (con)
            {
                try
                {
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;

                    //DynamicParameters param = new DynamicParameters();
                    //param.Add("@customerid", bill.customerid, DbType.Int16);
                    //param.Add("@customername", bill.customername, DbType.String);
                    //param.Add("@amount", bill.amount, DbType.Decimal);
                    //param.Add("@billdate", bill.billdate.ToShortDateString(), DbType.String);
                    cmd.Parameters.Add("@customerid", "0");
                    cmd.Parameters.Add("@customername", "");
                    cmd.Parameters.Add("@amount", bill.amount);
                    cmd.Parameters.Add("@billdate", bill.billdate.ToShortDateString());
                    cmd.Parameters.Add("@userid", Utilities.currentuser.userid);
                    cmd.Parameters.Add("@ispaid", bill.ispaid);
                    //cmd.Parameters.Add("@isserved", bill.isserved);
                    cmd.Parameters.Add("@pcid", Utilities.currentpc.id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    cmd.CommandType = CommandType.Text;
                    returndata = cmd.ExecuteScalar().ToString();
                    ////
                    int stock = 0;
                    foreach (billdetails item in bill.billdetails)
                    {
                        if (item.item.isstockable)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@itemid", item.itemid);
                            cmd.CommandText = "sp_check_stock";
                            cmd.CommandType = CommandType.StoredProcedure;
                            stock = int.Parse(cmd.ExecuteScalar().ToString());
                            if (stock < item.qty)
                            {
                                throw new Exception("Invalid Quantity for :" + item.itemname);
                            }
                        }
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@billno", returndata);
                        cmd.Parameters.Add("@itemid", item.itemid);
                        cmd.Parameters.Add("@qty", item.qty);
                        cmd.Parameters.Add("@amount", item.amount);
                        cmd.Parameters.Add("@total", item.total);
                        cmd.CommandText = "sp_finalbilldetails_insert";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        if (item.item.isstockable && !item.item.isserved)
                        {
                            //  if (!item.item.isserved)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.Add("@quantity", item.qty);
                                cmd.Parameters.Add("@itemid", item.itemid);
                                cmd.CommandText = "sp_Stock_update_by_sales";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    if (bill.pcid > 0)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@pcid", bill.pcid);
                        cmd.CommandText = "sp_billmaster_paid_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Utilities.ShowError("Not Saved error occured" + Environment.NewLine + ex.Message.ToString());

                }
                return returndata;
                //con.Execute("sp_billmaster_insert", param, null, null, CommandType.StoredProcedure);
                // string returndata = con.ExecuteScalar("SELECT @@IDENTITY", null, null, null, CommandType.Text).ToString();

            }
        }
        public List<billmasterModel> GetUnservedOrders()
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                return con.Query<billmasterModel>("sp_order_not_served", null, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<billmasterModel> GetUnservedOrders(int pcid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@pcid", pcid, DbType.Int16);
                return con.Query<billmasterModel>("sp_Order_not_served_By_pc", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<ItemModel> GetAllItemsNotBilledByPc(int pcid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@pcid", pcid, DbType.Int16);
                return con.Query<ItemModel>("sp_billdetails_by_pc", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public List<billdetails> GetBillDetails(int billno)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();

            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@billno", billno, DbType.Int16);
                return con.Query<billdetails>("sp_billdetails_by_billno", param, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public int GetStock(int itemid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@itemid", itemid, DbType.Int16);
                return int.Parse(con.ExecuteScalar("sp_check_stock", param, null, null, CommandType.StoredProcedure).ToString());
            }
        }
        public int UpdateServed(int billno)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@billno", billno, DbType.Int16);
                con.ExecuteScalar("sp_billmaster_update_served", param, null, null, CommandType.StoredProcedure);
                return billno;
            }
        }
        public int UpdatePaidStatus(int pcid)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@pcid", pcid, DbType.Int16);
                con.ExecuteScalar("sp_billmaster_paid_update", param, null, null, CommandType.StoredProcedure);
                return pcid;
            }
        }
    }
}
