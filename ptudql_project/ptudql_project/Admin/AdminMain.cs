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
    public partial class AdminMain : Form
    {
        int selectedRow = 0;
        BindingList<TaiKhoan> bindingList;

        public AdminMain()
        {
            InitializeComponent();
            LoadAccount();
            DataBind();
            InitCbbPermission();

        }
        void InitCbbPermission()
        {
            //var cbbList = new[] { new { value = 1, name = "Admin" }, new { value = 2, name ="Teacher"}, new { value = 3, name ="Student"} }.ToList();

            //this.cbDecent.DisplayMember = "name";
            //this.cbDecent.ValueMember = "value";
            //this.cbDecent.DataSource = cbbList;


        }

        BindingManagerBase BindingManager
        {
            get { return BindingContext[bindingList]; }
        }

        void DataBind()
        {
            this.bindingList = this.dtvAdmin.DataSource as BindingList<TaiKhoan>;

            this.txtAccount.DataBindings.Add("Text", bindingList, "TenDangNhap");
            //this.cbDecent.DataBindings.Add("SelectedValue", bindingList, "LoaiTK", true, DataSourceUpdateMode.OnPropertyChanged);
            var dbTxtRole = new Binding("Text", bindingList, "LoaiTK");
            dbTxtRole.Format += DbTxtRole_Format;
            txtRole.DataBindings.Add(dbTxtRole);
        }

        void LoadAccount()
        {      
            this.dtvAdmin.DataSource = Account.GetAll();
        }

        private void DbTxtRole_Format(object sender, ConvertEventArgs e)
        {
            Dictionary<int, string> roles = new Dictionary<int, string>();
            roles[1] = "Admin";
            roles[2] = "Teacher";
            roles[3] = "Student";

            if (e.DesiredType == typeof(string))
            {
                var roleInt = (int)e.Value;
                e.Value = string.Format(roles[roleInt]);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string PhanQuyen = txtRole.Text;
            string TaiKhoan = txtAccount.Text;
            switch (PhanQuyen)
            {
                case "Teacher":
                    updateTeacherInfo frmTeacher = new updateTeacherInfo(TaiKhoan);
                    frmTeacher.ShowDialog();
                    break;
                case "Student":
                    updateStudentInfo frmStudent = new updateStudentInfo(TaiKhoan);
                    frmStudent.ShowDialog();
                    break;
                case "Admin":
                    MessageBox.Show("Không được phép sửa thông tin Admin!", "Thông báo");
                    break;
            }
        }

       

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            string username = (BindingManager.Current as TaiKhoan).TenDangNhap;
            bool isSuccess = Account.deleteAccount(username);
            if (isSuccess)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                bindingList.Remove(BindingManager.Current as TaiKhoan);
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công , Xin Thử Lại!", "Thông Báo");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = ofdImportStudent.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = ofdImportStudent.FileName;
                try
                {
                    Import import = new Import(@filePath);
                    var list = import.importAccount();
                    import.Cleanup();
                    Account.Import(list);
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã xảy ra lỗi...");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var frmAddUser = new addUser();
            frmAddUser.AddUserSuccess += () =>
            {
                LoadAccount();
            };
            Router.ShowFormDialog(this, frmAddUser);
        }
    }
}
