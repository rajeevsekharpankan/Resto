using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Models;
using Resto.Manager;
namespace Resto.UI
{
    partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
            // this.Text = String.Format("About {0}", AssemblyTitle);
            //Utilities.ShowInfo(string.IsNullOrEmpty(Utilities.userid) ? "" : Utilities.userid.ToString());
        }

        //CustomerManager manager = new CustomerManager();
        PcManager manager = new PcManager();

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text.Trim() == "")
                {
                    Utilities.ShowInfo("Please enter valid PC number!");
                    return;
                }
                PcModel model = manager.CheckPcname(txtusername.Text.Trim());
                if (model != null)
                {
                    Utilities.pcname = model.pcname;
                    Utilities.currentpc = model;
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    Utilities.ShowInfo("Customer not exists!");
                    return;
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowInfo(ex.Message.ToString());
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Application.Exit();
            }
            catch (Exception ex)
            {

                Utilities.ShowInfo(ex.Message.ToString());
            }
        }
    }
}
