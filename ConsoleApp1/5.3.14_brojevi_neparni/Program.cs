using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._14_brojevi_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su neparni brojevi iz intervala [1, 10]: ");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write("{0} , ", i.ToString());
            }

            Console.ReadKey();
        }
    }
}
