using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;
using ptudql_project.DAO;

namespace ptudql_project.Student
{
    partial class StudentContest
    {
        private string username = Session.AccountName;
        private List<KyThi> listContest;
        private bool isChooseExam = false;

        private void btnDoContest_Click(object sender, EventArgs e)
        {
            if (!isChooseExam)
            {
                var contest = listContest[dgvListContest.CurrentRow.Index];
                var frmChooseExam = new ChooseExam(contest);
                frmChooseExam.FormClosed += FrmChooseExam_FormClosed;
                frmChooseExam.selectExam += FrmChooseExam_selectExam;
                Router.ShowFormDialog(this, frmChooseExam);
                isChooseExam = true;
            }
            else
            {
                MessageBox.Show("Vui lòng đóng kỳ thi hiện tại, và thử lại!", "Thông báo");
            }
        }

        private void FrmChooseExam_selectExam(KyThi contest, DeThi exam)
        {
            var frmDoExam = new DoExam(contest, exam);
            frmDoExam.FormClosed += (sender, e) =>
            {
                LoadTabChooseContest();
            };
            Router.ChangeForm(this, frmDoExam, true);
        }

        private void FrmChooseExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            isChooseExam = false;
        }
        
        private void LoadListContest()
        {
            listContest = Contest.getListContest(username);
            dgvListContest.DataSource = listContest;
        }

        private void LoadTabChooseContest()
        {
            LoadListContest();
        }
    }
}
