using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;


        public int Izmeni(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"update {objekat.VratiImeKlase()} set {objekat.PostaviVrednostAtributa()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            return komanda.ExecuteNonQuery();
        }

        public List<IObjekat> VratiSveSaUslovom(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}";
            SqlDataReader reader = command.ExecuteReader();
            List<IObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public int Obrisi(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"delete from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            return komanda.ExecuteNonQuery();
        }

        public List<IObjekat> VratiSve(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} ";
            SqlDataReader reader = command.ExecuteReader();
            List<IObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();

            return rezultat;
        }

        public int Sacuvaj(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);

            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} values ({objekat.VratiVrednostAtributa()})";

            return komanda.ExecuteNonQuery();
        }

        public int DajSledeciID(IObjekat objekat)
        {
            try
            {
                SqlCommand komanda = new SqlCommand("", connection, transaction);
                komanda.CommandText = $"select max({objekat.VratiImeID()}) from {objekat.VratiImeKlase()}";
                try
                {
                    int id = Convert.ToInt32(komanda.ExecuteScalar());
                    return id + 1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoursX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransakcije()
        {
            transaction.Commit();
        }

        public void RollbackTransakcije()
        {
            transaction.Rollback();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public IObjekat VratiJedan(IObjekat objekat)
        {
            IObjekat rezultat;

            SqlCommand command = new SqlCommand($"select * from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            SqlDataReader reader = command.ExecuteReader();
            rezultat = objekat.VratiObjekat(reader);
            reader.Close();
            return rezultat;
        }
    }
}
