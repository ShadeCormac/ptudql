using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public class Student
    {
        public static List<DanhSachThi> LoadStudent()
        {
            using (var db = new QLTNDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return (from hocSinh in db.DanhSachThis
                        select hocSinh).ToList();
            }
        }
        public static List<DanhSachThi> LoadListExamStudents(string tenKyThi)
        {
            using (var db = new QLTNDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return db.KyThis.Where(kt => kt.TenKyThi == tenKyThi)
                    .Join(db.DanhSachThis, kt => kt.IDKyThi, ds => ds.IdKyThi, (kt, ds) => ds).ToList();
            }
        }
        public static List<string> LoadListExam()
        {
            using (var db = new QLTNDataContext())
            {
                //db.DeferredLoadingEnabled = false;
                return (from kyThi in db.KyThis
                        select kyThi.TenKyThi).Distinct().ToList();
            }
        }
    }
}
