using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    //public enum NivoZahtevanogZnanja { Pocetnik, Junio, Medior, Senior}
    [Serializable]
    public class Uloga : IObjekat
    {
        [Browsable(false)]
        public int IDKurs { get; set; }
        public int IDTehnologija { get; set; }
        public string NazivUloge { get; set; }
        public string NivoZnanja { get; set; }
        public string PostaviVrednostAtributa()
        {
            return $"IDKurs = {IDKurs}, IDTehnologija = {IDTehnologija}, NazivUloge = '{NazivUloge}', NivoZnanja = '{NivoZnanja}'";
        }

        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Uloga";
        }

        public override string ToString()
        {
            return NazivUloge;
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> uloge = new List<IObjekat>();
            while (reader.Read())
            {
                Uloga uloga = new Uloga
                {
                    IDKurs = reader.GetInt32(0),
                    IDTehnologija = reader.GetInt32(1),
                    NazivUloge = reader.GetString(2),
                    NivoZnanja = reader.GetString(3)
                };
                uloge.Add(uloga);
            }
            return uloge;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat uloga = null;
            while (reader.Read())
            {
                uloga = new Uloga
                {
                    IDKurs = reader.GetInt32(0),
                    IDTehnologija = reader.GetInt32(1),
                    NazivUloge = reader.GetString(2),
                    NivoZnanja = reader.GetString(3)
                };
            }
            return uloga;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDKurs = {IDKurs}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDKurs}, {IDTehnologija}, '{NazivUloge}', '{NivoZnanja}'";
        }
    }
}
