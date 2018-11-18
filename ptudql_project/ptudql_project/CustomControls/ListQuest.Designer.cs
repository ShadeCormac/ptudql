namespace ptudql_project.CustomControls
{
  partial class ListQuest
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
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(10);
      this.label1.Size = new System.Drawing.Size(150, 38);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 38);
      this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(150, 112);
      this.panel1.TabIndex = 1;
      // 
      // ListQuest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Name = "ListQuest";
      this.Load += new System.EventHandler(this.ListQuest_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
  }
}
