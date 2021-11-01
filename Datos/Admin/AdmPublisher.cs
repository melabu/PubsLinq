using Datos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos.Servidor
{
    public class AdmPublisher
    {
        public static List<Publisher> Listar(string city)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", System.Data.SqlDbType.VarChar).Value = city;

            SqlDataReader reader;

            reader = comando.ExecuteReader();

            List<Publisher> listaPublisher = new List<Publisher>();

            while (reader.Read())
            {
                listaPublisher.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaPublisher;
        }

        public static List<Publisher> Listar(string city, string state)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city=@city and state=@state";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", System.Data.SqlDbType.VarChar).Value = city;
            comando.Parameters.Add("@state", System.Data.SqlDbType.VarChar).Value = state;

            SqlDataReader reader;

            reader = comando.ExecuteReader();

            List<Publisher> listaPublisher = new List<Publisher>();

            while (reader.Read())
            {
                listaPublisher.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaPublisher;
        }

        public static List<Publisher> Listar(string city, string state, string country)
        {
            string consultaSQL = "SELECT pub_id, pub_name, city, state, country FROM dbo.publishers WHERE city = @city and(state is null or state = '' or state = @state) and country = @country";

            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", System.Data.SqlDbType.VarChar).Value = city;
            comando.Parameters.Add("@state", System.Data.SqlDbType.VarChar).Value = state;
            comando.Parameters.Add("@country", System.Data.SqlDbType.VarChar).Value = country;

            SqlDataReader reader;

            reader = comando.ExecuteReader();

            List<Publisher> listaPublisher = new List<Publisher>();

            while (reader.Read())
            {
                listaPublisher.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString(),
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaPublisher;
        }
    }
}
