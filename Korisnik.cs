using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korisnici
{
    public class Korisnik
    {
        protected string korisnickoIme;
        protected string zaporka;

        public Korisnik()
        {
            korisnickoIme = "nedefinirano";
            zaporka = "12345";
            Console.WriteLine("Pozivam inicijalni konstruktor korisnika");
        }
        public void Zadaj(string  _korisnickoIme, string _zaporka)
        {
            korisnickoIme = _korisnickoIme;
            zaporka = _zaporka;
        }
        public Korisnik(string _korisnickoIme, string _zaporka)
        {
            korisnickoIme = _korisnickoIme;
            zaporka = _zaporka;
        }
        public virtual string PredstaviSe()
        {
            return String.Format("Ja sam korisnik {0} zaporka mi je {1}",
                korisnickoIme, zaporka);
        }
    }
}
