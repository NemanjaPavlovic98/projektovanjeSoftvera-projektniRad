using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Komunikacija
    {
        private static Komunikacija _instance;


        public static Komunikacija Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Komunikacija();
                return _instance;
            }
        }
        private Socket klijent;
        private NetworkStream tok;
        private BinaryFormatter formater = new BinaryFormatter();


        private Komunikacija()
        {
        }



        internal bool PoveziSe()
        {
            try
            {
                if (klijent == null || !klijent.Connected)
                {

                    klijent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijent.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    klijent.Connect("localhost", 9999);
                    tok = new NetworkStream(klijent);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal object VratiUloge(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = kurs, Operacija = Operacija.VratiUloge };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Uloga>)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao Glumce");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal void OdjaviSe()
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.OdjaviKorisnika };
            formater.Serialize(tok, zahtev);
            klijent.Close();
            klijent = null;
        }

        internal bool DodajRecenziju(Recenzija recenzija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = recenzija, Operacija = Operacija.DodajRecenziju };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao kurs");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool DodajTehnologiju(Tehnologija tehnologija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = tehnologija, Operacija = Operacija.DodajTehnologiju};
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao tehnologiju");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal void Zavrsi()
        {
            if (klijent != null)
            {
                klijent.Close();
                klijent = null;
            }
        }
       
        internal Korisnik PrijaviKorisnika(string username, string pass)
        {
            try
            {
                Korisnik korisnik = new Korisnik { KorisnickoIme = username, Password = pass };
                Zahtev zahtev = new Zahtev { Objekat = korisnik, Operacija = Operacija.PrijaviKorisnika };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (Korisnik)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception)
            {
                throw;

            }

        }

        internal bool IzmeniKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = kurs, Operacija = Operacija.IzmeniKurs };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio film");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal List<Tehnologija> vratiTehnologije()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiTehnologije };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Tehnologija>)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao tehnologije");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();

                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool ObrisiTehnologiju(Tehnologija tehnologija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = tehnologija, Operacija = Operacija.ObrisiTehnologiju };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao Glumca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool DodajKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = kurs, Operacija = Operacija.DodajKurs };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao kurs");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool IzmeniTehnologiju(Tehnologija tehnologija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = tehnologija, Operacija = Operacija.IzmeniTehnologiju };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio tehnologiju");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal object vratiKurseve()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiKurseve };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Kurs>)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao tehnologije");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool ObrisiKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = kurs, Operacija = Operacija.ObrisiKurs };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.Krajserver:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao kurs");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
    }
}
