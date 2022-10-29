using QuanLyDanhBa.Model;
using QuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa.Services
{
    public class NguoiService
    {
        //Lay toan bo lop hoc
        public static List<NguoiViewModel> Getlist()
        {
            var db = new Model1();
            var rs = db.Nguois.Select(e => new NguoiViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                DiaChi = e.DiaChi,
                PhoneNumber = e.PhoneNumber,
                IDNhom = (int)e.IDNhom
            }).ToList();

            return rs;

        }

        public static List<NguoiViewModel> Getlist(int idNhom)
        {
            var db = new Model1();
            var rs = db.Nguois.Where(e => e.IDNhom == idNhom).Select(e => new NguoiViewModel 
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                DiaChi = e.DiaChi,
                IDNhom = (int)e.IDNhom
            }).ToList();
            return rs;
        }
        public static KetQua Addnguoi(Nguoi n)
        {
            var db = new Model1();

            
            db.Nguois.Add(n);
            db.SaveChanges();   //Luu lai thay doi
            return KetQua.ThanhCong;


        }

        public static KetQua Updatenguoi(NguoiViewModel n)
        {
            var db = new Model1();
            var nguoi = db.Nguois.Where(e => e.ID == n.ID).FirstOrDefault();
            nguoi.TenGoi = n.TenGoi;
            nguoi.Email = n.Email;
            nguoi.DiaChi = n.DiaChi;
            nguoi.PhoneNumber = n.PhoneNumber;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua Deletenguoi(NguoiViewModel n)
        {
            var db = new Model1();
            var nguoi = db.Nguois.Where(e => e.ID == n.ID).FirstOrDefault();
            db.Nguois.Remove(nguoi);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static List<NguoiViewModel> TimKiemLienLac(int idNhom, string key)
        {
            var rs = NguoiService.Getlist(idNhom).Where(e => e.TenGoi.ToLower().Contains(key.ToLower()) || 
                                                        e.PhoneNumber.ToLower().Contains(key.ToLower()) || 
                                                        e.Email.ToLower().Contains(key.ToLower()) ||
                                                        e.DiaChi.ToLower().Contains(key.ToLower())).ToList();
            return rs;
        }
    }
}
