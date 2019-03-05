using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4_sa_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulaz_broj = Console.ReadLine();
            int broj = int.Parse(ulaz_broj);
            ulaz_broj.Reverse();
            //new string(ulaz_broj.Reverse().ToArray()) //izbaciš ako hoćeš da vrati na staro
            Console.WriteLine("Original: {0} Obrnuti: {1} ", broj, new string(ulaz_broj.Reverse().ToArray()));
            Console.ReadKey();
        }
    }
}
