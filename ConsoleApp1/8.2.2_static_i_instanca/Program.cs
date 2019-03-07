using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2_static_i_instanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ovdje unesi prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (Static_Instanca.Prost(broj))
            {
                Console.WriteLine("Broj je PROST.");
            }
            else
            {
                Console.WriteLine("Broje NIJE PROST.");
            }

            Static_Instanca SI = new Static_Instanca();
            if (SI.Savrsen(broj))
            {
                Console.WriteLine("Broj je SAVRŠEN.");
            }
            else
            {
                Console.WriteLine("Broj NIJE SAVRŠEN.");
            }

            Console.ReadKey();
        }
    }
}
