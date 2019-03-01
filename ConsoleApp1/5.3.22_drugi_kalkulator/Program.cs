using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._22_drugi_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            string odgovor = "D";

            while (odgovor == "D" || odgovor == "d")
            {
                Console.Write("Unesi 1.broj: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Unesi 2.broj: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Unesite operaciju računanja (+, -, *, /): ");
                operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("Razlika: {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("Umnožak: {0}", a * b);
                        break;
                    case "/":
                        Console.WriteLine("Kvocijent: {0}", a / b);
                        break;
                    default:
                        Console.Write("Nepoznata operacija računanja!");
                        break;




                }

                Console.Write("Želiš li ponovno računati (D/N)?");
                odgovor = Console.ReadLine();
            }
        }
    }
}
