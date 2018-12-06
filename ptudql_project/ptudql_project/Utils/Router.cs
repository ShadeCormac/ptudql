using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ptudql_project.Utils
{
  class Router
  {
        //public static void Navigate(Form parent, Form navigateTo)
        //{
        //  navigateTo.TopLevel = false;
        //  navigateTo.Size = parent.Size;
        //  navigateTo.Location = new Point(0, 0);

        //  parent.Controls.Clear();
        //  parent.Controls.Add(navigateTo);
        //  navigateTo.Show();
        //}
        //public static void NavigateInPage(Form parent, Form moved, Form navigateTo)
        //{
        //  navigateTo.TopLevel = false;
        //  navigateTo.Size = parent.Size;
        //  navigateTo.Location = new Point(0, 0);

        //  parent.Controls.Remove(moved);
        //  parent.Controls.Add(navigateTo);
        //  navigateTo.Show();
        //}
        public static void ChangeForm(Form currentForm, Form nextForm, bool turnBackAble = false)
        {
            nextForm.Location = currentForm.Location;
            nextForm.StartPosition = FormStartPosition.Manual;
            if (turnBackAble)
            {
                nextForm.FormClosing += delegate { currentForm.Show(); };
            }
            else
            {
                nextForm.FormClosing += delegate { currentForm.Close(); };
            }
            nextForm.Show();
            currentForm.Hide();
        }
        public static void ShowFormDialog(Form currentForm, Form frm)
        {
            frm.Location = currentForm.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
