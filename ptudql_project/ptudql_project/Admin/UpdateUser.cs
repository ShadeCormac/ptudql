using ptudql_project.DAO;
using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Admin
{
    public partial class UpdateUser : Form
    {
        private string userRole;
        private ErrorProvider errors = new ErrorProvider();

        public UpdateUser()
        {
            InitializeComponent();
        }

        public UpdateUser(string username, string role)
        {
            InitializeComponent();
            userRole = role;

            if (role == "2")
            {
                var gv = TeacherDAO.GetInfo(username);
                title.Text = "Cập nhật thông tin giáo viên";
                HideControls();
                txtAccountName.Text = gv.TenTK;
                txtEmail.Text = gv.Email;
                txtFullName.Text = gv.HoTen;
                txtAddress.Text = gv.DiaChi;
                rbMale.Checked = gv.GioiTinh == "Nam";
                rbFemale.Checked = gv.GioiTinh == "Nữ";
            }
            else
            {
                var hs = DAO.Student.getInfo(username);
                txtAccountName.Text = hs.TenTK;
                txtGrade.Text = hs.Khoi;
                txtClass.Text = hs.Lop;
                txtEmail.Text = hs.Email;
                txtFullName.Text = hs.HoTen;
                txtAddress.Text = hs.DiaChi;
                rbMale.Checked = hs.GioiTinh == "Nam";
                rbFemale.Checked = hs.GioiTinh == "Nữ";
            }
        }

        private void HideControls()
        {
            this.label6.Visible = false;
            this.txtAddress.Visible = false;
            this.picAddress.Visible = false;
            this.label8.Visible = false;
            this.txtGrade.Visible = false;
            this.label9.Visible = false;
            this.txtClass.Visible = false;
            this.picClass.Visible = false;
            this.picGrade.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (userRole)
            {
                case "2":
                    GiaoVien gv = new GiaoVien
                    {
                        TenTK = txtAccountName.Text,
                        HoTen = txtFullName.Text,
                        GioiTinh = (rbMale.Checked) ? "Nam" : "Nữ",
                        Email = txtEmail.Text,
                        SoDienThoai = txtPhone.Text,
                        DiaChi = txtAddress.Text
                    };
                    if (DAO.TeacherDAO.SaveInfo(gv))
                    {
                        MessageBox.Show("Cập nhật thông tin giáo viên thành công", "Thông báo");
                        Close();
                    }
                    break;
                case "3":
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
                    if (DAO.Student.SaveInfo(hs))
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo");
                        Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
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
