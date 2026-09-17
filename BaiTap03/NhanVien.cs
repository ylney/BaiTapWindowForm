using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        public NhanVien(string ma, string hoTen, DateTime ngaySinh, double heSoLuong, double heSoPhuCap)
        {
            MaNV = ma;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("Mã nhân viên: {0}; Họ tên: {1}; Ngày sinh: {2: dd/MM/yyyy}; Tổng lương: {3:N0} VNĐ", MaNV, HoTen, NgaySinh, TongLuong());
        }
    }
}
