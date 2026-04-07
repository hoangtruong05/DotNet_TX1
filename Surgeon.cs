using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1
{
    internal class Surgeon:Doctor
    {   
        public string surgeryType {  get; set; }
        public int numberOfSurgeries { get; set; }
        public Surgeon() { }
        public Surgeon(string iD, string fullName, string gender, string specialty, int experience, string mobile, string surgeryType, int numberOfSurgeries)
            :base(iD, fullName, gender, specialty, experience, mobile)
        {
            this.surgeryType = surgeryType;
            this.numberOfSurgeries = numberOfSurgeries;
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap surgeryType: ");
            surgeryType = Console.ReadLine();
            Console.WriteLine("Nhap numberOfSurgeries: ");
            numberOfSurgeries = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{iD,-10}{fullName,-10}{gender,-10}{specialty,-15}{experience,-12}{mobile,-10}{surgeryType,-15}{numberOfSurgeries,-15}";
        }
    }
}
