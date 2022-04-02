using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_pc
{
    class Program
    {
        public  class computer
        {
            public string displaycard;
            public string CPU;
            public string ram;
            public string mainboard;
            public string ssd;
            public string psu;
        }
        static void Main(string[] args)
        {
            computer computer = new computer();
            computer.displaycard = "Amd Rx 570";
            computer.CPU = "Amd ryzen 5 1600";
            computer.mainboard = "Asus B-420";
            computer.psu = "Corsair 750w";
            computer.ram = "SKhynix 16gb";
            computer.ssd = "WD BLUE SN550 M2 ssd";
            Console.WriteLine("Anakart: {0}", computer.mainboard);
            Console.WriteLine("İşlemci: {0}", computer.CPU);
            Console.WriteLine("Ram: {0}", computer.ram);
            Console.WriteLine("Power: {0}", computer.psu);
            Console.WriteLine("SSD: {0}", computer.ssd);
            Console.WriteLine("Ekran kartı: {0}", computer.displaycard);
            Console.WriteLine("Kapatmak için bir tuşa basınız !!!");
            Console.ReadKey();
        }
    }
}
