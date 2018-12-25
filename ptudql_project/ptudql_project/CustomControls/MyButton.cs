using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.CustomControls
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
            label.Click += RaiseClick;
            pictureBox1.Click += RaiseClick;
        }

        public string MyLabel
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public Point MyLabelLocation
        {
            get { return label.Location; }
            set { label.Location = value; }
        }

        public void RaiseClick(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
