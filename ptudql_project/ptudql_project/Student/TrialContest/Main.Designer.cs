namespace ptudql_project.Student
{
    partial class StudentTrialContest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTrialContest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequestQuestion = new ptudql_project.CustomControls.SidebarButton();
            this.btnInfo = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabChooseContest = new System.Windows.Forms.TabPage();
            this.btnDoContest = new System.Windows.Forms.Button();
            this.dgvListContest = new System.Windows.Forms.DataGridView();
            this.iDKyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbChooseContestTitle = new System.Windows.Forms.Label();
            this.tabTKKQ = new System.Windows.Forms.TabPage();
            this.lbKyThiFilter = new System.Windows.Forms.Label();
            this.cbKyThiFilter = new System.Windows.Forms.ComboBox();
            this.dgvTKKQ = new System.Windows.Forms.DataGridView();
            this.idKyThiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTKKQ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabChooseContest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).BeginInit();
            this.tabTKKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnRequestQuestion);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnThiThu);
            this.panel1.Controls.Add(this.btnLamBaiThi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 2;
            // 
            // btnRequestQuestion
            // 
            this.btnRequestQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnRequestQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestQuestion.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnRequestQuestion.CustomImage")));
            this.btnRequestQuestion.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnRequestQuestion.LabelText = "Đóng góp câu hỏi";
            this.btnRequestQuestion.Location = new System.Drawing.Point(0, 490);
            this.btnRequestQuestion.Name = "btnRequestQuestion";
            this.btnRequestQuestion.Size = new System.Drawing.Size(200, 110);
            this.btnRequestQuestion.TabIndex = 3;
            this.btnRequestQuestion.Tag = "RequestQuestion";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.CustomImage")));
            this.btnInfo.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnInfo.LabelText = "Thông tin cá nhân";
            this.btnInfo.Location = new System.Drawing.Point(0, 86);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 110);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Tag = "Info";
            // 
            // btnThiThu
            // 
            this.btnThiThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThiThu.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.CustomImage")));
            this.btnThiThu.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnThiThu.LabelText = "Ôn luyện, thi thử";
            this.btnThiThu.Location = new System.Drawing.Point(0, 361);
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
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(200, 110);
            this.btnLamBaiThi.TabIndex = 0;
            this.btnLamBaiThi.Tag = "Contest";
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabChooseContest);
            this.tabForms.Controls.Add(this.tabTKKQ);
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForms.ItemSize = new System.Drawing.Size(117, 35);
            this.tabForms.Location = new System.Drawing.Point(200, 0);
            this.tabForms.Name = "tabForms";
            this.tabForms.Padding = new System.Drawing.Point(20, 5);
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1080, 720);
            this.tabForms.TabIndex = 3;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // tabChooseContest
            // 
            this.tabChooseContest.Controls.Add(this.btnDoContest);
            this.tabChooseContest.Controls.Add(this.dgvListContest);
            this.tabChooseContest.Controls.Add(this.panel2);
            this.tabChooseContest.Controls.Add(this.lbChooseContestTitle);
            this.tabChooseContest.Location = new System.Drawing.Point(4, 39);
            this.tabChooseContest.Name = "tabChooseContest";
            this.tabChooseContest.Padding = new System.Windows.Forms.Padding(3);
            this.tabChooseContest.Size = new System.Drawing.Size(1072, 677);
            this.tabChooseContest.TabIndex = 4;
            this.tabChooseContest.Text = "Chọn kỳ thi";
            this.tabChooseContest.UseVisualStyleBackColor = true;
            // 
            // btnDoContest
            // 
            this.btnDoContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnDoContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoContest.ForeColor = System.Drawing.Color.White;
            this.btnDoContest.Location = new System.Drawing.Point(870, 607);
            this.btnDoContest.Name = "btnDoContest";
            this.btnDoContest.Size = new System.Drawing.Size(178, 52);
            this.btnDoContest.TabIndex = 22;
            this.btnDoContest.Text = "Làm bài thi";
            this.btnDoContest.UseVisualStyleBackColor = false;
            this.btnDoContest.Click += new System.EventHandler(this.btnDoContest_Click);
            // 
            // dgvListContest
            // 
            this.dgvListContest.AllowUserToAddRows = false;
            this.dgvListContest.AllowUserToDeleteRows = false;
            this.dgvListContest.AutoGenerateColumns = false;
            this.dgvListContest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKyThiDataGridViewTextBoxColumn,
            this.tenKyThiDataGridViewTextBoxColumn,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc});
            this.dgvListContest.DataSource = this.kyThiBindingSource;
            this.dgvListContest.Location = new System.Drawing.Point(38, 97);
            this.dgvListContest.Name = "dgvListContest";
            this.dgvListContest.ReadOnly = true;
            this.dgvListContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContest.Size = new System.Drawing.Size(1010, 504);
            this.dgvListContest.TabIndex = 2;
            this.dgvListContest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDoContest_Click);
            // 
            // iDKyThiDataGridViewTextBoxColumn
            // 
            this.iDKyThiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDKyThiDataGridViewTextBoxColumn.DataPropertyName = "IDKyThi";
            this.iDKyThiDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.iDKyThiDataGridViewTextBoxColumn.HeaderText = "Mã kỳ thi";
            this.iDKyThiDataGridViewTextBoxColumn.Name = "iDKyThiDataGridViewTextBoxColumn";
            this.iDKyThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKyThiDataGridViewTextBoxColumn
            // 
            this.tenKyThiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKyThiDataGridViewTextBoxColumn.DataPropertyName = "TenKyThi";
            this.tenKyThiDataGridViewTextBoxColumn.FillWeight = 0.3913102F;
            this.tenKyThiDataGridViewTextBoxColumn.HeaderText = "Tên kỳ thi";
            this.tenKyThiDataGridViewTextBoxColumn.Name = "tenKyThiDataGridViewTextBoxColumn";
            this.tenKyThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.FillWeight = 14.24369F;
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.ReadOnly = true;
            this.ThoiGianBatDau.Width = 200;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.FillWeight = 182.3193F;
            this.ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.ReadOnly = true;
            this.ThoiGianKetThuc.Width = 200;
            // 
            // kyThiBindingSource
            // 
            this.kyThiBindingSource.DataSource = typeof(ptudql_project.KyThi);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(38, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 1);
            this.panel2.TabIndex = 1;
            // 
            // lbChooseContestTitle
            // 
            this.lbChooseContestTitle.AutoSize = true;
            this.lbChooseContestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseContestTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbChooseContestTitle.Location = new System.Drawing.Point(407, 21);
            this.lbChooseContestTitle.Name = "lbChooseContestTitle";
            this.lbChooseContestTitle.Size = new System.Drawing.Size(260, 31);
            this.lbChooseContestTitle.TabIndex = 0;
            this.lbChooseContestTitle.Text = "Danh sách kỳ thi thử";
            // 
            // tabTKKQ
            // 
            this.tabTKKQ.Controls.Add(this.lbKyThiFilter);
            this.tabTKKQ.Controls.Add(this.cbKyThiFilter);
            this.tabTKKQ.Controls.Add(this.dgvTKKQ);
            this.tabTKKQ.Controls.Add(this.panel5);
            this.tabTKKQ.Controls.Add(this.lbTKKQ);
            this.tabTKKQ.Location = new System.Drawing.Point(4, 39);
            this.tabTKKQ.Name = "tabTKKQ";
            this.tabTKKQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKKQ.Size = new System.Drawing.Size(1072, 677);
            this.tabTKKQ.TabIndex = 5;
            this.tabTKKQ.Text = "Thống kê kết quả";
            this.tabTKKQ.UseVisualStyleBackColor = true;
            // 
            // lbKyThiFilter
            // 
            this.lbKyThiFilter.AutoSize = true;
            this.lbKyThiFilter.Location = new System.Drawing.Point(38, 130);
            this.lbKyThiFilter.Name = "lbKyThiFilter";
            this.lbKyThiFilter.Size = new System.Drawing.Size(51, 20);
            this.lbKyThiFilter.TabIndex = 16;
            this.lbKyThiFilter.Text = "Kỳ thi:";
            // 
            // cbKyThiFilter
            // 
            this.cbKyThiFilter.FormattingEnabled = true;
            this.cbKyThiFilter.Location = new System.Drawing.Point(107, 127);
            this.cbKyThiFilter.Name = "cbKyThiFilter";
            this.cbKyThiFilter.Size = new System.Drawing.Size(242, 28);
            this.cbKyThiFilter.TabIndex = 15;
            this.cbKyThiFilter.SelectedIndexChanged += new System.EventHandler(this.cbKyThiFilter_SelectedIndexChanged);
            // 
            // dgvTKKQ
            // 
            this.dgvTKKQ.AllowUserToAddRows = false;
            this.dgvTKKQ.AllowUserToDeleteRows = false;
            this.dgvTKKQ.AutoGenerateColumns = false;
            this.dgvTKKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKyThiDataGridViewTextBoxColumn1,
            this.idDeDataGridViewTextBoxColumn,
            this.lanThiDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn});
            this.dgvTKKQ.DataSource = this.danhSachThiBindingSource;
            this.dgvTKKQ.Location = new System.Drawing.Point(42, 179);
            this.dgvTKKQ.Name = "dgvTKKQ";
            this.dgvTKKQ.ReadOnly = true;
            this.dgvTKKQ.Size = new System.Drawing.Size(993, 447);
            this.dgvTKKQ.TabIndex = 14;
            // 
            // idKyThiDataGridViewTextBoxColumn1
            // 
            this.idKyThiDataGridViewTextBoxColumn1.DataPropertyName = "IdKyThi";
            this.idKyThiDataGridViewTextBoxColumn1.HeaderText = "Mã kỳ thi";
            this.idKyThiDataGridViewTextBoxColumn1.Name = "idKyThiDataGridViewTextBoxColumn1";
            this.idKyThiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDeDataGridViewTextBoxColumn
            // 
            this.idDeDataGridViewTextBoxColumn.DataPropertyName = "IdDe";
            this.idDeDataGridViewTextBoxColumn.HeaderText = "Mã đề";
            this.idDeDataGridViewTextBoxColumn.Name = "idDeDataGridViewTextBoxColumn";
            this.idDeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lanThiDataGridViewTextBoxColumn
            // 
            this.lanThiDataGridViewTextBoxColumn.DataPropertyName = "LanThi";
            this.lanThiDataGridViewTextBoxColumn.HeaderText = "Lần thi";
            this.lanThiDataGridViewTextBoxColumn.Name = "lanThiDataGridViewTextBoxColumn";
            this.lanThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danhSachThiBindingSource
            // 
            this.danhSachThiBindingSource.DataSource = typeof(ptudql_project.DanhSachThi);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel5.Location = new System.Drawing.Point(42, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(993, 1);
            this.panel5.TabIndex = 12;
            // 
            // lbTKKQ
            // 
            this.lbTKKQ.AutoSize = true;
            this.lbTKKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKKQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.lbTKKQ.Location = new System.Drawing.Point(388, 47);
            this.lbTKKQ.Name = "lbTKKQ";
            this.lbTKKQ.Size = new System.Drawing.Size(223, 31);
            this.lbTKKQ.TabIndex = 13;
            this.lbTKKQ.Text = "Thống kê kết quả";
            // 
            // StudentTrialContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.panel1);
            this.Name = "StudentTrialContest";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.tabForms.ResumeLayout(false);
            this.tabChooseContest.ResumeLayout(false);
            this.tabChooseContest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).EndInit();
            this.tabTKKQ.ResumeLayout(false);
            this.tabTKKQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.SidebarButton btnRequestQuestion;
        private CustomControls.SidebarButton btnInfo;
        private CustomControls.SidebarButton btnThiThu;
        private CustomControls.SidebarButton btnLamBaiThi;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.TabPage tabChooseContest;
        private System.Windows.Forms.Button btnDoContest;
        private System.Windows.Forms.DataGridView dgvListContest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChooseContestTitle;
        private System.Windows.Forms.BindingSource kyThiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.TabPage tabTKKQ;
        private System.Windows.Forms.Label lbKyThiFilter;
        private System.Windows.Forms.ComboBox cbKyThiFilter;
        private System.Windows.Forms.DataGridView dgvTKKQ;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTKKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKyThiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource danhSachThiBindingSource;
    }
}