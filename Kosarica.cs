using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaZaKupovinu.Logika
{
    public class Kosarica
    {
        //sve je Private!!!
        // id
        private Guid id;
        private Vlasnik vlasnik;
        private Status status;
        // stavke
        private List<Stavka> stavke = new List<Stavka>();

        // konstruktor
        public Kosarica(Vlasnik _vlasnik)
        {
            id = Guid.NewGuid();
            status = Status.Prazna;
            stavke = new List<Stavka>();
            vlasnik = _vlasnik;
        }

        // vrati
        public Vlasnik VratiVlasnika()
        {
            return vlasnik;
        }
        public Guid VratiId()
        {
            return id;
        }
        public Status VratiStatus()
        {
            return status;
        }

        //vrati stavke
        //vracanje kad ima vise stavke
        public List<Stavka>VratiStavke()
        {
            return stavke;
        }

        //manipuliranje kosaricom

        // dodati stavku
        public void DodajStavku(Stavka s)
        {
            if (status != Status.Placena && status != Status.Stornirana)
            {
                stavke.Add(s);
                status = Status.Aktivna;
            }
            else
            {
                throw new Exception();            }
              
        }

        public void Plati()
        {
            status = Status.Placena;
        }
        public void Storniraj()
        {
            status = Status.Stornirana;
        }

        // obrisi skavku
        public void ObrisiStavku(Stavka s)
        {
            stavke.Remove(s);
        }
        // obrisi stavke(kosaricu)
        public void Obrisi()
        {
            stavke.Clear();
        }

        //iznos kosarice - treba znati
        public decimal VratiIznos()
        {
            decimal iznos = 0;
            foreach (Stavka s in stavke)
                iznos += s.VratiIznos();
            return iznos;
        }
        private bool Zasticena()
        {
            return status == Status.Placena || status == Status.Stornirana;
        }
    }
}
