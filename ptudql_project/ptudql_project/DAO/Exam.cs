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
        public static BindingList<string> LoadIdTest(string idExam)
        {
            using (var db = new QLTNDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return new BindingList<string>(db.KyThi_DeThis.Where(deThi => deThi.IdKyThi == idExam).Select(d => d.IdDe).ToList());
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
                    foreach (var k in item.KyThi_DeThis)
                    {
                        db.KyThi_DeThis.DeleteOnSubmit(k);
                    }
                    foreach (var d in item.DanhSachThis)
                    {
                        db.DanhSachThis.DeleteOnSubmit(d);
                    }
                    db.KyThis.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
            }
        }

        public static List<DeThi> getByContest(string username, KyThi contest)
        {
            using (var db = new QLTNDataContext())
            {
                var listExam = (from kd in db.KyThi_DeThis
                                join d in db.DeThis on kd.IdDe equals d.IdDe
                                where kd.IdKyThi == contest.IDKyThi
                                && (contest.LoaiKyThi != 1 ||
                                    d.DanhSachThis
                                    .Where(dst => dst.TKHocSinh == username
                                                & dst.IdKyThi == contest.IDKyThi)
                                    .Count() == 0)
                                select d).ToList();
                listExam.ForEach(e => e.BoDeThis.Load());
                return listExam;
            }
        }

        public static DeThi getOneById(string idDeThi)
        {
            using(var db = new QLTNDataContext())
            {
                return (from d in db.DeThis
                        where d.IdDe == idDeThi
                        select d).FirstOrDefault();
            }
        }
    }
}
