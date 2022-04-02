using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_87
{
    class Program
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
                        Console.WriteLine("hatalı bilgi");
                    else
                        a = value;
                }
            }
            public int B
            {
                get { return b; }
                set
                {
                    if (value <= 0)
                        Console.WriteLine("hatalı bilgi");
                    else b = value;
                }
            }
            public int C
            {
                get { return c; }
                set
                {
                    if (value <= 0)
                        Console.WriteLine("hatalı bilgi");
                    else c = value;
                }
            }
        }
        static void Main(string[] args)
        {
            ucgen ucgen = new ucgen();
            ucgen.A = 3; 
            ucgen.B = 4;
            ucgen.C = 5;
            Console.WriteLine("Üçgenin a kenar uzunluğu: {0}", ucgen.A);
            Console.WriteLine("Üçgenin b kenar uzunluğu: {0}", ucgen.B);
            Console.WriteLine("Üçgenin c kenar uzunluğu: {0}", ucgen.C);
            Console.ReadKey();
        }
    }
}
