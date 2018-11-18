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
  public partial class SidebarButton : UserControl
  {
    public string LabelText
    {
      get => label1.Text;
      set => label1.Text = value;
    }

    public Point LabelLocation
    {
      get => label1.Location;
      set => label1.Location = value;
    }

    public Image CustomImage
    {
      get => pictureBox1.Image;
      set => pictureBox1.Image = value;
    }

    public SidebarButton()
    {
      InitializeComponent();
      pictureBox1.Click += btnClickHandle;
      label1.Click += btnClickHandle;
    }

    public void btnClickHandle(object sender, EventArgs e)
    {
      this.OnClick(e);
    }
  }
}
