using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MEVPaint.GrafickiOblici
{
    public class Pravokutnik : GrafickiOblikcs
    {
        public Pravokutnik()
        {
            oblik = new Rectangle();
        }
        public override void Nacrtaj()
        {
            base.Nacrtaj();
            //razlike
            oblik.Width = Math.Abs(startPoint.X - endPoint.X);
            oblik.Height = Math.Abs(startPoint.Y - endPoint.Y);
            Canvas.SetTop(oblik, Math.Min(startPoint.Y, endPoint.Y));
            Canvas.SetLeft(oblik, Math.Min(startPoint.X, endPoint.X));
        }

    }
}
