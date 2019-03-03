using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10_savrsen_nesavrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj: ");
                int a = int.Parse(Console.ReadLine());
                int zbrojDjelitelja = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        zbrojDjelitelja += i;
                    }

                }

                if (a == zbrojDjelitelja)
                {
                    Console.WriteLine("Uneseni broj je SAVRŠEN.");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je NESAVRSEN.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška u programu!");
                Console.WriteLine("Nisi unio broj: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
                
            
        }
    }
}
