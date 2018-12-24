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
using ptudql_project.DAO;

namespace ptudql_project.Student
{
    public partial class StudentInfo : Form
    {

        //private SidebarButton activeBtn = null;
        private string username = "test";

        private List<string> lstIdKyThi;
        private List<DanhSachThi> lstDST;

        ErrorProvider errors = null;

        public StudentInfo()
        {
            InitializeComponent();
            errors = new ErrorProvider();

            var routingHandler = StudentRouter.routingBuilder(this);
            btnLamBaiThi.Click += routingHandler;
            btnRequestQuestion.Click += routingHandler;
            btnThiThu.Click += routingHandler;
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

        private void LoadKQHT()
        {
            lstDST = Contest.getListContestResult(1, username);
            lstIdKyThi = Contest.getListIdKyThiFromDST(lstDST);
            
            lstIdKyThi.Insert(0, "Tất cả");

            cbKyThiFilter.Items.Clear();
            cbKyThiFilter.Items.AddRange(lstIdKyThi.ToArray());
            cbKyThiFilter.SelectedIndex = 0;
            dgvKQHT.DataSource = lstDST;
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab == tabForms.TabPages["tabContestResult"])
            {
                LoadKQHT();
            }
        }

        private void cbKyThiFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = cbKyThiFilter.SelectedIndex;
            
            if (idx == 0)
            {
                dgvKQHT.DataSource = lstDST;
                return;
            }

            dgvKQHT.DataSource = lstDST.Where(dst => dst.IdKyThi.Equals(lstIdKyThi[idx])).ToList();
        }
    }
}
