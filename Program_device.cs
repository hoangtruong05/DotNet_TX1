using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_device
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HTADevice> danhSach = new List<HTADevice>();
            int chon;
            HTADevice hta1 = new HTADevice("Model1", "HTA001", 123456, "CommPort01");
            HTADevice hta2 = new HTADevice("Model2", "HTA002", 123457, "CommPort02");
            HTADevice hta3 = new HTADevice("Model3", "HTA003", 123458, "CommPort03");
            danhSach.Add(hta1);
            danhSach.Add(hta2);
            danhSach.Add(hta3);
            do
            {
                Console.WriteLine("===== HE THONG QUAN LY THIET BI(DEVICE) =====");
                Console.WriteLine("1. Them thiet bi");
                Console.WriteLine("2. Hien thi danh sach thiet bi");
                Console.WriteLine("3. Tim kiem theo ma ID");
                Console.WriteLine("4. Sap xep theo ma ID (giam dan)");
                Console.WriteLine("5. Xoa thiet bi theo ma ID");
                Console.WriteLine("6. Thoat");
                Console.Write("Chon chuc nang can thuc hien 1-6: ");
                if (!int.TryParse(Console.ReadLine(), out chon)) continue;
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin cua thiet bi");
                        Console.WriteLine();
                        HTADevice hta = new HTADevice();
                        hta.Input();
                        if(danhSach.Any(x => x.ID == hta.ID))
                        {
                            Console.WriteLine("ID da ton tai. Them that bai!");
                        }
                        else
                        {
                            danhSach.Add(hta);
                            Console.WriteLine("Them thanh cong!");
                        }
                        break;
                    case 2:
                        if(danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong!");
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Danh sach thiet bi: ");
                        Console.WriteLine($"{"Model"}\t{"Serial"}\t{"ID"}\t{"CommPort"}");
                        Console.WriteLine(new string('-', 35));
                        foreach (HTADevice device in danhSach)
                        {
                            Console.WriteLine(device.ToString());
                            Console.WriteLine(new string ('-',35));
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Nhap ID cua thiet bi can tim: ");
                        int find_id = int.Parse(Console.ReadLine());
                        HTADevice canTim = danhSach.Find(x => x.ID == find_id);
                        if(canTim == null)
                        {
                            Console.WriteLine("Khong tim thay thiet bi!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Thiet bi co ma {find_id} can tim la: ");
                            Console.WriteLine($"{"Model"}\t{"Serial"}\t{"ID"}\t{"CommPort"}");
                            Console.WriteLine(new string('-', 35));
                            Console.WriteLine(canTim.ToString());
                            Console.WriteLine(new string('-', 35));
                        }
                        break;
                    case 4: 
                        Console.WriteLine("Nhap ma thiet bi can xoa");
                        int del_id = int.Parse(Console.ReadLine());
                        HTADevice canXoa = danhSach.Find(x => x.ID ==del_id);
                        if(!danhSach.Any(x => x.ID == canXoa.ID))
                        {
                            Console.WriteLine($"Khong tim thay thiet bi nao co ma: {del_id} ");
                            break;
                        }
                        else
                        {
                            danhSach.Remove(canXoa);
                            Console.WriteLine($"Da xoa thiet bi co ma: {del_id} thanh cong!");
                            break;
                        }
                    case 5: 
                        if(danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong khong the sap xep");
                            break ;
                        }
                        else
                        {
                            danhSach = danhSach.OrderByDescending(x => x.ID).ToList();
                            Console.WriteLine("Danh sach sau khi sap xep giam dan theo ID");
                            Console.WriteLine($"{"Model"}\t{"Serial"}\t{"ID"}\t{"CommPort"}");
                            Console.WriteLine(new string('-', 35));
                            foreach (HTADevice obj in danhSach)
                            {
                                Console.WriteLine(obj.ToString());
                                Console.WriteLine(new string('-', 35));
                            }
                            break;
                        }
                }
            } while (chon != 6);
        }
    }
}
