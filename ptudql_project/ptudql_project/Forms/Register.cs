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
  public partial class Register : Form
  {
    public Register()
    {
      InitializeComponent();
    }

    private void login_Click(object sender, EventArgs e)
    {
      Router.Navigate(ParentForm, new Login());
    }
  }
}
