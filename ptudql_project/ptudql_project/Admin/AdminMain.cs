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
        public AdminMain()
        {
            InitializeComponent();
            LoadAccount();
            LoadListConnection();
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
            var row = dtvAdmin.CurrentRow;
            string PhanQuyen = row.Cells[2].Value.ToString();
            string TaiKhoan = row.Cells[0].Value.ToString();

            if (PhanQuyen == "1")
            {
                MessageBox.Show("Không được phép sửa thông tin Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateUser frmUpdateUser = new UpdateUser(TaiKhoan, PhanQuyen);
            Router.ShowFormDialog(this, frmUpdateUser);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
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

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            var frm = new AddConnection();
            frm.AddSuccess += () => { LoadListConnection(); };
            Router.ShowFormDialog(this, frm);
        }

        private void btnChangeConnection_Click(object sender, EventArgs e)
        {
            if (dgvConnections.CurrentCell != null)
            {
                Connection.CurrentIdx = dgvConnections.CurrentCell.RowIndex;
                MessageBox.Show("Khởi động lại ứng dụng, để thấy thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        public void LoadListConnection()
        {
            dgvConnections.DataSource = Connection.LoadConnection();
        }

        private void btnDeleteConection_Click(object sender, EventArgs e)
        {
            if (dgvConnections.CurrentCell != null)
            {
                Connection.DeleteConnection(dgvConnections.CurrentCell.RowIndex);
                LoadListConnection();
            }
        }
        
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            var list = DAO.Account.GetAll().ToList();
            export.ExportAccounts(list);
            //Question.Import(list);
            MessageBox.Show("Xuất thành công");
        }
    }
}
