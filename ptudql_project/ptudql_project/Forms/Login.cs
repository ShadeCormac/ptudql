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
  public partial class Login : Form
  {
        private bool txtUsernameClick = false;
        private ErrorProvider errors = null;
        private bool txtPasswordClick = false;
    public Login()
    {
      InitializeComponent();
      errors = new ErrorProvider();
    }

    private void register_Click(object sender, EventArgs e)
    {
      Router.Navigate(ParentForm, new Register());
      
    }

    private void loginBtn_Click(object sender, EventArgs e)
    {
            //check database?
    }

      
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0 || control.Text == "Tên đăng nhập")
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

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0 || control.Text == "********")
            {
                errors.SetError(control, "Mật khẩu không được trống");
                e.Cancel = true;
            }
            else if (control.Text.Length < 6)
            {
                errors.SetError(control, "Mật khẩu có ít nhất 6 kí tự");
                e.Cancel = true;
            }
            else
            {
                errors.SetError(control, "");
            }

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsernameClick == false)
            {
                this.txtUsername.Text = "";
                txtUsernameClick = true;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.AutoValidate = AutoValidate.Disable;   
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            ((Control)sender).Select();
            if (txtPasswordClick == false)
            {
                this.txtPassword.Text = "";
                txtPasswordClick = true;
            }
            
        }
    }
}
