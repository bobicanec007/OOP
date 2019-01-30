using Koktel.Sastojci;
using System;

namespace Koktel
{
    class Program
    {
        static void Main(string[] args)
        {
            // preprema koktela
            Koktel CubaLibre = new Koktel("Cuba Libre");
            CubaLibre.Dodaj(new Limeta(0.5)); // jedna limeta ima 0.4dcl
            CubaLibre.Dodaj(new Rum(0.4, "Bacardi Gold")); // zadaje se u dcl
            CubaLibre.Dodaj(new CocaCola(1, "zero")); // coca-coca = 2.5dcl
            CubaLibre.Dodaj(new Led("zdrobljeni")); // porcija leda = 1dcl
            Console.Write(CubaLibre.Posluzi());
            Console.ReadKey();
        }
    }
}
