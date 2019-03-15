using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();
            while (broj > 0)
            {
                arr.Add(broj % 10);
                broj /= 10;
            }

            Console.Write("Ispis znamenki naopako: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
