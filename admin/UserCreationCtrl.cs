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
using Resto.Manager;
namespace ZigZag.Admin
{
    public partial class UserCreationCtrl : CommonCtrl
    {
        UserManager manager = new UserManager();
        public UserCreationCtrl()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validatectrls()) return;
                if (manager.Insert(new userModel()
                {
                    userid = txtuserid.Text.Trim(),
                    username = txtname.Text.Trim(),
                    password = txtpassword.Text
                }))
                {
                    Utilities.ShowInfo("Saved successfully!");
                    cleartexts();
                }
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
        public void FillUsers()
        {
            List<userModel> users = manager.GetUsers();
            pnlcustomer.Controls.Clear();
            foreach (userModel c in users)
            {

                userctrl user = new userctrl();
                user.lblname.Text = c.username;
                user.Tag = c;
                user.lbluserid.Text = c.userid;
                pnlcustomer.Controls.Add(user);
            }
        }
        public Boolean Validatectrls()
        {
            Boolean returndata = true;

            if (txtname.Text.Trim() == "")
            {
                Utilities.ShowInfo("Enter name!");
                returndata = false;
            }
            if (txtuserid.Text.Trim() == "")
            {
                Utilities.ShowInfo("Enter userid");
                returndata = false;
            }
            if (txtpassword.Text.Trim() == "")
            {
                Utilities.ShowInfo("Enter password");
                returndata = false;
            }
            return returndata;
        }
        public void cleartexts()
        {
            txtname.Text = txtpassword.Text = txtuserid.Text = "";
            FillUsers();
        }
    }
}
