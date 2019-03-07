using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_primjer_prirucnik
{
    class Ucenik
    {
        //Polja klase
        public DateTime DatumNastanka;
        private string ime = "";
        public string Prezime = "";
        public int OcjenaIzMatematike = 0;
        public int OcjenaIzEngleskog = 0;
        public int OcjenaIzBiologije = 0;

        public string Ime
        {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }


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
        public override string ToString()
        {
            return "Moje ime je " + Ime + " a moj prosjek je: " + Prosjek();
        }
    }
}
