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
            this.qlKyThi = new System.Windows.Forms.TabPage();
            this.qlKyThiThu = new System.Windows.Forms.TabPage();
            this.qlHocSinh = new System.Windows.Forms.TabPage();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.sidebarButton1 = new ptudql_project.CustomControls.SidebarButton();
            this.btnUser = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.qlCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuest)).BeginInit();
            this.qlDeThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
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
            // 
            // txtCauDung
            // 
            this.txtCauDung.Location = new System.Drawing.Point(725, 477);
            this.txtCauDung.MaxLength = 1;
            this.txtCauDung.Multiline = true;
            this.txtCauDung.Name = "txtCauDung";
            this.txtCauDung.Size = new System.Drawing.Size(52, 45);
            this.txtCauDung.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Câu Đúng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Câu D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Câu C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Câu B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Câu A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nội dung";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(272, 477);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(184, 45);
            this.txtA.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(505, 477);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(184, 45);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(272, 549);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(184, 45);
            this.txtC.TabIndex = 5;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(505, 549);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(184, 45);
            this.txtD.TabIndex = 4;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(26, 477);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(184, 45);
            this.txtNoiDung.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(66, 549);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 31);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Lưu thay đổi";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
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
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(391, 548);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(144, 55);
            this.btnDeleteTest.TabIndex = 10;
            this.btnDeleteTest.Text = "button2";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
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
            // 
            // qlKyThi
            // 
            this.qlKyThi.Location = new System.Drawing.Point(4, 22);
            this.qlKyThi.Name = "qlKyThi";
            this.qlKyThi.Size = new System.Drawing.Size(917, 631);
            this.qlKyThi.TabIndex = 2;
            this.qlKyThi.Text = "Kỳ thi";
            this.qlKyThi.UseVisualStyleBackColor = true;
            // 
            // qlKyThiThu
            // 
            this.qlKyThiThu.Location = new System.Drawing.Point(4, 22);
            this.qlKyThiThu.Name = "qlKyThiThu";
            this.qlKyThiThu.Size = new System.Drawing.Size(917, 631);
            this.qlKyThiThu.TabIndex = 3;
            this.qlKyThiThu.Text = "Kỳ thi thử";
            this.qlKyThiThu.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage qlKyThi;
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
    }
}