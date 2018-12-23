using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    class Exam
    {
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
