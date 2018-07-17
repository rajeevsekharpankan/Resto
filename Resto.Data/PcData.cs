using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Resto.Models;
using Dapper;
using System.Data.OleDb;
using System.Data;
namespace Resto.Data
{
    public class PcData
    {
        OleDbCommand cmd;
        OleDbConnection con;
        public List<PcModel> GetPcs()
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                return con.Query<PcModel>("sp_pcs_select", null, null, false, null, CommandType.StoredProcedure).ToList();
            }
        }
        public Boolean Upsert(PcModel pc)
        {
            Boolean returndata = false;
            string itemid = "";
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {

                con.Open();
                cmd = new OleDbCommand("sp_pcs_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pcname", pc.pcname);
                if (pc.id > 0)
                {
                    cmd.Parameters.Add("@id", pc.id);
                    cmd.CommandText = "sp_pcs_update";
                    itemid = pc.id.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    cmd.CommandType = CommandType.Text;
                    itemid = cmd.ExecuteScalar().ToString();
                }
                if (int.Parse(itemid) > 0) returndata = true;
            }
            return returndata;
        }
        public PcModel CheckPcname(string Pcname)
        {
            con = DBConnection.GetInstance().GetOleDbConnection();
            using (con)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@pcname", Pcname);
                return con.Query<PcModel>("sp_check_pc_name", param, null, false, null, CommandType.StoredProcedure).ToList().FirstOrDefault();
            }
        }

    }
}
