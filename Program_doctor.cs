using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Surgeon> danhSach = new List<Surgeon>();
            int chon;
            //Surgeon sr1 = new Surgeon("123", "Hoang", "Nam", "Da khoa", 12, "09876589", "Chan doan", 20);
            Surgeon sr2 = new Surgeon("124", "Van", "Nam", "Da khoa", 12, "09876589", "Chan doan", 10);
            Surgeon sr3 = new Surgeon("125", "Truong", "Nam", "Da khoa", 12, "09876589", "Chan doan", 30);
            danhSach.Add(sr1);
            danhSach.Add(sr2);
            danhSach.Add(sr3);
            do
            {
                Console.WriteLine("=====DANH SACH CHUC NANG=====");
                Console.WriteLine("1. Them");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("4. Tim kiem bac si bang ID");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Chon chuc nang muon thuc hien 1-4:");
                if (!int.TryParse(Console.ReadLine(), out chon))
                    continue;
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin bac si phau thuat: ");
                        Surgeon sr = new Surgeon();
                        sr.input();
                        danhSach.Add(sr);
                        break;
                    case 2:
                        Console.WriteLine();
                        if (danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sach rong.");
                            break;
                        }
                        Console.WriteLine("Danh sach bac si phau thuat:");
                        Console.WriteLine($"{"iD",-10}{"fullName",-10}{"gender",-10}{"specialty",-15}{"experience",-12}{"mobile",-10}{"surgeryType",-15}{"numberOfSurgeries|",-15}");
                        Console.WriteLine(new string('-', 100));
                        foreach (Surgeon obj in danhSach)
                        {
                            Console.WriteLine(obj);
                            Console.WriteLine(new string('-', 100));
                        }
                        break;
                    case 3:
                        // Sap xep theo numberOfSurgeries tang dan
                        if (danhSach.Count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Danh sach rong, khong co gi de sap xep.");
                        }
                        else
                        {
                            danhSach = danhSach.OrderBy(d => d.numberOfSurgeries).ToList();
                            Console.WriteLine();
                            Console.WriteLine("Da sap xep theo so ca phau thuat (tang dan).");
                            Console.WriteLine($"{"iD",-10}{"fullName",-10}{"gender",-10}{"specialty",-15}{"experience",-12}{"mobile",-10}{"surgeryType",-15}{"numberOfSurgeries|",-15}");
                            Console.WriteLine(new string('-', 100));
                            foreach (var dr in danhSach)
                            {
                                Console.WriteLine(dr);
                                Console.WriteLine(new string('-', 100));
                            }
                               
                        }
                        break;
                    case 4:
                        Console.Write("Nhap Id bac si can tim: ");
                        string findId = Console.ReadLine();
                        Surgeon canTim = danhSach.Find(d => d.iD == findId);
                        if (canTim != null)
                        {
                            Console.WriteLine("Ket qua tim duoc la: ");
                            Console.WriteLine($"{"iD",-10}{"fullName",-10}{"gender",-10}{"specialty",-15}{"experience",-12}{"mobile",-10}{"surgeryType",-15}{"numberOfSurgeries|",-15}");
                            Console.WriteLine(new string('-', 100));
                            Console.WriteLine(canTim.ToString());
                        }
                        else
                            Console.WriteLine($"Khong tim thay bac si co id: {findId}");
                        break;
                    case 5:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                }

            } while (chon != 5);
            
            
        }
    }
}
