using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b = 0;
            Console.WriteLine("Unesi 1. broj");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. broj");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je:{0}", a + b);

            Console.WriteLine("Razlika je:{0}", a - b);

            Console.WriteLine("Razlika je:{1} Zbroj je:{0}", a + b,  a - b);

            int c = 0, d = 0;
            Console.WriteLine("Unesite 1.broj:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2.broj:");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Umnožak: {0}, Kvocijent {1}", c*d, (float)c/(float)d);
            Console.WriteLine("Pritisnite neku tipku za kraj...");
            




            Console.ReadLine();
        }
    }
}
