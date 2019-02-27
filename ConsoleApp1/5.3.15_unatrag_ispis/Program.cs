using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._15_unatrag_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su prirodni brojevi iz intervala [1,10] unatrag:");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
