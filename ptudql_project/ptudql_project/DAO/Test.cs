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
        public static void Create(DeThi test)
        {
            using (var db = new QLTNDataContext())
            {
                db.DeThis.InsertOnSubmit(test);
                db.SubmitChanges();
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

        public static List<string> getAllTestId()
        {
            using (var db = new QLTNDataContext())
            {
                return db.DeThis.Select(d => d.IdDe).ToList();
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

        public static BindingList<string> loadQuestionsId(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                return new BindingList<string>(db.BoDeThis.Where(bdt => bdt.IdDe == testId)
                    .Join(db.CauHois,
                    bdt => bdt.IdCauHoi,
                    quest => quest.IdCauHoi,
                    (bdt, quest) => quest.IdCauHoi.ToString()).ToList());
            }
        }

        public static int? getTime(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                return db.DeThis.Where(d => d.IdDe == testId).Single().ThoiGian;
            }
        }

        public static void removeQuestions(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                var test = db.DeThis.Where(t => t.IdDe == testId).Single();
                foreach (BoDeThi b in test.BoDeThis)
                {
                    db.BoDeThis.DeleteOnSubmit(b);
                }
                db.SubmitChanges();
            }
        }
        public static void Remove(string testId)
        {
            using (var db = new QLTNDataContext())
            {
                var test = db.DeThis.Where(t => t.IdDe == testId).Single();
                
                foreach (KyThi_DeThi tx in test.KyThi_DeThis)
                {
                    db.KyThi_DeThis.DeleteOnSubmit(tx);
                }
                foreach (BoDeThi b in test.BoDeThis)
                {
                    db.BoDeThis.DeleteOnSubmit(b);
                }
                foreach (DanhSachThi d in test.DanhSachThis)
                {
                    db.DanhSachThis.DeleteOnSubmit(d);
                }
                db.DeThis.DeleteOnSubmit(test);
                db.SubmitChanges();
            }

        }

        public static void Update(DeThi test)
        {
            using (var db = new QLTNDataContext())
            {
                var oldTest = db.DeThis.Where(t => t.IdDe == test.IdDe).Single();
                oldTest.ThoiGian = test.ThoiGian;
                oldTest.GVRaDe = test.GVRaDe;
                oldTest.DoKho = test.DoKho;
                db.SubmitChanges();
            }
        }
    }
}
