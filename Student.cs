using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korisnici
{
    class Student : Korisnik
    {
        protected int godinaStudija;

        public Student()
        {
            korisnickoIme = "student";
            zaporka = "9999";
            Console.WriteLine("Pozivam inicijalni konstruktor Studenta");
        }
        public Student(string _korisnickoIme, string _zaporka) : base(_korisnickoIme, _zaporka)
        {
            //korisnickoIme = _korisnickoIme;
            //zaporka = _zaporka;
        }
        public void ZadajGodinuStudija(int godina)
        {
            godinaStudija = godina;
        }
        public sealed override string PredstaviSe()
        {
            return String.Format("Ja sam student {0}, {1} godine studija, zaporka mi je {2}",
                korisnickoIme,godinaStudija, zaporka);
        }
    }
}
