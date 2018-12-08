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
    public partial class StudentContest : Form
    {
        private int maxQuest = 40;
        private List<CauHoi> listQuest;
        private List<string> listAnsInput = new List<string>(new string[40]);
        private int _numQuest = 0;

        private int NumQuest
        {
            get { return _numQuest; }
            set
            {
                if (value >= 0 && value < maxQuest)
                {
                    _numQuest = value;
                    loadQuestion();
                    loadAnsInput();
                }
            }
        }

        public StudentContest()
        {
            InitializeComponent();

            loadTVListQuest();
            loadQuestion();
            initTimer();
        }

        private void initTimer()
        {
            long maxSecond = 20 * 60;
            lbTime.Text = maxSecond.toTimeString();
            MyTimer timer = new MyTimer(maxSecond); // 20 phut
            timer.onMyTimerTick += second =>
            {
                lbTime.Text = second.toTimeString();
            };
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab == tabForms.TabPages["tabContest"])
            {
                
            }
        }

        private void loadTVListQuest()
        {
            if (listQuest == null)
            {
                listQuest = Question.LoadQuestion();
            }

            int idx = 0;

            foreach (var quest in listQuest)
            {
                var tn = new TreeNode("Câu " + (idx + 1).ToString());
                tn.Tag = idx;
                tvListQuest.Nodes.Add(tn);
                idx++;
            }

            tvListQuest.ExpandAll();
        }

        private void loadQuestion()
        {
            var quest = listQuest[NumQuest];

            txtQuest.Text = string.Format("Câu {0}. {1}", NumQuest + 1, quest.NoiDung);
            txtAnsA.Text = quest.CauA;
            txtAnsB.Text = quest.CauB;
            txtAnsC.Text = quest.CauC;
            txtAnsD.Text = quest.CauD;
        }

        private void loadAnsInput()
        {
            string ans = listAnsInput[NumQuest];

            switch (ans)
            {
                case "a":
                    rdbAnsAInput.Checked = true;
                    break;
                case "b":
                    rdbAnsBInput.Checked = true;
                    break;
                case "c":
                    rdbAnsCInput.Checked = true;
                    break;
                case "d":
                    rdbAnsDInput.Checked = true;
                    break;
                default:
                    rdbAnsAInput.Checked = false;
                    rdbAnsBInput.Checked = false;
                    rdbAnsCInput.Checked = false;
                    rdbAnsDInput.Checked = false;
                    break;
            }
        }

        private void tvListQuest_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = e.Node;
            NumQuest = (int)tn.Tag;
        }

        private void rdbAnsInput_CheckedChanged(object sender, EventArgs e)
        {
            string ans = string.Empty;
            ans = rdbAnsAInput.Checked ? "a" : ans;
            ans = rdbAnsBInput.Checked ? "b" : ans;
            ans = rdbAnsCInput.Checked ? "c" : ans;
            ans = rdbAnsDInput.Checked ? "d" : ans;

            if (ans != string.Empty)
            {
                tvListQuest.Nodes[NumQuest].ForeColor = Color.Green;
                tvListQuest.Nodes[NumQuest].NodeFont = new Font("Calibri", 12, FontStyle.Bold);
            }

            listAnsInput[NumQuest] = ans;
        }

        private void btnNextQuest_Click(object sender, EventArgs e)
        {
            NumQuest++;
        }

        private void btnPrevQuest_Click(object sender, EventArgs e)
        {
            NumQuest--;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int correctAns = 0;

            for(var i = 0; i < maxQuest; i++)
            {
                string ans = listAnsInput[i];
                if (ans != string.Empty && ans == listQuest[i].CauTLDung.ToString())
                {
                    correctAns++;
                }
            }

            var resultForm = new StudentContestResult(correctAns, maxQuest);
            resultForm.StartPosition = FormStartPosition.CenterParent;
            resultForm.ShowDialog();
        }
    }
}
