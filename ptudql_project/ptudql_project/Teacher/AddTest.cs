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
        public AddTest(string testId)
        {
            listQuestions = new BindingList<string>();
            InitializeComponent();
            this.txtBoDeThi.Text = testId;
            this.txtBoDeThi.Enabled = false;
            //this.txtBoDeThi.ReadOnly = true; 
            LoadListQuests(testId);
        }

        private void LoadListQuests(string testId)
        {
            listQuestions = Test.loadQuestionsId(testId);
            this.nipTime.Text = Test.getTime(testId).ToString();
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
            if (this.lbAddedQuestion.Items.Count == 0)
            {
                this.lbAddedQuestion.DataSource = listQuestions;

            }
            var allQuestions = Question.GetAllQuestions();
            this.dgvQuestions.DataSource = allQuestions;
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

            Test.Create(new DeThi()
            {
                GVRaDe = "gv00001",
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

        private void btnRemoveQuest_Click(object sender, EventArgs e)
        {
            this.listQuestions.Remove(this.lbAddedQuestion.SelectedItem.ToString());
        }
    }
}
