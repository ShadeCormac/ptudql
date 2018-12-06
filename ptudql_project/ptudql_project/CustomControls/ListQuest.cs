using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;

namespace ptudql_project.CustomControls
{
  public partial class ListQuest : UserControl
  {
    public long _countDownTime = 20 * 60; // seconds
    private Timer timer;

    public ListQuest()
    {
      InitializeComponent();
      this.Dock = DockStyle.Fill;
    }

    public long Counter
    {
      get { return _countDownTime; }
      set { _countDownTime = value; }
    }

    private void ListQuest_Load(object sender, EventArgs e)
    {
      timer = new Timer();
      timer.Interval = 1000;
      timer.Tick += (o, e2) =>
      {
        if (Counter == 0)
        {
          timer.Stop();
        }
        Counter--;
        this.label1.Text = Counter.toTimeString(); // loop
      };
      this.label1.Text = Counter.toTimeString(); //init
      timer.Start();
    }
  }
}
