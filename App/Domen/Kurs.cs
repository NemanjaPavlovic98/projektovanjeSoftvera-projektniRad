using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Kurs : IObjekat
    {
        public int IDKursa { get; set; }
        public string NazivKursa { get; set; }
        public string ProvajderKursa { get; set; }
        public int Minutaza { get; set; }
        public string OpisKursa { get; set; }
        public double OcenaKursa { get; set; }
        public double CenaKursa { get; set; }
        public List<Uloga> uloge { get; set; }

        public Kurs()
        {
            uloge = new List<Uloga>();
        }

        public override string ToString()
        {
            return NazivKursa;
        }

        public string PostaviVrednostAtributa()
        {
            return $"NazivKursa = '{NazivKursa}', ProvajderKursa = '{ProvajderKursa}', Minutaza = {Minutaza}, OpisKursa = '{OpisKursa}', OcenaKursa = '{OcenaKursa.ToString(System.Globalization.CultureInfo.InvariantCulture)}', CenaKursa = '{CenaKursa.ToString(System.Globalization.CultureInfo.InvariantCulture)}'";
        }

        public string VratiImeID()
        {
            return "IDKursa";
        }

        public string VratiImeKlase()
        {
            return "Kurs";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> kursevi = new List<IObjekat>();

            while (reader.Read())
            {
                Kurs kurs1 = new Kurs
                {
                    IDKursa = reader.GetInt32(0),
                    NazivKursa = reader.GetString(1),
                    ProvajderKursa = reader.GetString(2),
                    Minutaza = reader.GetInt32(3),
                    //OpisKursa = reader.GetString(4),
                    OcenaKursa = (double)reader.GetDecimal(5),
                    CenaKursa = (double)reader.GetDecimal(6)

                };
                if (!reader.IsDBNull(4))
                {
                    kurs1.OpisKursa = reader.GetString(4);
                }        
                else
                {
                    kurs1.OpisKursa = string.Empty;
                }
                kursevi.Add(kurs1);
            }
            return kursevi;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            Kurs kurs = new Kurs();
            while (reader.Read())
            {
                kurs = new Kurs
                {
                    IDKursa = reader.GetInt32(0),
                    NazivKursa = reader.GetString(1),
                    ProvajderKursa = reader.GetString(2),
                    Minutaza = reader.GetInt32(3),
                    OpisKursa = reader.GetString(4),
                    OcenaKursa = (double)reader.GetDecimal(5),
                    CenaKursa = (double)reader.GetDecimal(6)

                };
            }
            return kurs;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDKursa = {IDKursa}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDKursa}, '{NazivKursa}', '{ProvajderKursa}', {Minutaza},'{OpisKursa}', '{OcenaKursa.ToString(System.Globalization.CultureInfo.InvariantCulture)}', '{CenaKursa.ToString(System.Globalization.CultureInfo.InvariantCulture)}'";
        }
    }
}
