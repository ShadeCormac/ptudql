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
    public partial class updateTeacherInfo : Form
    {
        private ErrorProvider errors = new ErrorProvider();
        private GiaoVien gv;

        private string[] genDer = new string[] { "Nam", "Nữ" }; 
        public updateTeacherInfo()
        {
            InitializeComponent();
        }

        public updateTeacherInfo(string Account)
        {
            InitializeComponent();

            gv = TeacherDAO.GetInfo(Account);
            txtAccount.Text = gv.TenTK;
            txtName.Text = gv.HoTen;
            txtEmail.Text = gv.Email;

            cbGender.Items.AddRange(genDer);
            cbGender.SelectedIndex = gv.GioiTinh == "Nam" ? 0 : 1;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbGender.SelectedIndex;
            gv.GioiTinh = genDer[idx];
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
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

        private void txtName_Validated(object sender, EventArgs e)
        {
            gv.HoTen = ((TextBox)sender).Text;
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            gv.Email = ((TextBox)sender).Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TeacherDAO.SaveInfo(gv))
            {
                MessageBox.Show("Cập nhật thông tin thành công !", "Thông Báo");
            }
        }
    }
}
