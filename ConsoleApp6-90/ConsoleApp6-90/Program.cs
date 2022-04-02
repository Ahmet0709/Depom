using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_90
{
    public class ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı g");
                else
                    A = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı g");
                else
                    B = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("hatalı g");
                else
                    C = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ucgen ucgen = new ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.C = 5;
            Console.WriteLine("A kenar uzunluğu: {0}", ucgen.A);
            Console.WriteLine("B kenar uzunluğu: {0}", ucgen.B);
            Console.WriteLine("C kenar uzunluğu: {0}", ucgen.C);
        }
    }
}
