using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Upišite rečenicu.");
            string unos = Console.ReadLine();
            string[] rijeci = unos.Split();
            Console.WriteLine(rijeci.First() +" "+ rijeci.Last());

            Console.ReadLine();
        }
    }
}
