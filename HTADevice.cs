using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_device
{
    internal class HTADevice:Device
    {
        private int iD;
        private string commPort;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string CommPort
        {
            get { return commPort; }
            set { commPort = value; }
        }
        public HTADevice() { }
        public HTADevice(string model, string serial, int ID, string CommPort)
            :base(model, serial)
        {
            this.ID = ID;
            this.CommPort = CommPort;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap id: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap CommPort");
            CommPort = Console.ReadLine();
        }
        public string getDate()
        {
            return DateTime.Now.ToString("dd//MM//yyyy");
        }
        public override string ToString()
        {
            return $"{Model}  {Serial}  {ID}  {CommPort}";
        }
    }
}
