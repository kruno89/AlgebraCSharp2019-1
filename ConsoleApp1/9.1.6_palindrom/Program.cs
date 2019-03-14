using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._6_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst: ");
            string tekst = Console.ReadLine();

            // Ovdje uklanjamo razmake
            tekst = tekst.Replace(" ", "");

            // String varijabla zdesna na lijevo
            string obrnuto = "";
            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                obrnuto += tekst[i];
            }

            // palindrom
            if (tekst == obrnuto)
            {
                Console.WriteLine("To je PALINDROM.");
            }
            else
            {
                Console.WriteLine("To NIJE PALINDROM.");
            }
            Console.ReadKey();
          

        }
    }
}
