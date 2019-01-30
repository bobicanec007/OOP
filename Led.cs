using System;
using System.Collections.Generic;
using System.Text;

namespace Koktel.Sastojci
{
    class Led : Sastojak
    {
        public Led(string _vrsta)
        {
            vrsta = _vrsta;
            kolicinaDeci = 1;
        }
        public override string Prikazi()
        {
            return "Led " + vrsta;
        }
    }

}
