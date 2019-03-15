using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2._2_primjer_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Učitavamo datumski podatak
            Console.Write("Unesite podatak tipa DateTime: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            // Ispisujemo datume
            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            // Ispisujemo vrijeme
            Console.WriteLine("Vrijeme: ");
            // ako ne "kastamo", ispisuje se slovima
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            // Korisničko formatiranje
            // Sistemsko vrijeme ispisujemo na preciznost
            // tisućinke sekunde
            Console.WriteLine("Sada je točno: ");
            d1 = DateTime.Now;

            Console.WriteLine(
                d1.ToString("MMMM, dddd yyyy HH:mm:ss fff"));

            // Koliko je dana ima do Nove godine
            // 1) Kreiram novi datum za Novu godinu
            DateTime dNG = new DateTime(2019, 1, 1);

            // 2) Oduzimam tekući datum od datuma Nove godine
            TimeSpan ts = dNG.Subtract(d1);

            // 3) Ispisujemo koliko ima do Nove godine
            Console.WriteLine("Do Nove godine ima: ");
            Console.WriteLine("dana: " + ts.Days);
            Console.WriteLine("i sati: " + ts.Hours);
            Console.WriteLine(
                "To je ukupno sati: " + ts.TotalHours);
            Console.WriteLine(
                "Ili {0} dana {1} sati {2} minuta {3} sekundi",
                ts.Days, ts.Hours, ts.Minutes, ts.Seconds);

            // Povećanje datuma
            Console.WriteLine("Danas je izdana potvrda na 6 mjeseci. ");
            DateTime DatumIzdavanja = DateTime.Now;
            DateTime DatumIsteka =
                DatumIzdavanja.AddMonths(6);
            Console.WriteLine("Datum isteka: {0}", 
                DatumIsteka);

            Console.ReadKey();

        }
    }
}
