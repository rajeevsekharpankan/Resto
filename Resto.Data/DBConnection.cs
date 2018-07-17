using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Resto.Data
{
    public class DBConnection
    {
        private static DBConnection _instance = null;
        public static string _constring = @"D:\Personal Projects\naveen\Resto\RestoDB.xlsx";
        private DBConnection()
        {
            
           
        }
        public static DBConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
        public static string GetKeyValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static string GetConnection()
        {
          
            string con = ConfigurationManager.AppSettings["connection"].ToString();
            return con;
        }
        public OleDbConnection GetOleDbConnection()
        {
            string con = ConfigurationManager.AppSettings["connection"].ToString();
            OleDbConnection connection = new OleDbConnection(con);
            return connection;
        }
    }
}
