namespace ptudql_project.Teacher
{
    partial class FilterQuestion
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
            this.dgvFilterQuestions = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilterQuestions
            // 
            this.dgvFilterQuestions.AllowUserToAddRows = false;
            this.dgvFilterQuestions.AllowUserToDeleteRows = false;
            this.dgvFilterQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterQuestions.Location = new System.Drawing.Point(59, 74);
            this.dgvFilterQuestions.MultiSelect = false;
            this.dgvFilterQuestions.Name = "dgvFilterQuestions";
            this.dgvFilterQuestions.ReadOnly = true;
            this.dgvFilterQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilterQuestions.Size = new System.Drawing.Size(1042, 511);
            this.dgvFilterQuestions.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(354, 591);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(157, 41);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Chấp nhận câu hỏi";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(630, 591);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(157, 41);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "Từ chối câu hỏi";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // FilterQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 644);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvFilterQuestions);
            this.Name = "FilterQuestion";
            this.Text = "FilterQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilterQuestions;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
    }
}