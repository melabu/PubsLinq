using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Admin;
using Datos.Servidor;
using System.Data.SqlClient;
using Datos.Models;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> Listar()
        {
            //una variable con la consulta de SQL
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";

            //Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //declarar un objeto SqlDataReader
            SqlDataReader reader;

            //crear el reader
            reader = comando.ExecuteReader();

            //Recorrer leer los datos hacia adelante
            List<Author> listaAutores = new List<Author>();

            while (reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = (bool)reader["contract"],
                    }
                    );
            }
            AdminDB.ConectarBase().Close();//cerramos la conexión
            reader.Close();
            return listaAutores;
        }
    }

    /*
        public static List<Author> Listar(string city)
        {
            //una variable con la consulta de SQL
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city";

            //Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //AGREGAMOS ---> Declarar el parámetro de SQL Server 
            comando.Parameters.Add("@city", System.Data.SqlDbType.VarChar).Value = city;

            //declarar un objeto SqlDataReader
            SqlDataReader reader;

            //crear el reader
            reader = comando.ExecuteReader();
            
            //Recorrer leer los datos hacia adelante
            List<Author> listaAutores = new List<Author>();

            while (reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = (bool)reader["contract"],
                    }
                    );
            }
            AdminDB.ConectarBase().Close();//cerramos la conexión
            reader.Close();
            return listaAutores;
        }

        public static List<Author> Listar(string city, string state)
        {
            //una variable con la consulta de SQL
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city=@city and state=@state";

            //Crear un objeto SqlCommand
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //AGREGAMOS ---> Declarar el parámetro de SQL Server 
            comando.Parameters.Add("@city", System.Data.SqlDbType.VarChar).Value = city;
            comando.Parameters.Add("@state", System.Data.SqlDbType.VarChar).Value = state;

            //declarar un objeto SqlDataReader
            SqlDataReader reader;

            //crear el reader
            reader = comando.ExecuteReader();

            //Recorrer leer los datos hacia adelante
            List<Author> listaAutores = new List<Author>();

            while (reader.Read())
            {
                listaAutores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = (bool)reader["contract"],
                    }
                    );
            }
            AdminDB.ConectarBase().Close();//cerramos la conexión
            reader.Close();
            return listaAutores;
        }
    } */

}
