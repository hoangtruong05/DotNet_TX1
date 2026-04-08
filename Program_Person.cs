using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> danhSach = new List<NhanVien>();
            int chon;
            NhanVien nv1 = new NhanVien("Hoang Van Truong", "Hung Yen", "NV001", "Giam doc",5);
            NhanVien nv2 = new NhanVien("Hoang Van Truong", "Hung Yen", "NV002", "Pho giam doc", 4);
            NhanVien nv3 = new NhanVien("Nguyen Van Truong", "Hung Yen", "NV003", "Pho phong", 2);
            danhSach.Add(nv1);
            danhSach.Add(nv2);
            danhSach.Add(nv3);
            do
            {
                Console.WriteLine("===== HE THONG QUAN LY NHAN VIEN =====");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. Hien thi danh sach nhan vien");
                Console.WriteLine("3. Sap xep nhan vien theo ho ten tang dan");
                Console.WriteLine("4. Tim kiem nhan vien theo ma nhan vien");
                Console.WriteLine("5. Xoa nhan vien theo ma nhan vien");
                Console.WriteLine("6. Thoat");
                Console.Write("Chon chuc nang can thuc hien 1-6: ");
                if (!int.TryParse(Console.ReadLine(), out chon)) continue;
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhap ma nhan vien: ");
                        string ma = Console.ReadLine();
                        if(danhSach.Any(x => x.MaNV == ma))
                        {
                            Console.WriteLine("Ma nhan vien da ton tai. Them that bai!");
                            break;
                        }
                        else
                        {
                            NhanVien nv = new NhanVien();
                            nv.nhap();
                            danhSach.Add(nv);
                            break;
                        }
                    case 2:
                        if(danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("---- Danh sach nhan vien ----");
                            Console.WriteLine($"{"Ho ten", -20}\t{"Dia chi", -15}\t{"Ma NV", -10}\t{"Chuc vu", -12}\t{"He so luong CB", -17}\t{"Luong",-10}");
                            Console.WriteLine(new string('-', 105));
                            foreach(NhanVien nv in danhSach)
                            {
                                Console.WriteLine(nv.ToString());
                                Console.WriteLine(new string('-', 105));
                            }
                            break;
                        }
                    case 3:
                        danhSach = danhSach.OrderBy(x => x.HoTen).ThenBy(x => x.HeSoLuongCB).ToList();
                        Console.WriteLine("---- Danh sach nhan vien sau khi sap xep ----");
                        Console.WriteLine($"{"Ho ten",-20}\t{"Dia chi",-15}\t{"Ma NV",-10}\t{"Chuc vu",-12}\t{"He so luong CB",-17}\t{"Luong",-10}");
                        Console.WriteLine(new string('-', 105));
                        foreach (NhanVien nv in danhSach)
                        {
                            Console.WriteLine(nv.ToString());
                            Console.WriteLine(new string('-', 105));
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ma nhan vien can tim kiem: ");
                        string maFind = Console.ReadLine();
                        NhanVien canTim = danhSach.Find(d => d.MaNV == maFind);
                        if(canTim == null)
                        {
                            Console.WriteLine($"Khong tim thay nhan vien co ma {maFind}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Nhan vien co ma {maFind} can tim la: ");
                            Console.WriteLine($"{"Ho ten",-20}\t{"Dia chi",-15}\t{"Ma NV",-10}\t{"Chuc vu",-12}\t{"He so luong CB",-17}\t{"Luong",-10}");
                            Console.WriteLine(new string('-', 105));                           
                            Console.WriteLine(canTim.ToString());
                            Console.WriteLine(new string('-', 105));
                            break;
                        }
                    case 5:
                        Console.WriteLine("Nhap ma nhan vien can xoa: ");
                        string maDel = Console.ReadLine();
                        NhanVien canXoa = danhSach.Find(d => d.MaNV ==  maDel);

                        if(canXoa == null)
                        {
                            Console.WriteLine($"Khong tim thay nhan vien co ma {maDel}");
                            break;
                        }
                        else
                        {
                            danhSach.Remove(canXoa);
                            Console.WriteLine("Danh sach nhan vien sau khi xoa la: ");
                            Console.WriteLine($"{"Ho ten",-20}\t{"Dia chi",-15}\t{"Ma NV",-10}\t{"Chuc vu",-12}\t{"He so luong CB",-17}\t{"Luong",-10}");
                            Console.WriteLine(new string('-', 105));
                            foreach(NhanVien nv in danhSach)
                            {
                                Console.WriteLine(nv.ToString());
                                Console.WriteLine(new string('-', 105));
                            }
                            break;
                        }
                }
            } while (chon != 6); 
            
        }
    }
}
