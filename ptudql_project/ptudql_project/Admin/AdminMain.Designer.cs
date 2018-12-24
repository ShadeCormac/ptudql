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
            this.dtvAdmin = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdImportStudent = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvAdmin
            // 
            this.dtvAdmin.AllowUserToAddRows = false;
            this.dtvAdmin.AllowUserToDeleteRows = false;
            this.dtvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.Column2,
            this.PhanQuyen,
            this.Column4,
            this.Column5});
            this.dtvAdmin.Location = new System.Drawing.Point(0, 142);
            this.dtvAdmin.Name = "dtvAdmin";
            this.dtvAdmin.ReadOnly = true;
            this.dtvAdmin.RowTemplate.Height = 28;
            this.dtvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvAdmin.Size = new System.Drawing.Size(1115, 778);
            this.dtvAdmin.TabIndex = 0;
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
            // txtAccount
            // 
            this.txtAccount.Enabled = false;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(207, 61);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(271, 39);
            this.txtAccount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 44);
            this.label3.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(127, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1490, 5);
            this.panel3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(615, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 46);
            this.label10.TabIndex = 24;
            this.label10.Text = "Quản Trị Admin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label11.Location = new System.Drawing.Point(24, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 32);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(24, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phân Quyền";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(313, 314);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(189, 80);
            this.btnChange.TabIndex = 27;
            this.btnChange.Text = "Sửa Thông Tin";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "1 : Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "2 : Teacher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(161, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "(*) Lưu Ý Phân Quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "3 : Student";
            // 
            // ofdImportStudent
            // 
            this.ofdImportStudent.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(1185, 157);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(187, 80);
            this.btnImport.TabIndex = 34;
            this.btnImport.Text = "Thêm sinh viên từ excel";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(1494, 157);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(187, 80);
            this.btnAddUser.TabIndex = 35;
            this.btnAddUser.Text = "Thêm Người Dùng";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1140, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 421);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(207, 145);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(271, 39);
            this.txtRole.TabIndex = 33;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 920);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvAdmin);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            ((System.ComponentModel.ISupportInitialize)(this.dtvAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvAdmin;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.OpenFileDialog ofdImportStudent;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRole;
    }
}