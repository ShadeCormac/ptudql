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
        public AddExam(int loaiKT)
        {
            InitializeComponent();
            this.txtTypeExam.Text = loaiKT.ToString();
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtTimeStart.Text = dtpTimeStart.Value.ToString("MM-dd-yyyy hh:mm:ss");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtTimeEnd.Text = dtpTimeEnd.Value.ToString("MM-dd-yyyy hh:mm:ss");
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            if(txtIdExam.Text == "")
            {
                MessageBox.Show("Chưa nhập mã kì thi", "Thông báo");
                return;
            }
            else if(Exam.isExisted(txtIdExam.Text))
            {
                MessageBox.Show("Mã kỳ thi đã tồn tại", "Thông báo");
                return;
            }

            else if(txtParticipant.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng học sinh tham gia", "Thông báo");
                return;
            }
            else if(txtNameExam.Text =="")
            {
                MessageBox.Show("Chưa nhập tên kỳ thi", "Thông báo");
                return; 
            }
            else if(txtTimeStart.Text == "")
            {
                MessageBox.Show("Chưa nhập giờ bắt đầu", "Thông báo");
                return;
            }
            else if(txtTimeEnd.Text =="")
            {
                MessageBox.Show("Chưa nhập giờ kết thúc", "Thông báo");
                return;
            }
            else if (string.Compare(txtTimeStart.Text,txtTimeEnd.Text,true) > 0)
            {
                MessageBox.Show("Thời gian không hợp lệ","Thông báo");
                return;
            }


            var exam = new KyThi
            {
                IDKyThi = txtIdExam.Text,
                TenKyThi = txtNameExam.Text,
                SLThamGia = int.Parse(txtParticipant.Text),
                LoaiKyThi = int.Parse(txtTypeExam.Text),
                ThoiGianBatDau = DateTime.Parse(txtTimeStart.Text),
                ThoiGianKetThuc = DateTime.Parse(txtTimeEnd.Text)
            };
            Exam.Insert(exam);
            MessageBox.Show("Tạo kỳ thi thành công");
        }
    }
}
