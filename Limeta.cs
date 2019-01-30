using System;
using System.Collections.Generic;
using System.Text;

namespace Koktel.Sastojci
{
    class Limeta : Sastojak
    {
        public Limeta(double _kolicina)
        {
            kolicina = _kolicina;
            kolicinaDeci = _kolicina * 0.4;
        }
        public override string Prikazi()
        {
            return kolicina + " limete"; 
        }
    }

}
