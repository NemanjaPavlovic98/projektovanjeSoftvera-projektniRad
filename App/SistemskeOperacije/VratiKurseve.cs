using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiKurseve : OpstaSistemskaOperacija
    {
        public List<Kurs> Kursevi { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Kursevi = new List<Kurs>(broker.VratiSve(objekat).Cast<Kurs>());
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
