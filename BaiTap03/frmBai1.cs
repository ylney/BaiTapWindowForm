using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap03
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            double heSoLuong = double.Parse(txtLuong.Text);
            double heSoPhuCap = double.Parse(txtPhuCap.Text);

            NhanVien nv = new NhanVien(ma, ten, ngaySinh, heSoLuong, heSoPhuCap);

            lblKetQua.Text = nv.HienThi();
        }
    }
}
