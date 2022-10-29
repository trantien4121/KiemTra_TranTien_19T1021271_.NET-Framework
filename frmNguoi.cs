using QuanLyDanhBa.Model;
using QuanLyDanhBa.Services;
using QuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhBa
{
    public partial class frmNguoi : Form
    {
        NguoiViewModel nguoi;
        NhomViewModel nhom;
        public frmNguoi(NhomViewModel nhom = null)
        {
            InitializeComponent();
            this.nhom = nhom;
            if (nhom != null)
            {
                txtTenNhom.Text = nhom.TenNhom;
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.nhom != null)
            {
                var nguoiThem = new Nguoi
                {
                    TenGoi = txtTenGoi.Text,
                    Email = txtEmail.Text,
                    DiaChi =txtDiaChi.Text,
                    PhoneNumber = txtSoDienThoai.Text,
                    IDNhom = nhom.ID
                    
                };
                if (NguoiService.Addnguoi(nguoiThem) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK; //Bao ket qua
                }
            }
        }
    }
}
