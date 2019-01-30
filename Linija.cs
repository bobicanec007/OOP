using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MEVPaint.GrafickiOblici
{
   public class Linija : GrafickiOblikcs
    {
        public Linija()
        {
            oblik = new Line();
        }
        public override void Nacrtaj()
        {
            base.Nacrtaj();
            // razlike za liniju
            (oblik as Line).X1 = startPoint.X;
            (oblik as Line).Y1 = startPoint.Y;
            (oblik as Line).X2 = endPoint.X;
            (oblik as Line).Y2 = endPoint.Y;

        }
    }
}
