using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajTehnologiju : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            int id = broker.DajSledeciID(objekat);
            Tehnologija t = (Tehnologija)objekat;
            t.IDTehnologije = id;

            if (broker.Sacuvaj(t) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Tehnologija))
            {
                throw new ArgumentException();
            }
        }
    }
}
