using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.DAO
{
    class Contest
    {
        public static List<KyThi> getContestByType(int type, string username = "")
        {
            using (var db = new QLTNDataContext())
            {
                var now = DateTime.Now;
                return db.KyThis
                    .Where(k => k.LoaiKyThi == type 
                        && now >= k.ThoiGianBatDau && now <= k.ThoiGianKetThuc 
                        && (k.LoaiKyThi != 1 || (
                            k.DanhSachThis.Where(dst => dst.TKThi == username).Count() <
                            k.KyThi_DeThis.Count
                        ))).ToList();
            }
        }
        public static List<KyThi> getListContest(string username)
        {
            return getContestByType(1, username);
        }

        public static List<KyThi> getListTrialContest()
        {
            return getContestByType(2);
        }

        public static List<DanhSachThi> getListContestResult(int type, string username)
        {
            using (var db = new QLTNDataContext())
            {
                return (from dst in db.DanhSachThis
                        join k in db.KyThis on dst.IdKyThi equals k.IDKyThi
                        where k.LoaiKyThi == type && dst.TKThi == username
                        select dst).ToList();
            }
        }

        public static List<string> getListIdKyThiFromDST(List<DanhSachThi> lstDST)
        {
            return (from dst in lstDST
                    group dst by dst.IdKyThi into g
                    select g.Key).ToList();
        }

        public static bool saveContestResult(string username, string idKyThi, string idDe, float score, bool isTrial)
        {
            using(var db = new QLTNDataContext())
            {
                try
                {
                    DanhSachThi dst = new DanhSachThi();
                    dst.TKThi = username;
                    dst.IdDe = idDe;
                    dst.IdKyThi = idKyThi;
                    dst.Diem = Math.Round(score, 2);

                    int lanThi = 1;

                    if (isTrial)
                    {
                        lanThi = db.DanhSachThis
                            .Where(d => d.IdDe == idDe && d.IdKyThi == idKyThi && d.TKThi == username)
                            .DefaultIfEmpty()
                            .Max(d => d == null ? 0 : d.LanThi) + 1;
                    }

                    dst.LanThi = lanThi; 
                        
                    db.DanhSachThis.InsertOnSubmit(dst);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi");
                    return false;
                }
                
            }
        }
    }
}
