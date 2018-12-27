using ptudql_project.Utils;
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
        public static BindingList<KyThi> LoadExam(int loaiKT)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                db.DeferredLoadingEnabled = false;
                return new BindingList<KyThi>((from kyThi in db.KyThis
                                               where kyThi.LoaiKyThi == loaiKT
                                               select kyThi).ToList());
            }
        }

        public static BindingList<string> LoadIdTest(string idExam)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                db.DeferredLoadingEnabled = false;
                return new BindingList<string>(db.KyThi_DeThis.Where(deThi => deThi.IdKyThi == idExam).Select(d => d.IdDe).ToList());
            }
        }
        public static void Insert(KyThi exam)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                db.KyThis.InsertOnSubmit(exam);
                db.SubmitChanges();
            }
        }

        public static bool isExisted(string idKyThi)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return (db.KyThis.Where(exam => exam.IDKyThi == idKyThi).SingleOrDefault() == null) ? false : true;
            }
        }

        public static void SaveChanges(List<KyThi> updatedList)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
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

        public static bool delete(string id)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                var item = db.KyThis.Where(exam => exam.IDKyThi == id).SingleOrDefault();
                if (item.DanhSachThis.Any())
                {
                    return false;
                }
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
            return true;
        }

        public static List<DeThi> getByContest(string username, KyThi contest)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                var listExam = (from kd in db.KyThi_DeThis
                                join d in db.DeThis on kd.IdDe equals d.IdDe
                                where kd.IdKyThi == contest.IDKyThi
                                && (contest.LoaiKyThi != 1 ||
                                    d.DanhSachThis
                                    .Where(dst => dst.TKThi == username
                                                & dst.IdKyThi == contest.IDKyThi)
                                    .Count() == 0)
                                select d).ToList();
                listExam.ForEach(e => e.BoDeThis.Load());
                return listExam;
            }
        }

        public static DeThi getOneById(string idDeThi)
        {
            using(var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return (from d in db.DeThis
                        where d.IdDe == idDeThi
                        select d).FirstOrDefault();
            }
        }
    }
}
