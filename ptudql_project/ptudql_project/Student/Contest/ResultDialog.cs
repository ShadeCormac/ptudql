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
using ptudql_project.DAO;

namespace ptudql_project.Student
{
    public partial class StudentContestResult : Form
    {
        public StudentContestResult(string _idKyThi, string _idDe, string _username, int correctAns, int maxQuest)
        {
            InitializeComponent();
            
            lbIdKyThi.Text = _idKyThi;
            lbIdDe.Text = _idDe;
            lbUsername.Text = _username;
            lbCorrectAns.Text = $"{correctAns}/{maxQuest}";
            lbScore.Text = (correctAns / (float)maxQuest * 10).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
