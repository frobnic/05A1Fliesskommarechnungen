using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05A1Fliesskommarechnungen
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 3.0f, g = 3.5f;

            Console.WriteLine("f = {0:F2}  g = {1:F2}", f, g);
            Console.WriteLine();
            Console.WriteLine("pause...");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Summe     f+g {0,10:F4}", f + g);
            Console.WriteLine("Differenz f-g {0,10:F4}", f - g); 
            Console.WriteLine("Produkt   f*g {0,10:F4}", f * g);
            Console.WriteLine("Quotient  f/g {0,10:F4}", f / g);
        }
    }
}
