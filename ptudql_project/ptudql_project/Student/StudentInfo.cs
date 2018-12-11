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
using ptudql_project.Utils;

namespace ptudql_project.Student
{
    public partial class StudentInfo : Form
    {

        //private SidebarButton activeBtn = null;
        ErrorProvider errors = null;
        public StudentInfo()
        {
            InitializeComponent();
            errors = new ErrorProvider();
            this.btnLamBaiThi.Click += lamBaiTracNghiem;

        }

        //private void changeColorBtn(object sender, EventArgs e)
        //{
        //  SidebarButton btn = (SidebarButton)sender;
        //  if (activeBtn != null)
        //  {
        //    activeBtn.BackColor = Color.FromArgb(53, 152, 220);
        //  }
        //  btn.BackColor = Color.FromArgb(48, 124, 176);
        //  activeBtn = btn;
        //}

        private void lamBaiTracNghiem(object sender, EventArgs e)
        {
            //List<Quest> listQuest = new List<Quest>();
            //for(int i = 1; i <= 20; i++)
            //{
            //Quest quest = new Quest($"Câu hỏi {i}", "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4");
            //listQuest.Add(quest);
            //}
            //ListQuest listQuestControl = new ListQuest(listQuest);

            //TabPage lamBaiTracNghiemPage = new TabPage("Làm bài trắc nghiệm");
            //lamBaiTracNghiemPage.Controls.Add(listQuestControl);

            //tabControl1.TabPages.Clear();
            //tabControl1.TabPages.Add(lamBaiTracNghiemPage);
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new StudentContest());
        }

        private void CheckMail(object sender, EventArgs e)
        {
            //string mail = "nthiepgk123@gmail.com";
            TextBox input = sender as TextBox;
            if (Validation.isEmail(input.Text))
            {
                errors.SetError((Control)sender, "");
            }
            else
            {
                errors.SetError((Control)sender, "Email không hợp lệ ! Kiểm tra lại");
            }
        }

        private void CheckName(object sender, EventArgs e)
        {
            TextBox input = sender as TextBox;
            if (Validation.checkName(input.Text))
            {
                errors.SetError((Control)sender, "");
            }
            else
            {
                errors.SetError((Control)sender, "Họ tên không hợp lệ ! Kiểm tra lại");
            }
        }

        private void CheckPassWord(object sender, EventArgs e) 
        {
            TextBox input = sender as TextBox;
            if (Validation.checkPassWord(input.Text,tbpassword.Text))
            {
                errors.SetError((Control)sender, "");
            }
            else
            {
                errors.SetError((Control)sender, "Họ tên không hợp lệ ! Kiểm tra lại");
            }
        }

        private void btnLamBaiThi_Load(object sender, EventArgs e)
        {

        }

        private void btnLamBaiThi_DoubleClick(object sender, EventArgs e)
        {
            //Router.ChangeForm(this, )
        }

        private void sidebarButton1_Load(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new RequestQuestion("Đóng góp câu hỏi"));
        }

        private void sidebarButton1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
