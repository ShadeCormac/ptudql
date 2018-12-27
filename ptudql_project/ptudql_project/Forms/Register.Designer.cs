﻿namespace ptudql_project
{
  partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegister = new ptudql_project.CustomControls.MyButton();
            this.login = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(445, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 600);
            this.panel1.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(50, 450);
            this.btnRegister.MyLabel = "Tạo tài khoản";
            this.btnRegister.MyLabelLocation = new System.Drawing.Point(98, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 40);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.CausesValidation = false;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.login.Location = new System.Drawing.Point(200, 509);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 18);
            this.login.TabIndex = 16;
            this.login.Text = "Đăng nhập ngay";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(98, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đã có tài khoản?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(47, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(65, 383);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(273, 20);
            this.txtConfirmPassword.TabIndex = 12;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(47, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPassword.Location = new System.Drawing.Point(65, 276);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(273, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(151, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đăng ký";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsername.Location = new System.Drawing.Point(65, 173);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(273, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ptudql_project.Properties.Resources.TextBox;
            this.pictureBox2.Location = new System.Drawing.Point(51, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 40);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ptudql_project.Properties.Resources.TextBox;
            this.pictureBox3.Location = new System.Drawing.Point(50, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 40);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ptudql_project.Properties.Resources.TextBox;
            this.pictureBox4.Location = new System.Drawing.Point(51, 373);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 40);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ptudql_project.Properties.Resources.congcong;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label login;
    private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.MyButton btnRegister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}