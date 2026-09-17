using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    internal class TienIch
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            hoten = hoten.Trim();
            int viTriKhoangTrangDau = hoten.IndexOf(" ");

            if (viTriKhoangTrangDau == -1)
            {
                s1 = hoten;
                s2 = " ";
            }
            else
            {
                s1 = hoten.Substring(0, viTriKhoangTrangDau);
                s2 = hoten.Substring(viTriKhoangTrangDau + 1).Trim();
            }
        }

        public static bool ThuTu(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }
}
