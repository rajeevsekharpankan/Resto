using Resto.Models;
using Resto.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto.UI
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;
        public List<ItemModel> products = new List<ItemModel>();
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnhome.Height;
            SidePanel.Top = btnhome.Top;
            firstCustomControl1.BringToFront();
            panelWidth = pnlmenu.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnhome.Height;
            SidePanel.Top = btnhome.Top;
            firstCustomControl1.Top = mySecondCustmControl1.Top;
            firstCustomControl1.Left = mySecondCustmControl1.Left;
            firstCustomControl1.Width = mySecondCustmControl1.Width;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySecondCustmControl1.categoryid = 2;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            mySecondCustmControl1.BringToFront();
            mySecondCustmControl1.FillCatagories();

            //Thanks for watching Friends...
            //Please dont forget to Subscribe... :) :) :) 
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                btnexit.Left = splitContainer1.Width - 3;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnbill.Height;
            SidePanel.Top = btnbill.Top;
            billscontrol1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                pnlmenu.Width = pnlmenu.Width + 10;
                if (pnlmenu.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlmenu.Width = (pnlmenu.Width - 10);

                if (pnlmenu.Width <= btncollapse.Width)
                {
                    timer1.Stop();
                    //pnlmenu.Width = btnhome.Width;
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnpendingorder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnpendingorder.Height;
            SidePanel.Top = btnpendingorder.Top;
            string s = Utilities.pcname;
            pendingOrderCtrl1.FillOrders();
            pendingOrderCtrl1.parentform = this;
            pendingOrderCtrl1.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
