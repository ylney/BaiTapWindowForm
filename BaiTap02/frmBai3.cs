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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;

            string ketQua = " ";

            TienIch.NoiChuoi(ho, ten, ref ketQua);

            lblKetQuaChuoi.Text = ketQua;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            long ketQuaGT = TienIch.GiaiThua(n);

            lblKetQuaGT.Text = ketQuaGT.ToString();
        }
    }
}
