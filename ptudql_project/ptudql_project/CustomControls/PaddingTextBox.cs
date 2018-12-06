using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.CustomControls
{
  public partial class PaddingTextBox : UserControl
  {
    public string CustomText
    {
      get
            { return textBox1.Text; }
      set { textBox1.Text = value; }
    }

    public PaddingTextBox()
    {
      InitializeComponent();
    }
  }
}
