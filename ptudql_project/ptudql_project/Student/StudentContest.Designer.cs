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
            this.tabListQuestion = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabContest.SuspendLayout();
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
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForms.Location = new System.Drawing.Point(200, 0);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(1080, 720);
            this.tabForms.TabIndex = 2;
            // 
            // tabContest
            // 
            this.tabContest.Controls.Add(this.tabListQuestion);
            this.tabContest.Location = new System.Drawing.Point(4, 29);
            this.tabContest.Name = "tabContest";
            this.tabContest.Padding = new System.Windows.Forms.Padding(3);
            this.tabContest.Size = new System.Drawing.Size(1072, 687);
            this.tabContest.TabIndex = 3;
            this.tabContest.Text = "Làm bài thi";
            this.tabContest.UseVisualStyleBackColor = true;
            // 
            // tabListQuestion
            // 
            this.tabListQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListQuestion.Location = new System.Drawing.Point(3, 3);
            this.tabListQuestion.Name = "tabListQuestion";
            this.tabListQuestion.SelectedIndex = 0;
            this.tabListQuestion.Size = new System.Drawing.Size(1066, 681);
            this.tabListQuestion.TabIndex = 0;
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
        private System.Windows.Forms.TabControl tabListQuestion;
    }
}