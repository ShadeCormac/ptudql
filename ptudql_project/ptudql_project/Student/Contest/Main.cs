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
        public StudentContest()
        {
            InitializeComponent();
            LoadTabChooseContest();
            var routingHandler = StudentRouter.routingBuilder(this);
            btnInfo.Click += routingHandler;
            btnRequestQuestion.Click += routingHandler;
            btnThiThu.Click += routingHandler;
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab == tabForms.TabPages["tabChooseContest"])
            {
                LoadTabChooseContest();
            }
        }
    }
}
