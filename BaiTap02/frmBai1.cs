using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ma = txtMaTB.Text;
            string ten = txtTenTB.Text;
            string nuoc = txtNuocSX.Text;
            double gia = double.Parse(txtDonGia.Text);
            int sl = int.Parse(txtSoLuong.Text);

            ThietBi tb = new ThietBi(ma, ten, nuoc, gia, sl);

            lblKetQua.Text = tb.HienThi();
        }
    }
}
