using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vjezba4_Vrijeme.Logika
{
    /*
     * 1. Napišite razred Tocka kojim je ostvarena dvodimenzionalna točka. Razred mora sadržavati:
        1.1.	Ispravno definiran naziv razreda
        1.2.	Podatak o apscisi (x) tipa float
        1.3.	Podatak o ordinati (y) tipa float
        1.4.	Podrazumijevani konstruktor koji točku inicijalizira na x=10, y=10
        1.5.	Konstruktor kojim se postavljaju oba svojstva (x i y)
        1.6.	Metodu za postavljanje svojstva x
        1.7.	Metodu za postavljanje svojstva y
        1.8.	Metodu za dohvat svojstva x
        1.9.	Metodu za dohvat svojstva y
        1.10.	Metodu za postavljanje oba svojstva x i y u jednom pozivu
        1.11.	Metodu za pomak točke u x i y smjeru 
        1.12.	Metodu za izračun udaljenosti do točke čiji se parametri predaju kao dvije koordinate tipa float
        1.13.	Metodu za izračun udaljenosti do točke koja se metodi predaje kao tip Tocka
    */

    class Tocka
    {
        private float x;
        private float y;

        /// <summary>
        /// Podrazumijevani konstruktor
        /// </summary>
        public Tocka()
        {
            x = 10;
            y = 10;
        }

        /// <summary>
        ///  Konstruktor koji prima dva parametra
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Tocka(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void postaviX(float x)
        {
            // Console.WriteLine("Promjena svojstva x!!!");
            this.x = x;
        }

        public void postaviY(float y)
        {
            // Console.WriteLine("Promjena svojstva y!!!");
            this.y = y;
        }

        public float dohvatiX()
        {
            float val = 0;

            val = x;

            return val;
        }

        public float dohvatiY()
        {
            return y;
        }

        public void postaviXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void postaviTocku(Tocka t)
        {
            this.x = t.dohvatiX();
            this.y = t.dohvatiY();
        }

        public void pomakniZa(float dx, float dy)
        {
            this.x += dx;
            this.y += dy;
        }


        /// <summary>
        /// -Metoda za izračun udaljenosti do točke čiji se parametri predaju 
        /// kao dvije koordinate tipa float. Modifikator pristupa metodeje private
        /// te se ona ne može korsititi izvan razreda.
        /// </summary>
        /// <param name="x">Koordinata X točke do koje se izračunava udaljenost</param>
        /// <param name="y">Koordinata Y točke do koje se izračunava udaljenost</param>
        /// <returns>Udaljenost između točke objekta do točke definirane 
        /// predanim parametrima x i y</returns>
        private float udaljenost(float x, float y)
        {
            return (float)Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

        /// <summary>
        /// Javno sučelje za metodu za izračun udaljenosti do točke čiji se parametri predaju 
        /// kao dvije koordinate tipa float.
        /// </summary>
        /// <param name="x">Koordinata X točke do koje se izračunava udaljenost</param>
        /// <param name="y">Koordinata Y točke do koje se izračunava udaljenost</param>
        /// <returns>Udaljenost između točke objekta do točke definirane 
        /// predanim parametrima x i y</returns>
        public float udaljenostDo(float x, float y)
        {
            return udaljenost(x, y);
        }

        /// <summary>
        ///  Javno sučelje za izračun udaljenost do točke koje prima patametar tima Tocka
        /// </summary>
        /// <param name="t">Tocka do koje se izračunava udaljenost</param>
        /// <returns>Udaljenost do točke</returns>
        public float udaljenostDo(Tocka t)
        {
            return udaljenost(t.dohvatiX(), t.dohvatiY());
        }

    }
}
