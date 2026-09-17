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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string ho = " ", ten = " ";

            TienIch.TachChuoi(hoTen, ref ho, ref ten);

            lblHo.Text = ho;
            lblTen.Text = ten;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            bool kiemTra = TienIch.ThuTu(n1, n2);

            if (kiemTra)
            {
                lblKestQuaSo.Text = "Đây là hay số nguyên liên tiếp.";
            }
            else
            {
                lblKestQuaSo.Text = "Đây không phải là hai số nguyên liên tiếp.";
            }
        }
    }
}
