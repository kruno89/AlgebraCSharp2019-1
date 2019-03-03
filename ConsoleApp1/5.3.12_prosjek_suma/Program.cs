using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12_prosjek_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {          
            int zbroj = 0;
            float prosjek;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Unesite {0}. prirodni broj:", i.ToString());
                zbroj += int.Parse(Console.ReadLine());
            }
            prosjek = (float) zbroj / 5;

            Console.Write("Zbroj = {0} \nProsjek = {1}", zbroj, prosjek);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška u programu!");
                Console.WriteLine("Nisi unio prirodni broj: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
