using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Manager;
using Resto.Models;
namespace ZigZag.Admin
{
    public partial class PcListCtrl : CommonCtrl
    {
        PcManager manager = new PcManager();
        public delegate void EditPcsCtrl(PcModel pc);
        public PcListCtrl()
        {
            InitializeComponent();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtitemname.Text.Trim() == "")
                {
                    Utilities.ShowInfo("Please enter PC name!");
                    return;
                }
                if (manager.Upsert(new PcModel() { pcname = txtitemname.Text.Trim(), id = this.txtitemname.Tag == null ? 0 : int.Parse(this.txtitemname.Tag.ToString()) }))
                {
                    Utilities.ShowInfo("Saved successfully!");
                    txtitemname.Text = "";
                    txtitemname.Tag = null;
                    FillPcs();
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        public void FillPcs()
        {
            List<PcModel> pcs = manager.GetPcs();
            pnlpcs.Controls.Clear();
            PcCtrl pcctrl;
            foreach (PcModel item in pcs)
            {
                pcctrl = new PcCtrl();
                pcctrl.lblname.Text = item.pcname;
                pcctrl.Tag = item;
                pcctrl.EditPcCallback = new EditPcsCtrl(EditPcsCtrlCallback);
                pnlpcs.Controls.Add(pcctrl);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                txtitemname.Text = "";
                txtitemname.Tag = null;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
        public void EditPcsCtrlCallback(PcModel model)
        {
            this.txtitemname.Text = model.pcname;
            this.txtitemname.Tag = model.id;
        }
    }
}
