using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public class Exam
    {
        public static BindingList<KyThi> LoadExam()
        {
            using (var db = new QLTNDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return new BindingList<KyThi>((from kyThi in db.KyThis
                        select kyThi).Where(kyThi => kyThi.LoaiKyThi == 1).ToList());
            }
        }
        public static BindingList<KyThi> LoadExamTest()
        {
            using (var db = new QLTNDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return new BindingList<KyThi>((from kyThi in db.KyThis
                                               select kyThi).Where(kyThi => kyThi.LoaiKyThi == 2).ToList());
            }
        }

        public static void Insert(KyThi exam)
        {
            using (var db = new QLTNDataContext())
            {
                db.KyThis.InsertOnSubmit(exam);
                db.SubmitChanges();
            }
        }

        public static bool isExisted(string idKyThi)
        {
            using (var db = new QLTNDataContext())
            {
                return (db.KyThis.Where(exam => exam.IDKyThi == idKyThi).SingleOrDefault() == null) ? false : true;
            }
        }

        public static void SaveChanges(List<KyThi> updatedList)
        {
            using (var db = new QLTNDataContext())
            {
                List<string> id = updatedList.Select(e => e.IDKyThi).ToList();
                var uul = db.KyThis.Where(e => id.Contains(e.IDKyThi)).ToList();
                for (int i = 0; i < updatedList.Count; ++i)
                {
                    uul[i].SLThamGia = updatedList[i].SLThamGia;
                    uul[i].TenKyThi = updatedList[i].TenKyThi;
                    uul[i].ThoiGianBatDau = updatedList[i].ThoiGianBatDau;
                    uul[i].ThoiGianKetThuc = updatedList[i].ThoiGianKetThuc;
                }
                db.SubmitChanges();
            }
        }

        public static void delete(string id)
        {
            using (var db = new QLTNDataContext())
            {
                var item = db.KyThis.Where(exam => exam.IDKyThi == id).SingleOrDefault();
                if (item != null)
                {
                    try
                    {
                        db.KyThis.DeleteOnSubmit(item);

                        db.SubmitChanges();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    
                }
            }
        }
    }
}
