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
    public partial class AddConnection : Form
    {
        public event Action AddSuccess;

        public AddConnection()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var conStr = txtConnectionStr.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Không được để trống tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(conStr))
            {
                MessageBox.Show("Không được để Connection String", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connection.AddConnection(new Connection() { Name = name, ConnectionString = conStr });

            txtName.Text = "";
            txtConnectionStr.Text = "";

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddSuccess();
        }
    }
}
