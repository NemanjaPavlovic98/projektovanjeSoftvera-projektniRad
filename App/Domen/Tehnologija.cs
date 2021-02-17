using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Tehnologija : IObjekat
    {
        public int IDTehnologije { get; set; }
        public string NazivTehnologije { get; set; }
        public string VrstaTehnologije { get; set; }
        public string KompanijaVlasnik { get; set; }
        public string AktuelnaVerzija { get; set; }


        public override string ToString()
        {
            return NazivTehnologije;
        }
        public string PostaviVrednostAtributa()
        {
            return $"NazivTehnologije = '{NazivTehnologije}', VrstaTehnologije = '{VrstaTehnologije}', KompanijaVlasnik = '{KompanijaVlasnik}', AktuelnaVerzija = '{AktuelnaVerzija}'";
        }

        public string VratiImeKlase()
        {
            return "Tehnologija";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> tehnologije = new List<IObjekat>();
            while (reader.Read())
            {
                Tehnologija tehnologija = new Tehnologija
                {
                    IDTehnologije = reader.GetInt32(0),
                    NazivTehnologije = reader.GetString(1),
                    VrstaTehnologije = reader.GetString(2),
                    //KompanijaVlasnik = reader.GetString(3),
                    //AktuelnaVerzija = reader.GetString(4)

                };
                if (!reader.IsDBNull(3))
                {
                    tehnologija.KompanijaVlasnik = reader.GetString(3);
                }
                else
                {
                    tehnologija.KompanijaVlasnik = string.Empty;
                }

                if (!reader.IsDBNull(4))
                {
                    tehnologija.AktuelnaVerzija = reader.GetString(4);
                }
                else
                {
                    tehnologija.AktuelnaVerzija = string.Empty;
                }

                tehnologije.Add(tehnologija);
            }
            return tehnologije;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat tehnologija = null;
            while (reader.Read())
            {
                tehnologija = new Tehnologija
                {
                    IDTehnologije = reader.GetInt32(0),
                    NazivTehnologije = reader.GetString(1),
                    VrstaTehnologije = reader.GetString(2),
                    KompanijaVlasnik = reader.GetString(3),
                    AktuelnaVerzija = reader.GetString(4)
                };
            }
            return tehnologija;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDTehnologije = {IDTehnologije}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDTehnologije}, '{NazivTehnologije}', '{VrstaTehnologije}', '{KompanijaVlasnik}', '{AktuelnaVerzija}'";
        }

        public string VratiImeID()
        {
            return "IDTehnologije";
        }
    }
}
