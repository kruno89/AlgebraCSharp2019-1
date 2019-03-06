using System;
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
            Console.WriteLine(ucenik2.Prezime + " " + ucenik2.Ime);

            Console.ReadKey();
        }
    }

    class Ucenik
    {
        //Polja klase
        public DateTime DatumNastanka;
        public string Ime = "";
        public string Prezime = "";
        public int OcjenaIzMatematike = 0;
        public int OcjenaIzEngleskog = 0;
        public int OcjenaIzBiologije = 0;

        //Konstruktor1
        public Ucenik()
        {
            DatumNastanka = DateTime.Now;
        }
        //Konstruktor2
        public Ucenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        //Ostale metode
        public double Prosjek()
        {
            return
                (double)
                (OcjenaIzMatematike
                + OcjenaIzBiologije
                + OcjenaIzEngleskog)
                / 3;
        }
    }
}
