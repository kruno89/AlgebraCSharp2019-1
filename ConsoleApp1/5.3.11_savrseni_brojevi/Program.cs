using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._11_savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su savršeni brojevi iz intervala [1,1000]:");
            int zbrojDjeljitelja;

            for (int i = 1; i <= 1000; i++)
            {
                zbrojDjeljitelja = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        zbrojDjeljitelja += j;
                    }
                }

                if (i == zbrojDjeljitelja)
                {
                    Console.Write("{0} , ", i.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
