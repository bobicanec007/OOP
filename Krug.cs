using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEVPaint.GrafickiOblici
{
    public class Krug : Elipsa
    {
        public override void Nacrtaj()
        {
            base.Nacrtaj();
            if (oblik.Width < oblik.Height)
                oblik.Width = oblik.Height;
            else
                oblik.Height = oblik.Width;
        }
    }
}
