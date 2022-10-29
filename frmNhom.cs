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
    public partial class frmNhom : Form
    {
        NhomViewModel nhom;
        public frmNhom(NhomViewModel nhom = null)
        {
            InitializeComponent();
            this.nhom = nhom;
            if (nhom != null)
            {
                txtTenNhom.Text = nhom.TenNhom;
            }
        }

        private void btnDongY_Click_1(object sender, EventArgs e)
        {
            if (this.nhom == null)
            {
                var nhomThem = new Nhom
                {
                    TenNhom = txtTenNhom.Text,

                };
                if (String.IsNullOrEmpty(txtTenNhom.Text))
                {
                    MessageBox.Show("Tên nhóm không được để trống", "Thong bao");
                    txtTenNhom.Focus();


                }
                else
                if (NhomService.addnhom(nhomThem) == KetQua.ThanhCong)
                {
                    MessageBox.Show("Thêm Thành công");

                    DialogResult = DialogResult.OK; //Bao ket qua
                }
                else
                {
                    MessageBox.Show("Tên Lớp đã tồn tại", "Thông báo");
                    txtTenNhom.Focus();
                }
            }
            else
            {
                nhom.TenNhom = txtTenNhom.Text;

                NhomService.Updatenhom(nhom);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
