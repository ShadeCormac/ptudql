using ptudql_project.DAO;
using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Student
{
    public partial class RequestQuestion : Form
    {
        public RequestQuestion(string label)
        {
            InitializeComponent();
            this.label2.Text = label;
            this.btnImport.Visible = (label == "Thêm câu hỏi") ? true : false;
            var routingHandler = StudentRouter.routingBuilder(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var checkedButton = this.Controls.OfType<RadioButton>().Where(rb => rb.Checked).SingleOrDefault();
            if(txtNoiDung.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập nội dung câu hỏi", "Thông báo");
                return;
            }
            else if (txtCauA.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập nội dung câu A", "Thông báo");
                return;
            }
            else if (txtCauB.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập nội dung câu B", "Thông báo");
                return;
            }
            else if (txtCauC.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập nội dung câu C", "Thông báo");
                return;
            }
            else if (txtCauD.Text.Length == 0)
            {
                MessageBox.Show("Phải nhập nội dung câu D", "Thông báo");
                return;
            }
            else if (checkedButton == null)
            {
                MessageBox.Show("Chưa chọn đáp án đúng", "Thông báo");
                return;
            }
            var requestQuest = new CauHoi()
            {
                NoiDung = txtNoiDung.Text,
                CauA = txtCauA.Text,
                CauB = txtCauB.Text,
                CauC = txtCauC.Text,
                CauD = txtCauD.Text,
                CauTLDung = checkedButton.Text.ToLower().ToCharArray().First(),
                LoaiCauHoi = (this.label2.Text == "Thêm câu hỏi")? 1 : 2,
                DaDuyet = 0
            };
            Question.AddRequest(requestQuest);
            MessageBox.Show("Bạn đã thêm thành công");
            ResetInput(checkedButton);

        }

        void ResetInput(RadioButton checkedBtn)
        {
            txtNoiDung.Text = "";
            txtCauA.Text = "";
            txtCauB.Text = "";
            txtCauC.Text = "";
            txtCauD.Text = "";
            checkedBtn.Checked = false;

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdImport.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = ofdImport.FileName;
                try
                {
                    Import import = new Import(@filePath);
                    var list = import.importQuestions();
                    import.Cleanup();
                    Question.Import(list);
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã xảy ra lỗi...");
                }
            }
        }
    }
}
