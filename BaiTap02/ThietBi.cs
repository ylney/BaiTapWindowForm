using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXUat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string ma, string ten, string nuocSX, double donGia, int soLuong)
        {
            MaThietBi = ma;
            TenThietBi = ten;
            NuocSanXUat = nuocSX;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }
        public string HienThi()
        {
            return string.Format("Mã thiết bị: {0}, Tên thiết bị: {1}, Nước sản xuất: {2}, Thành tiền: {3}", MaThietBi, TenThietBi, NuocSanXUat, ThanhTien());
        }
    }
}
