using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_Person
{
    internal abstract class Person
    {
        private string hoTen;
        private string diaChi;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public Person() { }
        public Person(string hoTen, string diaChi)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }
        public abstract void nhap();
        public abstract double tinhLuong();
    }
}
