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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double diemLT = double.Parse(txtDiemLT.Text);
            double diemTH = double.Parse(txtDiemTH.Text);

            double dtb = (diemLT + diemTH) / 2;

            if (diemLT < 5 || diemTH < 5)
            {
                lblKetQua.Text = "Yếu";
            }
            else if (dtb < 7)
            {
                lblKetQua.Text = "Trung bình";
            }
            else if (dtb >= 7 && dtb < 8)
            {
                lblKetQua.Text = "Khá";
            }
            else if (dtb >= 8 && dtb < 9)
            {
                lblKetQua.Text = "Giỏi";
            }
            else
            {
                lblKetQua.Text = "Xuất sắc";
            }
        }
    }
}
