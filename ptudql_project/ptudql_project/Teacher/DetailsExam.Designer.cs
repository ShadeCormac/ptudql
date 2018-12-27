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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsExam));
            this.lbIdExam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBIdTest = new System.Windows.Forms.ListBox();
            this.lBAllIdTest = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new ptudql_project.CustomControls.MyButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddIdTest = new System.Windows.Forms.PictureBox();
            this.btnRemoveIdTest = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddIdTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveIdTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdExam
            // 
            this.lbIdExam.BackColor = System.Drawing.Color.White;
            this.lbIdExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.lbIdExam.Location = new System.Drawing.Point(167, 80);
            this.lbIdExam.Name = "lbIdExam";
            this.lbIdExam.Size = new System.Drawing.Size(222, 32);
            this.lbIdExam.TabIndex = 0;
            this.lbIdExam.Text = "Kỳ thi hiện tại";
            this.lbIdExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(331, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đề thi đang chọn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(44, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách đề thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBIdTest
            // 
            this.lBIdTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBIdTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIdTest.FormattingEnabled = true;
            this.lBIdTest.ItemHeight = 19;
            this.lBIdTest.Location = new System.Drawing.Point(348, 198);
            this.lBIdTest.Name = "lBIdTest";
            this.lBIdTest.Size = new System.Drawing.Size(151, 247);
            this.lBIdTest.TabIndex = 7;
            this.lBIdTest.SelectedIndexChanged += new System.EventHandler(this.lBIdTest_SelectedIndexChanged);
            // 
            // lBAllIdTest
            // 
            this.lBAllIdTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBAllIdTest.Font = new System.Drawing.Font("Calibri", 12F);
            this.lBAllIdTest.FormattingEnabled = true;
            this.lBAllIdTest.ItemHeight = 19;
            this.lBAllIdTest.Location = new System.Drawing.Point(61, 198);
            this.lBAllIdTest.Name = "lBAllIdTest";
            this.lBAllIdTest.Size = new System.Drawing.Size(151, 247);
            this.lBAllIdTest.TabIndex = 8;
            this.lBAllIdTest.SelectedIndexChanged += new System.EventHandler(this.lBAllIdTest_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(194, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chi tiết đề thi";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(127, 509);
            this.btnSubmit.MyLabel = "Cập nhật";
            this.btnSubmit.MyLabelLocation = new System.Drawing.Point(110, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(300, 40);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.panel4.Location = new System.Drawing.Point(50, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 1);
            this.panel4.TabIndex = 65;
            // 
            // btnAddIdTest
            // 
            this.btnAddIdTest.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIdTest.Image")));
            this.btnAddIdTest.Location = new System.Drawing.Point(244, 249);
            this.btnAddIdTest.Name = "btnAddIdTest";
            this.btnAddIdTest.Size = new System.Drawing.Size(65, 40);
            this.btnAddIdTest.TabIndex = 66;
            this.btnAddIdTest.TabStop = false;
            this.btnAddIdTest.Click += new System.EventHandler(this.btnAddIdTest_Click);
            // 
            // btnRemoveIdTest
            // 
            this.btnRemoveIdTest.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveIdTest.Image")));
            this.btnRemoveIdTest.Location = new System.Drawing.Point(244, 320);
            this.btnRemoveIdTest.Name = "btnRemoveIdTest";
            this.btnRemoveIdTest.Size = new System.Drawing.Size(65, 40);
            this.btnRemoveIdTest.TabIndex = 67;
            this.btnRemoveIdTest.TabStop = false;
            this.btnRemoveIdTest.Click += new System.EventHandler(this.btnRemoveIdTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 285);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 285);
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // DetailsExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 592);
            this.Controls.Add(this.btnRemoveIdTest);
            this.Controls.Add(this.btnAddIdTest);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBAllIdTest);
            this.Controls.Add(this.lBIdTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIdExam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "DetailsExam";
            this.Text = "Chi tiết đề thi";
            this.Load += new System.EventHandler(this.DetailsExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddIdTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveIdTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBIdTest;
        private System.Windows.Forms.ListBox lBAllIdTest;
        private System.Windows.Forms.Label label3;
        private CustomControls.MyButton btnSubmit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnAddIdTest;
        private System.Windows.Forms.PictureBox btnRemoveIdTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}