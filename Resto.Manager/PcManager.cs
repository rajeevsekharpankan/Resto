using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Resto.Models;
using Resto.Data;
namespace Resto.Manager
{
    public class PcManager
    {
        PcData data = new PcData();
        public List<PcModel> GetPcs()
        {
            return data.GetPcs();
        }
        public Boolean Upsert(PcModel pc)
        {
            return data.Upsert(pc);
        }
        public PcModel CheckPcname(string Pcname)
        {
            return data.CheckPcname(Pcname);
        }
    }
}
