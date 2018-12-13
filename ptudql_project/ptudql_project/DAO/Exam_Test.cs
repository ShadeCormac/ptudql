using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.DAO
{
    public class Exam_Test
    {
        public static void UpdateTests(string idKyThi, List<string> listDe)
        {
            try
            {
                using (var db = new QLTNDataContext())
                {
                    KyThi_DeThi kt_dt = new KyThi_DeThi();
                    kt_dt.IdKyThi = idKyThi;

                    /// fix hộ không delete mã đề thi cũ đc
                    var test = db.KyThi_DeThis.Where(t => t.IdKyThi == idKyThi).Select(kt => kt.IdDe);
                    if (test.Count() != 0)
                    {
                        foreach (string idDe in test)
                        {
                            kt_dt.IdDe = idDe;
                            db.KyThi_DeThis.DeleteOnSubmit(kt_dt);
                            db.SubmitChanges();
                        }
                    }
                    ///


                    if (listDe.Count() != 0)
                    {
                        foreach (string idDe in listDe)
                        {
                            kt_dt.IdDe = idDe;
                            db.KyThi_DeThis.InsertOnSubmit(kt_dt);
                            db.SubmitChanges();
                        }
                    }
                }
                MessageBox.Show("Thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thành công");
            }
        }
    }
}
