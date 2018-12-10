using ptudql_project.DAO;
using ptudql_project.Utils;
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
    public partial class TeacherMain : Form
    {
        private BindingList<CauHoi> _trackingList = null;
        public TeacherMain()
        {
            InitializeComponent();
            _trackingList = new BindingList<CauHoi>();
            LoadQuestionsForm();
            LoadQuestForm();
            BindTxt();
            //LoadStudentRecords();
            LoadListExam();

        }

        private void BindTxt()
        {
            txtNoiDung.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "NoiDung");
            txtA.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "CauA");
            txtB.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "CauB");
            txtC.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "CauC");
            txtD.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "CauD");
            txtCauDung.DataBindings.Add("Text", dgvAllQuest.DataSource as BindingList<CauHoi>, "CauTLDung");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (this.tabControl1.SelectedTab.Text) {
            //    case "Đề thi":
            //        LoadQuestForm();
            //        break;
            //    case "Câu hỏi":
            //        LoadQuestionsForm();
            //        break;
                
            //}
        }
        void LoadQuestionsForm()
        {
            if (this.dgvAllQuest.DataSource == null)
            {
                var data = Question.GetAllQuestions();
                data.ListChanged += Data_ListChanged;
                
                this.dgvAllQuest.DataSource = data;
            }
            
        }

        void LoadStudentRecords()
        {
            if (this.dgvHocSinh.DataSource == null)
            {
                this.dgvHocSinh.DataSource = DAO.Student.LoadStudent();
               
            }

        }
        void LoadListExam()
        {
            //if (this.cbKyThi.DataSource == null)
            {
                List<string> examList = DAO.Student.LoadListExam();
                this.cbKyThi.Items.Add("ALL");
                foreach (string exam in examList)
                {
                    this.cbKyThi.Items.Add(exam);
                }

                if (cbKyThi.SelectedItem == null || cbKyThi.SelectedItem.ToString() == "ALL")
                {
                    this.dgvHocSinh.DataSource = DAO.Student.LoadStudent();
                }
                else
                {
                    this.dgvHocSinh.DataSource = DAO.Student.LoadListExamStudents(cbKyThi.SelectedText.ToString());
                }
            }

        }

        private void Data_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                var list = this.dgvAllQuest.DataSource as BindingList<CauHoi>;
                if(!_trackingList.Contains(list[e.NewIndex]))
                    _trackingList.Add(list[e.NewIndex]);
            }
        }

        void LoadQuestForm()
        {
            var q = Question.GetAllQuestions();
            q.ListChanged += Data_ListChanged;
            this.dgvAllQuest.DataSource = q;
            
        }

        private void CbbTestId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load lai ds cac cau hoi cua de thi
            this.dgvQuestions.DataSource = Test.loadQuestions(cbbTestId.SelectedValue.ToString());
        }

        void LoadStudents()
        {
            
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new AddTest(),true);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_trackingList.Count > 0)
            {
                Question.SaveChanges(_trackingList.OrderBy(q => q.IdCauHoi).ToList());
                _trackingList.Clear();
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");
            }
            
        }

        private void qlHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void cbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKyThi.SelectedItem.ToString() != "ALL")
            {
                this.dgvHocSinh.DataSource = DAO.Student.LoadListExamStudents(cbKyThi.SelectedItem.ToString());
            }
            else
            {

                this.dgvHocSinh.DataSource = DAO.Student.LoadStudent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new AddExam(), true);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarButton1_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Load(object sender, EventArgs e)
        {

        }

        private void btnThiThu_Load(object sender, EventArgs e)
        {

        }

        private void btnLamBaiThi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qlCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void txtCauDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAllQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qlDeThi_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void qlKyThi_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void qlKyThiThu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
