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
    public partial class AddTest : Form
    {
        BindingList<string> listQuestions = null;
        public AddTest()
        {
            listQuestions = new BindingList<string>();
            InitializeComponent();
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
            var allQuestions = Question.GetAllQuestions();
            this.dgvQuestions.DataSource = allQuestions;
            this.lbAddedQuestion.DataSource = listQuestions;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
           if(dgvQuestions.SelectedRows.Count==0)
            { return; }
           else
            {
                var tempList = listQuestions.ToList();
                foreach(DataGridViewRow question in dgvQuestions.SelectedRows)
                {
                    string questionId = question.Cells["IdCauHoi"].Value.ToString();
                    //MessageBox.Show(question.Cells["IdCauHoi"].Value.ToString());
                    if (!tempList.Contains(questionId))
                        listQuestions.Add(questionId);
                }
                
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
            else if (Test.isExisted(txtBoDeThi.Text))
            {
                MessageBox.Show("Mã đề thi đã tồn tại", "Thông báo");
                return;
            }

            Test.create(new DeThi()
            {
                GVRaDe = "giaovien",
                IdDe = txtBoDeThi.Text,
                ThoiGian = int.Parse(nipTime.Text)
            });

            BoDeThi bdt = null;
            List<BoDeThi> bdtList = new List<BoDeThi>();
            foreach (string quest in listQuestions)
            {
                bdt = new BoDeThi
                {
                    IdCauHoi = int.Parse(quest),
                    IdDe = txtBoDeThi.Text
                };
                bdtList.Add(bdt);
            }
            Test.addQuestions(bdtList);

            MessageBox.Show("Bạn đã thêm thành công");
            this.nipTime.Text = "";
            this.listQuestions.Clear();
            this.txtBoDeThi.Text = "";

        }
    }
}
