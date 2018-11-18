namespace ptudql_project
{
  partial class StudentLayout
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLayout));
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.sidebarButton1 = new ptudql_project.CustomControls.SidebarButton();
      this.btnUser = new ptudql_project.CustomControls.SidebarButton();
      this.btnThiThu = new ptudql_project.CustomControls.SidebarButton();
      this.btnLamBaiThi = new ptudql_project.CustomControls.SidebarButton();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
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
      this.panel1.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControl1.Location = new System.Drawing.Point(200, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1080, 720);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1072, 687);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1072, 687);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
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
      this.sidebarButton1.Click += new System.EventHandler(this.changeColorBtn);
      // 
      // btnUser
      // 
      this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
      this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnUser.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnUser.CustomImage")));
      this.btnUser.LabelLocation = new System.Drawing.Point(30, 83);
      this.btnUser.LabelText = "Thông tin cá nhân";
      this.btnUser.Location = new System.Drawing.Point(0, 86);
      this.btnUser.Name = "btnUser";
      this.btnUser.Size = new System.Drawing.Size(200, 110);
      this.btnUser.TabIndex = 2;
      this.btnUser.Click += new System.EventHandler(this.changeColorBtn);
      // 
      // btnThiThu
      // 
      this.btnThiThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
      this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnThiThu.CustomImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.CustomImage")));
      this.btnThiThu.LabelLocation = new System.Drawing.Point(20, 83);
      this.btnThiThu.LabelText = "Thi thử trắc nghiệm";
      this.btnThiThu.Location = new System.Drawing.Point(0, 361);
      this.btnThiThu.Name = "btnThiThu";
      this.btnThiThu.Size = new System.Drawing.Size(200, 110);
      this.btnThiThu.TabIndex = 1;
      this.btnThiThu.Click += new System.EventHandler(this.changeColorBtn);
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
      this.btnLamBaiThi.Click += new System.EventHandler(this.changeColorBtn);
      // 
      // StudentLayout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "StudentLayout";
      this.Text = "StudentLayout";
      this.panel1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private CustomControls.SidebarButton btnLamBaiThi;
    private CustomControls.SidebarButton btnThiThu;
    private CustomControls.SidebarButton btnUser;
    private CustomControls.SidebarButton sidebarButton1;
  }
}