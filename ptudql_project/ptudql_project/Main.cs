using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      var Login = new Login();
      Login.TopLevel = false;
      //Login.Size = this.Size;
      Login.Location = new Point(0, 0);
      Controls.Add(Login);
      Login.Show();
    }
  }
}
