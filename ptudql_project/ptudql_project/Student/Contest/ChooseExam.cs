using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.DAO;
using ptudql_project.Utils;

namespace ptudql_project.Student
{
    public partial class ChooseExam : Form
    {
        private string username = Session.AccountName;
        private KyThi contest;
        private DeThi[] listExam;

        public delegate void SelectExamHandler(KyThi contest, DeThi exam);
        public event SelectExamHandler selectExam;

        public ChooseExam()
        {
            InitializeComponent();
        }

        public ChooseExam(KyThi contest) : this()
        {
            this.contest = contest;
            listExam = Exam.getByContest(username, contest).ToArray();
            txtContest.Text = contest.TenKyThi;
            cbChooseExam.DataSource = listExam;
            cbChooseExam.DisplayMember = "IdDe";
            cbChooseExam.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var idx = cbChooseExam.SelectedIndex;
            selectExam(contest, listExam[idx]);
            this.Close();
        }

        private void cbChooseExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exam = listExam[cbChooseExam.SelectedIndex];
            lbExamCount.Text = exam.BoDeThis.Count.ToString();
            lbLevel.Text = exam.DoKho.ToString();
            lbTeacherName.Text = exam.GVRaDe;
            lbTime.Text = $"{exam.ThoiGian} phút";
        }
    }
}
