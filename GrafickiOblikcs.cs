using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MEVPaint.GrafickiOblici
{
    public class GrafickiOblikcs
    {
        // krajnje točke
        protected Point startPoint;
        protected Point endPoint;
        //boja
        protected Brush boja;
        // linija
        protected double debljinaLinije;
        protected Brush bojaLinije;
        // kanvas na koji se postavlja
        protected Canvas kanvas;
        //oblik koji postavljamo
        protected Shape oblik;

        // zadavanje oblika
        public virtual void Postavi(Canvas _kanvas, Point _pocetak, Point _kraj, Brush _boja, double _linija, Brush _bojaLinije)
        {
            kanvas = _kanvas;
            startPoint = _pocetak;
            endPoint = _kraj;
            boja = _boja;
            debljinaLinije = _linija;
            bojaLinije = _bojaLinije;
        }

        // metoda za crtanje oblika
        public virtual void Nacrtaj()
        {
            // ako ne postoji na kanvasu dodaj ga
            if (!kanvas.Children.Contains(oblik))
                kanvas.Children.Add(oblik);
            // ono što je zajednicko svim objektima
            oblik.Stroke = bojaLinije;
            oblik.StrokeThickness = debljinaLinije;
            oblik.Fill = boja;
        }

    }
}
