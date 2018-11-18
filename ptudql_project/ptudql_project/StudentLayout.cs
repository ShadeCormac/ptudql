using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.CustomControls;

namespace ptudql_project
{
  public partial class StudentLayout : Form
  {

    private SidebarButton activeBtn = null;

    public StudentLayout()
    {
      InitializeComponent();
      this.btnLamBaiThi.Click += lamBaiTracNghiem;
    }

    private void changeColorBtn(object sender, EventArgs e)
    {
      SidebarButton btn = (SidebarButton)sender;
      if (activeBtn != null)
      {
        activeBtn.BackColor = Color.FromArgb(53, 152, 220);
      }
      btn.BackColor = Color.FromArgb(48, 124, 176);
      activeBtn = btn;
    }

    private void lamBaiTracNghiem(object sender, EventArgs e)
    {
      List<Quest> listQuest = new List<Quest>();
      for(int i = 1; i <= 20; i++)
      {
        Quest quest = new Quest($"Câu hỏi {i}", "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4");
        listQuest.Add(quest);
      }
      ListQuest listQuestControl = new ListQuest(listQuest);

      TabPage lamBaiTracNghiemPage = new TabPage("Làm bài trắc nghiệm");
      lamBaiTracNghiemPage.Controls.Add(listQuestControl);

      tabControl1.TabPages.Clear();
      tabControl1.TabPages.Add(lamBaiTracNghiemPage);
    }
  }
}
