using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._7_ispis_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi koji su djeljivi sa 7, a nisu djeljivi 3 iz intervala [1,100] su:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.Write("{0} , ", i.ToString());
                }

            }
            Console.ReadKey();
        }
    }
}
