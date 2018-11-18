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
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void register_Click(object sender, EventArgs e)
    {
      Router.Navigate(ParentForm, new Register());
    }

    private void loginBtn_Click(object sender, EventArgs e)
    {
      Router.Navigate(ParentForm, new StudentLayout());
    }
  }
}
