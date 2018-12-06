using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;

namespace ptudql_project
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      Router.Navigate(this, new Login());
    }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls[0].CausesValidation = false;
            this.CausesValidation = false;
            if (!e.Cancel)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
