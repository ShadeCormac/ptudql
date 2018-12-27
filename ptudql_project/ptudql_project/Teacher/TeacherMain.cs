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

        private int _loaiKT = 1;
        private int LoaiKT
        {
            get { return _loaiKT; }
            set
            {
                _loaiKT = value;
                LoadExam();
            }
        }

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
            dtpTimeStart.DataBindings.Clear();
            dtpTimeEnd.DataBindings.Clear();
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

                txtNameExam.DataBindings.Add("Text", dgv, "TenKyThi", true, DataSourceUpdateMode.OnPropertyChanged);

                txtParticipants.DataBindings.Add("Text", dgv, "SLThamGia", true, DataSourceUpdateMode.OnPropertyChanged);

                txtTypeExam.DataBindings.Add("Text", dgv, "LoaiKyThi");

                dtpTimeStart.DataBindings.Add("Value", dgv, "ThoiGianBatDau", true, DataSourceUpdateMode.OnPropertyChanged);

                dtpTimeEnd.DataBindings.Add("Value", dgv, "ThoiGianKetThuc", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo");
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
            txtNoiDung.DataBindings.Add("Text", bl, "NoiDung", true, DataSourceUpdateMode.OnPropertyChanged);
            txtA.DataBindings.Add("Text", bl, "CauA", true, DataSourceUpdateMode.OnPropertyChanged);
            txtB.DataBindings.Add("Text", bl, "CauB", true, DataSourceUpdateMode.OnPropertyChanged);
            txtC.DataBindings.Add("Text", bl, "CauC", true, DataSourceUpdateMode.OnPropertyChanged);
            txtD.DataBindings.Add("Text", bl, "CauD", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCauDung.DataBindings.Add("Text", bl, "CauTLDung", true, DataSourceUpdateMode.OnPropertyChanged);
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
            this.dgvExam.DataSource = DAO.Exam.LoadExam(LoaiKT);
            BindExamTxt();
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
                this.cbKyThi.Items.Add("Tất cả");
                this.cbKyThi.SelectedIndex = 0;
                foreach (string exam in examList)
                {
                    this.cbKyThi.Items.Add(exam);
                }

                if (cbKyThi.SelectedItem == null || cbKyThi.SelectedItem.ToString() == "Tất cả")
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
            if (cbKyThi.SelectedItem.ToString() != "Tất cả")
            {
                this.dgvHocSinh.DataSource = DAO.Student.LoadListExamStudents(cbKyThi.SelectedItem.ToString());
            }
            else
            {

                this.dgvHocSinh.DataSource = DAO.Student.LoadStudent();
            }
        }
        
        private void btnAddExam_Click(object sender, EventArgs e)
        {
            var addForm = new AddExam();
            addForm.FormClosed += AddForm_FormClosed;
            Router.ShowFormDialog(this, addForm);
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadExam();
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
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa kỳ thi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
            {
                return;
            }
            var bl = this.dgvExam.DataSource as BindingList<KyThi>;
            var removeItem = bl.Where(exam => exam.IDKyThi == IdExam.Text).SingleOrDefault();
            try
            {
                if (!Exam.delete(IdExam.Text))
                {
                    MessageBox.Show("Không thể xóa kỳ thi đã có người thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bl.Remove(removeItem);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            BindExamTxt();
            LoadTests();
            LoadLoaiKT();
        }

        private void btnRemoveQuest_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa câu hỏi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
            {
                return;
            }
            try
            {
                int id;
                id = (int)dgvAllQuest.CurrentRow.Cells[0].Value;
                Question.Remove(id);
                MessageBox.Show("Xoá thành công");
                var lst = (dgvAllQuest.DataSource as BindingList<CauHoi>);
                lst.Remove(lst.Where(el => el.IdCauHoi == id).First());
            }
            catch (SqlException)
            {
                MessageBox.Show("Xoá không thành công");
            }
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
            var frmAddQuest = new RequestQuestion("Thêm câu hỏi");
            frmAddQuest.AddSuccess += FrmAddQuest_AddSuccess;
            Router.ShowFormDialog(this, frmAddQuest);
        }

        private void FrmAddQuest_AddSuccess(List<CauHoi> lstQuest)
        {
            var lst = dgvAllQuest.DataSource as BindingList<CauHoi>;
            foreach(var quest in lstQuest)
            {
                lst.Add(quest);
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa đề thi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
            {
                return;
            }
            try
            {
                if (!Test.Remove(cbbTestId.SelectedItem.ToString()))
                {
                    MessageBox.Show("Không thể xóa đề thi đã có người thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadTests();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int id, daDuyet;
            var row = dgvAllQuest.CurrentRow;

            DataGridViewCell idCell = row.Cells[0];
            DataGridViewCell daDuyetCell = row.Cells[8];
            
            int.TryParse(idCell.Value.ToString(), out id);
            int.TryParse(daDuyetCell.Value.ToString(), out daDuyet);

            if (daDuyet == 1)
            {
                MessageBox.Show($"Câu hỏi {id} đã được duyệt, không cần thực hiện lại", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            var rs = MessageBox.Show("Bạn có thực sự muốn duyệt câu hỏi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
            {
                return;
            }
            
            Question.Accept(id);
            MessageBox.Show("Duyệt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadQuestionsForm();
        }

        private void btnDetailsExam_Click(object sender, EventArgs e)
        {
            Router.ShowFormDialog(this, new DetailsExam(dgvExam.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
                Export export = new Export();
                var list = DAO.Question.GetAllQuestions().ToList();
                export.ExportQuestions(list);
                //Question.Import(list); 
                MessageBox.Show("Xuất thành công");      
        }

        private void btnStudentFeature_Click(object sender, EventArgs e)
        {
            Router.ChangeForm(this, new StudentInfo(), true);
        }

        private void txtCauDung_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            var ch = txt.Text.Length == 0 ? 'a' : txt.Text.ToLower().ToCharArray()[0];

            if (ch < 'a' || ch > 'd')
            {
                txt.Text = "a";
            }
        }


        private void LoadLoaiKT()
        {
            cbLoaiKyThi.Items.AddRange(new string[] { "Thi thật", "Thi thử" });
            cbLoaiKyThi.SelectedIndex = 0;
        }

        private void cbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiKT = cbLoaiKyThi.SelectedIndex + 1;
        }
    }
}
