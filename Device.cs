using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_device
{
    internal class Device
    {
        private string model;
        private string serial;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        public Device() { }
        public Device(string model, string serial)
        {
            this.model = model;
            this.serial = serial;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap thong tin cua Device: ");
            Console.WriteLine("Nhap model: ");
            model = Console.ReadLine();
            Console.WriteLine("Nhap serial: ");
            serial = Console.ReadLine();
        }
    }
}
