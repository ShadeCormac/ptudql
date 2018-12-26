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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequestQuestion = new ptudql_project.CustomControls.SidebarButton();
            this.btnInfo = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabChooseContest = new System.Windows.Forms.TabPage();
            this.btnDoContest = new System.Windows.Forms.PictureBox();
            this.dgvListContest = new System.Windows.Forms.DataGridView();
            this.iDKyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbChooseContestTitle = new System.Windows.Forms.Label();
            this.tabTKKQ = new System.Windows.Forms.TabPage();
            this.danhSachThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbKyThiFilter = new System.Windows.Forms.Label();
            this.cbKyThiFilter = new System.Windows.Forms.ComboBox();
            this.dgvTKKQ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabChooseContest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).BeginInit();
            this.tabTKKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
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
            this.btnRequestQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.btnRequestQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestQuestion.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnRequestQuestion.CustomImage")));
            this.btnRequestQuestion.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnRequestQuestion.LabelText = "Đóng góp câu hỏi";
            this.btnRequestQuestion.Location = new System.Drawing.Point(0, 405);
            this.btnRequestQuestion.Name = "btnRequestQuestion";
            this.btnRequestQuestion.Size = new System.Drawing.Size(200, 110);
            this.btnRequestQuestion.TabIndex = 3;
            this.btnRequestQuestion.Tag = "RequestQuestion";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.CustomImage")));
            this.btnInfo.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnInfo.LabelText = "Thông tin cá nhân";
            this.btnInfo.Location = new System.Drawing.Point(0, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 110);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Tag = "Info";
            // 
            // btnThiThu
            // 
            this.btnThiThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(194)))));
            this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThiThu.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.CustomImage")));
            this.btnThiThu.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnThiThu.LabelText = "Ôn luyện, thi thử";
            this.btnThiThu.Location = new System.Drawing.Point(0, 276);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(200, 110);
            this.btnThiThu.TabIndex = 1;
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.btnLamBaiThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamBaiThi.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnLamBaiThi.CustomImage")));
            this.btnLamBaiThi.LabelLocation = new System.Drawing.Point(20, 83);
            this.btnLamBaiThi.LabelText = "Làm bài trắc nghiệm";
            this.btnLamBaiThi.Location = new System.Drawing.Point(0, 136);
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
            this.btnDoContest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoContest.Image = ((System.Drawing.Image)(resources.GetObject("btnDoContest.Image")));
            this.btnDoContest.Location = new System.Drawing.Point(748, 617);
            this.btnDoContest.Name = "btnDoContest";
            this.btnDoContest.Size = new System.Drawing.Size(300, 40);
            this.btnDoContest.TabIndex = 4;
            this.btnDoContest.TabStop = false;
            this.btnDoContest.Click += new System.EventHandler(this.btnDoContest_Click);
            // 
            // dgvListContest
            // 
            this.dgvListContest.AllowUserToAddRows = false;
            this.dgvListContest.AllowUserToDeleteRows = false;
            this.dgvListContest.AutoGenerateColumns = false;
            this.dgvListContest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListContest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dgvListContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKyThiDataGridViewTextBoxColumn,
            this.tenKyThiDataGridViewTextBoxColumn,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc});
            this.dgvListContest.DataSource = this.kyThiBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListContest.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListContest.Location = new System.Drawing.Point(38, 97);
            this.dgvListContest.Name = "dgvListContest";
            this.dgvListContest.ReadOnly = true;
            this.dgvListContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContest.Size = new System.Drawing.Size(1010, 504);
            this.dgvListContest.TabIndex = 2;
            this.dgvListContest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDoContest_Click);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(38, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 1);
            this.panel2.TabIndex = 1;
            // 
            // lbChooseContestTitle
            // 
            this.lbChooseContestTitle.AutoSize = true;
            this.lbChooseContestTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseContestTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.lbChooseContestTitle.Location = new System.Drawing.Point(32, 22);
            this.lbChooseContestTitle.Name = "lbChooseContestTitle";
            this.lbChooseContestTitle.Size = new System.Drawing.Size(242, 33);
            this.lbChooseContestTitle.TabIndex = 0;
            this.lbChooseContestTitle.Text = "Danh sách kỳ thi thử";
            // 
            // tabTKKQ
            // 
            this.tabTKKQ.Controls.Add(this.pictureBox9);
            this.tabTKKQ.Controls.Add(this.lbKyThiFilter);
            this.tabTKKQ.Controls.Add(this.cbKyThiFilter);
            this.tabTKKQ.Controls.Add(this.dgvTKKQ);
            this.tabTKKQ.Controls.Add(this.panel5);
            this.tabTKKQ.Controls.Add(this.label15);
            this.tabTKKQ.Controls.Add(this.pictureBox8);
            this.tabTKKQ.Location = new System.Drawing.Point(4, 39);
            this.tabTKKQ.Name = "tabTKKQ";
            this.tabTKKQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKKQ.Size = new System.Drawing.Size(1072, 677);
            this.tabTKKQ.TabIndex = 5;
            this.tabTKKQ.Text = "Thống kê kết quả";
            this.tabTKKQ.UseVisualStyleBackColor = true;
            // 
            // danhSachThiBindingSource
            // 
            this.danhSachThiBindingSource.DataSource = typeof(ptudql_project.DanhSachThi);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(785, 65);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(0, 0);
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // lbKyThiFilter
            // 
            this.lbKyThiFilter.AutoSize = true;
            this.lbKyThiFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKyThiFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.lbKyThiFilter.Location = new System.Drawing.Point(28, 99);
            this.lbKyThiFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKyThiFilter.Name = "lbKyThiFilter";
            this.lbKyThiFilter.Size = new System.Drawing.Size(60, 24);
            this.lbKyThiFilter.TabIndex = 18;
            this.lbKyThiFilter.Text = "Kỳ thi:";
            // 
            // cbKyThiFilter
            // 
            this.cbKyThiFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKyThiFilter.FormattingEnabled = true;
            this.cbKyThiFilter.Location = new System.Drawing.Point(112, 100);
            this.cbKyThiFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbKyThiFilter.Name = "cbKyThiFilter";
            this.cbKyThiFilter.Size = new System.Drawing.Size(270, 28);
            this.cbKyThiFilter.TabIndex = 17;
            // 
            // dgvTKKQ
            // 
            this.dgvTKKQ.AllowUserToAddRows = false;
            this.dgvTKKQ.AllowUserToDeleteRows = false;
            this.dgvTKKQ.AutoGenerateColumns = false;
            this.dgvTKKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKKQ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTKKQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTKKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idDeDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn});
            this.dgvTKKQ.DataSource = this.danhSachThiBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTKKQ.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTKKQ.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvTKKQ.Location = new System.Drawing.Point(33, 161);
            this.dgvTKKQ.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTKKQ.Name = "dgvTKKQ";
            this.dgvTKKQ.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTKKQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTKKQ.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTKKQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTKKQ.Size = new System.Drawing.Size(1022, 487);
            this.dgvTKKQ.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdKyThi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã kỳ thi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDeDataGridViewTextBoxColumn
            // 
            this.idDeDataGridViewTextBoxColumn.DataPropertyName = "IdDe";
            this.idDeDataGridViewTextBoxColumn.HeaderText = "Mã đề";
            this.idDeDataGridViewTextBoxColumn.Name = "idDeDataGridViewTextBoxColumn";
            this.idDeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel5.Location = new System.Drawing.Point(32, 70);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1022, 1);
            this.panel5.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label15.Location = new System.Drawing.Point(27, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 31);
            this.label15.TabIndex = 15;
            this.label15.Text = "Kết quả học tập";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ptudql_project.Properties.Resources.TextBox;
            this.pictureBox8.Location = new System.Drawing.Point(96, 94);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(300, 40);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnDoContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).EndInit();
            this.tabTKKQ.ResumeLayout(false);
            this.tabTKKQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvListContest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChooseContestTitle;
        private System.Windows.Forms.BindingSource kyThiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.TabPage tabTKKQ;
        private System.Windows.Forms.BindingSource danhSachThiBindingSource;
        private System.Windows.Forms.PictureBox btnDoContest;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbKyThiFilter;
        private System.Windows.Forms.ComboBox cbKyThiFilter;
        private System.Windows.Forms.DataGridView dgvTKKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}