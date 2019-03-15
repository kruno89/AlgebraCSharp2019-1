using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi auto. ");
            Automobil auto = new Automobil();
            Console.WriteLine("Unesi naziv: ");
            auto.NazivAutomobila = Console.ReadLine();
            Console.WriteLine("Unesi godinu: ");
            auto.GodinaProizvodnje = int.Parse (Console.ReadLine());
            Console.WriteLine("Unesi cijenu: ");
            auto.OsnovnaCijena = double.Parse (Console.ReadLine());

            Console.WriteLine("Vozilo se zove {0}, proizvedeno je godine {1} i staro je {2} godina, te ukupno kosta {3} na cijenu od {4} HRK.", auto.NazivAutomobila,
                auto.GodinaProizvodnje, auto.Starost(), auto.Cijena(), auto.OsnovnaCijena);

            Console.ReadKey();
        }
    }
}
