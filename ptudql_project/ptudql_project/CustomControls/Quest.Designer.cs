namespace ptudql_project.CustomControls
{
  partial class Quest
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quest));
      this.questBox = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ans1 = new System.Windows.Forms.RadioButton();
      this.ans2 = new System.Windows.Forms.RadioButton();
      this.ans3 = new System.Windows.Forms.RadioButton();
      this.ans4 = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // questBox
      // 
      this.questBox.Enabled = false;
      this.questBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.questBox.Location = new System.Drawing.Point(14, 16);
      this.questBox.Multiline = true;
      this.questBox.Name = "questBox";
      this.questBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.questBox.Size = new System.Drawing.Size(670, 60);
      this.questBox.TabIndex = 0;
      this.questBox.Text = resources.GetString("questBox.Text");
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ans4);
      this.groupBox1.Controls.Add(this.ans3);
      this.groupBox1.Controls.Add(this.ans2);
      this.groupBox1.Controls.Add(this.ans1);
      this.groupBox1.Location = new System.Drawing.Point(14, 76);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(670, 222);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      // 
      // ans1
      // 
      this.ans1.BackColor = System.Drawing.Color.White;
      this.ans1.Location = new System.Drawing.Point(7, 20);
      this.ans1.Name = "ans1";
      this.ans1.Size = new System.Drawing.Size(657, 40);
      this.ans1.TabIndex = 0;
      this.ans1.TabStop = true;
      this.ans1.Text = resources.GetString("ans1.Text");
      this.ans1.UseVisualStyleBackColor = false;
      // 
      // ans2
      // 
      this.ans2.BackColor = System.Drawing.Color.White;
      this.ans2.Location = new System.Drawing.Point(6, 66);
      this.ans2.Name = "ans2";
      this.ans2.Size = new System.Drawing.Size(658, 40);
      this.ans2.TabIndex = 1;
      this.ans2.TabStop = true;
      this.ans2.Text = resources.GetString("ans2.Text");
      this.ans2.UseVisualStyleBackColor = false;
      // 
      // ans3
      // 
      this.ans3.BackColor = System.Drawing.Color.White;
      this.ans3.Location = new System.Drawing.Point(6, 112);
      this.ans3.Name = "ans3";
      this.ans3.Size = new System.Drawing.Size(658, 40);
      this.ans3.TabIndex = 2;
      this.ans3.TabStop = true;
      this.ans3.Text = "radioButton3";
      this.ans3.UseVisualStyleBackColor = false;
      // 
      // ans4
      // 
      this.ans4.BackColor = System.Drawing.Color.White;
      this.ans4.Location = new System.Drawing.Point(6, 158);
      this.ans4.Name = "ans4";
      this.ans4.Size = new System.Drawing.Size(658, 40);
      this.ans4.TabIndex = 3;
      this.ans4.TabStop = true;
      this.ans4.Text = "radioButton4";
      this.ans4.UseVisualStyleBackColor = false;
      // 
      // Quest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.questBox);
      this.Name = "Quest";
      this.Size = new System.Drawing.Size(701, 310);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox questBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton ans4;
    private System.Windows.Forms.RadioButton ans3;
    private System.Windows.Forms.RadioButton ans2;
    private System.Windows.Forms.RadioButton ans1;
  }
}
