using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Student
{
    public partial class StudentContestResult : Form
    {
        public StudentContestResult(int numCorrectAns, int maxQuest)
        {
            InitializeComponent();
            lbNumCorrectAns.Text = string.Format("{0}/{1}", numCorrectAns, maxQuest);
            lbScore.Text = (numCorrectAns / (float)maxQuest * 10).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
