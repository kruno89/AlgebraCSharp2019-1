using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_zaposlenik
{
    class Zaposlenik
    {

        #region Svojstva

        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        string jmbg;
        public string JMBG
        {
            get { return jmbg; }
            set { jmbg = value; }
        }


        double brojBodova;
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }
                else
                {
                    Exception ex = new Exception("Ne možeš unijeti negativnu brojčanu vrijednost, SAMO POZITIVNA!");
                    throw ex;
                }
            }
        }

        double vrijednostBoda;
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set
            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Ne možeš unijeti negativnu brojčanu vrijednost, samo POZITIVNA!");
                    throw ex;
                }
            }
        }

        // samo ReadOnly svojstvo

        public double Porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return neto * 0.06;
                }
                else if (neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }


            }
        }


        #endregion


        #region Metode 

        public double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }

        #endregion


        #region Konstruktori

        public Zaposlenik() { }

        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;

        }

        public Zaposlenik(string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;

        }

        #endregion

    }
}
