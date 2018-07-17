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

namespace Resto.UI
{
    public partial class Productctrl : UserControl
    {
        public Productctrl()
        {
            InitializeComponent();
        }

        //public AddProduct.EditProductDelegate EditItemCallback;
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ItemModel item = (ItemModel)this.Tag;
                //EditItemCallback(item, RestoEnums.update);
            }
            catch (Exception ex)
            {

                Utilities.ShowError(ex.Message.ToString());
            }
        }

    }
}
