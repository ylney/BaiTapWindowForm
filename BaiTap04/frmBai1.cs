using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap04
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.LoaiSanPham = txtLoaiSP.Text;
            sp.NgaySanPham = dtpNgaySX.Value;
            lblKetQua.Text = sp.HienThi();
        }
    }
}
