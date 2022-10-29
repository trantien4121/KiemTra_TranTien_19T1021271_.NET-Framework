using QuanLyDanhBa.Model;
using QuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa.Services
{
    public class NhomService
    {
        public static List<NhomViewModel> Getlist()
        {
            var db = new Model1();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();

            return rs;

        }

        public static KetQua addnhom(Nhom n)
        {
            var db = new Model1();
           
           /* db.Nhoms.Add(n);
            db.SaveChanges();
            return KetQua.ThanhCong;*/

            int count = db.Nhoms.Where(e => e.TenNhom == n.TenNhom).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.Nhoms.Add(n);
                db.SaveChanges();   //Luu lai thay doi
                return KetQua.ThanhCong;
            }

        }
        public static KetQua Updatenhom(NhomViewModel n)
        {
            var db = new Model1();
            var nhom = db.Nhoms.Where(e => e.ID == n.ID).FirstOrDefault();
            nhom.TenNhom = n.TenNhom;

            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua Deletenhom(NhomViewModel n)
        {
            var db = new Model1();
            var nhom = db.Nhoms.Where(e => e.ID == n.ID).FirstOrDefault();
            List<Nguoi> nguoiCuaNhom  = db.Nguois.Where(e => e.IDNhom == n.ID).ToList();
            foreach(Nguoi ng in nguoiCuaNhom)
            {
                db.Nguois.Remove(ng);
            }
            db.Nhoms.Remove(nhom);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
