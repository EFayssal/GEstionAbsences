using GestionAbsences.WinForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestionAbsences.WinForms.utils;

namespace GestionAbsences.WinForms.dal
{
    public class UtilisateurDal : DalBase
    {
        public Utilisateur GetUtilisateur(string login, string password)
        {
            Utilisateur utilisateur = null;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@password, 256)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        utilisateur = new Utilisateur
                        {
                            Login = reader["login"].ToString(),
                            Password = reader["pwd"].ToString()
                        };
                    }
                }
            }

            return utilisateur;
        }
    }
}