using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobar_broj_2_5._2._7
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


                if (a % 4 == 0 && !(a >= 100))
                {
                    Console.Write("Broj je dobar.");

                }
                else
                {
                    Console.WriteLine("Broj nije dobar!");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(" Provjeri je li unesen broj?"+e.ToString());
            }


            
            Console.Read();
        }
    }
}
