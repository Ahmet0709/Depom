using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_öğrenci
{
    class Program
    {
        public class ogrenci
        {
            public string number;
            public string name;
            public string gender;
        }
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.name = "Abdul Fettah RAJEH";
            ogrenci.number = "1006";
            ogrenci.gender = "E";
            Console.WriteLine("ogrencinin Adı-Soyadı: {0}", ogrenci.name);
            Console.WriteLine("Ögrencinin numarası : {0}", ogrenci.number);
            Console.WriteLine("Ogrencinin cinsiyeti: {0}", ogrenci.gender);
            Console.WriteLine("kapatmak için bir tuşa basınız!!");
            Console.ReadKey();

        }
    }
}
