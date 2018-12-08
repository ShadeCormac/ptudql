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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentContest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarButton1 = new ptudql_project.CustomControls.SidebarButton();
            this.btnUser = new ptudql_project.CustomControls.SidebarButton();
            this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
            this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabContest = new System.Windows.Forms.TabPage();
            this.btnNextQuest = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrevQuest = new System.Windows.Forms.Button();
            this.rdbAnsDInput = new System.Windows.Forms.RadioButton();
            this.txtAnsD = new System.Windows.Forms.TextBox();
            this.rdbAnsCInput = new System.Windows.Forms.RadioButton();
            this.txtAnsC = new System.Windows.Forms.TextBox();
            this.rdbAnsBInput = new System.Windows.Forms.RadioButton();
            this.txtAnsB = new System.Windows.Forms.TextBox();
            this.rdbAnsAInput = new System.Windows.Forms.RadioButton();
            this.txtAnsA = new System.Windows.Forms.TextBox();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.tvListQuest = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabContest.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 1;
            // 
            // sidebarButton1
            // 
            this.sidebarButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.sidebarButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebarButton1.CustomImage = ((System.Drawing.Image)(resources.GetObject("sidebarButton1.CustomImage")));
            this.sidebarButton1.LabelLocation = new System.Drawing.Point(30, 83);
            this.sidebarButton1.LabelText = "Đóng góp câu hỏi";
            this.sidebarButton1.Location = new System.Drawing.Point(0, 490);
            this.sidebarButton1.Name = "sidebarButton1";
            this.sidebarButton1.Size = new System.Drawing.Size(200, 110);
            this.sidebarButton1.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnUser.CustomImage")));
            this.btnUser.LabelLocation = new System.Drawing.Point(30, 83);
            this.btnUser.LabelText = "Thông tin cá nhân";
            this.btnUser.Location = new System.Drawing.Point(0, 86);
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
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(200, 110);
            this.btnThiThu.TabIndex = 1;
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.btnLamBaiThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamBaiThi.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnLamBaiThi.CustomImage")));
            this.btnLamBaiThi.LabelLocation = new System.Drawing.Point(20, 83);
            this.btnLamBaiThi.LabelText = "Làm bài trắc nghiệm";
            this.btnLamBaiThi.Location = new System.Drawing.Point(0, 221);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(200, 110);
            this.btnLamBaiThi.TabIndex = 0;
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabContest);
            this.tabForms.Controls.Add(this.tabPage1);
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForms.ItemSize = new System.Drawing.Size(117, 35);
            this.tabForms.Location = new System.Drawing.Point(200, 0);
            this.tabForms.Name = "tabForms";
            this.tabForms.Padding = new System.Drawing.Point(20, 5);
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1080, 720);
            this.tabForms.TabIndex = 2;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // tabContest
            // 
            this.tabContest.Controls.Add(this.btnNextQuest);
            this.tabContest.Controls.Add(this.btnSubmit);
            this.tabContest.Controls.Add(this.btnPrevQuest);
            this.tabContest.Controls.Add(this.rdbAnsDInput);
            this.tabContest.Controls.Add(this.txtAnsD);
            this.tabContest.Controls.Add(this.rdbAnsCInput);
            this.tabContest.Controls.Add(this.txtAnsC);
            this.tabContest.Controls.Add(this.rdbAnsBInput);
            this.tabContest.Controls.Add(this.txtAnsB);
            this.tabContest.Controls.Add(this.rdbAnsAInput);
            this.tabContest.Controls.Add(this.txtAnsA);
            this.tabContest.Controls.Add(this.txtQuest);
            this.tabContest.Controls.Add(this.tvListQuest);
            this.tabContest.Controls.Add(this.panel2);
            this.tabContest.Location = new System.Drawing.Point(4, 39);
            this.tabContest.Name = "tabContest";
            this.tabContest.Padding = new System.Windows.Forms.Padding(3);
            this.tabContest.Size = new System.Drawing.Size(1072, 677);
            this.tabContest.TabIndex = 3;
            this.tabContest.Text = "Làm bài thi";
            this.tabContest.UseVisualStyleBackColor = true;
            // 
            // btnNextQuest
            // 
            this.btnNextQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnNextQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuest.ForeColor = System.Drawing.Color.White;
            this.btnNextQuest.Location = new System.Drawing.Point(860, 583);
            this.btnNextQuest.Name = "btnNextQuest";
            this.btnNextQuest.Size = new System.Drawing.Size(188, 52);
            this.btnNextQuest.TabIndex = 35;
            this.btnNextQuest.Text = "Câu tiếp theo";
            this.btnNextQuest.UseVisualStyleBackColor = false;
            this.btnNextQuest.Click += new System.EventHandler(this.btnNextQuest_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(536, 583);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(188, 52);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrevQuest
            // 
            this.btnPrevQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnPrevQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevQuest.ForeColor = System.Drawing.Color.White;
            this.btnPrevQuest.Location = new System.Drawing.Point(204, 583);
            this.btnPrevQuest.Name = "btnPrevQuest";
            this.btnPrevQuest.Size = new System.Drawing.Size(188, 52);
            this.btnPrevQuest.TabIndex = 33;
            this.btnPrevQuest.Text = "Câu trước đó";
            this.btnPrevQuest.UseVisualStyleBackColor = false;
            this.btnPrevQuest.Click += new System.EventHandler(this.btnPrevQuest_Click);
            // 
            // rdbAnsDInput
            // 
            this.rdbAnsDInput.AutoSize = true;
            this.rdbAnsDInput.Location = new System.Drawing.Point(167, 512);
            this.rdbAnsDInput.Name = "rdbAnsDInput";
            this.rdbAnsDInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsDInput.TabIndex = 32;
            this.rdbAnsDInput.TabStop = true;
            this.rdbAnsDInput.UseVisualStyleBackColor = true;
            this.rdbAnsDInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsD
            // 
            this.txtAnsD.BackColor = System.Drawing.Color.White;
            this.txtAnsD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsD.Location = new System.Drawing.Point(204, 489);
            this.txtAnsD.Multiline = true;
            this.txtAnsD.Name = "txtAnsD";
            this.txtAnsD.ReadOnly = true;
            this.txtAnsD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsD.Size = new System.Drawing.Size(844, 54);
            this.txtAnsD.TabIndex = 31;
            // 
            // rdbAnsCInput
            // 
            this.rdbAnsCInput.AutoSize = true;
            this.rdbAnsCInput.Location = new System.Drawing.Point(167, 419);
            this.rdbAnsCInput.Name = "rdbAnsCInput";
            this.rdbAnsCInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsCInput.TabIndex = 30;
            this.rdbAnsCInput.TabStop = true;
            this.rdbAnsCInput.UseVisualStyleBackColor = true;
            this.rdbAnsCInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsC
            // 
            this.txtAnsC.BackColor = System.Drawing.Color.White;
            this.txtAnsC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsC.Location = new System.Drawing.Point(204, 397);
            this.txtAnsC.Multiline = true;
            this.txtAnsC.Name = "txtAnsC";
            this.txtAnsC.ReadOnly = true;
            this.txtAnsC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsC.Size = new System.Drawing.Size(844, 54);
            this.txtAnsC.TabIndex = 29;
            // 
            // rdbAnsBInput
            // 
            this.rdbAnsBInput.AutoSize = true;
            this.rdbAnsBInput.Location = new System.Drawing.Point(167, 322);
            this.rdbAnsBInput.Name = "rdbAnsBInput";
            this.rdbAnsBInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsBInput.TabIndex = 28;
            this.rdbAnsBInput.TabStop = true;
            this.rdbAnsBInput.UseVisualStyleBackColor = true;
            this.rdbAnsBInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsB
            // 
            this.txtAnsB.BackColor = System.Drawing.Color.White;
            this.txtAnsB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsB.Location = new System.Drawing.Point(204, 302);
            this.txtAnsB.Multiline = true;
            this.txtAnsB.Name = "txtAnsB";
            this.txtAnsB.ReadOnly = true;
            this.txtAnsB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsB.Size = new System.Drawing.Size(844, 54);
            this.txtAnsB.TabIndex = 27;
            // 
            // rdbAnsAInput
            // 
            this.rdbAnsAInput.AutoSize = true;
            this.rdbAnsAInput.Location = new System.Drawing.Point(167, 227);
            this.rdbAnsAInput.Name = "rdbAnsAInput";
            this.rdbAnsAInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsAInput.TabIndex = 26;
            this.rdbAnsAInput.TabStop = true;
            this.rdbAnsAInput.UseVisualStyleBackColor = true;
            this.rdbAnsAInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsA
            // 
            this.txtAnsA.BackColor = System.Drawing.Color.White;
            this.txtAnsA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsA.Location = new System.Drawing.Point(204, 206);
            this.txtAnsA.Multiline = true;
            this.txtAnsA.Name = "txtAnsA";
            this.txtAnsA.ReadOnly = true;
            this.txtAnsA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsA.Size = new System.Drawing.Size(844, 54);
            this.txtAnsA.TabIndex = 25;
            // 
            // txtQuest
            // 
            this.txtQuest.BackColor = System.Drawing.Color.White;
            this.txtQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuest.Location = new System.Drawing.Point(204, 75);
            this.txtQuest.Multiline = true;
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.ReadOnly = true;
            this.txtQuest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuest.Size = new System.Drawing.Size(844, 99);
            this.txtQuest.TabIndex = 24;
            // 
            // tvListQuest
            // 
            this.tvListQuest.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvListQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvListQuest.Location = new System.Drawing.Point(3, 39);
            this.tvListQuest.Name = "tvListQuest";
            this.tvListQuest.Size = new System.Drawing.Size(121, 635);
            this.tvListQuest.TabIndex = 1;
            this.tvListQuest.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListQuest_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 36);
            this.panel2.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(469, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(138, 36);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 677);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabContest.ResumeLayout(false);
            this.tabContest.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.SidebarButton sidebarButton1;
        private CustomControls.SidebarButton btnUser;
        private CustomControls.SidebarButton btnThiThu;
        private CustomControls.SidebarButton btnLamBaiThi;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.TabPage tabContest;
        private System.Windows.Forms.TreeView tvListQuest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNextQuest;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrevQuest;
        private System.Windows.Forms.RadioButton rdbAnsDInput;
        private System.Windows.Forms.TextBox txtAnsD;
        private System.Windows.Forms.RadioButton rdbAnsCInput;
        private System.Windows.Forms.TextBox txtAnsC;
        private System.Windows.Forms.RadioButton rdbAnsBInput;
        private System.Windows.Forms.TextBox txtAnsB;
        private System.Windows.Forms.RadioButton rdbAnsAInput;
        private System.Windows.Forms.TextBox txtAnsA;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TabPage tabPage1;
    }
}