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

namespace ptudql_project.Student
{
    public partial class StudentContest : Form
    {
        public StudentContest()
        {
            InitializeComponent();
            var listQuest = Question.LoadQuestion();
            foreach (var quest in listQuest)
            {
                
            }
        }

        private void tabListQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
