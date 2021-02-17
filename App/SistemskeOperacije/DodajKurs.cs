using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajKurs : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Kurs k = (Kurs)objekat;
            int id = broker.DajSledeciID(objekat);
            k.IDKursa = id;
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
                foreach (Uloga u in k.uloge)
                {

                    u.IDKurs = id;
                    if (broker.Sacuvaj(u) != 1)
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
            if (!(objekat is Kurs))
            {
                throw new ArgumentException();
            }
        }
    }
}
