using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._1_primjer_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite tekst: ");
            string upisano = Console.ReadLine();

            // Zapisivanje u datoteku // kreiranje handle, ovo prvo napisano 
            FileStream fs1 =
                new FileStream("Proba.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs1);

            sw.WriteLine(upisano);

            sw.Flush();

            sw.Close();
            fs1.Close();

            // Čitanje datoteke
            FileStream fs2 =
                new FileStream("Proba.txt", FileMode.Open);

            StreamReader sr = new StreamReader(fs2);

            string procitano = sr.ReadToEnd();

            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);
            Console.ReadKey();
        }
    }
}
