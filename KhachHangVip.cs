using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1
{
    internal class KhachHangVip:KhachHang
    {
        private string ngayLamThe { get; set; }

        public KhachHangVip()
        {

        }
        public KhachHangVip(string maKhachHang, string gioiTinh, int soLuongMua, double donGia, string ngayLamThe)
            :base( maKhachHang,  gioiTinh,  soLuongMua,  donGia)
        {
            this.ngayLamThe = ngayLamThe;
        }
        public override void nhapThongTin()
        {
            base.nhapThongTin();
            Console.WriteLine("Nhap vao ngay lam the: (dd/mm/yyyy)");
            ngayLamThe = Console.ReadLine();
        }
        public override double tinhTongTien()
        {
           double tong =  base.tinhTongTien();
            if (tong <= 1000) return tong *= 0.9;
            return tong *= 0.8;
        }
        public override string ToString()
        {
            return $"{MaKhachHang,-10} {GioiTinh,-10} {ngayLamThe,-12} {SoLuongMua,-10} {DonGia,-10} {tinhTongTien(),-12}";
        }
    }
}
