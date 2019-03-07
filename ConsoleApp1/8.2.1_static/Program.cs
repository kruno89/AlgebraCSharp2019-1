using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ovdje unesi prvi broj: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ovdje unesi drugi broj: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", Static.Zbroj(a, b));

            Console.Write("Ovdje unesi broj za kubiranje: ");
            double broj = double.Parse(Console.ReadLine());
            Console.WriteLine(Static.Kub(broj));

            Console.Write("Ovdje unesi x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Ovdje unesi x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Ovdje unesi y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Ovdje unesi y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljenost točaka: " + Static.Udaljenost(x1, x2, y1, y2));

            Console.Write("Ovdje unesi Celzijuse: ");
            broj = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + Static.Fahrenheit(broj));

            Console.ReadKey();

        }
    }
}
