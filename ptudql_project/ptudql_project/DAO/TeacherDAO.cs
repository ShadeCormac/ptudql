﻿using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptudql_project.DAO
{
    public class TeacherDAO
    {
        public static GiaoVien GetInfo(string Username)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return db.GiaoViens.Where(use => use.TenTK == Username).FirstOrDefault();
            }
        }

        public static bool SaveInfo(GiaoVien newInfo)
        {
            try
            {
                using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
                {
                    var TeacherUpdate = db.GiaoViens
                        .Where(user => user.TenTK == newInfo.TenTK)
                        .FirstOrDefault();
                    TeacherUpdate.HoTen = newInfo.HoTen;
                    TeacherUpdate.GioiTinh = newInfo.GioiTinh;
                    TeacherUpdate.Email = newInfo.Email;
                    TeacherUpdate.DiaChi = newInfo.DiaChi;
                    TeacherUpdate.SoDienThoai = newInfo.SoDienThoai;
                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi");
                return false;
            }
        }

        public static void Insert(TaiKhoan account)
        {
            using(var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                GiaoVien newGV = new GiaoVien
                {
                    TenTK = account.TenDangNhap,

                };
                db.GiaoViens.InsertOnSubmit(newGV);
                db.SubmitChanges();
            }
        }
    }
}
