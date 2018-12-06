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
    public Register()
    {
      InitializeComponent();
            errors = new ErrorProvider();
    }

    private void login_Click(object sender, EventArgs e)
    {
      Router.Navigate(ParentForm, new Login());
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
            //save to database
        }
    }
}
