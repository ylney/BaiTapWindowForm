using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap04
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanPham { get; set; }

        public SanPham()
        {

        }

        public int NamHetHan()
        {
            return NgaySanPham.Year + 3;
        }

        public string HienThi()
        {
            return string.Format("Mã sản phẩm: {0}; Tên sản phẩm: {1}; Loại sản phẩm: {2}; Ngày sản xuất: {3:dd/MM/yyyy}; Năm hết hạn: {4}", MaSanPham, TenSanPham, LoaiSanPham, NgaySanPham, NamHetHan());
        }
    }
}
