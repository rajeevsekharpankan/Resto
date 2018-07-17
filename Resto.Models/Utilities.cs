using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace Resto.Models
{
    public class Utilities
    {
        
        public static void ShowInfo(string message)
        {
            zigzagbox messagebox = new zigzagbox();
            messagebox.btnCancel.Visible = false;
            messagebox.ShowBox(message, "Information");
            //zigzagbox.ShowBox(message,"Information");
        }
        public static void ShowError(string message)
        {
            zigzagbox messagebox = new zigzagbox();
            messagebox.btnCancel.Visible = false;
            messagebox.ShowBox(message, "Error Occured");
           // MessageBox.Show(message, "Confirm please!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static DialogResult Confirm(string message)
        {
            zigzagbox messagebox = new zigzagbox();
            
            messagebox.ShowBox(message, "Confirm");
            return MessageBox.Show(message, "Confirm please!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static string pcname { get; set; }
        public static PcModel currentpc { get; set; }
        public static userModel currentuser { get; set; }
    }
}
