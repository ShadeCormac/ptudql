namespace ptudql_project.Student
{
    partial class StudentContest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentContest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequestQuestion = new ptudql_project.CustomControls.SidebarButton();
            this.btnInfo = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabChooseContest = new System.Windows.Forms.TabPage();
            this.btnDoContest = new System.Windows.Forms.PictureBox();
            this.dgvListContest = new System.Windows.Forms.DataGridView();
            this.IDKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKyThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbChooseContestTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabChooseContest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // btnRequestQuestion
            // 
            this.btnRequestQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.btnRequestQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestQuestion.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnRequestQuestion.CustomImage")));
            this.btnRequestQuestion.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnRequestQuestion.LabelText = "Đóng góp câu hỏi";
            this.btnRequestQuestion.Location = new System.Drawing.Point(0, 403);
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
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 110);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Tag = "Info";
            // 
            // btnThiThu
            // 
            this.btnThiThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThiThu.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.CustomImage")));
            this.btnThiThu.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnThiThu.LabelText = "Ôn luyện, thi thử";
            this.btnThiThu.Location = new System.Drawing.Point(0, 274);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(200, 110);
            this.btnThiThu.TabIndex = 1;
            this.btnThiThu.Tag = "TrialContest";
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(194)))));
            this.btnLamBaiThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamBaiThi.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnLamBaiThi.CustomImage")));
            this.btnLamBaiThi.LabelLocation = new System.Drawing.Point(20, 83);
            this.btnLamBaiThi.LabelText = "Làm bài trắc nghiệm";
            this.btnLamBaiThi.Location = new System.Drawing.Point(0, 134);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(200, 110);
            this.btnLamBaiThi.TabIndex = 0;
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabChooseContest);
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForms.ItemSize = new System.Drawing.Size(117, 35);
            this.tabForms.Location = new System.Drawing.Point(200, 0);
            this.tabForms.Name = "tabForms";
            this.tabForms.Padding = new System.Drawing.Point(20, 5);
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1080, 720);
            this.tabForms.TabIndex = 2;
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
            this.btnDoContest.TabIndex = 3;
            this.btnDoContest.TabStop = false;
            this.btnDoContest.Click += new System.EventHandler(this.btnDoContest_Click);
            // 
            // dgvListContest
            // 
            this.dgvListContest.AllowUserToAddRows = false;
            this.dgvListContest.AllowUserToDeleteRows = false;
            this.dgvListContest.AutoGenerateColumns = false;
            this.dgvListContest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListContest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListContest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKyThi,
            this.tenKyThiDataGridViewTextBoxColumn,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc});
            this.dgvListContest.DataSource = this.kyThiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListContest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListContest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dgvListContest.Location = new System.Drawing.Point(38, 97);
            this.dgvListContest.Name = "dgvListContest";
            this.dgvListContest.ReadOnly = true;
            this.dgvListContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListContest.Size = new System.Drawing.Size(1010, 504);
            this.dgvListContest.TabIndex = 2;
            this.dgvListContest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnDoContest_Click);
            // 
            // IDKyThi
            // 
            this.IDKyThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDKyThi.DataPropertyName = "IDKyThi";
            this.IDKyThi.HeaderText = "Mã kỳ thi";
            this.IDKyThi.Name = "IDKyThi";
            this.IDKyThi.ReadOnly = true;
            // 
            // tenKyThiDataGridViewTextBoxColumn
            // 
            this.tenKyThiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKyThiDataGridViewTextBoxColumn.DataPropertyName = "TenKyThi";
            this.tenKyThiDataGridViewTextBoxColumn.FillWeight = 19.48051F;
            this.tenKyThiDataGridViewTextBoxColumn.HeaderText = "Tên kỳ thi";
            this.tenKyThiDataGridViewTextBoxColumn.Name = "tenKyThiDataGridViewTextBoxColumn";
            this.tenKyThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.ReadOnly = true;
            this.ThoiGianBatDau.Width = 200;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
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
            this.lbChooseContestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseContestTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(194)))));
            this.lbChooseContestTitle.Location = new System.Drawing.Point(32, 23);
            this.lbChooseContestTitle.Name = "lbChooseContestTitle";
            this.lbChooseContestTitle.Size = new System.Drawing.Size(257, 31);
            this.lbChooseContestTitle.TabIndex = 0;
            this.lbChooseContestTitle.Text = "Kỳ thi đang diễn ra";
            // 
            // StudentContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.panel1);
            this.Name = "StudentContest";
            this.Text = "StudentContest";
            this.panel1.ResumeLayout(false);
            this.tabForms.ResumeLayout(false);
            this.tabChooseContest.ResumeLayout(false);
            this.tabChooseContest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListContest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChooseContestTitle;
        private System.Windows.Forms.DataGridView dgvListContest;
        private System.Windows.Forms.BindingSource kyThiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKyThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.PictureBox btnDoContest;
    }
}