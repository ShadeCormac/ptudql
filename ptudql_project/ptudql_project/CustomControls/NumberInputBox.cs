using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.CustomControls
{
    class NumberInputBox : TextBox
    {
        public NumberInputBox() : base()
        {
            this.KeyPress += textBox1_KeyPress;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
