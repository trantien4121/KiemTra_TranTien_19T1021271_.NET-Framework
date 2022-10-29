using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
        ThatBai
    }
    public class NhomViewModel
    {
        public int ID { get; set; }
        public String TenNhom { get; set; }

    }
}
