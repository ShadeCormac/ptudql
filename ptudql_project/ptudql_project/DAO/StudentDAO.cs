using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.DAO
{
    public class StudentDAO
    {
        public static HocSinh getInfo(string username)
        {
            using(var db = new QLTNDataContext())
            {
                return db.HocSinhs.Where(hs => hs.TenTK == username).FirstOrDefault();
            }
        }

        public static bool SaveInfo(HocSinh newStudentInfo)
        {
            try
            {
                using(var db = new QLTNDataContext())
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
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi");
                return false;
            }
        }
    }
}
