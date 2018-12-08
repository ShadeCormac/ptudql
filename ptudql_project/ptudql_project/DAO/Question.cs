using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public partial class Question
    {
        public static List<CauHoi> LoadQuestion()
        {
            using(var db = new QLTNDataContext())
            {
                return (from cauHoi in db.CauHois
                        select cauHoi).Take(40).ToList();
            }
        }

        public static void AddRequest(CauHoi request)
        {
            using (var db = new QLTNDataContext())
            {
                db.CauHois.InsertOnSubmit(request);
                db.SubmitChanges();
            }
        }

        public static BindingList<CauHoi> GetAllQuestions()
        {
            using (var db = new QLTNDataContext())
            {
                return new BindingList<CauHoi>(db.CauHois.ToList());
            }
        }
    }
}
