namespace ptudql_project.CustomControls
{
  partial class PaddingTextBox
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
      this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.textBox1.Location = new System.Drawing.Point(17, 16);
      this.textBox1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(313, 25);
      this.textBox1.TabIndex = 8;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Location = new System.Drawing.Point(4, 4);
      this.panel2.Margin = new System.Windows.Forms.Padding(4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(339, 48);
      this.panel2.TabIndex = 9;
      // 
      // PaddingTextBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.panel2);
      this.Name = "PaddingTextBox";
      this.Size = new System.Drawing.Size(349, 58);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel2;
  }
}
