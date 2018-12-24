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

namespace ptudql_project.Teacher
{
    public partial class AddTest : Form
    {
        List<string> listQuestions = null;
        public AddTest()
        {
            listQuestions = new List<string>();
            InitializeComponent();
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
            using(var db = new QLTNDataContext())
            {
                var data = db.CauHois;
                this.dgvQuestions.DataSource = data;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (txtBoDeThi.Text == "")
            {
                MessageBox.Show("Chưa nhập bộ đề thi", "Thông báo");
                return;
            }
            else if(nipTime.Text == "")
            {
                MessageBox.Show("Chưa nhập thời gian", "Thông báo");
                return;
            }
           if(dgvQuestions.SelectedRows.Count==0)
            { return; }
           else
            {
                foreach(DataGridViewRow question in dgvQuestions.SelectedRows)
                {
                    //MessageBox.Show(question.Cells["IdCauHoi"].Value.ToString());
                    listQuestions.Add(question.Cells["IdCauHoi"].Value.ToString());
                }
                listQuestions = listQuestions.Distinct().ToList();
            }

            
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            if (txtBoDeThi.Text == "")
            {
                MessageBox.Show("Chưa nhập bộ đề thi", "Thông báo");
                return;
            }
            else if (nipTime.Text == "")
            {
                MessageBox.Show("Chưa nhập thời gian", "Thông báo");
                return;
            }
            else
            {
                using (var db = new QLTNDataContext())
                {
                    var result = db.DeThis.Where(dethi => dethi.IdDe == txtBoDeThi.Text).SingleOrDefault();
                    if (result != null)
                    {
                        MessageBox.Show("Mã đề đã tồn tại", "Thông báo");
                        return;
                    }
                }
            }
            using (var create = new QLTNDataContext())
            {
                create.DeThis.InsertOnSubmit(new DeThi()
                {
                    GVRaDe = "giaovien",
                    IdDe = txtBoDeThi.Text,
                    ThoiGian = 20//int.Parse(nipTime.Text)
                });
                foreach (string quest in listQuestions)
                {
                    create.BoDeThis.InsertOnSubmit(new BoDeThi
                    {
                        IdCauHoi = int.Parse(quest),
                        IdDe = txtBoDeThi.Text
                    });
                }
                create.SubmitChanges();
                //create.add
                MessageBox.Show("Bạn đã thêm thành công");
                //ResetInput(checkedButton);
            }
        }
    }
}
