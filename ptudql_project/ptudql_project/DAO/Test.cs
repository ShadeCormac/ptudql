using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public partial class Test
    {
        public static bool isExisted(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                return (db.DeThis.Where(test => test.IdDe == testId).SingleOrDefault() == null) ? false : true;
            }
        }
        public static void create(DeThi test)
        {
            using (var db = new QLTNDataContext())
            {
                db.DeThis.InsertOnSubmit(test);
                //db.SubmitChanges();
            }
        }
        public static void addQuestions(List<BoDeThi> bdtList)
        {
            using (var db = new QLTNDataContext())
            {
                db.BoDeThis.InsertAllOnSubmit(bdtList);
                db.SubmitChanges();
            }
        }

        public static BindingList<CauHoi> loadQuestions(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                return new BindingList<CauHoi>(db.BoDeThis.Where(bdt => bdt.IdDe == testId)
                    .Join(db.CauHois,
                    bdt => bdt.IdCauHoi,
                    quest => quest.IdCauHoi,
                    (bdt, quest) => quest).ToList());
            }
        }
    }
}
