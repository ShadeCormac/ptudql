using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.DAO
{
    public partial class Question
    {
        public static List<CauHoi> LoadQuestion()
        {
            using(var db = new QLTNDataContext())
            {
                return (from cauHoi in db.CauHois
                        select cauHoi).Take(40).ToList();
            }
        }

        public static void AddRequest(CauHoi request)
        {
            using (var db = new QLTNDataContext())
            {
                db.CauHois.InsertOnSubmit(request);
                db.SubmitChanges();
            }
        }

        public static BindingList<CauHoi> GetAllQuestions()
        {
            using (var db = new QLTNDataContext())
            {
                
                return new BindingList<CauHoi>(db.CauHois.ToList());
            }
        }

        public static void SaveChanges(List<CauHoi> updatedList)
        {
            using (var db = new QLTNDataContext())
            {
                List<int> id = updatedList.Select(quest => quest.IdCauHoi).ToList();
                var uul = db.CauHois.Where(quest => id.Contains(quest.IdCauHoi)).ToList();
                for (int i = 0; i < updatedList.Count; ++i)
                {
                    uul[i].LoaiCauHoi = updatedList[i].LoaiCauHoi;
                    uul[i].NoiDung = updatedList[i].NoiDung;
                    uul[i].CauA = updatedList[i].CauA;
                    uul[i].CauB = updatedList[i].CauA;
                    uul[i].CauC = updatedList[i].CauB;
                    uul[i].CauD = updatedList[i].CauC;
                    uul[i].CauTLDung = updatedList[i].CauTLDung;
                }
                db.SubmitChanges();
            }
        }

        
    }
}
