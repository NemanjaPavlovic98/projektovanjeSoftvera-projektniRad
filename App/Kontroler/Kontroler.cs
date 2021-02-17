using BrokerBazePodataka;
using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Kontroler
    {
        private static Kontroler _instance;
        private Broker broker = new Broker();
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kontroler();
                return _instance;
            }
        }

        public Korisnik PrijaviKorisnika(Korisnik korisnik)
        {
            OpstaSistemskaOperacija operacija = new PrijaviKorisnika();
            operacija.Izvrsi(korisnik);
            return ((PrijaviKorisnika)operacija).Korisnik;
        }

        public object DodajTehnologiju(Tehnologija objekat)
        {
            OpstaSistemskaOperacija operacija = new DodajTehnologiju();
            operacija.Izvrsi(objekat);
            return ((DodajTehnologiju)operacija).Uspelo;
        }

        public object VratiTehnologije()
        {
            OpstaSistemskaOperacija operacija = new VratiTehnologije();
            operacija.Izvrsi(new Tehnologija());
            return ((VratiTehnologije)operacija).Tehnologije;

        }

        public object ObrisiTehnologije(Tehnologija tehnologija)
        {
            OpstaSistemskaOperacija operacija = new ObrisiTehnologiju();
            operacija.Izvrsi(tehnologija);
            return ((ObrisiTehnologiju)operacija).Uspelo;
        }

        public object IzmeniTehnologije(Tehnologija tehnologija)
        {
            OpstaSistemskaOperacija operacija = new IzmeniTehnologiju();
            operacija.Izvrsi(tehnologija);
            return ((IzmeniTehnologiju)operacija).Uspelo;
        }

        public object DodajKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija operacija = new DodajKurs();
            operacija.Izvrsi(kurs);
            return ((DodajKurs)operacija).Uspelo;
        }

        public object VratiKurseve()
        {
            OpstaSistemskaOperacija operacija = new VratiKurseve();
            operacija.Izvrsi(new Kurs());
            return ((VratiKurseve)operacija).Kursevi;
        }

        public object ObrisiKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija operacija = new ObrisiKurs();
            operacija.Izvrsi(kurs);
            return ((ObrisiKurs)operacija).Uspelo;
        }

        public object IzmeniKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija operacija = new IzmeniKurs();
            operacija.Izvrsi(kurs);
            return ((IzmeniKurs)operacija).Uspelo;
        }

        public object VratiUloge(Kurs kurs)
        {
            OpstaSistemskaOperacija operacija = new VratiUloge();
            operacija.Izvrsi(kurs);
            return ((VratiUloge)operacija).Uloge;
        }

        public object DodajRecenziju(Recenzija recenzija)
        {
            OpstaSistemskaOperacija operacija = new DodajRecenziju();
            operacija.Izvrsi(recenzija);
            return ((DodajRecenziju)operacija).Uspelo;
        }
    }
}
