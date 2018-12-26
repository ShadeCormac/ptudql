using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;

namespace ptudql_project.Student
{
    class StudentRouter
    {
        public static EventHandler routingBuilder(Form currentForm)
        {
            return (object sender, EventArgs e) =>
            {
                var btn = sender as Control;
                switch (btn.Tag as string)
                {
                    case "Contest":
                        Router.ChangeForm(currentForm, new StudentContest());
                        break;
                    case "TrialContest":
                        Router.ChangeForm(currentForm, new StudentTrialContest());
                        break;
                    case "Info":
                        Router.ChangeForm(currentForm, new StudentInfo());
                        break;
                    case "RequestQuestion":
                        Router.ShowFormDialog(currentForm, new RequestQuestion("Đóng góp câu hỏi"));
                        break;
                }
            };
            
        }
    }
}
