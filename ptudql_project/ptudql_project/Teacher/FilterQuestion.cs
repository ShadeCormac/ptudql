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
    public partial class FilterQuestion : Form
    {
        public FilterQuestion()
        {
            InitializeComponent();
        }
        void LoadDataGridView()
        {
            this.dgvFilterQuestions.DataSource = Question.GetAllRequestedQuestions();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.dgvFilterQuestions.SelectedRows.Count > 0)
            {
                int acceptedQuestId = int.Parse(this.dgvFilterQuestions.SelectedRows[0].Cells["IdCauHoi"].Value.ToString());
                Question.Accept(acceptedQuestId);
                MessageBox.Show("Câu hỏi đã được chấp nhận.");
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (this.dgvFilterQuestions.SelectedRows.Count > 0)
            {
                int acceptedQuestId = int.Parse(this.dgvFilterQuestions.SelectedRows[0].Cells["IdCauHoi"].Value.ToString());
                Question.Remove(acceptedQuestId);
                MessageBox.Show("Câu hỏi đã được từ chối và xoá.");
            }
        }
    }
}
