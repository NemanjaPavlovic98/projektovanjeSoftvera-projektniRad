using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Recenzija : IObjekat
    {
        public int IDRecenzijeKursa{ get; set; }
        public Korisnik Korisnik { get; set; }
        public Kurs Kurs { get; set; }
        public string RecenzijaKursa { get; set; }
        public List<RecenzijaUloge> RecenzijeUloga { get; set; }

        public Recenzija()
        {
            RecenzijeUloga = new List<RecenzijaUloge>();
        }

        public string PostaviVrednostAtributa()
        {
            return $"OpisRecenzije = '{RecenzijaKursa}', IDKurs = {Kurs.IDKursa}, IDKorisnika = {Korisnik.Id}";
        }

        public string VratiImeID()
        {
            return "IDRecenzijeKursa";
        }

        public string VratiImeKlase()
        {
            return "RecenzijaKursa";
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
            return $"IDRecenzijeKursa = {IDRecenzijeKursa}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDRecenzijeKursa}, '{RecenzijaKursa}', {Kurs.IDKursa}, {Korisnik.Id}";
        }
    }
}
