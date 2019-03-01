using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._18_ocjene_unos
{
    class Program
    {
        static void Main(string[] args)
        {
            string ocjena = "";
            bool unosObavljen = false;

            while (!unosObavljen)
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = Console.ReadLine();

                if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                {
                    unosObavljen = true;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos!");
                }
            }

            Console.WriteLine("Ocjena je ispravno unesena.");
            Console.ReadKey();
        }
    }
}
