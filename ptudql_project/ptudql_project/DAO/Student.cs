using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static HocSinh getInfo(string username)
        {
            using (var db = new QLTNDataContext())
            {
                return db.HocSinhs.Where(hs => hs.TenTK == username).FirstOrDefault();
            }
        }

        public static bool SaveInfo(HocSinh newStudentInfo)
        {
            try
            {
                using (var db = new QLTNDataContext())
                {
                    var studentToUpdate = db.HocSinhs
                        .Where(st => st.TenTK == newStudentInfo.TenTK)
                        .FirstOrDefault();

                    studentToUpdate.Lop = newStudentInfo.Lop;
                    studentToUpdate.Khoi = newStudentInfo.Khoi;
                    studentToUpdate.HoTen = newStudentInfo.HoTen;
                    studentToUpdate.GioiTinh = newStudentInfo.GioiTinh;
                    studentToUpdate.Email = newStudentInfo.Email;

                    db.SubmitChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi");
                return false;
            }
        }

        public static void Insert(TaiKhoan account)
        {
            using(var db = new QLTNDataContext())
            {
                HocSinh newHS = new HocSinh
                {
                    TenTK = account.TenDangNhap,

                };
                db.HocSinhs.InsertOnSubmit(newHS);
                db.SubmitChanges();
            }
        }
    }
}
