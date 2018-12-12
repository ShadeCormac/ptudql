namespace ptudql_project.Teacher
{
    partial class AddTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoDeThi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.IdCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauTLDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nipTime = new ptudql_project.CustomControls.NumberInputBox();
            this.lbAddedQuestion = new System.Windows.Forms.ListBox();
            this.btnRemoveQuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề thi:";
            // 
            // txtBoDeThi
            // 
            this.txtBoDeThi.Location = new System.Drawing.Point(291, 111);
            this.txtBoDeThi.Name = "txtBoDeThi";
            this.txtBoDeThi.Size = new System.Drawing.Size(201, 20);
            this.txtBoDeThi.TabIndex = 1;
            this.txtBoDeThi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(10, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 3);
            this.panel3.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(392, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tạo đề thi";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCauHoi,
            this.NoiDung,
            this.A,
            this.B,
            this.C,
            this.D,
            this.CauTLDung,
            this.LoaiCauHoi,
            this.DaDuyet});
            this.dgvQuestions.Location = new System.Drawing.Point(15, 158);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(559, 275);
            this.dgvQuestions.TabIndex = 9;
            // 
            // IdCauHoi
            // 
            this.IdCauHoi.DataPropertyName = "IdCauHoi";
            this.IdCauHoi.HeaderText = "ID câu hỏi";
            this.IdCauHoi.Name = "IdCauHoi";
            this.IdCauHoi.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // A
            // 
            this.A.DataPropertyName = "CauA";
            this.A.HeaderText = "Câu A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.DataPropertyName = "CauB";
            this.B.HeaderText = "Câu B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // C
            // 
            this.C.DataPropertyName = "CauC";
            this.C.HeaderText = "Câu C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // D
            // 
            this.D.DataPropertyName = "CauD";
            this.D.HeaderText = "Câu D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // CauTLDung
            // 
            this.CauTLDung.DataPropertyName = "CauTLDung";
            this.CauTLDung.HeaderText = "Câu đúng";
            this.CauTLDung.Name = "CauTLDung";
            this.CauTLDung.ReadOnly = true;
            // 
            // LoaiCauHoi
            // 
            this.LoaiCauHoi.DataPropertyName = "LoaiCauHoi";
            this.LoaiCauHoi.HeaderText = "LoaiCauHoi";
            this.LoaiCauHoi.Name = "LoaiCauHoi";
            this.LoaiCauHoi.ReadOnly = true;
            this.LoaiCauHoi.Visible = false;
            // 
            // DaDuyet
            // 
            this.DaDuyet.DataPropertyName = "DaDuyet";
            this.DaDuyet.HeaderText = "DaDuyet";
            this.DaDuyet.Name = "DaDuyet";
            this.DaDuyet.ReadOnly = true;
            this.DaDuyet.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Câu hỏi";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(261, 473);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(136, 23);
            this.btnAddQuestion.TabIndex = 11;
            this.btnAddQuestion.Text = "Thêm câu hỏi";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(689, 473);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(136, 23);
            this.btnCreateTest.TabIndex = 12;
            this.btnCreateTest.Text = "Tạo đề thi";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thời gian(phút)";
            // 
            // nipTime
            // 
            this.nipTime.Location = new System.Drawing.Point(689, 111);
            this.nipTime.Name = "nipTime";
            this.nipTime.Size = new System.Drawing.Size(101, 20);
            this.nipTime.TabIndex = 14;
            // 
            // lbAddedQuestion
            // 
            this.lbAddedQuestion.FormattingEnabled = true;
            this.lbAddedQuestion.Location = new System.Drawing.Point(670, 158);
            this.lbAddedQuestion.Name = "lbAddedQuestion";
            this.lbAddedQuestion.Size = new System.Drawing.Size(263, 277);
            this.lbAddedQuestion.TabIndex = 15;
            // 
            // btnRemoveQuest
            // 
            this.btnRemoveQuest.Location = new System.Drawing.Point(589, 289);
            this.btnRemoveQuest.Name = "btnRemoveQuest";
            this.btnRemoveQuest.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveQuest.TabIndex = 16;
            this.btnRemoveQuest.Text = "Xóa câu hỏi";
            this.btnRemoveQuest.UseVisualStyleBackColor = true;
            this.btnRemoveQuest.Click += new System.EventHandler(this.btnRemoveQuest_Click);
            // 
            // AddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.btnRemoveQuest);
            this.Controls.Add(this.lbAddedQuestion);
            this.Controls.Add(this.nipTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoDeThi);
            this.Controls.Add(this.label1);
            this.Name = "AddTest";
            this.Text = "AddTest";
            this.Load += new System.EventHandler(this.AddTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoDeThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Label label3;
        private CustomControls.NumberInputBox nipTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauTLDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaDuyet;
        private System.Windows.Forms.ListBox lbAddedQuestion;
        private System.Windows.Forms.Button btnRemoveQuest;
    }
}