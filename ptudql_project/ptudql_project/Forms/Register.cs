using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;

namespace ptudql_project
{
  public partial class Register : Form
  {
        private ErrorProvider errors = null;
        private string _username = "";
        private string _password = "";
        private string _rePassword = "";
    public Register()
    {
      InitializeComponent();
            errors = new ErrorProvider();
    }

    private void login_Click(object sender, EventArgs e)
    {
      Router.ChangeForm(this, new Login());
    }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Tên tài khoản không được trống");
                e.Cancel = true;
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Tên tài khoản ít nhất 6 kí tự");
                e.Cancel = true;
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Mật khẩu không được trống");
                e.Cancel = true;
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Mật khẩu ít nhất 6 kí tự");
                e.Cancel = true;
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, "Mật khẩu không được trống");
                e.Cancel = true;
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Mật khẩu ít nhất 6 kí tự");
                e.Cancel = true;
            } else if (txtPassword.Text != control.Text)
            {
                errors.SetError(control, "Mật khẩu nhập lại phải trùng khớp");
                e.Cancel = true;
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_username.Length == 0 || _password.Length == 0 || _rePassword.Length == 0)
            {
                errors.SetError((Control)sender, "Bạn phải nhập đủ thông tin");

            }
            else
            {
                errors.SetError((Control)sender, "");
                //must use crypto
                //save to database
            }

        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            _username = ((TextBox)sender).Text;
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            _password = ((TextBox)sender).Text;
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            _rePassword = ((TextBox)sender).Text;
        }
    }
}
