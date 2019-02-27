using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._13_min_max_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int a;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Unesite {0}. prirodni broj:", i.ToString());
                a = int.Parse(Console.ReadLine());

                if (a < min)
                {
                    min = a;
                }
                if (a > max)
                {
                    max = a;
                }
            }
            Console.Write("Najmanji = {0} \n Najveći = {1}", min, max);
            Console.ReadKey();
        }
    }
}
