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
    public partial class StudentTrialContest : Form
    {
        private string username = "test";

        private List<string> lstIdKyThi;
        private List<DanhSachThi> lstDST;

        public StudentTrialContest()
        {
            InitializeComponent();
            var routingHandler = StudentRouter.routingBuilder(this);
            btnInfo.Click += routingHandler;
            btnRequestQuestion.Click += routingHandler;
            btnLamBaiThi.Click += routingHandler;
            LoadTabChooseContest();
        }

        private void loadTKKQ()
        {
            lstDST = Contest.getListContestResult(2, username);
            lstIdKyThi = Contest.getListIdKyThiFromDST(lstDST);

            lstIdKyThi.Insert(0, "Tất cả");

            cbKyThiFilter.Items.Clear();
            cbKyThiFilter.Items.AddRange(lstIdKyThi.ToArray());
            cbKyThiFilter.SelectedIndex = 0;
            dgvTKKQ.DataSource = lstDST;
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabForms.SelectedTab == tabForms.TabPages["tabTKKQ"])
            {
                loadTKKQ();
            }
        }

        private void cbKyThiFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = cbKyThiFilter.SelectedIndex;

            if (idx == 0)
            {
                dgvTKKQ.DataSource = lstDST;
                return;
            }

            dgvTKKQ.DataSource = lstDST.Where(dst => dst.IdKyThi.Equals(lstIdKyThi[idx])).ToList();
        }
    }
}
