namespace ptudql_project.Admin
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ofdImportStudent = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new ptudql_project.CustomControls.SidebarButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAccountManager = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.PictureBox();
            this.btnExportExcel = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtvAdmin = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteConnection = new System.Windows.Forms.PictureBox();
            this.btnChangeConnection = new System.Windows.Forms.PictureBox();
            this.btnAddConnection = new System.Windows.Forms.PictureBox();
            this.btnDeleteConection = new ptudql_project.CustomControls.MyButton();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAccountManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImportStudent
            // 
            this.ofdImportStudent.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 690);
            this.panel1.TabIndex = 37;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(194)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnHome.CustomImage")));
            this.btnHome.LabelLocation = new System.Drawing.Point(55, 83);
            this.btnHome.LabelText = "Trang chủ";
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 110);
            this.btnHome.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAccountManager);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(200, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(20, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1080, 690);
            this.tabControl.TabIndex = 38;
            // 
            // tabAccountManager
            // 
            this.tabAccountManager.Controls.Add(this.btnImport);
            this.tabAccountManager.Controls.Add(this.btnAddUser);
            this.tabAccountManager.Controls.Add(this.btnChange);
            this.tabAccountManager.Controls.Add(this.btnExportExcel);
            this.tabAccountManager.Controls.Add(this.label10);
            this.tabAccountManager.Controls.Add(this.panel3);
            this.tabAccountManager.Controls.Add(this.dtvAdmin);
            this.tabAccountManager.Controls.Add(this.label3);
            this.tabAccountManager.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccountManager.Location = new System.Drawing.Point(4, 42);
            this.tabAccountManager.Name = "tabAccountManager";
            this.tabAccountManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountManager.Size = new System.Drawing.Size(1072, 644);
            this.tabAccountManager.TabIndex = 0;
            this.tabAccountManager.Text = "Quản lý tài khoản";
            this.tabAccountManager.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(750, 250);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(300, 40);
            this.btnImport.TabIndex = 55;
            this.btnImport.TabStop = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(750, 104);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(300, 40);
            this.btnAddUser.TabIndex = 54;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnChange
            // 
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(750, 177);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(300, 40);
            this.btnChange.TabIndex = 53;
            this.btnChange.TabStop = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(750, 323);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(300, 40);
            this.btnExportExcel.TabIndex = 52;
            this.btnExportExcel.TabStop = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label10.Location = new System.Drawing.Point(17, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 31);
            this.label10.TabIndex = 47;
            this.label10.Text = "Quản lý tài khoản";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel3.Location = new System.Drawing.Point(27, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 1);
            this.panel3.TabIndex = 46;
            // 
            // dtvAdmin
            // 
            this.dtvAdmin.AllowUserToAddRows = false;
            this.dtvAdmin.AllowUserToDeleteRows = false;
            this.dtvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dtvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.Column2,
            this.PhanQuyen,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvAdmin.Location = new System.Drawing.Point(27, 104);
            this.dtvAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dtvAdmin.MultiSelect = false;
            this.dtvAdmin.Name = "dtvAdmin";
            this.dtvAdmin.ReadOnly = true;
            this.dtvAdmin.RowTemplate.Height = 28;
            this.dtvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvAdmin.Size = new System.Drawing.Size(696, 505);
            this.dtvAdmin.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteConnection);
            this.tabPage2.Controls.Add(this.btnChangeConnection);
            this.tabPage2.Controls.Add(this.btnAddConnection);
            this.tabPage2.Controls.Add(this.btnDeleteConection);
            this.tabPage2.Controls.Add(this.dgvConnections);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý kết nối CSDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteConnection
            // 
            this.btnDeleteConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteConnection.Image")));
            this.btnDeleteConnection.Location = new System.Drawing.Point(746, 577);
            this.btnDeleteConnection.Name = "btnDeleteConnection";
            this.btnDeleteConnection.Size = new System.Drawing.Size(300, 40);
            this.btnDeleteConnection.TabIndex = 11;
            this.btnDeleteConnection.TabStop = false;
            this.btnDeleteConnection.Click += new System.EventHandler(this.btnDeleteConection_Click);
            // 
            // btnChangeConnection
            // 
            this.btnChangeConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeConnection.Image")));
            this.btnChangeConnection.Location = new System.Drawing.Point(396, 577);
            this.btnChangeConnection.Name = "btnChangeConnection";
            this.btnChangeConnection.Size = new System.Drawing.Size(300, 40);
            this.btnChangeConnection.TabIndex = 10;
            this.btnChangeConnection.TabStop = false;
            this.btnChangeConnection.Click += new System.EventHandler(this.btnChangeConnection_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnAddConnection.Image")));
            this.btnAddConnection.Location = new System.Drawing.Point(22, 577);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(300, 40);
            this.btnAddConnection.TabIndex = 9;
            this.btnAddConnection.TabStop = false;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // btnDeleteConection
            // 
            this.btnDeleteConection.Location = new System.Drawing.Point(45, 859);
            this.btnDeleteConection.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteConection.MyLabel = "Xoá Connection";
            this.btnDeleteConection.MyLabelLocation = new System.Drawing.Point(369, 69);
            this.btnDeleteConection.Name = "btnDeleteConection";
            this.btnDeleteConection.Size = new System.Drawing.Size(400, 58);
            this.btnDeleteConection.TabIndex = 8;
            this.btnDeleteConection.Click += new System.EventHandler(this.btnDeleteConection_Click);
            // 
            // dgvConnections
            // 
            this.dgvConnections.AllowUserToAddRows = false;
            this.dgvConnections.AllowUserToDeleteRows = false;
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnections.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConnections.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConnections.Location = new System.Drawing.Point(22, 93);
            this.dgvConnections.MultiSelect = false;
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.ReadOnly = true;
            this.dgvConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnections.Size = new System.Drawing.Size(1024, 460);
            this.dgvConnections.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel2.Location = new System.Drawing.Point(22, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 1);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quản lí kết nối CSDL";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TenDangNhap";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.HeaderText = "Mật Khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.DataPropertyName = "LoaiTK";
            this.PhanQuyen.HeaderText = "Phân Quyền";
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HocSinh";
            this.Column4.HeaderText = "Học Sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaoVien";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabAccountManager.ResumeLayout(false);
            this.tabAccountManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImportStudent;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.SidebarButton btnHome;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAccountManager;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtvAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvConnections;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnImport;
        private System.Windows.Forms.PictureBox btnAddUser;
        private System.Windows.Forms.PictureBox btnChange;
        private System.Windows.Forms.PictureBox btnExportExcel;
        private CustomControls.MyButton btnDeleteConection;
        private System.Windows.Forms.PictureBox btnDeleteConnection;
        private System.Windows.Forms.PictureBox btnChangeConnection;
        private System.Windows.Forms.PictureBox btnAddConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}