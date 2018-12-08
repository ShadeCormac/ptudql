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

namespace ptudql_project.Teacher
{
    public partial class TeacherMain : Form
    {
        public TeacherMain()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedTab.Text) {
                case "Đề thi":
                    LoadQuestForm();
                    break;
                case "Câu hỏi":
                    LoadQuestionsForm();
                    break;
                
            }
        }
        void LoadQuestionsForm()
        {
            var data = Question.LoadQuestion();
            this.dgvAllQuest.DataSource = data;
        }

        void LoadQuestForm()
        {
            
            using (var db = new QLTNDataContext())
            {
                var Tests = db.DeThis.Select(dt => dt.IdDe).Distinct();
                this.cbbTestId.DataSource = Tests;
                this.cbbTestId.SelectedIndexChanged += CbbTestId_SelectedIndexChanged;
               
            }

        }

        private void CbbTestId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load lai ds cac cau hoi cua de thi
            this.dgvQuestions.DataSource = Test.loadQuestions(cbbTestId.SelectedValue.ToString());
        }

        void LoadStudents()
        {

        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new AddTest());
        }

       
    }
}
