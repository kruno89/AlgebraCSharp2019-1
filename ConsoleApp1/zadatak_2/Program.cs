using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();

            while (true)
            {
                Console.Write("Unesite riječ: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                {
                    break;
                }
                else 
                {
                    rijeci.Add(rijec);

                }

            }

            // slovo a

            List<string> rijeciSaSlovomA = (from ri in rijeci
                                            where ri.ToLower().StartsWith("a")
                                            select ri).ToList();
            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"A\" su: ");

            foreach  (string rijec in rijeciSaSlovomA)
            {
                Console.WriteLine(rijec + ", ");
            }


            // slovo b
            List<string> rijeciSaSlovomB = (from ri in rijeci
                                            where ri.ToLower().StartsWith("b")
                                            select ri).ToList();

            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"B\" su: ");

            foreach (string rijec in rijeciSaSlovomB)
            {
                Console.WriteLine(rijec + ", ");
            }

            // slovo c
            List<string> rijeciSaSlovomC = (from ri in rijeci
                                            where ri.ToLower().StartsWith("c")
                                            select ri).ToList();
            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"C\" su: ");

            foreach (string rijec in rijeciSaSlovomC)
            {
                Console.WriteLine(rijec + ", ");
            }

            // ostale riječi // kako ostale da prepozna?

            ////List<string> rijeciOstale = (from ri in rijeci
            //                                where ri.ToLower().("")
            //                                select ri).ToList();
            //Console.WriteLine();
            //Console.Write("Ostale riječi \"\" su: ");

            //foreach (string rijec in rijeciOstale)
            //{
            //    Console.WriteLine(rijec + ", ");
            //}

            Console.ReadKey();
        }
    }
}
