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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            if (rdbTinhTong.Checked)
            {
                long tong = 0;
                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                }
                lblKetQua.Text = tong.ToString();
            }
            else if (rdbGiaiThua.Checked)
            {
                long giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }
                lblKetQua.Text = giaiThua.ToString();
            }
        }
    }
}
