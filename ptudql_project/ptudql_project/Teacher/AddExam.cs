using ptudql_project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Teacher
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            cbExamType.SelectedIndex = 0;
        }
        
        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            if(txtIdExam.Text == "")
            {
                MessageBox.Show("Chưa nhập mã kì thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(Exam.isExisted(txtIdExam.Text))
            {
                MessageBox.Show("Mã kỳ thi đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(nbJoin.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng học sinh tham gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtNameExam.Text =="")
            {
                MessageBox.Show("Chưa nhập tên kỳ thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else if (DateTime.Compare(dtpTimeStart.Value, dtpTimeEnd.Value) > 0)
            {
                MessageBox.Show("Thời gian bắt đầu không hợp lệ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var exam = new KyThi
            {
                IDKyThi = txtIdExam.Text,
                TenKyThi = txtNameExam.Text,
                SLThamGia = int.Parse(nbJoin.Text),
                LoaiKyThi = cbExamType.SelectedIndex + 1,
                ThoiGianBatDau = dtpTimeStart.Value,
                ThoiGianKetThuc = dtpTimeEnd.Value
            };
            Exam.Insert(exam);
            MessageBox.Show("Thêm kỳ thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
