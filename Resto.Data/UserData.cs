using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resto.Models;
using Dapper;
using System.Data.OleDb;
using System.Data;
namespace Resto.Data
{
    public class UserData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public List<userModel> GetUsers()
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                return con.Query<userModel>("sp_users_select", null, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }

        public Boolean Insert(userModel user)
        {
            Boolean returndata = false;

            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {

                con.Open();
                cmd = new OleDbCommand("sp_users_select_by_userid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@userid", user.userid);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    Utilities.ShowInfo("User Id exists!" + Environment.NewLine + "Please try with another!");
                    return returndata;

                }
                rdr.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@username", user.username);
                cmd.Parameters.Add("@userid", user.userid);
                cmd.Parameters.Add("@isactive", true);
                cmd.Parameters.Add("@password", user.password);
                cmd.CommandText = "sp_user_insert";
                cmd.ExecuteNonQuery();
                returndata = true;
            }
            return returndata;
        }
        public userModel CheckLogin(string userid, string password)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@userid", userid, DbType.String);
                param.Add("@password", password, DbType.String);
                return con.Query<userModel>("sp_users_login", param, null, false, null, CommandType.StoredProcedure).FirstOrDefault();
            }

        }
    }
}
