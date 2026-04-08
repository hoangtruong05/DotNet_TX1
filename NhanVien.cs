using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_Person
{
    internal class NhanVien : Person
    {
        private string maNV;
        private string chucVu;
        private int heSoLuongCB;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        public int HeSoLuongCB
        {
            get { return heSoLuongCB; }
            set { heSoLuongCB = value; }
        }
        public NhanVien() { }
        public NhanVien(string hoTen, string diaChi, string MaNV, string ChucVu, int HeSoLuongCB)
            : base(hoTen, diaChi)
        {
            this.MaNV = MaNV;
            this.ChucVu = ChucVu;
            this.HeSoLuongCB = HeSoLuongCB;
        }
        public int heSoChucVu()
        {
            switch (ChucVu.ToLower())
            {
                case "giam doc": return 10; break;
                case "truong phong": return 6; break;
                case "pho giam doc": return 6; break;
                case "pho phong": return 10; break;
                default: return 2;

            }
        }
        public override double tinhLuong()
        {
            return (HeSoLuongCB + heSoChucVu()) * 2000000;
        }
        public override string ToString()
        {
            return $"{HoTen,-20}\t{DiaChi,-15}\t{MaNV,-10}\t{ChucVu,-12}\t{HeSoLuongCB,-17}\t{tinhLuong(),-10}";
        }
        public override void nhap()
        {
            try
            {
                Console.WriteLine("Nhap ho va ten: ");
                HoTen = Console.ReadLine();
                Console.WriteLine("Nhap dia chi: ");
                DiaChi = Console.ReadLine();
                Console.WriteLine("Nhap ma nhan vien: ");
                MaNV = Console.ReadLine();
                Console.WriteLine("Nhap chuc vu: ");
                ChucVu = Console.ReadLine();
                Console.WriteLine("Nhap he so luong co ban: ");
                HeSoLuongCB = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Loi du lieu vao khong hop le!");
            }
        }
    }
}
