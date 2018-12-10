namespace ptudql_project.Teacher
{
    partial class TeacherMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.qlCauHoi = new System.Windows.Forms.TabPage();
            this.txtCauDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dgvAllQuest = new System.Windows.Forms.DataGridView();
            this.qlDeThi = new System.Windows.Forms.TabPage();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.cbbTestId = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.qlKyThiThu = new System.Windows.Forms.TabPage();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTimeStar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTypeExam = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameExam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDExam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoveExamTest = new System.Windows.Forms.Button();
            this.btnUpdateExamTest = new System.Windows.Forms.Button();
            this.btnAddExamTest = new System.Windows.Forms.Button();
            this.dgvExamTest = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.qlHocSinh = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.sidebarButton1 = new ptudql_project.CustomControls.SidebarButton();
            this.btnUser = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.qlKyThi = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.qlCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuest)).BeginInit();
            this.qlDeThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.qlKyThiThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTest)).BeginInit();
            this.qlHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.sidebarButton1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnThiThu);
            this.panel1.Controls.Add(this.btnLamBaiThi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.qlCauHoi);
            this.tabControl1.Controls.Add(this.qlDeThi);
            this.tabControl1.Controls.Add(this.qlKyThi);
            this.tabControl1.Controls.Add(this.qlKyThiThu);
            this.tabControl1.Controls.Add(this.qlHocSinh);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(200, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 657);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // qlCauHoi
            // 
            this.qlCauHoi.Controls.Add(this.txtCauDung);
            this.qlCauHoi.Controls.Add(this.label6);
            this.qlCauHoi.Controls.Add(this.label5);
            this.qlCauHoi.Controls.Add(this.label4);
            this.qlCauHoi.Controls.Add(this.label3);
            this.qlCauHoi.Controls.Add(this.label2);
            this.qlCauHoi.Controls.Add(this.label1);
            this.qlCauHoi.Controls.Add(this.txtA);
            this.qlCauHoi.Controls.Add(this.txtB);
            this.qlCauHoi.Controls.Add(this.txtC);
            this.qlCauHoi.Controls.Add(this.txtD);
            this.qlCauHoi.Controls.Add(this.txtNoiDung);
            this.qlCauHoi.Controls.Add(this.btnSaveChanges);
            this.qlCauHoi.Controls.Add(this.dgvAllQuest);
            this.qlCauHoi.Location = new System.Drawing.Point(4, 22);
            this.qlCauHoi.Name = "qlCauHoi";
            this.qlCauHoi.Padding = new System.Windows.Forms.Padding(3);
            this.qlCauHoi.Size = new System.Drawing.Size(917, 631);
            this.qlCauHoi.TabIndex = 0;
            this.qlCauHoi.Text = "Câu hỏi";
            this.qlCauHoi.UseVisualStyleBackColor = true;
            this.qlCauHoi.Click += new System.EventHandler(this.qlCauHoi_Click);
            // 
            // txtCauDung
            // 
            this.txtCauDung.Location = new System.Drawing.Point(713, 549);
            this.txtCauDung.MaxLength = 1;
            this.txtCauDung.Multiline = true;
            this.txtCauDung.Name = "txtCauDung";
            this.txtCauDung.Size = new System.Drawing.Size(52, 45);
            this.txtCauDung.TabIndex = 14;
            this.txtCauDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCauDung.TextChanged += new System.EventHandler(this.txtCauDung_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Câu Đúng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Câu D";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Câu C";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Câu B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Câu A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nội dung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(480, 477);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(184, 45);
            this.txtA.TabIndex = 7;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(713, 477);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(184, 45);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(252, 549);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(184, 45);
            this.txtC.TabIndex = 5;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(480, 549);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(184, 45);
            this.txtD.TabIndex = 4;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(26, 477);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(410, 45);
            this.txtNoiDung.TabIndex = 2;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(26, 549);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(184, 45);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Lưu thay đổi";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dgvAllQuest
            // 
            this.dgvAllQuest.AllowUserToAddRows = false;
            this.dgvAllQuest.AllowUserToDeleteRows = false;
            this.dgvAllQuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuest.Location = new System.Drawing.Point(26, 0);
            this.dgvAllQuest.Name = "dgvAllQuest";
            this.dgvAllQuest.ReadOnly = true;
            this.dgvAllQuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllQuest.Size = new System.Drawing.Size(883, 444);
            this.dgvAllQuest.TabIndex = 0;
            this.dgvAllQuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllQuest_CellContentClick);
            // 
            // qlDeThi
            // 
            this.qlDeThi.Controls.Add(this.btnDeleteTest);
            this.qlDeThi.Controls.Add(this.btnAddTest);
            this.qlDeThi.Controls.Add(this.dgvQuestions);
            this.qlDeThi.Controls.Add(this.cbbTestId);
            this.qlDeThi.Controls.Add(this.panel3);
            this.qlDeThi.Controls.Add(this.label10);
            this.qlDeThi.Location = new System.Drawing.Point(4, 22);
            this.qlDeThi.Name = "qlDeThi";
            this.qlDeThi.Padding = new System.Windows.Forms.Padding(3);
            this.qlDeThi.Size = new System.Drawing.Size(917, 631);
            this.qlDeThi.TabIndex = 1;
            this.qlDeThi.Text = "Đề thi";
            this.qlDeThi.UseVisualStyleBackColor = true;
            this.qlDeThi.Click += new System.EventHandler(this.qlDeThi_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(391, 548);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(144, 55);
            this.btnDeleteTest.TabIndex = 10;
            this.btnDeleteTest.Text = "button2";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(143, 548);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(144, 55);
            this.btnAddTest.TabIndex = 9;
            this.btnAddTest.Text = "Thêm đề thi mới";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(44, 122);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(603, 398);
            this.dgvQuestions.TabIndex = 8;
            this.dgvQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellContentClick);
            // 
            // cbbTestId
            // 
            this.cbbTestId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTestId.FormattingEnabled = true;
            this.cbbTestId.Location = new System.Drawing.Point(44, 81);
            this.cbbTestId.Name = "cbbTestId";
            this.cbbTestId.Size = new System.Drawing.Size(121, 21);
            this.cbbTestId.TabIndex = 7;
            this.cbbTestId.SelectedIndexChanged += new System.EventHandler(this.CbbTestId_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 3);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(385, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Đề thi";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // qlKyThiThu
            // 
            this.qlKyThiThu.Controls.Add(this.txtTimeEnd);
            this.qlKyThiThu.Controls.Add(this.label15);
            this.qlKyThiThu.Controls.Add(this.txtTimeStar);
            this.qlKyThiThu.Controls.Add(this.label14);
            this.qlKyThiThu.Controls.Add(this.txtTypeExam);
            this.qlKyThiThu.Controls.Add(this.label13);
            this.qlKyThiThu.Controls.Add(this.txtParticipants);
            this.qlKyThiThu.Controls.Add(this.label12);
            this.qlKyThiThu.Controls.Add(this.txtNameExam);
            this.qlKyThiThu.Controls.Add(this.label11);
            this.qlKyThiThu.Controls.Add(this.txtIDExam);
            this.qlKyThiThu.Controls.Add(this.label9);
            this.qlKyThiThu.Controls.Add(this.btnRemoveExamTest);
            this.qlKyThiThu.Controls.Add(this.btnUpdateExamTest);
            this.qlKyThiThu.Controls.Add(this.btnAddExamTest);
            this.qlKyThiThu.Controls.Add(this.dgvExamTest);
            this.qlKyThiThu.Controls.Add(this.panel2);
            this.qlKyThiThu.Controls.Add(this.label7);
            this.qlKyThiThu.Location = new System.Drawing.Point(4, 22);
            this.qlKyThiThu.Name = "qlKyThiThu";
            this.qlKyThiThu.Size = new System.Drawing.Size(917, 631);
            this.qlKyThiThu.TabIndex = 3;
            this.qlKyThiThu.Text = "Kỳ thi thử";
            this.qlKyThiThu.UseVisualStyleBackColor = true;
            this.qlKyThiThu.Click += new System.EventHandler(this.qlKyThiThu_Click);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEnd.Location = new System.Drawing.Point(703, 460);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(194, 24);
            this.txtTimeEnd.TabIndex = 43;
            this.txtTimeEnd.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(573, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 31);
            this.label15.TabIndex = 42;
            this.label15.Text = "Thời gian kết thúc";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtTimeStar
            // 
            this.txtTimeStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStar.Location = new System.Drawing.Point(703, 371);
            this.txtTimeStar.Name = "txtTimeStar";
            this.txtTimeStar.Size = new System.Drawing.Size(194, 24);
            this.txtTimeStar.TabIndex = 41;
            this.txtTimeStar.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(560, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 35);
            this.label14.TabIndex = 40;
            this.label14.Text = "Thời gian bắt đầu";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtTypeExam
            // 
            this.txtTypeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeExam.Location = new System.Drawing.Point(90, 461);
            this.txtTypeExam.Name = "txtTypeExam";
            this.txtTypeExam.ReadOnly = true;
            this.txtTypeExam.Size = new System.Drawing.Size(105, 24);
            this.txtTypeExam.TabIndex = 39;
            this.txtTypeExam.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Loại kỳ thi";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtParticipants
            // 
            this.txtParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipants.Location = new System.Drawing.Point(363, 461);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(175, 24);
            this.txtParticipants.TabIndex = 37;
            this.txtParticipants.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(232, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 47);
            this.label12.TabIndex = 36;
            this.label12.Text = "Số lượng tham gia";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtNameExam
            // 
            this.txtNameExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameExam.Location = new System.Drawing.Point(363, 371);
            this.txtNameExam.Name = "txtNameExam";
            this.txtNameExam.Size = new System.Drawing.Size(175, 24);
            this.txtNameExam.TabIndex = 35;
            this.txtNameExam.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tên  Kỳ Thi";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtIDExam
            // 
            this.txtIDExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDExam.Location = new System.Drawing.Point(90, 371);
            this.txtIDExam.Name = "txtIDExam";
            this.txtIDExam.Size = new System.Drawing.Size(105, 24);
            this.txtIDExam.TabIndex = 33;
            this.txtIDExam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "ID Kỳ Thi";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // btnRemoveExamTest
            // 
            this.btnRemoveExamTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnRemoveExamTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveExamTest.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExamTest.Location = new System.Drawing.Point(689, 541);
            this.btnRemoveExamTest.Name = "btnRemoveExamTest";
            this.btnRemoveExamTest.Size = new System.Drawing.Size(208, 49);
            this.btnRemoveExamTest.TabIndex = 31;
            this.btnRemoveExamTest.Text = "Xóa kỳ thi thử";
            this.btnRemoveExamTest.UseVisualStyleBackColor = false;
            this.btnRemoveExamTest.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateExamTest
            // 
            this.btnUpdateExamTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnUpdateExamTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExamTest.ForeColor = System.Drawing.Color.White;
            this.btnUpdateExamTest.Location = new System.Drawing.Point(351, 541);
            this.btnUpdateExamTest.Name = "btnUpdateExamTest";
            this.btnUpdateExamTest.Size = new System.Drawing.Size(208, 49);
            this.btnUpdateExamTest.TabIndex = 30;
            this.btnUpdateExamTest.Text = "Sửa kỳ thi thử";
            this.btnUpdateExamTest.UseVisualStyleBackColor = false;
            this.btnUpdateExamTest.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddExamTest
            // 
            this.btnAddExamTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnAddExamTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExamTest.ForeColor = System.Drawing.Color.White;
            this.btnAddExamTest.Location = new System.Drawing.Point(17, 541);
            this.btnAddExamTest.Name = "btnAddExamTest";
            this.btnAddExamTest.Size = new System.Drawing.Size(208, 49);
            this.btnAddExamTest.TabIndex = 29;
            this.btnAddExamTest.Text = "Thêm kỳ thi thử";
            this.btnAddExamTest.UseVisualStyleBackColor = false;
            this.btnAddExamTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvExamTest
            // 
            this.dgvExamTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamTest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExamTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamTest.Location = new System.Drawing.Point(5, 89);
            this.dgvExamTest.Name = "dgvExamTest";
            this.dgvExamTest.Size = new System.Drawing.Size(906, 247);
            this.dgvExamTest.TabIndex = 28;
            this.dgvExamTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 3);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label7.Location = new System.Drawing.Point(386, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kỳ thi thử";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // qlHocSinh
            // 
            this.qlHocSinh.Controls.Add(this.label8);
            this.qlHocSinh.Controls.Add(this.cbKyThi);
            this.qlHocSinh.Controls.Add(this.dgvHocSinh);
            this.qlHocSinh.Location = new System.Drawing.Point(4, 22);
            this.qlHocSinh.Name = "qlHocSinh";
            this.qlHocSinh.Size = new System.Drawing.Size(917, 631);
            this.qlHocSinh.TabIndex = 4;
            this.qlHocSinh.Text = "Học sinh";
            this.qlHocSinh.UseVisualStyleBackColor = true;
            this.qlHocSinh.Click += new System.EventHandler(this.qlHocSinh_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(464, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chọn kỳ thi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbKyThi
            // 
            this.cbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKyThi.FormattingEnabled = true;
            this.cbKyThi.Location = new System.Drawing.Point(630, 24);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(279, 24);
            this.cbKyThi.TabIndex = 3;
            this.cbKyThi.SelectedIndexChanged += new System.EventHandler(this.cbKyThi_SelectedIndexChanged);
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.GridColor = System.Drawing.Color.White;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 64);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(906, 559);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // sidebarButton1
            // 
            this.sidebarButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.sidebarButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebarButton1.CustomImage = ((System.Drawing.Image)(resources.GetObject("sidebarButton1.CustomImage")));
            this.sidebarButton1.LabelLocation = new System.Drawing.Point(30, 83);
            this.sidebarButton1.LabelText = "Thêm câu hỏi";
            this.sidebarButton1.Location = new System.Drawing.Point(0, 490);
            this.sidebarButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebarButton1.Name = "sidebarButton1";
            this.sidebarButton1.Size = new System.Drawing.Size(200, 110);
            this.sidebarButton1.TabIndex = 3;
            this.sidebarButton1.Load += new System.EventHandler(this.sidebarButton1_Load);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnUser.CustomImage")));
            this.btnUser.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnUser.LabelText = "Thông tin cá nhân";
            this.btnUser.Location = new System.Drawing.Point(0, 86);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(200, 110);
            this.btnUser.TabIndex = 2;
            this.btnUser.Load += new System.EventHandler(this.btnUser_Load);
            // 
            // btnThiThu
            // 
            this.btnThiThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThiThu.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.CustomImage")));
            this.btnThiThu.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnThiThu.LabelText = "Ôn luyện, thi thử";
            this.btnThiThu.Location = new System.Drawing.Point(0, 361);
            this.btnThiThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(200, 110);
            this.btnThiThu.TabIndex = 1;
            this.btnThiThu.Load += new System.EventHandler(this.btnThiThu_Load);
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnLamBaiThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamBaiThi.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnLamBaiThi.CustomImage")));
            this.btnLamBaiThi.LabelLocation = new System.Drawing.Point(20, 83);
            this.btnLamBaiThi.LabelText = "Làm bài trắc nghiệm";
            this.btnLamBaiThi.Location = new System.Drawing.Point(0, 221);
            this.btnLamBaiThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(200, 110);
            this.btnLamBaiThi.TabIndex = 0;
            this.btnLamBaiThi.Load += new System.EventHandler(this.btnLamBaiThi_Load);
            // 
            // qlKyThi
            // 
            this.qlKyThi.Location = new System.Drawing.Point(4, 22);
            this.qlKyThi.Name = "qlKyThi";
            this.qlKyThi.Size = new System.Drawing.Size(917, 631);
            this.qlKyThi.TabIndex = 2;
            this.qlKyThi.Text = "Kỳ thi";
            this.qlKyThi.UseVisualStyleBackColor = true;
            this.qlKyThi.Click += new System.EventHandler(this.qlKyThi_Click);
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherMain";
            this.Text = "TeacherMain";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.qlCauHoi.ResumeLayout(false);
            this.qlCauHoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuest)).EndInit();
            this.qlDeThi.ResumeLayout(false);
            this.qlDeThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.qlKyThiThu.ResumeLayout(false);
            this.qlKyThiThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTest)).EndInit();
            this.qlHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.SidebarButton sidebarButton1;
        private CustomControls.SidebarButton btnUser;
        private CustomControls.SidebarButton btnThiThu;
        private CustomControls.SidebarButton btnLamBaiThi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage qlCauHoi;
        private System.Windows.Forms.TabPage qlDeThi;
        private System.Windows.Forms.TabPage qlKyThiThu;
        private System.Windows.Forms.TabPage qlHocSinh;
        private System.Windows.Forms.ComboBox cbbTestId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvAllQuest;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCauDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKyThi;
        private System.Windows.Forms.DataGridView dgvExamTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveExamTest;
        private System.Windows.Forms.Button btnUpdateExamTest;
        private System.Windows.Forms.Button btnAddExamTest;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTimeStar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTypeExam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameExam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDExam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage qlKyThi;
    }
}