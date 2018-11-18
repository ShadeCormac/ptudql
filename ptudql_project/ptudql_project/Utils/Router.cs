using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ptudql_project.Utils
{
  class Router
  {
    public static void Navigate(Form parent, Form navigateTo)
    {
      navigateTo.TopLevel = false;
      navigateTo.Size = parent.Size;
      navigateTo.Location = new Point(0, 0);

      parent.Controls.Clear();
      parent.Controls.Add(navigateTo);
      navigateTo.Show();
    }
    public static void NavigateInPage(Form parent, Form moved, Form navigateTo)
    {
      navigateTo.TopLevel = false;
      navigateTo.Size = parent.Size;
      navigateTo.Location = new Point(0, 0);

      parent.Controls.Remove(moved);
      parent.Controls.Add(navigateTo);
      navigateTo.Show();
    }
  }
}
