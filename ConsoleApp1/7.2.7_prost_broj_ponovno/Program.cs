using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._7_prost_broj_ponovno
{
    class Program
    {
        static void Main(string[] args)
        {
            char odgovor = 'd';

            while (odgovor == 'D' || odgovor == 'd')
            {
                Console.WriteLine();
                Console.Write("Ovdje unesi neki prirodan broj koji želiš: ");
                int broj = int.Parse(Console.ReadLine());

                if (Prost(broj))
                {
                    Console.WriteLine("Broj je PROST.");
                }
                else
                {
                    Console.WriteLine("Broj je SLOŽEN.");
                }

                Console.Write("Želiš li ispočetka (D/N) ?");
                odgovor = Console.ReadKey().KeyChar;
            }
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
