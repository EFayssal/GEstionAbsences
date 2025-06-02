// Fichier : GestionAbsences.WinForms/dal/ServiceDal.cs

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // Ou MySqlClient selon votre SGBD
using GestionAbsences.WinForms.Modele;
using MySql.Data.MySqlClient;

namespace GestionAbsences.WinForms.dal
{
    public class ServiceDal
    {
        private const string ConnectionString = "server=localhost;database=gestion_absences;uid=resp_app;pwd=1234;";

        public List<Service> GetAllServices()
        {
            var services = new List<Service>();
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT idservice, nom FROM service", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        services.Add(new Service
                        {
                            Id = reader.GetInt32(0),
                            Nom = reader.GetString(1)
                        });
                    }
                }
            }
            return services;
        }
    }

    public class Service
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}

