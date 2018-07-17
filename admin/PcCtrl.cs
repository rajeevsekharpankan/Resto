using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Models;

namespace ZigZag.Admin
{
    public partial class PcCtrl : UserControl
    {
        public PcListCtrl.EditPcsCtrl EditPcCallback;
        public PcCtrl()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                EditPcCallback((PcModel)this.Tag);
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }
    }
}
