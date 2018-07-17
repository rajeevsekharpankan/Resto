using Resto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Data
{

    public class PurchaseData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public string Insert(PurchaseModel bill)
        {
            string returndata = "";
            OleDbTransaction transaction = null;
            con = DBConnection.GetInstance().GetOleDbConnection();
            cmd = new OleDbCommand("sp_purchase_insert");
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
                    cmd.Parameters.Add("@purchaseno", bill.purchaseno);
                    cmd.Parameters.Add("@remarks", bill.remarks);
                    cmd.Parameters.Add("@purchasedate", bill.purchasedate);
                    cmd.Parameters.Add("@forname", bill.forname);
                    cmd.Parameters.Add("@supplierid", bill.supplierid);
                    cmd.Parameters.Add("@totalamount", bill.totalamount);
                    cmd.Parameters.Add("@paymentmode", bill.paymentmode);
                    cmd.Parameters.Add("@paidstatus", bill.paidstatus);
                    cmd.Parameters.Add("@userid", Utilities.currentuser.userid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    cmd.CommandType = CommandType.Text;
                    returndata = cmd.ExecuteScalar().ToString();
                    ////
                    foreach (PurchaseItemModel item in bill.purchasedetails)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@purchaseserialno", returndata);
                        cmd.Parameters.Add("@itemid", item.item.id);
                        cmd.Parameters.Add("@cost", item.cost);
                        cmd.Parameters.Add("@price", item.cost);
                        cmd.Parameters.Add("@qty", item.qty);
                        cmd.Parameters.Add("@amount", item.cost * item.qty);
                        cmd.CommandText = "sp_purchasedetails_insert";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@quantity", item.qty);
                        cmd.Parameters.Add("@cost", item.cost);
                        cmd.Parameters.Add("@itemid", item.item.id);

                        
                        cmd.CommandText = "sp_Stock_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Utilities.ShowError("Not Saved error occured");

                }
                return returndata;
                //con.Execute("sp_billmaster_insert", param, null, null, CommandType.StoredProcedure);
                // string returndata = con.ExecuteScalar("SELECT @@IDENTITY", null, null, null, CommandType.Text).ToString();

            }
        }
    }
}
