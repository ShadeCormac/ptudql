﻿using ptudql_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.DAO
{
    public partial class Account
    {
        public static bool isRegisterd(string userName)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return (db.TaiKhoans.Where(account => account.TenDangNhap == userName).SingleOrDefault() == null) ? false : true;
            }
        }
        public static void Register(TaiKhoan account)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                db.TaiKhoans.InsertOnSubmit(account);
                db.SubmitChanges();

            }
        }

        // add them tai khoan cua admin
        public static void Register_admin(TaiKhoan account)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                db.TaiKhoans.InsertOnSubmit(account);
                db.SubmitChanges();
            }

            if (account.LoaiTK == 3)
            {
                DAO.Student.Insert(account);
            }
            else if (account.LoaiTK == 2)
            {
                TeacherDAO.Insert(account);
            }
        }

        public static string getPassword(string userName)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return db.TaiKhoans.Where(account => account.TenDangNhap == userName).Single().MatKhau;
            }
        }

        public static BindingList<TaiKhoan> GetAll()
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return new BindingList<TaiKhoan>(db.TaiKhoans.ToList());
            }
        }

        public static bool deleteAccount(string username)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                var userToDelete = db.TaiKhoans.Where(user => user.TenDangNhap == username).FirstOrDefault();
                if (userToDelete == null)
                {
                    return false;
                }
                db.TaiKhoans.DeleteOnSubmit(userToDelete);
                db.SubmitChanges();
                return true;
            }
        }

        // cap nhat lai danh sach sau khi thay doi
        public static void updateListAccount(BindingList<TaiKhoan> Accounts)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                foreach (TaiKhoan Acc in Accounts)
                {
                    var userUpdate = db.TaiKhoans.Where(user => user.TenDangNhap == Acc.TenDangNhap).FirstOrDefault();
                    if (userUpdate != null)
                    {
                        db.TaiKhoans.DeleteOnSubmit(userUpdate);
                        db.TaiKhoans.InsertOnSubmit(Acc);
                        db.SubmitChanges();
                        if (Acc.LoaiTK == 2)
                        {
                            
                        }
                    }      
                }
            }
        }

        public static void Import(List<TaiKhoan> listAcc)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                foreach (TaiKhoan Acc in listAcc)
                {
                    if (db.TaiKhoans.Where(acc => acc.TenDangNhap == Acc.TenDangNhap).SingleOrDefault() != null)
                    {
                        continue;
                    }
                    else
                    {
                        db.TaiKhoans.InsertOnSubmit(Acc);
                        if (Acc.LoaiTK == 3)
                        {
                            HocSinh newHS = new HocSinh
                            {
                                TenTK = Acc.LoaiTK.ToString()
                            };
                            db.HocSinhs.InsertOnSubmit(newHS);
                        }
                        else if (Acc.LoaiTK == 2)
                        {
                            GiaoVien newGV = new GiaoVien
                            {
                                TenTK = Acc.LoaiTK.ToString()
                            };
                            db.GiaoViens.InsertOnSubmit(newGV);
                        }
                    }
                }
                db.SubmitChanges();
            }
        }

        public static void changePassword(TaiKhoan acc)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                var old = db.TaiKhoans
                    .Where(tk => tk.TenDangNhap == acc.TenDangNhap)
                    .SingleOrDefault();
                if (old != null)
                {
                    old.MatKhau = acc.MatKhau;
                    db.SubmitChanges();
                }
            }
        }

        public static int getAccountType(string username)
        {
            using (var db = new QLTNDataContext(Connection.CurrentConnectionString))
            {
                return (int)db.TaiKhoans.Where(acc => acc.TenDangNhap == username).Single().LoaiTK;
            }
        }
    }
}
