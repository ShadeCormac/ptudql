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
       
        private ErrorProvider errors = null;
        private string _username = "";
        private string _password = "";
        public Login()
    {
      InitializeComponent();
      errors = new ErrorProvider();
    }

    private void register_Click(object sender, EventArgs e)
    {
      Router.ChangeForm(this, new Register());
    }

    private void loginBtn_Click(object sender, EventArgs e)
    {
            if (_username.Length < 6 || _password.Length < 6)
            {
                errors.SetError((Control)sender, "Bạn phải nhập thông tin");
            }
            else
            {
                errors.SetError((Control)sender, "");
                //MessageBox.Show(string.Format($"{_username} { _password}" ));
                //Router.ChangeForm(this, new StudentInfo());
            }


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

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            this._username = ((TextBox)sender).Text;
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            this._password = ((TextBox)sender).Text;
        }
    }
}
