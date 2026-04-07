using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1
{
    internal class KhachHang
    {
        private string maKhachHang;
        private string gioiTinh;
        private int soLuongMua;
        private double donGia;

        public string MaKhachHang 
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int SoLuongMua
        {
            get { return soLuongMua; }
            set { soLuongMua = value; }
        }
        public double DonGia
        {
            get { return donGia; }
            set {donGia = value; }
        }

        public KhachHang()
        {
            maKhachHang = " ";
            gioiTinh = " ";
            soLuongMua = 0;
            donGia = 0;
        }
        public KhachHang(string maKhachHang, string gioiTinh, int soLuongMua, double donGia)
        {
            this.maKhachHang = maKhachHang;
            this.gioiTinh=gioiTinh;
            this.soLuongMua=soLuongMua;
            this.donGia=donGia;
        }
        public virtual double tinhTongTien()
        {
            return soLuongMua*donGia;
        }

        public virtual void nhapThongTin()
        {
            Console.WriteLine("Nhap ma khach hang: ");
            maKhachHang=Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            gioiTinh=Console.ReadLine();
            Console.WriteLine("Nhap so luong mua: ");
            soLuongMua=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don gia: ");
            donGia=double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{maKhachHang, -10} {gioiTinh, -10} {"N/A", -12} {soLuongMua, -10} {donGia, -10} {tinhTongTien(), -12}";
        }
        public override bool Equals(object obj)
        {
            if (obj is KhachHang kh)
                return this.maKhachHang == kh.maKhachHang;
            return false;
        }
    }
}
