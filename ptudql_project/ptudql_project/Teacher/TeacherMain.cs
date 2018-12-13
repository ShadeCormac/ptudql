using ptudql_project.DAO;
using ptudql_project.Student;
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

        }

        private void UnbindExamTxt()
        {
            IdExam.DataBindings.Clear();
            txtNameExam.DataBindings.Clear();
            txtParticipants.DataBindings.Clear();
            txtTypeExam.DataBindings.Clear();
            txtTimeStart.DataBindings.Clear();
            txtTimeEnd.DataBindings.Clear();

        }

        private void UnbindTestExamTxt()
        {
            IDExamTest.DataBindings.Clear();
            txtNameExamTest.DataBindings.Clear();
            txtParicipantsTest.DataBindings.Clear();
            txtTypeExamTest.DataBindings.Clear();
            txtTimeStartTest.DataBindings.Clear();
            txtTimeEndTest.DataBindings.Clear();
        }

        private void BindExamTxt()
        {
            try
            {
                UnbindExamTxt();
                //dgvExam.DataBindings.Clear();
                var dgv = dgvExam.DataSource as BindingList<KyThi>;

                dgv.ListChanged += Dgv_ListChanged;

                IdExam.DataBindings.Add("Text", dgv, "IDKyThi");

                txtNameExam.DataBindings.Add("Text", dgv, "TenKyThi");

                txtParticipants.DataBindings.Add("Text", dgv, "SLThamGia", true);

                txtTypeExam.DataBindings.Add("Text", dgv, "LoaiKyThi", true);

                txtTimeStart.DataBindings.Add("Text", dgv, "ThoiGianBatDau", true);

                txtTimeEnd.DataBindings.Add("Text", dgv, "ThoiGianKetThuc", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }



        private void BindTestExamTxt()
        {
            try
            {
                dgvExamTest.DataBindings.Clear();
                var dgv = dgvExamTest.DataSource as BindingList<KyThi>;
                dgv.ListChanged += Dgv_ListChanged1;
                UnbindTestExamTxt();

                IDExamTest.DataBindings.Add("Text", dgv, "IDKyThi");

                txtNameExamTest.DataBindings.Add("Text", dgv, "TenKyThi");

                txtParicipantsTest.DataBindings.Add("Text", dgv, "SLThamGia", true);

                txtTypeExamTest.DataBindings.Add("Text", dgv, "LoaiKyThi", true);

                txtTimeStartTest.DataBindings.Add("Text", dgv, "ThoiGianBatDau", true);

                txtTimeEndTest.DataBindings.Add("Text", dgv, "ThoiGianKetThuc", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
        private void Dgv_ListChanged1(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                var list = this.dgvExamTest.DataSource as BindingList<KyThi>;
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
            var bl = dgvAllQuest.DataSource as BindingList<CauHoi>;
            txtQuestId.DataBindings.Add("Text", bl, "IdCauHoi");
            txtNoiDung.DataBindings.Add("Text", bl, "NoiDung");
            txtA.DataBindings.Add("Text", bl, "CauA");
            txtB.DataBindings.Add("Text", bl, "CauB");
            txtC.DataBindings.Add("Text", bl, "CauC");
            txtD.DataBindings.Add("Text", bl, "CauD");
            txtCauDung.DataBindings.Add("Text", bl, "CauTLDung");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadQuestionsForm()
        {

            {
                var data = Question.GetAllQuestions();
                data.ListChanged += Data_ListChanged;

                this.dgvAllQuest.DataSource = data;
            }

        }
        void LoadExam()
        {
            this.dgvExam.DataSource = DAO.Exam.LoadExam();
            BindExamTxt();
        }

        void LoadExamTest()
        {
            this.dgvExamTest.DataSource = DAO.Exam.LoadExamTest();
            BindTestExamTxt();
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
                if (!_trackingList.Contains(list[e.NewIndex]))
                    _trackingList.Add(list[e.NewIndex]);
            }
        }


        private void CbbTestId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load lai ds cac cau hoi cua de thi
            this.dgvQuestions.DataSource = Test.loadQuestions(cbbTestId.SelectedValue.ToString());
        }


        private void btnAddTest_Click(object sender, EventArgs e)
        {
            var addForm = new AddTest();
            addForm.FormClosed += AddForm_FormClosed1;
            Router.ChangeForm(this, addForm, true);

        }

        private void AddForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            LoadTests();
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
            var addForm = new AddExam(2);
            Router.ChangeForm(this, addForm, true);
            addForm.FormClosed += AddForm1_FormClosed;
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
        private void AddForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadExamTest();
        }


        private void btnRemoveExamTest_Click(object sender, EventArgs e)
        {
            var bl = this.dgvExamTest.DataSource as BindingList<KyThi>;
            var removeItem = bl.Where(Exam => Exam.IDKyThi == IDExamTest.Text).SingleOrDefault();
            try
            {
                Exam.delete(IdExam.Text);
                bl.Remove(removeItem);
                MessageBox.Show("Đã xóa thành công", "Thông báo");
            }
            catch (SqlException)
            {

                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
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
            catch (SqlException)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }

        }

        private void btnUpdateExamTest_Click(object sender, EventArgs e)
        {
            if (_trackingExamList.Count > 0)
            {
                Exam.SaveChanges(_trackingExamList.OrderBy(exam => exam.IDKyThi).ToList());
                _trackingExamList.Clear();
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");
            }
        }

        private void TeacherMain_Load(object sender, EventArgs e)
        {
            LoadQuestionsForm();
            BindTxt();
            //LoadStudentRecords();
            LoadListExam();
            LoadExam();
            LoadExamTest();
            BindExamTxt();
            BindTestExamTxt();
            LoadTests();

        }

        private void btnRemoveQuest_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                foreach (DataGridViewRow row in this.dgvAllQuest.SelectedRows)
                {
                    id = (int)row.Cells["IdCauHoi"].Value;
                    Question.Remove(id);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Xoá không thành công");
            }
            MessageBox.Show("Xoá thành công");
            LoadQuestionsForm();
        }

        private void LoadTests()
        {

            {
                this.cbbTestId.DataSource = Test.getAllTestId();
                if (this.cbbTestId.Items.Count != 0)
                    this.dgvQuestions.DataSource = Test.loadQuestions(this.cbbTestId.SelectedItem.ToString());
                else this.dgvQuestions.DataSource = null;
            }

        }
        

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new RequestQuestion("Thêm câu hỏi"), true);
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new RequestQuestion("Thêm câu hỏi"), true);
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new StudentContest(), true);
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            try
            {
                Test.Remove(cbbTestId.SelectedItem.ToString());
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadTests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            var addForm = new AddTest(this.cbbTestId.SelectedItem.ToString());
            addForm.FormClosed += AddForm_FormClosed1;
            Router.ChangeForm(this, addForm, true);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new FilterQuestion(), true);
        }

        private void btnDetailsExam_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new DetailsExam(dgvExam.CurrentRow.Cells["IDKyThi"].Value.ToString()),true);
        }
    }
}
