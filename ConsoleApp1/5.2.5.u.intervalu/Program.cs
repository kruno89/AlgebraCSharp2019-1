using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._5.u.intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj:");
            int a = int.Parse(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                Console.WriteLine("Broj je u intervalu [100,200].");
            }
            else
            {
                Console.WriteLine("Broj nije u intervalu [100,200]!");
            }
            Console.ReadKey();
        }
    }
}
