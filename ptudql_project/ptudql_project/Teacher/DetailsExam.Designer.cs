namespace ptudql_project.Teacher
{
    partial class DetailsExam
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
            this.lbIdExam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIdTest = new System.Windows.Forms.Button();
            this.btnRemoveIdTest = new System.Windows.Forms.Button();
            this.lBIdTest = new System.Windows.Forms.ListBox();
            this.lBAllIdTest = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdExam
            // 
            this.lbIdExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.lbIdExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdExam.ForeColor = System.Drawing.Color.White;
            this.lbIdExam.Location = new System.Drawing.Point(341, 25);
            this.lbIdExam.Name = "lbIdExam";
            this.lbIdExam.Size = new System.Drawing.Size(222, 32);
            this.lbIdExam.TabIndex = 0;
            this.lbIdExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(615, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã đề thi hiện có";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tất cả mã đề thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddIdTest
            // 
            this.btnAddIdTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddIdTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIdTest.ForeColor = System.Drawing.Color.White;
            this.btnAddIdTest.Location = new System.Drawing.Point(391, 165);
            this.btnAddIdTest.Name = "btnAddIdTest";
            this.btnAddIdTest.Size = new System.Drawing.Size(112, 64);
            this.btnAddIdTest.TabIndex = 5;
            this.btnAddIdTest.Text = "Thêm";
            this.btnAddIdTest.UseVisualStyleBackColor = false;
            this.btnAddIdTest.Click += new System.EventHandler(this.btnAddIdTest_Click);
            // 
            // btnRemoveIdTest
            // 
            this.btnRemoveIdTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoveIdTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveIdTest.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIdTest.Location = new System.Drawing.Point(391, 296);
            this.btnRemoveIdTest.Name = "btnRemoveIdTest";
            this.btnRemoveIdTest.Size = new System.Drawing.Size(112, 64);
            this.btnRemoveIdTest.TabIndex = 6;
            this.btnRemoveIdTest.Text = "Xóa";
            this.btnRemoveIdTest.UseVisualStyleBackColor = false;
            this.btnRemoveIdTest.Click += new System.EventHandler(this.btnRemoveIdTest_Click);
            // 
            // lBIdTest
            // 
            this.lBIdTest.FormattingEnabled = true;
            this.lBIdTest.Location = new System.Drawing.Point(558, 122);
            this.lBIdTest.Name = "lBIdTest";
            this.lBIdTest.Size = new System.Drawing.Size(293, 303);
            this.lBIdTest.TabIndex = 7;
            this.lBIdTest.SelectedIndexChanged += new System.EventHandler(this.lBIdTest_SelectedIndexChanged);
            // 
            // lBAllIdTest
            // 
            this.lBAllIdTest.FormattingEnabled = true;
            this.lBAllIdTest.Location = new System.Drawing.Point(48, 122);
            this.lBAllIdTest.Name = "lBAllIdTest";
            this.lBAllIdTest.Size = new System.Drawing.Size(293, 303);
            this.lBAllIdTest.TabIndex = 8;
            this.lBAllIdTest.SelectedIndexChanged += new System.EventHandler(this.lBAllIdTest_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(270, 471);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(333, 64);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DetailsExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 592);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lBAllIdTest);
            this.Controls.Add(this.lBIdTest);
            this.Controls.Add(this.btnRemoveIdTest);
            this.Controls.Add(this.btnAddIdTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIdExam);
            this.Name = "DetailsExam";
            this.Text = "DetailsExam";
            this.Load += new System.EventHandler(this.DetailsExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIdExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddIdTest;
        private System.Windows.Forms.Button btnRemoveIdTest;
        private System.Windows.Forms.ListBox lBIdTest;
        private System.Windows.Forms.ListBox lBAllIdTest;
        private System.Windows.Forms.Button btnSubmit;
    }
}