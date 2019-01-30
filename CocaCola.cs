using System;
using System.Collections.Generic;
using System.Text;

namespace Koktel.Sastojci
{
    class CocaCola : Sastojak
    {
        public CocaCola(double _kolicina, string _vrsta)
        {
            kolicina = _kolicina;
            kolicinaDeci = _kolicina * 2.5;
            vrsta = _vrsta;
        }
        public override string Prikazi()
        {
            return kolicina + " Coca-cola " + vrsta;
        }
    }
}
