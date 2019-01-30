using KosaricaZaKupovinu.Logika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uđe marko u dućan
            Vlasnik marko = new Vlasnik(
                "marko@mev.com", "Marko Markovic", "Mihovljanska 12, Cakovec");

            Console.WriteLine("Kupac: {0}", marko);

            // Marko mijenja adresu
            marko.PromijeniAdresu("A.G.Markoša 113, Varaždin");

            Console.WriteLine("Kupac mijenja adresu..\nKupac: {0}", marko);

            // Marko uzima košaricu
            Kosarica markovaKosarica = new Kosarica(marko);

            //marko kupuje
            Stavka st = new Stavka("TV LG 58 615", 8667.23m);
            markovaKosarica.DodajStavku(st);
            markovaKosarica.DodajStavku(new Stavka("Produzni kabel", 54.45m,2));
            markovaKosarica.DodajStavku(new Stavka("Antena TVX", 123.50m, 1));

            markovaKosarica.ObrisiStavku(st);

            // Ispisati košaricu - u kolokviju
            Console.WriteLine("\nIspis košarice\nID: {0}\nKupac: {1}\nStatus: {2}\nStavke:////////////////",
            markovaKosarica.VratiId(), markovaKosarica.VratiVlasnika(),
            markovaKosarica.VratiStatus());

            //ispis stavka
            int brojac = 0;
            foreach(Stavka s in markovaKosarica.VratiStavke())
            {
                Console.WriteLine("{0}. {1}", ++brojac, s);
            }

            //ukupno
            Console.WriteLine("Ukupuno za platiti: {0}", markovaKosarica.VratiIznos());
       



        }
    }
}
