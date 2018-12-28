using ptudql_project.DAO;
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

namespace ptudql_project.Admin
{
    public partial class addUser : Form
    {
        private ErrorProvider errors = null;
        private string _username = "";
        private string _password = "";
        private string _rePassword = "";
        public event Action AddUserSuccess;

        public addUser()
        {
            InitializeComponent();
            errors = new ErrorProvider();
            InitCbbPermission();
        }

        void InitCbbPermission()
        {
            var cbbList = new[] { new { value = 1, name = "Admin" }, new { value = 2, name = "Teacher" }, new { value = 3, name = "Student" } }.ToList();

            this.cbDecent.DisplayMember = "name";
            this.cbDecent.ValueMember = "value";
            this.cbDecent.DataSource = cbbList;
        }

        private void txtAccount_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Tên tài khoản không hợp lệ");
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Tên tài khoản ít nhất 6 kí tự");
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Mật khẩu không được trống");
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Mật khẩu ít nhất 6 kí tự");
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void txtrePass_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Mật khẩu không được trống");
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Mật khẩu ít nhất 6 kí tự");
            }
            else if (txtPass.Text != control.Text)
            {
                errors.SetError(control, "Mật khẩu nhập lại phải trùng khớp");
            }
            else
            {
                errors.SetError(control, "");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            //must use crypto
            //use Validation class later
            if (_username.Length < 6 || _password.Length < 6 || _rePassword.Length < 6)
            {
                errors.SetError((Control)sender, "Bạn phải nhập đủ thông tin");
            }
            else
            {
                if (!Account.isRegisterd(txtAccount.Text))
                {
                    if (!Validation.checkPassWord(txtPass.Text, txtrePass.Text))
                    {
                        errors.SetError((Control)sender, "Mật khẩu không trùng");
                    }
                    else
                    {
                        errors.SetError((Control)sender, "");
                        //save to database
                        TaiKhoan tk = new TaiKhoan { TenDangNhap = txtAccount.Text, MatKhau = Crypto.hashPassword(txtPass.Text), LoaiTK = (int)cbDecent.SelectedValue };
                        Account.Register_admin(tk);
                        AddUserSuccess();
                    }
                }
                else
                {
                    MessageBox.Show("Ten tai khoan da ton tai");
                }
            }
        }


        private void txtAccount_Validated(object sender, EventArgs e)
        {
            _username = ((TextBox)sender).Text;
        }

        private void txtPass_Validated(object sender, EventArgs e)
        {
            _password = ((TextBox)sender).Text;
        }

        private void txtrePass_Validated(object sender, EventArgs e)
        {
            _rePassword = ((TextBox)sender).Text;
        }
    }
}
