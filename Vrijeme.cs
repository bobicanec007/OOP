using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba4_Vrijeme.Logika
{
    public class Vrijeme
    {
        // privatna varijabla koja zapisuje stanje vrremena
        private int sekundi;

        // konstruktori
        public Vrijeme()
        {
            sekundi = 0;
        }

        public Vrijeme(int sek)
        {
            sekundi = sek;
        }

        public Vrijeme(string hhmmss)
        {
            //sekundi =
            //    int.Parse(hhmmss.Split(':')[0]) * 60 * 60 +
            //    int.Parse(hhmmss.Split(':')[1]) * 60 +
            //    int.Parse(hhmmss.Split(':')[2]);
            string[] hms = hhmmss.Split(':');
            sekundi =
                int.Parse(hms[0]) * 60 * 60 +
                int.Parse(hms[1]) * 60 +
                int.Parse(hms[2]);
        }

        // vrati vrijeme kao string
        public string VratiString()
        {
            int sati = sekundi / 3600;
            int minuta = (sekundi % 3600) / 60;
            int sek = sekundi % 60;
            return string.Format("Vrijeme {0}s = {1} sati, {2} minuta i {3} sekundi",
                sekundi, sati, minuta, sek);
        }

        // zadaj metode
        public void ZadajSate(double sati)
        {
            sekundi = (int)(sati * 3600);
        }

        public void ZadajMinte(double minuta)
        {
            sekundi = (int)(minuta * 60);
        }

        public void ZadajSekunde(int sek)
        {
            sekundi = sek;
        }

        // vrati metoda
        public double VratiSate()
        {
            return (double)sekundi / 3600;
        }

        public double VratiMinute()
        {
            return (double)sekundi / 60;
        }

        public int VratiSekunde()
        {
            return sekundi;
        }

        // dodaj i oduzmi vremena
        public void DodajVrijeme(Vrijeme v)
        {
            sekundi += v.VratiSekunde();
        }

        public void OduzmiVrijeme(Vrijeme v)
        {
            sekundi -= v.VratiSekunde();
        }
    }
}
