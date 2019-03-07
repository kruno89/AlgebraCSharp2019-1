using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite naziv proizvoda: ");
            Proizvod proizvod = new Proizvod(Console.ReadLine());

            Console.Write("Unesite cijenu proizvoda: ");
            proizvod.Cijena = double.Parse(Console.ReadLine());
            Console.Write("Unesite maržu proizvoda: ");
            proizvod.Marza = double.Parse(Console.ReadLine());
            Console.Write("Unesite porez na proizvod: ");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena za proizvod {0} je {1}.", proizvod.Naziv, proizvod.MPC());

            Console.ReadKey();
        }
    }
}
