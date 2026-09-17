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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            double kq = 0;

            if (rdCong.Checked)
            {
                kq = so1 + so2;
            }
            else if (rdTru.Checked)
            {
                kq = so1 - so2;
            }
            else if (rdNhan.Checked)
            {
                kq = so1 * so2;
            }
            else if (rdChia.Checked)
            {
                kq = so1 / so2;
            }

            lblKetQua.Text = kq.ToString();
        }
    }
}
