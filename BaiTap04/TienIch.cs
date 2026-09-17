using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap04
{
    internal class TienIch
    {
        public static string ChaoHoi(string hoten, bool gioiTinh)
        {
            if (gioiTinh == true)
            {
                return "Chào ông " + hoten;
            }
            else
            {
                {
                    return "Chào bà " + hoten;
                }
            }
        }
        public static int USCLN(int m, int n)
        {
            m = Math.Abs(m);
            n = Math.Abs(n);

            while (n != 0)
            {
                int du = m % n;
                m = n;
                n = du;
            }
            return m;
        }
    }
}
