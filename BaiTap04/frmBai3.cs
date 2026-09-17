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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnChaoHoi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;

            bool gioiTinh = rdbNam.Checked;

            string thongBao = TienIch.ChaoHoi(hoTen, gioiTinh);

            lblKetQuaChao.Text = thongBao;
        }

        private void btnUSCLN_Click(object sender, EventArgs e)
        {

            int m = int.Parse(txtM.Text);
            int n = int.Parse(txtN.Text);

            int ketQua = TienIch.USCLN(m, n);

            lblKetQuaUSCLN.Text = ketQua.ToString();
        }
    }
}
