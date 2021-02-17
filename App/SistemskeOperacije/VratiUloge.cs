using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiUloge : OpstaSistemskaOperacija
    {
        public List<Uloga> Uloge { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Kurs k = (Kurs)objekat;
            Uloga u = new Uloga();
            u.IDKurs = k.IDKursa;
            Uloge = new List<Uloga>(broker.VratiSveSaUslovom(u).Cast<Uloga>());
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
