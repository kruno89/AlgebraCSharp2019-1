using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ovdje unesite radijus kruga: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Opseg kruga s radijusom {0} je {1}.", r, Math.Round(OpsegKruga(r), 2));
            Console.ReadKey();
        }

        static double OpsegKruga(double r)
        {
            return 2 * r * Math.PI;
        }
        static double PovrsinaKruga(double r)
        {
            return r * r * Math.PI;
        }
    }
}
