using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korisnici
{
    class Program
    {
        private static List<Korisnik> korisnici = new List<Korisnik>();

        static void Main(string[] args)
        {
            Korisnik marko = new Korisnik("marko@mev.hr", "5555");
           //marko.Zadaj("marko@mev.hr","5555");
            Console.WriteLine(marko.PredstaviSe());

            Console.WriteLine();
            Student ivan = new Student("iivan@mev.hr", "0000");
            Console.WriteLine(ivan.PredstaviSe());
            //ivan.Zadaj("iivan@mev.hr", "0000");
            ivan.ZadajGodinuStudija(2);
            Console.WriteLine(((Korisnik)ivan).PredstaviSe());

            Console.WriteLine();
            Profesor pero = new Profesor();
            pero.Zadaj("ppero@mev.hr", "1111");
            pero.ZadajPredmete("OOP1, AISP, PAUP");
            Console.WriteLine(pero.PredstaviSe());

            Console.WriteLine();
            StudentMeva ana = new StudentMeva();
            Console.WriteLine(ana.PredstaviSe());

            korisnici.Add(marko);
            korisnici.Add(ivan);
            korisnici.Add(pero);

            Console.WriteLine("\nPopis korisnika:");
            foreach(Korisnik k in korisnici)
            {
                Console.WriteLine(k.PredstaviSe());
            }
            Console.WriteLine();
        }
    }
}
