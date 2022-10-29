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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            NapDsNhom();
            NapDsNguoi();
            if (selectedNguoi != null && selectedNhom!=null)
                NapThongTin();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return bdsNhom.Current as NhomViewModel;
            }
        }
       
        public NguoiViewModel selectedNguoi
        {
            get
            {
                return bdsNguoi.Current as NguoiViewModel;
            }
        }
        void NapDsNhom()
        {
            var ls = NhomService.Getlist();
            bdsNhom.DataSource = ls;
            gridNhom.DataSource = bdsNhom;
        }
        void NapThongTin()
        {
            if (selectedNguoi != null)
            {
                lblDiaChi.Show();
                lblEmail.Show();
                lblPhoneNumber.Show();

                txtTenGoi.Show();
                txtemail.Show();
                txtdiachi.Show();
                txtsodienthoai.Show();

                txtTenGoi.Text = selectedNguoi.TenGoi;
                txtdiachi.Text = selectedNguoi.DiaChi;
                txtemail.Text = selectedNguoi.Email;
                txtsodienthoai.Text = selectedNguoi.PhoneNumber;
            }
            else
            {
                lblDiaChi.Hide();
                lblEmail.Hide();
                lblPhoneNumber.Hide();

                txtTenGoi.Text="Không có liên lạc nào trong nhóm này!";
                txtsodienthoai.Hide();
                txtdiachi.Hide();
                txtemail.Hide();
            }
        }
        void NapDsNguoi()
        {
            if (selectedNhom != null)
            {
                var ls = NguoiService.Getlist(selectedNhom.ID);
                bdsNguoi.DataSource = ls;
                gridNguoi.DataSource = bdsNguoi;
            }
            NapThongTin();

        }
        
        private void gridNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedNhom != null)
            {
                NapDsNguoi();
            }
        }

        private void gridNguoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapThongTin();
        }


        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new frmNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsNhom();
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                if (selectedNguoi != null)
                {
                    var rs = MessageBox.Show($"Nhóm {selectedNhom.TenNhom} đang có liên lạc, Bạn có chắc là muốn xóa Nhóm này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        NhomService.Deletenhom(selectedNhom);
                        NapDsNhom();
                        NapDsNguoi();
                    }
                }
                else
                {
                    var rs = MessageBox.Show($"Bạn có chắc là muốn xóa Nhóm {selectedNhom.TenNhom}?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        NhomService.Deletenhom(selectedNhom);
                        NapDsNhom();
                        NapDsNguoi();
                    }
                }
            }
        }

        private void btnXoaNg_Click(object sender, EventArgs e)
        {
            if (selectedNguoi != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa liên lạc này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NguoiService.Deletenguoi(selectedNguoi);
                    NapDsNguoi();
                    NapThongTin();
                }
            }
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var f = new frmNguoi(selectedNhom);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    NapDsNguoi();
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender,  KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (selectedNhom != null)
                {
                    var ls = NguoiService.TimKiemLienLac(selectedNhom.ID, txtTimKiem.Text);
                    bdsNguoi.DataSource = ls;
                    gridNguoi.DataSource = bdsNguoi;
                }
                NapThongTin();
            }
        }
    }
}
