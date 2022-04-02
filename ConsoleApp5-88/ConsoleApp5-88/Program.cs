using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_88
{
    public class ucgen
    {
        public int A;
        public int B;
        public int C;
        public int cevre
        {
            get
            {
                return A + B + C;
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
            Console.WriteLine("Üçgenin çevresi:{0}", ucgen.cevre);
            Console.ReadKey();
        }
    }
}
