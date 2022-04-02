using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Daire
        {
            private double r ;
            public Daire(double r)
            {
                this. r = r;
            }
            public double AlanHesapla()
            {
                return  Math.PI*r*r ;
            }
            public double CevreHesapla()
            {
                return Math.PI*(r*2);
            }
        }
        static void Main(string[] args)
        {
            Daire d = new Daire(3); // daireye atama
            Console.WriteLine("Daire alanı: {0}", d.AlanHesapla());
            Console.WriteLine("Daire çevresi: {0}", d.CevreHesapla());
            Console.WriteLine("Programdan çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
