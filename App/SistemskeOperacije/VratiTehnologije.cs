using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiTehnologije : OpstaSistemskaOperacija
    {
        public List<Tehnologija> Tehnologije { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Tehnologije = new List<Tehnologija>(broker.VratiSve(objekat).Cast<Tehnologija>());
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
