using Resto.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZag.Admin
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;
        public List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnhome.Height;
            SidePanel.Top = btnhome.Top;
            //firstCustomControl1.BringToFront();
            panelWidth = pnlmenu.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnhome.Height;
            SidePanel.Top = btnhome.Top;

        }

        private void btnItemmaster_click(object sender, EventArgs e)
        {
            ClearButtonColor();
            btnItemmaster.BackColor = Color.FromArgb(57, 82, 163);
            SidePanel.Height = btnItemmaster.Height;
            SidePanel.Top = btnItemmaster.Top;
            this.ItemListCtrl1.splitContainer1.SplitterDistance = this.ItemListCtrl1.pnlmain.Width;
            this.ItemListCtrl1.FillCategories();
            this.ItemListCtrl1.BringToFront();
            if (!this.ItemListCtrl1.fmload)
                this.ItemListCtrl1.clearTexts();


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
                zigzagHome1.parentform = this;
                zigzagHome1.BringToFront();
                zigzagHome1.parentform = this;
                zigzagHome1.FillOrders();

                //Utilities.userid = "rajeev";
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            btnbill.BackColor = Color.FromArgb(57, 82, 163);
            SidePanel.Height = btnbill.Height;
            SidePanel.Top = btnbill.Top;
            pcBillingCtrl1.parentform = this;
            pcBillingCtrl1.FillCatagories();
            pcBillingCtrl1.BringToFront();

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
                pnlmenu.Width = (pnlmenu.Width - 30);

                if (pnlmenu.Width <= btnhome.Width)
                {
                    timer1.Stop();
                    //pnlmenu.Width = btnhome.Width;
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            btncustomer.BackColor = Color.FromArgb(57, 82, 163);
            SidePanel.Height = btncustomer.Height;
            SidePanel.Top = btncustomer.Top;
            customerCtrl1.BringToFront();
            customerCtrl1.addCustomer1.FillCustomer();
            customerCtrl1.parentform = this;
        }

        private void btnlandingpage_Click(object sender, EventArgs e)
        {
            try
            {
                ClearButtonColor();
                btnlandingpage.BackColor = Color.FromArgb(57, 82, 163);
                zigzagHome1.BringToFront();
                SidePanel.Height = btnlandingpage.Height;
                SidePanel.Top = btnlandingpage.Top;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void tmronline_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            try
            {
                ClearButtonColor();
                btnpurchase.BackColor = Color.FromArgb(57, 82, 163);
                purchaseCtrl1.BringToFront();
                SidePanel.Height = btnpurchase.Height;
                SidePanel.Top = btnpurchase.Top;
                purchaseCtrl1.FillCatagroies();
                purchaseCtrl1.FillSuppliers();
                purchaseCtrl1.parentform = this;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
        private void btnpclist_Click(object sender, EventArgs e)
        {
            try
            {
                ClearButtonColor();
                btnpclist.BackColor = Color.FromArgb(57, 82, 163);
                SidePanel.Height = btnbill.Height;
                SidePanel.Top = btnbill.Top;
                pcListCtrl1.BringToFront();
                SidePanel.Height = btnpclist.Height;
                SidePanel.Top = btnpclist.Top;
                pcListCtrl1.FillPcs();
                pcListCtrl1.parentform = this;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            btnsuppliers.BackColor = Color.FromArgb(57, 82, 163);
            SidePanel.Height = btnsuppliers.Height;
            SidePanel.Top = btnsuppliers.Top;
            suppliers1.BringToFront();
            suppliers1.FillCustomer();
            suppliers1.parentform = this;
        }
        public void ClearButtonColor()
        {

            btnlandingpage.BackColor = btnhome.BackColor = Color.FromArgb(41, 39, 40);
            btncustomer.BackColor = Color.FromArgb(41, 39, 40);
            btnItemmaster.BackColor = Color.FromArgb(41, 39, 40);
            btnsuppliers.BackColor = Color.FromArgb(41, 39, 40);
            btnpurchase.BackColor = Color.FromArgb(41, 39, 40);
            btnpclist.BackColor = Color.FromArgb(41, 39, 40);
            btnbill.BackColor = Color.FromArgb(41, 39, 40);
            btndirectbilling.BackColor = Color.FromArgb(41, 39, 40);
            btndirectbilling.BackColor = Color.FromArgb(41, 39, 40);
            btnusers.BackColor = Color.FromArgb(41, 39, 40);
            btnstock.BackColor = Color.FromArgb(41, 39, 40);
        }

        private void btndirectbilling_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            btndirectbilling.BackColor = Color.FromArgb(57, 82, 163);
            SidePanel.Height = btndirectbilling.Height;
            SidePanel.Top = btndirectbilling.Top;
            if (!billscontrol1.isloaded)
            {
                billscontrol1.isloaded = true;
                billscontrol1.FillPc();
            }
            billscontrol1.BringToFront();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            try
            {
                ClearButtonColor();
                btnusers.BackColor = Color.FromArgb(57, 82, 163);
                SidePanel.Height = btnusers.Height;
                SidePanel.Top = btnusers.Top;
                userCreationCtrl1.BringToFront();
                userCreationCtrl1.FillUsers();
                userCreationCtrl1.parentform = this;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }

        private void billscontrol1_Load(object sender, EventArgs e)
        {

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            try
            {
                ClearButtonColor();
                btnstock.BackColor = Color.FromArgb(57, 82, 163);
                SidePanel.Height = btnstock.Height;
                SidePanel.Top = btnstock.Top;
                stockCtrl1.BringToFront();
                stockCtrl1.FillCategories();
                stockCtrl1.parentform = this;
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString() + Environment.NewLine + ex.StackTrace.ToString());
            }
        }
    }
}
