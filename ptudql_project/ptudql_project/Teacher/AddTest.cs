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
        List<Tuple<int, string>> diffList = null;
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
            this.btnCreateTest.Text = "Lưu thay đổi";
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
            diffList = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (1, "Dễ"),
                new Tuple<int, string> (2, "Trung bình"),
                new Tuple<int, string> (3, "Khó"),
                new Tuple<int, string> (4, "Cực khó"),
            };
            this.cbbDifficulty.DataSource = diffList;
            this.cbbDifficulty.DisplayMember = "item2";
            this.cbbDifficulty.ValueMember = "item1";
            this.listQuestions.ListChanged += ListQuestions_ListChanged;
            this.lbCount.Text = $"Tông số câu hỏi hiện tại: {this.listQuestions.Count}.";
        }

        private void ListQuestions_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.lbCount.Text = $"Tông số câu hỏi hiện tại: {this.listQuestions.Count}.";
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
            else if (Test.isExisted(txtBoDeThi.Text) && this.btnCreateTest.Text != "Lưu thay đổi")
            {
                MessageBox.Show("Mã đề thi đã tồn tại", "Thông báo");
                return;
            }
            int value = int.Parse(cbbDifficulty.SelectedValue.ToString());
            switch (value)
            {
                case 1:
                    if (listQuestions.Count != 20)
                    {
                        MessageBox.Show("Mức độ dễ là 20 câu hỏi.");
                        return; 
                    }
                    break;
                case 2:
                    if (listQuestions.Count != 30)
                    {
                        MessageBox.Show("Mức độ trung bình là 30 câu hỏi.");
                        return;
                    }
                    break;
                case 3:
                    if (listQuestions.Count != 40)
                    {
                        MessageBox.Show("Mức độ khó là 40 câu hỏi.");
                        return;
                    }
                    break;
                case 4:
                    if (listQuestions.Count != 50)
                    {
                        MessageBox.Show("Mức độ cực khó là 50 câu hỏi.");
                        return;
                    }
                    break;
                
            }

            var test = new DeThi()
            {
                GVRaDe = "giaovien1",
                IdDe = txtBoDeThi.Text,
                ThoiGian = int.Parse(nipTime.Text),
                DoKho = value
            };

            if (btnCreateTest.Text == "Lưu thay đổi")
            {
                //Test.removeQuestion
                Test.Update(test);
                Test.removeQuestions(this.txtBoDeThi.Text);
                
            }
            else
            {
                Test.Create(test);
            }          
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
            if (btnCreateTest.Text == "Lưu thay đổi")
            {
                MessageBox.Show("Lưu thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã thêm thành công");
            
                this.nipTime.Text = "";
                this.listQuestions.Clear();
                this.txtBoDeThi.Text = "";
            }
        }

        private void btnRemoveQuest_Click(object sender, EventArgs e)
        {
            this.listQuestions.Remove(this.lbAddedQuestion.SelectedItem.ToString());
        }
    }
}
