using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._6_prost_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ovdje unesi jedan prirodan broj po želji: ");
            int broj = int.Parse(Console.ReadLine());

            if (Prost(broj))
            {
                Console.WriteLine("Broj je PROST.");

            }
            else
            {
                Console.WriteLine("Broj je SLOŽEN.");
            }

            Console.ReadKey();
        }

        static bool Prost(int broj)
        {
            bool prost = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
        }
    }
}
