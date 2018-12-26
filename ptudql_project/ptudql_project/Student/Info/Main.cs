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
        private string username = Session.AccountName;    
        private List<string> lstIdKyThi;
        private List<DanhSachThi> lstDST;

        ErrorProvider errors = null;

        public StudentInfo()
        {
            InitializeComponent();
            errors = new ErrorProvider();
            this.txtAccountName.Text = Session.AccountName;
            LoadTextBoxes();
            var routingHandler = StudentRouter.routingBuilder(this);
            btnLamBaiThi.Click += routingHandler;
            btnRequestQuestion.Click += routingHandler;
            btnThiThu.Click += routingHandler;
        }

        private void LoadTextBoxes()
        {
            switch (Session.AccountType)
            {
                case 2:
                    GiaoVien gv = TeacherDAO.GetInfo(Session.AccountName);
                    this.txtFullName.Text = gv.HoTen;
                    rbMale.Checked = (gv.GioiTinh == "Nam") ? true : false;
                    rbFemale.Checked = !rbMale.Checked;
                    this.txtEmail.Text = gv.Email;
                    this.txtAddress.Text = gv.DiaChi;
                    this.txtPhone.Text = gv.SoDienThoai;
                    HideControls();
                    break;
                case 3:
                    HocSinh hs = DAO.Student.getInfo(Session.AccountName);
                    this.txtFullName.Text = hs.HoTen;
                    rbMale.Checked = (hs.GioiTinh == "Nam") ? true : false;
                    rbFemale.Checked = !rbMale.Checked;
                    this.txtGrade.Text = hs.Khoi;
                    this.txtClass.Text = hs.Lop;
                    this.txtEmail.Text = hs.Email;
                    this.txtAddress.Text = hs.DiaChi;
                    this.txtPhone.Text = hs.SoDienThoai;
                    break;
                default:
                    break;
            }
        }

        private void HideControls()
        {
            this.label6.Visible = false;
            this.txtAddress.Visible = false;
            this.label8.Visible = false;
            this.txtGrade.Visible = false;
            this.label9.Visible = false;
            this.txtClass.Visible = false;     
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

        //private void CheckPassWord(object sender, EventArgs e) 
        //{
        //    TextBox input = sender as TextBox;
        //    if (Validation.checkPassWord(input.Text,tbpassword.Text))
        //    {
        //        errors.SetError((Control)sender, "");
        //    }
        //    else
        //    {
        //        errors.SetError((Control)sender, "Họ tên không hợp lệ ! Kiểm tra lại");
        //    }
        //}

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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Router.ShowFormDialog(this, new ChangePassword());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (Session.AccountType)
            {
                case 2:
                    GiaoVien gv = new GiaoVien
                    {
                        TenTK = txtAccountName.Text,
                        HoTen = txtFullName.Text,
                        GioiTinh = (rbMale.Checked) ? "Nam" : "Nữ",
                        Email = txtEmail.Text,
                        SoDienThoai = txtPhone.Text,
                        DiaChi = txtAddress.Text
                    };
                    DAO.TeacherDAO.SaveInfo(gv);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                    break;
                case 3:
                    HocSinh hs = new HocSinh
                    {
                        TenTK = txtAccountName.Text,
                        HoTen = txtFullName.Text,
                        Khoi = txtGrade.Text,
                        Lop = txtClass.Text,
                        GioiTinh = (rbMale.Checked) ? "Nam" : "Nữ",
                        Email = txtEmail.Text,
                        SoDienThoai = txtPhone.Text,
                        DiaChi = txtAddress.Text
                    };
                    DAO.Student.SaveInfo(hs);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                    break;
                default:
                    break;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            this.CheckMail(sender, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = sender as TextBox;
            if (Validation.checkName(input.Text))
            {
                errors.SetError((Control)sender, "");
            }
            else
            {
                errors.SetError((Control)sender, "Số điện thoại phải là 10 chữ số!");
            }
        }
    }
}
