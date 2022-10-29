using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa.ViewModel
{
    public class NguoiViewModel
    {
        public int ID { get; set; }
        public String TenGoi { get; set; }
        public String Email { get; set; }
        public String DiaChi { get; set; }
        public String PhoneNumber { get; set; }       
        public int IDNhom { get; set; }
    }
}
