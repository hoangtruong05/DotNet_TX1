using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1
{
    internal class Doctor
    {
        public string iD {  get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }  
        public string specialty { get; set; }
        public int experience { get; set; }
        public string mobile { get; set; }
        public Doctor() { }
        public Doctor(string iD, string fullName, string gender, string specialty, int experience, string mobile)
        {
            this.iD = iD;
            this.fullName = fullName;
            this.gender = gender;
            this.specialty = specialty;
            this.experience = experience;
            this.mobile = mobile;
        }
        public virtual void input()
        {
        
            Console.WriteLine("Nhap id: ");
            iD = Console.ReadLine();
            Console.WriteLine("Nhap fullName: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Nhap specialty: ");
            specialty = Console.ReadLine();
            Console.WriteLine("Nhap experience: ");
            experience = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mobile: ");
            mobile = Console.ReadLine();
        }
        // Override Object.ToString to provide formatted doctor information
        public override string ToString()
        {
            return $"{iD,-10} {fullName,-15} {gender,-6} {specialty,-15} {experience,-12} |{mobile,-10}";
        }
    }
    
}
