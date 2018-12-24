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
    public partial class updateStudentInfo : Form
    {
        private ErrorProvider errors = new ErrorProvider();
        private HocSinh hs;

        private string[] lstGender = new string[] { "Nam", "Nữ" };

        public updateStudentInfo()
        {
            InitializeComponent();
        }

        public updateStudentInfo(string username)
        {
            InitializeComponent();

            hs = StudentDAO.getInfo(username);
            txtAccount.Text = hs.TenTK;
            txtKhoi.Text = hs.Khoi;
            txtLop.Text = hs.Lop;
            txtMail.Text = hs.Email;
            txtName.Text = hs.HoTen;

            cbGender.Items.AddRange(lstGender);
            cbGender.SelectedIndex = hs.GioiTinh == "Nam" ? 0 : 1;
        }

        private void txtLop_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            Regex rg = new Regex(@"[^a-zA-Z0-9_]+");

            if (control.Text.Length == 0) 
            {
                errors.SetError(control, $"Không được để trống");
            }
            else if (rg.IsMatch(control.Text))
            {
                errors.SetError(control, $"Không được chứa kí tự đặc biệt");
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, $"Không được để trống");
            }
            else if (!Validation.checkName(control.Text))
            {
                errors.SetError(control, $"Tên không hợp lệ!");
            }
            else
            {
                errors.SetError(control, "");
            }

        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Length == 0)
            {
                errors.SetError(control, $"Không được để trống");
            }
            else if (!Validation.isEmail(control.Text))
            {
                errors.SetError(control, $"Email không hợp lệ!");
            }
            else
            {
                errors.SetError(control, "");
            }
        }

        private void txtAccount_Validated(object sender, EventArgs e)
        {
            hs.TenTK = ((TextBox)sender).Text;
        }

        private void txtLop_Validated(object sender, EventArgs e)
        {
            hs.Lop = ((TextBox)sender).Text;
        }

        private void txtKhoi_Validated(object sender, EventArgs e)
        {
            hs.Khoi = ((TextBox)sender).Text;
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            hs.HoTen = ((TextBox)sender).Text;
        }

        private void txtMail_Validated(object sender, EventArgs e)
        {
            hs.Email = ((TextBox)sender).Text;
        }
        
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbGender.SelectedIndex;
            hs.GioiTinh = lstGender[idx];
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (StudentDAO.SaveInfo(hs))
            {
                MessageBox.Show("Cập nhật thông tài khoản thành công", "Thông báo");
            }
        }
    }
}
