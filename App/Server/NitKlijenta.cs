using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class NitKlijenta
    {
        private Socket klijent;
        public Korisnik korisnik;
        private FrmServer frmServer;
        private NetworkStream tok;
        private BinaryFormatter formatter = new BinaryFormatter();
        private bool kraj;

        public NitKlijenta(Socket klijent, FrmServer frmServer)
        {
            this.klijent = klijent;
            this.frmServer = frmServer;
            this.tok = new NetworkStream(klijent);

        }

        internal void Obradjuj()
        {
            kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(tok);
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.PrijaviKorisnika:
                            odgovor = PrijaviKorisnika((Korisnik)zahtev.Objekat);
                            break;
                        case Operacija.DodajTehnologiju:
                            odgovor = DodajTehnologiju((Tehnologija)zahtev.Objekat);
                            break;
                        case Operacija.VratiTehnologije:
                            odgovor = VratiTehnologije();
                            break;
                        case Operacija.ObrisiTehnologiju:
                            odgovor = ObrisiTehnologiju((Tehnologija)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniTehnologiju:
                            odgovor = IzmeniTehnologiju((Tehnologija)zahtev.Objekat);
                            break;
                        case Operacija.DodajKurs:
                            odgovor = DodajKurs((Kurs)zahtev.Objekat);
                            break;
                        case Operacija.Kraj:
                            Zavrsi();
                            break;
                        case Operacija.VratiKurseve:
                            odgovor = VratiKurseve();
                            break;
                        case Operacija.ObrisiKurs:
                            odgovor = ObrisiKurs((Kurs)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniKurs:
                            odgovor = IzmeniKurs((Kurs)zahtev.Objekat);
                            break;
                        case Operacija.VratiUloge:
                            odgovor = VratiUloge((Kurs)zahtev.Objekat);
                            break;
                        case Operacija.DodajRecenziju:
                            odgovor = DodajRecenziju((Recenzija)zahtev.Objekat);
                            break;
                        case Operacija.OdjaviKorisnika:
                            break;
                    }
                    Salji(odgovor);
                }
                //catch (ThreadInterruptedException e)
                //{
                  //  kraj = true;
                //}
                //catch (IOException e)
                //{
                  //  kraj = true;
                //}
                catch (Exception e)
                {
                    kraj = false;
                }
            }
        }

        private Odgovor DodajRecenziju(Recenzija recenzija)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajRecenziju(recenzija);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor VratiUloge(Kurs kurs)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiUloge(kurs);
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor IzmeniKurs(Kurs kurs)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.IzmeniKurs(kurs);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor ObrisiKurs(Kurs kurs)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiKurs(kurs);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiKurseve()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiKurseve();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor DodajKurs(Kurs kurs)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajKurs(kurs);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor IzmeniTehnologiju(Tehnologija tehnologija)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.IzmeniTehnologije(tehnologija);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor ObrisiTehnologiju(Tehnologija tech)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiTehnologije(tech);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiTehnologije()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiTehnologije();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor DodajTehnologiju(Tehnologija tech)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajTehnologiju(tech);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor PrijaviKorisnika(Korisnik objekat)
        {
            korisnik = Kontroler.Kontroler.Instance.PrijaviKorisnika(objekat);
            Odgovor odgovor = new Odgovor();
            if (korisnik == null)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = "Nije pronadjen korisnik";
                //odgovor.Objekat = new Korisnik();
            }
            else
            {
                odgovor.Signal = Signal.Ok;
                odgovor.Poruka = "Pronadjen je korisnik";
                odgovor.Objekat = korisnik;
            }
            return odgovor;
        }

        private void Salji(Odgovor odgovor)
        {
            formatter.Serialize(tok, odgovor);
        }
        internal void Ugasi()
        {
            Salji(new Odgovor { Signal = Signal.Krajserver });
            Zavrsi();
        }

        internal void Zavrsi()
        {
            kraj = true;
            if (klijent != null && klijent.Connected)
            {
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Disconnect(false);
                klijent.Close();
                klijent = null;

            }
        }
    }
}
