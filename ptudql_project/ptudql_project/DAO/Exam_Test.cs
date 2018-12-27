using ptudql_project.Utils;
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
        public static void removeTests(string idKyThi)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                var query = db.KyThi_DeThis.Where(k => k.IdKyThi == idKyThi).ToList();
                db.KyThi_DeThis.DeleteAllOnSubmit(query);
                db.SubmitChanges();
            }
        }
        public static void insertTests(string idKyThi, List<string> listIdDe)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                KyThi_DeThi curTest = null;
                foreach (string idDe in listIdDe)
                {
                    curTest = new KyThi_DeThi
                    {
                        IdDe = idDe,
                        IdKyThi = idKyThi
                    };
                    db.KyThi_DeThis.InsertOnSubmit(curTest);
                }
                db.SubmitChanges();
            }
        }
    }
}
