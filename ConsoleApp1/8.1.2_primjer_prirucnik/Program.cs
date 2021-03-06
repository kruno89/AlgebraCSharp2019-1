﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_primjer_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Što je to nastavnik?");
            Console.WriteLine(Nastavnik.Opis());
            Console.WriteLine("Koji je koeficijent nastavnika?");
            Console.WriteLine(Nastavnik.Koeficijent());

            Nastavnik n1 = new Nastavnik();
            // ne može postaviti READ ONLY property
            // n1.Ime = "Claudije";

            // ispis može
            Console.WriteLine("Njegovo ime je " + n1.Ime);

            // OIB možemo postaviti 
            n1.Oib = 12345;

            

            // Ne dozvoljava čitanje oiba
            // Console.WriteLine("Njegov OIB je " + n1.Oib);


            // Ispiši dio oiba
            Console.WriteLine("Njegov OIB je " + n1.PartialOib + "*********");
            
            
            
            
            //Instanciranje novog objekta klase Ucenik
            Ucenik ucenik1 = new Ucenik();

            //Inicijalizacija objekta
            Console.Write("Unesite ime učenika: ");
            ucenik1.Ime = Console.ReadLine();
            Console.Write("Unesite prezime učenika: ");
            ucenik1.Prezime = Console.ReadLine();
            Console.Write("Unesite ocjenu iz matematike: ");
            ucenik1.OcjenaIzMatematike =
                        int.Parse(Console.ReadLine());
            Console.Write("Unesite ocjenu iz biologije: ");
            ucenik1.OcjenaIzBiologije =
                        int.Parse(Console.ReadLine());
            Console.Write("Unesite ocjenu iz engleskog: ");
            ucenik1.OcjenaIzEngleskog =
                        int.Parse(Console.ReadLine());
            
            //Poziv metode objekta
            Console.WriteLine("Prosjek je " +
                        ucenik1.Prosjek() + ".");

            //2. objekt instanciran je pomoću 2.konstruktora
            Ucenik ucenik2 = new Ucenik("Marko", "Marković");
            Console.WriteLine("Ime učenika je " + ucenik1.Ime + " i " + ucenik2.Ime);

            //može i ovako // List<Ucenik> ucenici = new List<Ucenik>();
            List<Ucenik> ucenici = new List<Ucenik> { ucenik1, ucenik2 };
            ucenici.Add(ucenik1);
            ucenici.Add(ucenik2);

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNastavnici");

            List<Nastavnik> nastavnici = new List<Nastavnik> ();
            nastavnici.Add(n1);
            foreach (var item in nastavnici)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

}
