namespace ptudql_project.Student
{
    partial class DoExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoExam));
            this.percentBar = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
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
            this.lbGoiY = new System.Windows.Forms.Label();
            this.colorRed = new System.Windows.Forms.Panel();
            this.colorGreen = new System.Windows.Forms.Panel();
            this.panelTips = new System.Windows.Forms.Panel();
            this.lbTipsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipAns = new System.Windows.Forms.Label();
            this.btnPrevQuest = new System.Windows.Forms.PictureBox();
            this.btnNextQuest = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conAnsA = new System.Windows.Forms.PictureBox();
            this.conAnsB = new System.Windows.Forms.PictureBox();
            this.conAnsC = new System.Windows.Forms.PictureBox();
            this.conAnsD = new System.Windows.Forms.PictureBox();
            this.pbGoiY = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new ptudql_project.CustomControls.MyButton();
            this.panelTips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevQuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextQuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoiY)).BeginInit();
            this.SuspendLayout();
            // 
            // percentBar
            // 
            this.percentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.percentBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.percentBar.Location = new System.Drawing.Point(188, 0);
            this.percentBar.MaximumSize = new System.Drawing.Size(887, 5);
            this.percentBar.Name = "percentBar";
            this.percentBar.Size = new System.Drawing.Size(887, 5);
            this.percentBar.TabIndex = 51;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.lbTime.Location = new System.Drawing.Point(554, 27);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(138, 36);
            this.lbTime.TabIndex = 37;
            this.lbTime.Text = "time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbAnsDInput
            // 
            this.rdbAnsDInput.AutoSize = true;
            this.rdbAnsDInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdbAnsDInput.Location = new System.Drawing.Point(154, 509);
            this.rdbAnsDInput.Name = "rdbAnsDInput";
            this.rdbAnsDInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsDInput.TabIndex = 47;
            this.rdbAnsDInput.TabStop = true;
            this.rdbAnsDInput.UseVisualStyleBackColor = true;
            this.rdbAnsDInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsD
            // 
            this.txtAnsD.BackColor = System.Drawing.Color.White;
            this.txtAnsD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnsD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnsD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsD.Location = new System.Drawing.Point(200, 492);
            this.txtAnsD.Multiline = true;
            this.txtAnsD.Name = "txtAnsD";
            this.txtAnsD.ReadOnly = true;
            this.txtAnsD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsD.Size = new System.Drawing.Size(860, 44);
            this.txtAnsD.TabIndex = 46;
            // 
            // rdbAnsCInput
            // 
            this.rdbAnsCInput.AutoSize = true;
            this.rdbAnsCInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdbAnsCInput.Location = new System.Drawing.Point(154, 416);
            this.rdbAnsCInput.Name = "rdbAnsCInput";
            this.rdbAnsCInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsCInput.TabIndex = 45;
            this.rdbAnsCInput.TabStop = true;
            this.rdbAnsCInput.UseVisualStyleBackColor = true;
            this.rdbAnsCInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsC
            // 
            this.txtAnsC.BackColor = System.Drawing.Color.White;
            this.txtAnsC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnsC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnsC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsC.Location = new System.Drawing.Point(200, 400);
            this.txtAnsC.Multiline = true;
            this.txtAnsC.Name = "txtAnsC";
            this.txtAnsC.ReadOnly = true;
            this.txtAnsC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsC.Size = new System.Drawing.Size(860, 44);
            this.txtAnsC.TabIndex = 44;
            // 
            // rdbAnsBInput
            // 
            this.rdbAnsBInput.AutoSize = true;
            this.rdbAnsBInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdbAnsBInput.Location = new System.Drawing.Point(154, 319);
            this.rdbAnsBInput.Name = "rdbAnsBInput";
            this.rdbAnsBInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsBInput.TabIndex = 43;
            this.rdbAnsBInput.TabStop = true;
            this.rdbAnsBInput.UseVisualStyleBackColor = true;
            this.rdbAnsBInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsB
            // 
            this.txtAnsB.BackColor = System.Drawing.Color.White;
            this.txtAnsB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnsB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnsB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsB.Location = new System.Drawing.Point(200, 305);
            this.txtAnsB.Multiline = true;
            this.txtAnsB.Name = "txtAnsB";
            this.txtAnsB.ReadOnly = true;
            this.txtAnsB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsB.Size = new System.Drawing.Size(860, 44);
            this.txtAnsB.TabIndex = 42;
            // 
            // rdbAnsAInput
            // 
            this.rdbAnsAInput.AutoSize = true;
            this.rdbAnsAInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdbAnsAInput.Location = new System.Drawing.Point(154, 224);
            this.rdbAnsAInput.Name = "rdbAnsAInput";
            this.rdbAnsAInput.Size = new System.Drawing.Size(14, 13);
            this.rdbAnsAInput.TabIndex = 41;
            this.rdbAnsAInput.TabStop = true;
            this.rdbAnsAInput.UseVisualStyleBackColor = true;
            this.rdbAnsAInput.CheckedChanged += new System.EventHandler(this.rdbAnsInput_CheckedChanged);
            // 
            // txtAnsA
            // 
            this.txtAnsA.BackColor = System.Drawing.Color.White;
            this.txtAnsA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnsA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnsA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnsA.Location = new System.Drawing.Point(200, 208);
            this.txtAnsA.Multiline = true;
            this.txtAnsA.Name = "txtAnsA";
            this.txtAnsA.ReadOnly = true;
            this.txtAnsA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnsA.Size = new System.Drawing.Size(860, 44);
            this.txtAnsA.TabIndex = 40;
            // 
            // txtQuest
            // 
            this.txtQuest.BackColor = System.Drawing.Color.White;
            this.txtQuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtQuest.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.txtQuest.Location = new System.Drawing.Point(200, 80);
            this.txtQuest.Multiline = true;
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.ReadOnly = true;
            this.txtQuest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuest.Size = new System.Drawing.Size(860, 86);
            this.txtQuest.TabIndex = 39;
            // 
            // tvListQuest
            // 
            this.tvListQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.tvListQuest.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvListQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvListQuest.ForeColor = System.Drawing.Color.White;
            this.tvListQuest.LineColor = System.Drawing.Color.White;
            this.tvListQuest.Location = new System.Drawing.Point(0, 0);
            this.tvListQuest.Name = "tvListQuest";
            this.tvListQuest.Size = new System.Drawing.Size(121, 665);
            this.tvListQuest.TabIndex = 38;
            this.tvListQuest.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListQuest_AfterSelect);
            // 
            // lbGoiY
            // 
            this.lbGoiY.AutoSize = true;
            this.lbGoiY.BackColor = System.Drawing.Color.White;
            this.lbGoiY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoiY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.lbGoiY.Location = new System.Drawing.Point(999, 38);
            this.lbGoiY.Name = "lbGoiY";
            this.lbGoiY.Size = new System.Drawing.Size(45, 19);
            this.lbGoiY.TabIndex = 53;
            this.lbGoiY.Text = "Gợi ý";
            this.lbGoiY.Click += new System.EventHandler(this.goiY_Click);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.colorRed.ForeColor = System.Drawing.Color.White;
            this.colorRed.Location = new System.Drawing.Point(103, 8);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(18, 18);
            this.colorRed.TabIndex = 54;
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.colorGreen.ForeColor = System.Drawing.Color.White;
            this.colorGreen.Location = new System.Drawing.Point(206, 8);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(18, 18);
            this.colorGreen.TabIndex = 55;
            // 
            // panelTips
            // 
            this.panelTips.Controls.Add(this.lbTipsTitle);
            this.panelTips.Controls.Add(this.label1);
            this.panelTips.Controls.Add(this.lbTipAns);
            this.panelTips.Controls.Add(this.colorGreen);
            this.panelTips.Controls.Add(this.colorRed);
            this.panelTips.Location = new System.Drawing.Point(188, 30);
            this.panelTips.Name = "panelTips";
            this.panelTips.Size = new System.Drawing.Size(313, 33);
            this.panelTips.TabIndex = 56;
            // 
            // lbTipsTitle
            // 
            this.lbTipsTitle.AutoSize = true;
            this.lbTipsTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbTipsTitle.Location = new System.Drawing.Point(15, 7);
            this.lbTipsTitle.Name = "lbTipsTitle";
            this.lbTipsTitle.Size = new System.Drawing.Size(74, 19);
            this.lbTipsTitle.TabIndex = 58;
            this.lbTipsTitle.Text = "Chú thích:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(111)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(230, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Bạn chọn";
            // 
            // lbTipAns
            // 
            this.lbTipAns.AutoSize = true;
            this.lbTipAns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lbTipAns.Location = new System.Drawing.Point(127, 7);
            this.lbTipAns.Name = "lbTipAns";
            this.lbTipAns.Size = new System.Drawing.Size(55, 19);
            this.lbTipAns.TabIndex = 56;
            this.lbTipAns.Text = "Đán án";
            // 
            // btnPrevQuest
            // 
            this.btnPrevQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevQuest.Image")));
            this.btnPrevQuest.Location = new System.Drawing.Point(188, 585);
            this.btnPrevQuest.Name = "btnPrevQuest";
            this.btnPrevQuest.Size = new System.Drawing.Size(65, 40);
            this.btnPrevQuest.TabIndex = 58;
            this.btnPrevQuest.TabStop = false;
            this.btnPrevQuest.Click += new System.EventHandler(this.btnPrevQuest_Click);
            // 
            // btnNextQuest
            // 
            this.btnNextQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuest.Image = ((System.Drawing.Image)(resources.GetObject("btnNextQuest.Image")));
            this.btnNextQuest.Location = new System.Drawing.Point(1011, 585);
            this.btnNextQuest.Name = "btnNextQuest";
            this.btnNextQuest.Size = new System.Drawing.Size(65, 40);
            this.btnNextQuest.TabIndex = 59;
            this.btnNextQuest.TabStop = false;
            this.btnNextQuest.Click += new System.EventHandler(this.btnNextQuest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 100);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // conAnsA
            // 
            this.conAnsA.Image = ((System.Drawing.Image)(resources.GetObject("conAnsA.Image")));
            this.conAnsA.Location = new System.Drawing.Point(188, 203);
            this.conAnsA.Name = "conAnsA";
            this.conAnsA.Size = new System.Drawing.Size(888, 55);
            this.conAnsA.TabIndex = 61;
            this.conAnsA.TabStop = false;
            // 
            // conAnsB
            // 
            this.conAnsB.Image = ((System.Drawing.Image)(resources.GetObject("conAnsB.Image")));
            this.conAnsB.Location = new System.Drawing.Point(188, 300);
            this.conAnsB.Name = "conAnsB";
            this.conAnsB.Size = new System.Drawing.Size(888, 55);
            this.conAnsB.TabIndex = 62;
            this.conAnsB.TabStop = false;
            // 
            // conAnsC
            // 
            this.conAnsC.Image = ((System.Drawing.Image)(resources.GetObject("conAnsC.Image")));
            this.conAnsC.Location = new System.Drawing.Point(188, 395);
            this.conAnsC.Name = "conAnsC";
            this.conAnsC.Size = new System.Drawing.Size(888, 55);
            this.conAnsC.TabIndex = 63;
            this.conAnsC.TabStop = false;
            // 
            // conAnsD
            // 
            this.conAnsD.Image = ((System.Drawing.Image)(resources.GetObject("conAnsD.Image")));
            this.conAnsD.Location = new System.Drawing.Point(188, 487);
            this.conAnsD.Name = "conAnsD";
            this.conAnsD.Size = new System.Drawing.Size(888, 55);
            this.conAnsD.TabIndex = 64;
            this.conAnsD.TabStop = false;
            // 
            // pbGoiY
            // 
            this.pbGoiY.Image = ((System.Drawing.Image)(resources.GetObject("pbGoiY.Image")));
            this.pbGoiY.Location = new System.Drawing.Point(1050, 36);
            this.pbGoiY.Name = "pbGoiY";
            this.pbGoiY.Size = new System.Drawing.Size(25, 25);
            this.pbGoiY.TabIndex = 66;
            this.pbGoiY.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(486, 585);
            this.btnSubmit.MyLabel = "Nộp bài";
            this.btnSubmit.MyLabelLocation = new System.Drawing.Point(118, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(300, 40);
            this.btnSubmit.TabIndex = 57;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 665);
            this.Controls.Add(this.pbGoiY);
            this.Controls.Add(this.btnNextQuest);
            this.Controls.Add(this.btnPrevQuest);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelTips);
            this.Controls.Add(this.lbGoiY);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.rdbAnsDInput);
            this.Controls.Add(this.txtAnsD);
            this.Controls.Add(this.rdbAnsCInput);
            this.Controls.Add(this.txtAnsC);
            this.Controls.Add(this.rdbAnsBInput);
            this.Controls.Add(this.rdbAnsAInput);
            this.Controls.Add(this.txtAnsA);
            this.Controls.Add(this.txtQuest);
            this.Controls.Add(this.tvListQuest);
            this.Controls.Add(this.percentBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.conAnsA);
            this.Controls.Add(this.conAnsC);
            this.Controls.Add(this.txtAnsB);
            this.Controls.Add(this.conAnsD);
            this.Controls.Add(this.conAnsB);
            this.Name = "DoExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoContest";
            this.Load += new System.EventHandler(this.DoExam_Load);
            this.panelTips.ResumeLayout(false);
            this.panelTips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevQuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextQuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conAnsD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoiY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel percentBar;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.RadioButton rdbAnsDInput;
        private System.Windows.Forms.TextBox txtAnsD;
        private System.Windows.Forms.RadioButton rdbAnsCInput;
        private System.Windows.Forms.TextBox txtAnsC;
        private System.Windows.Forms.RadioButton rdbAnsBInput;
        private System.Windows.Forms.TextBox txtAnsB;
        private System.Windows.Forms.RadioButton rdbAnsAInput;
        private System.Windows.Forms.TextBox txtAnsA;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.TreeView tvListQuest;
        private System.Windows.Forms.Label lbGoiY;
        private System.Windows.Forms.Panel colorRed;
        private System.Windows.Forms.Panel colorGreen;
        private System.Windows.Forms.Panel panelTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipAns;
        private System.Windows.Forms.Label lbTipsTitle;
        private CustomControls.MyButton btnSubmit;
        private System.Windows.Forms.PictureBox btnPrevQuest;
        private System.Windows.Forms.PictureBox btnNextQuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox conAnsA;
        private System.Windows.Forms.PictureBox conAnsB;
        private System.Windows.Forms.PictureBox conAnsC;
        private System.Windows.Forms.PictureBox conAnsD;
        private System.Windows.Forms.PictureBox pbGoiY;
    }
}