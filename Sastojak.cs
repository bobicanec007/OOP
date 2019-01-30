using System;
using System.Collections.Generic;
using System.Text;

namespace Koktel
{
    class Sastojak
    {
        protected double kolicina;
        protected double kolicinaDeci;
        protected string vrsta;

        public double VratiDecilitre()
        {
            return kolicinaDeci;
        }
        public virtual string Prikazi()
        {
            return "nedefiniran";
        }
    }
}
