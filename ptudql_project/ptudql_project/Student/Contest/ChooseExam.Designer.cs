﻿namespace ptudql_project.Student
{
    partial class ChooseExam
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbChooseExamTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseExam = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbExamCount = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(43, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 1);
            this.panel2.TabIndex = 3;
            // 
            // lbChooseExamTitle
            // 
            this.lbChooseExamTitle.AutoSize = true;
            this.lbChooseExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseExamTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbChooseExamTitle.Location = new System.Drawing.Point(141, 23);
            this.lbChooseExamTitle.Name = "lbChooseExamTitle";
            this.lbChooseExamTitle.Size = new System.Drawing.Size(152, 31);
            this.lbChooseExamTitle.TabIndex = 2;
            this.lbChooseExamTitle.Text = "Chọn đề thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kỳ thi";
            // 
            // txtContest
            // 
            this.txtContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContest.Location = new System.Drawing.Point(43, 143);
            this.txtContest.Name = "txtContest";
            this.txtContest.ReadOnly = true;
            this.txtContest.Size = new System.Drawing.Size(363, 29);
            this.txtContest.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(39, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đề thi";
            // 
            // cbChooseExam
            // 
            this.cbChooseExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseExam.FormattingEnabled = true;
            this.cbChooseExam.Location = new System.Drawing.Point(43, 240);
            this.cbChooseExam.Name = "cbChooseExam";
            this.cbChooseExam.Size = new System.Drawing.Size(363, 32);
            this.cbChooseExam.TabIndex = 7;
            this.cbChooseExam.SelectedIndexChanged += new System.EventHandler(this.cbChooseExam_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(43, 529);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(363, 40);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.Text = "Đồng ý";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbTeacherName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLevel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbExamCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 206);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbTeacherName.Location = new System.Drawing.Point(211, 16);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(121, 20);
            this.lbTeacherName.TabIndex = 4;
            this.lbTeacherName.Text = "lbTeacherName";
            // 
            // lbLevel
            // 
            this.lbLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbLevel.Location = new System.Drawing.Point(243, 67);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(58, 20);
            this.lbLevel.TabIndex = 5;
            this.lbLevel.Text = "lbLevel";
            // 
            // lbExamCount
            // 
            this.lbExamCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbExamCount.AutoSize = true;
            this.lbExamCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExamCount.ForeColor = System.Drawing.Color.Red;
            this.lbExamCount.Location = new System.Drawing.Point(220, 118);
            this.lbExamCount.Name = "lbExamCount";
            this.lbExamCount.Size = new System.Drawing.Size(104, 20);
            this.lbExamCount.TabIndex = 6;
            this.lbExamCount.Text = "lbExamCount";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Red;
            this.lbTime.Location = new System.Drawing.Point(244, 169);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(55, 20);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "lbTime";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giáo viên ra đề";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(61, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Độ khó";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(61, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số câu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(54, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thời gian";
            // 
            // ChooseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbChooseExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbChooseExamTitle);
            this.Name = "ChooseExam";
            this.Text = "ChooseExam";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbChooseExamTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChooseExam;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbExamCount;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}