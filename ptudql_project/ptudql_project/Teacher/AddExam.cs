using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.Teacher
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("MM-dd-yyyy hh:mm:ss");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = dateTimePicker2.Value.ToString("MM-dd-yyyy hh:mm:ss");
        }
    }
}
