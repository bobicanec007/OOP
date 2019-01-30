using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Knjiga
    {
        public double cijena;
        public string tip;
        public string autor;
        public int kolicina;
    }

    class Program
    {
        private static List<Knjiga> knjige = new List<Knjiga>();
        static void Main(string[] args)
        {
            Knjiga k1 = new Knjiga();
            k1.tip = "Harry Potter i Kamen Mudraca";
            k1.autor = "J.K.Rowling";
            k1.cijena = 200;
            k1.kolicina = 1;
            knjige.Add(k1);


            knjige.Add(new Knjiga
            {
                tip = "Pale sam na svijetu",
                autor = "Mateo",
                cijena = 100,
                kolicina = 2,
            });

            knjige.Add(new Knjiga
            {
                tip = "Harry Potter i Plameni Pehar",
                autor = "J.K.Rowling",
                cijena = 200,
                kolicina = 3,
            });

            knjige.Add(new Knjiga
            {
                tip = "Zlocin i Kazna",
                autor = "Ivan Bartolic",
                cijena = 140,
                kolicina = 2,
            });

            knjige.Add(new Knjiga
            {
                tip = "Crvenkapica",
                autor = "Josip Strosmajer",
                cijena = 160,
                kolicina = 4,
            });
            double min = double.MaxValue;
            foreach (Knjiga k in knjige)
            {
                if (k.cijena < min)
                {
                    min = k.cijena;
                }
            }

            double ukupnaCijenaKnjiga = 0;
            int brojKnjiga = 0;
            foreach (Knjiga k in knjige)
            {
                brojKnjiga++;
                ukupnaCijenaKnjiga += k.cijena;
            }

            double ukupnaCijena = 0;
            foreach (Knjiga k in knjige)
            {
                ukupnaCijena += k.kolicina * k.cijena;
                Console.WriteLine("{0,-20}{1,-20}{2,10}{3,10}", k.tip, k.autor, k.cijena, k.kolicina);
            }
            Console.WriteLine("Ukopni iznos {0}", ukupnaCijena);
            Console.WriteLine("Najeftinija knjiga {0}", min);
            Console.WriteLine("Prosjecna cijena svih knjiga iznosi: {0}", ukupnaCijenaKnjiga / brojKnjiga);
        }
    }
}


//moramo napisati 10 knjiga u neku liste, ispiste prosjecnu cijenu artikla, 
//napraviti strukturu sa par polja, list tip, tipa knjiga, dodati u tu listu 5knjiga, najeftinja knjiga je ta, prosjecna cijena je ta.
//razredi nece biti na kolokviju-to danas.

   //List<knjiga>
   //3,4 knjige
   //ukopni iznos
   //najeftinije knjige
   //prosjecnu cijenu
