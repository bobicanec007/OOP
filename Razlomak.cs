using System;

namespace Razlomak1
{

    public class Razlomak  : IComparable<Razlomak>, IEquatable<Razlomak>
    {
        private int brojnik, nazivnik;

        // konstruktor
        public Razlomak(int brojnik, int nazivnik)
        {
            this.brojnik = brojnik;
            this.nazivnik = nazivnik;
        }

        public void ZadajBrojnik(int brojac)
        {

            this.brojnik = brojnik;

        }
        public void ZadajNazivnik(int nazivnik)
        {
            this.nazivnik = nazivnik;

        }

        public int VratiBrojnik()
        {
            return brojnik;

        }
        public int VratiNazivnik()
        {
            return nazivnik;

        }
        public float PretvoriUFloat()

        {
            return (float)brojnik / nazivnik;
        }

        public bool Ispravan()
        {
            return nazivnik != 0;
        }
        private int nzm(int a, int b)

        {
            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
               a = temp;
            }
            return a;

        }
        public void SkratiRazlomak()
        {
            if (brojnik < nazivnik)
            {
                int mjera = nzm(nazivnik, brojnik);
                brojnik = brojnik /mjera;
                nazivnik = nazivnik / mjera;
            }
            else
            {
                int mjera = nzm(brojnik, nazivnik);
                brojnik /= mjera;
                nazivnik /= mjera; 
            }

            }

        public int CompareTo(Razlomak other)
        {
           //throw new NotImplementedException();
          if (PretvoriUFloat()>other.PretvoriUFloat())
            return 1;

            else if( PretvoriUFloat() < other.PretvoriUFloat())
                    return -1;
            else
            return 0;
        }
        //kolkoovij
        public bool Equals(Razlomak other)
        {
            //throw new NotImplementedException();
            return brojnik == other.VratiBrojnik() &&
                nazivnik == other.VratiNazivnik();
            }

        //public override bool Equals(object obj)
        //{
        //    return this.Equals((Razlomak)obj);
        //}
    }
    }
    
