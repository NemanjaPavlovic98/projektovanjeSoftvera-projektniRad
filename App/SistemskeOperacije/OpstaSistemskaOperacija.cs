using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker = new Broker();
        protected abstract void IzvrsiKonkretnuOperaciju(IObjekat objekat);
        protected abstract void Validacija(IObjekat objekat);
        public void Izvrsi(IObjekat objekat)
        {
            try
            {
                Validacija(objekat);
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                IzvrsiKonkretnuOperaciju(objekat);
                broker.CommitTransakcije();
            }
            catch (Exception)
            {
                broker.RollbackTransakcije();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }
    }
}
