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
  public partial class Quest : UserControl
  {
    public Quest()
    {
      InitializeComponent();
      this.Size = new Size(470, 200);
    }
    public Quest(string quest, string ans1, string ans2, string ans3, string ans4) : this()
    {
      this.questBox.Text = quest;
      this.ans1.Text = ans1;
      this.ans2.Text = ans2;
      this.ans3.Text = ans3;
      this.ans4.Text = ans4;
    }
    public string QuestText
    {
      get
            { return this.questBox.Text; }
      set { this.questBox.Text = value; }
    }
    public string Ans1Text
    {
      get
            { return this.ans1.Text; }
      set { this.ans1.Text = value; }
    }
    public string Ans2Text
    {
      get
            { return this.ans2.Text; }
      set { this.ans2.Text = value; }
    }
    public string Ans3Text
    {
      get
            { return this.ans3.Text; }
      set { this.ans3.Text = value; }
    }
    public string Ans4Text
    {
      get
            { return this.ans4.Text; }
      set { this.ans4.Text = value; }
    }
  }
}
