using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._9_paran_neparan_i_djeljiv_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj:");
            int a = 0;
            try
            {

                a = int.Parse(Console.ReadLine());


                if (a % 2 == 0)
                {
                    Console.Write("Broj je paran.");

                }
                if (a % 3 == 0)
                {
                    Console.WriteLine("Broj je djeljiv s 3");
                }
                else
                {
                    Console.WriteLine("Broj {0} nije djeljiv sa 3, ostatak je {1}", a, (a % 3));
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(" Provjeri je li unesen broj?" + e.ToString());
            }



            Console.Read();
        }
    }
}
