using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrijaviKorisnika : OpstaSistemskaOperacija
    {
        public Korisnik Korisnik { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Korisnik = (Korisnik)broker.VratiJedan(objekat);
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Korisnik))
            {
                throw new ArgumentException();
            }
        }
    }
}
