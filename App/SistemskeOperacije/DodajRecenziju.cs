using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajRecenziju : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Recenzija r = (Recenzija)objekat;
            int id = broker.DajSledeciID(objekat);
            r.IDRecenzijeKursa = id;
            if (broker.Sacuvaj(objekat) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }

            if (Uspelo == true)
            {
                foreach (RecenzijaUloge ru in r.RecenzijeUloga)
                {

                    ru.IDRecenzijeKursa = id;
                    if (broker.Sacuvaj(ru) != 1)
                    {
                        Uspelo = false;
                    }
                    else
                    {
                        Uspelo = true;
                    }
                }

            }
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Recenzija))
            {
                throw new ArgumentException();
            }
        }
    }
}
