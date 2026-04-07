using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> danhSach = new List<KhachHang>();
            int chon;
            do
            {
                Console.WriteLine();
                Console.WriteLine("===== DANH SACH CHUC NANG ===== ");
                Console.WriteLine("1. Nhap thong tin ");
                Console.WriteLine("2. Hien thi danh sach ");
                Console.WriteLine("3. Xoa khach hang ");
                Console.WriteLine("4. Thoat ");
                Console.WriteLine("Chon chuc nang muon thuc hien 1-4 ");
                if (!int.TryParse(Console.ReadLine(), out chon))
                    continue;
                switch (chon) {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("--- NHAP THONG TIN ---");
                        Console.WriteLine("1. Khach hang thuong");
                        Console.WriteLine("2. Khach hang Vip");
                        Console.WriteLine("Chon loai khach hang(1 or 2): ");
                        if (!int.TryParse(Console.ReadLine(), out int loai) || (loai != 1 && loai != 2))
                        {
                            Console.WriteLine("Lua chon khong hop le!");
                            return;
                        }

                        if(loai == 1)
                        {
                            KhachHang kh = new KhachHang();
                            kh.nhapThongTin();
                            danhSach.Add(kh);
                        }
                        if(loai == 2)
                        {
                            KhachHangVip khvip  = new KhachHangVip();
                            khvip.nhapThongTin();
                            danhSach.Add(khvip);
                        }

                        Console.WriteLine("Them khach hang thanh cong!");
                        Console.WriteLine();
                        break;
                    case 2:
                        if(danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong!");
                            return;
                        }
                        Console.WriteLine();
                        Console.WriteLine("--- DANH SACH KHACH HANG ---");
                        Console.WriteLine($"{"Ma KH",-10} {"Gioi tinh",-10} {"Ngay lam the",-12} {"SoLuong Mua",-10} {"Don gia",-10} {"Tong tien",-12}");
                        Console.WriteLine(new string('-', 70));
                        foreach(KhachHang kh in danhSach)
                        {
                            //Console.WriteLine(kh.ToString());
                            kh.ToString();
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Nhap ma khach hang can xoa: ");
                        string ma = Console.ReadLine();
                        KhachHang canXoa = danhSach.Find(kh => kh.MaKhachHang == ma);
                        if(canXoa != null)
                        {
                            danhSach.Remove(canXoa);
                            Console.WriteLine($"Da xoa khach hang co ma {ma}");
                        }
                        else
                            Console.WriteLine($"Khong tim thay khach hang co ma: {ma}");
                        break;
                    case 4:
                        Console.WriteLine("Chuong trinh ket thuc!");
                        break ;
                }

            } while (chon != 4);

        }
    }
}
