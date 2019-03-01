using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._20_par_nepar_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojParnih = 0;
            int brojNeparnih = 0;
            int broj = -1;

            while (broj != 0)
            {
                Console.Write("Unesite prirodan broj: ");
                broj = int.Parse(Console.ReadLine());

                if (broj != 0)
                {
                    if (broj %2 == 0)
                    {
                        brojParnih++;
                    }
                    else
                    {
                        brojNeparnih++;
                    }
                }
            }

            Console.WriteLine("Parnih: " + brojParnih.ToString());
            Console.WriteLine("Neparnih: " + brojNeparnih.ToString());
            Console.ReadKey();
        }
    }
}
