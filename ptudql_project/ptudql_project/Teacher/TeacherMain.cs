using ptudql_project.DAO;
using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BindingList<KyThi> _trackingExamList = null;
        private BindingList<KyThi> _trackingTestExamList = null;
        public TeacherMain()
        {
            InitializeComponent();
            _trackingList = new BindingList<CauHoi>();
            _trackingExamList = new BindingList<KyThi>();
            _trackingTestExamList = new BindingList<KyThi>();
            LoadQuestionsForm();
            LoadQuestForm();
            BindTxt();
           
            //LoadStudentRecords();
            LoadListExam();
            LoadExam();
            LoadExamTest();
            //BindExamTxt();
            
        }

        private void BindExamTxt()
        {
            dgvExam.DataBindings.Clear();
            var dgv = dgvExam.DataSource as BindingList<KyThi>;
            
            dgv.ListChanged += Dgv_ListChanged;

            IdExam.DataBindings.Clear();
            IdExam.DataBindings.Add("Text", dgv, "IDKyThi");
            txtNameExam.DataBindings.Clear();
            txtNameExam.DataBindings.Add("Text",dgv,"TenKyThi");
            txtParticipants.DataBindings.Clear();
            txtParticipants.DataBindings.Add("Text", dgv, "SLThamGia");
            txtTypeExam.DataBindings.Clear();
            txtTypeExam.DataBindings.Add("Text", dgv, "LoaiKyThi");
            txtTimeStart.DataBindings.Clear();
            txtTimeStart.DataBindings.Add("Text", dgv, "ThoiGianBatDau");
            txtTimeEnd.DataBindings.Clear();
            txtTimeEnd.DataBindings.Add("Text", dgv, "ThoiGianKetThuc");


            //dgv = dgvExamTest.DataSource as BindingList<KyThi>;
            //dgv.ListChanged += Dgv_ListChanged1;
            //IDExamTest.DataBindings.Add("Text", dgv, "IDKyThi");
            //txtNameExamTest.DataBindings.Add("Text", dgv, "TenKyThi");
            //txtParticipantsTest.DataBindings.Add("Text", dgv, "SLThamGia");
            //txtTypeExamTest.DataBindings.Add("Text", dgv, "LoaiKyThi");
            //txtTimeStartTest.DataBindings.Add("Text", dgv, "ThoiGianBatDau");
            //txtTimeEndTest.DataBindings.Add("Text", dgv, "ThoiGianKetThuc");
        }

        private void Dgv_ListChanged1(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                var list = this.dgvExam.DataSource as BindingList<KyThi>;
                if (!_trackingExamList.Contains(list[e.NewIndex]))
                    _trackingExamList.Add(list[e.NewIndex]);
            }
        }

        private void Dgv_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                var list = this.dgvExam.DataSource as BindingList<KyThi>;
                if (!_trackingExamList.Contains(list[e.NewIndex]))
                    _trackingExamList.Add(list[e.NewIndex]);
            }
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
        void LoadExam()
        {
            this.dgvExam.DataSource = null;
            this.dgvExam.DataSource = DAO.Exam.LoadExam();
            BindExamTxt();

        }
        void LoadExamTest()
        {

            if (this.dgvExamTest.DataSource == null)
            {
                this.dgvExamTest.DataSource = DAO.Exam.LoadExamTest();

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

        private void btnAddExamTest_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new AddExam(2), true);
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            var addForm = new AddExam(1);
            Router.ChangeForm(this, addForm, true);
            addForm.FormClosed += AddForm_FormClosed;
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadExam();
        }

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRemoveExamTest_Click(object sender, EventArgs e)
        {

        }

        private void dgvAllQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            if (_trackingExamList.Count > 0)
            {
                Exam.SaveChanges(_trackingExamList.OrderBy(exam => exam.IDKyThi).ToList());
                _trackingExamList.Clear();
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");
            }
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            var bl = this.dgvExam.DataSource as BindingList<KyThi>;
            var removeItem = bl.Where(exam => exam.IDKyThi == IdExam.Text).SingleOrDefault();
            try
            {
                Exam.delete(IdExam.Text);
                bl.Remove(removeItem);
                MessageBox.Show("Đã xóa thành công", "Thông báo");
            }
            catch(SqlException ex)
            {

                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
           
            //LoadExam();
            
        }
    }
}
