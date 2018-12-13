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
    public partial class DetailsExam : Form
    {
        public DetailsExam()
        {
            InitializeComponent();
        }
        public DetailsExam(string idExam)
        {
            InitializeComponent();
            lbIdExam.Text = idExam;
        }
        private void LoadAllIdTest()
        {
            var l = Test.loadQuestionsId();
            this.lBAllIdTest.DataSource = l;
        }
        private void LoadIdTest()
        {
            var l = Exam.LoadIdTest(lbIdExam.Text);
            this.lBIdTest.DataSource = l;
        }
        private void DetailsExam_Load(object sender, EventArgs e)
        {
            LoadAllIdTest();
            LoadIdTest();
            btnAddIdTest.Enabled = false;
            btnRemoveIdTest.Enabled = false;
        }

        private void lBAllIdTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddIdTest.Enabled = true;
            btnRemoveIdTest.Enabled = false;
        }

        private void lBIdTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddIdTest.Enabled = false;
            btnRemoveIdTest.Enabled = true;
        }

        private void btnAddIdTest_Click(object sender, EventArgs e)
        {
            BindingList<string> leftList = this.lBAllIdTest.DataSource as BindingList<string>;
            BindingList<string> rightList = this.lBIdTest.DataSource as BindingList<string>;
            rightList.Add(this.lBAllIdTest.SelectedItem.ToString());
            leftList.Remove(this.lBAllIdTest.SelectedItem.ToString());         
        }

        private void btnRemoveIdTest_Click(object sender, EventArgs e)
        {
            BindingList<string> leftList = this.lBAllIdTest.DataSource as BindingList<string>;
            BindingList<string> rightList = this.lBIdTest.DataSource as BindingList<string>;
            leftList.Add(this.lBIdTest.SelectedItem.ToString());
            rightList.Remove(this.lBIdTest.SelectedItem.ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> idTest = new List<string>();
            for ( int i = 0; i < this.lBIdTest.Items.Count; i++)
            {
                idTest.Add(this.lBIdTest.Items[i].ToString());
            }
            Exam_Test.UpdateTests(lbIdExam.Text, idTest);
        }
    }
}
