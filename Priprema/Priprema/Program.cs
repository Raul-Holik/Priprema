using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.4;
            double b = 2.2;
            double c = 5.1;
            double d = 1.2;
            double x = a * 2 + b * 2 + c * 2 + d * 2 / (a + b) * 2 + (c + d) * 2;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
