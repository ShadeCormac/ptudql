using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public partial class Account
    {
        public static bool isRegisterd(string userName)
        {
            using (var db = new QLTNDataContext())
            {
                return (db.TaiKhoans.Where(account => account.TenDangNhap == userName).SingleOrDefault() == null) ? false : true;
            }
        }
        public static void Register(TaiKhoan account)
        {
            using (var db = new QLTNDataContext())
            {
                db.TaiKhoans.InsertOnSubmit(account);
                db.SubmitChanges();
            }
        }
        public static string getPassword(string userName)
        {
            using (var db = new QLTNDataContext())
            {
                return db.TaiKhoans.Where(account => account.TenDangNhap == userName).Single().MatKhau;
            }
        }
    }
}
