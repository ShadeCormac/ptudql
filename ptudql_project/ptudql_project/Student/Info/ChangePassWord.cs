using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Student
{
    public partial class ChangePassword : Form
    {
        private string _oldPass;
        public ChangePassword()
        {
            InitializeComponent();
            _oldPass = DAO.Account.getPassword(Session.AccountName);
        }

        private void btnRegister_Load(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Length == 0 || txtConfirmPassword.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Phải điền đủ thông tin", "Thông báo");
                return;
            }
            if (txtOldPass.Text.Length < 6 || txtConfirmPassword.Text.Length < 6 || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo");
                return;
            }
            if (!Crypto.passwordCompare(txtOldPass.Text, _oldPass))
            {
                MessageBox.Show("Mật khẫu cũ không trùng khớp", "Thông báo");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo");
                return;
            }
            DAO.Account.changePassword(new TaiKhoan {
                TenDangNhap = Session.AccountName,
                MatKhau = Crypto.hashPassword(txtPassword.Text)
            });
            MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
        }
    }
}
