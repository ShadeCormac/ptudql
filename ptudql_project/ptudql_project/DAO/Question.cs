﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public class Question
    {
        public static List<CauHoi> LoadQuestion()
        {
            using(var db = new QLTNDataContext())
            {
                return (from cauHoi in db.CauHois
                        select cauHoi).Take(40).ToList();
            }
        }

        public static List<CauHoi> getByDeThi(string idDeThi)
        {
            using(var db = new QLTNDataContext())
            {
                return (from bd in db.BoDeThis
                join c in db.CauHois on bd.IdCauHoi equals c.IdCauHoi
                where bd.IdDe == idDeThi
                select c).ToList();
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
    }
}
