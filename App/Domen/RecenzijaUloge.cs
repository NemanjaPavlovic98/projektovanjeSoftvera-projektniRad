using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class RecenzijaUloge : IObjekat
    {
        [Browsable(false)]
        public int IDRecenzijeKursa { get; set; }
        public int IDRecenzijeUloge { get; set; }
        public string Recenzija { get; set; }

        public Kurs Kurs { get; set; }
        [Browsable(false)]
        public Tehnologija Tehnologija { get; set; }

        public RecenzijaUloge()
        {
            Kurs = new Kurs();
            Tehnologija = new Tehnologija();
        }

        public string PostaviVrednostAtributa()
        {
            return $"IDRecenzijeKursa = {IDRecenzijeKursa}, IDRecenzijeUloge = {IDRecenzijeUloge}, Recenzija = '{Recenzija}', IDKurs = {Kurs.IDKursa}, IDTehnologija = {Tehnologija.IDTehnologije}";
        }

        public string VratiImeID()
        {
            return "IDRecenzijeUloge";
        }

        public string VratiImeKlase()
        {
            return "RecenzijaUloge";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaTrazenje()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDRecenzijeKursa}, {IDRecenzijeUloge}, '{Recenzija}', {Kurs.IDKursa}, {Tehnologija.IDTehnologije}";
        }
    }
}
