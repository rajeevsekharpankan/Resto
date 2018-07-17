using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resto.Models;
using Resto.Manager;
namespace ZigZag.Admin
{
    public partial class RestoLogin : Form
    {
        UserManager manager = new UserManager();
        public RestoLogin()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate()) return;
                userModel model = manager.CheckLogin(txtusername.Text.Trim(), txtpassword.Text.Trim());
                if (model == null)
                {
                    Utilities.ShowInfo("user is not registered!" + Environment.NewLine + "Please contact admin!");
                    return;
                }
                else
                {
                    Utilities.currentuser = model;
                    Form1 form = new Form1();
                    this.Hide();
                    form.Show();
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
        public Boolean Validate()
        {
            Boolean returndata = true;
            if (txtusername.Text.Trim() == "")
            {
                Utilities.ShowInfo("Please enter user id");
                returndata= false;
            }
            if (txtpassword.Text.Trim() == "")
            {
                Utilities.ShowInfo("Please enter password");
                returndata= false;
            }
            return returndata;
        }
    }
}
