using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciranje novog objekta 

            Zaposlenik Z1 = new Zaposlenik("Marko", "Marković", "1234567890123");

            // ovdje treba ispravno unijeti broj bodova
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Ovdje unesi broj bodova: ");

                try
                {
                    Z1.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex) // ovdje lovimo special greške
                {
                    Console.WriteLine("GREŠKA: " + ex.Message);
                }
                catch (Exception ex) // ovdje pak lovimo ostatak grešaka
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }

            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Ovdje unesi vrijednost boda: ");

                try
                {
                    Z1.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("GREŠKA: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }

            // Ovdje pravimo ispis

            Console.WriteLine("Zaposlenik: " + Z1.Ime + " " + Z1.Prezime);
            Console.WriteLine("NETO: " + Z1.NetoIzracunPlace());
            Console.WriteLine("POREZ: " + Z1.Porez);
            Console.WriteLine("BRUTO: " + Z1.BrutoIzracunPlace());

            Console.ReadKey();



        }
    }
}
