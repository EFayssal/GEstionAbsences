using GestionAbsences.WinForms.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences.WinForms.dal
{
    class PersonnelDal
    {
        private const string ConnectionString = "server=localhost;database=gestion_absences;uid=resp_app;pwd=1234;";

        public List<Personnel> GetAllPersonnel()
        {
            var list = new List<Personnel>();
            using (var connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM personnel";
                var command = new MySqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Personnel
                        {
                            idpersonnel = Convert.ToInt32(reader["idpersonnel"]),
                            idservice = Convert.ToInt32(reader["idService"]),
                            nom = reader["nom"].ToString(),
                            prenom = reader["prenom"].ToString(),
                            tel = reader["tel"].ToString(),
                            mail = reader["mail"].ToString(),
                        });
                    }
                }
            }
            return list;
        }

        public void AjouterPersonnel(Personnel personnel)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)", conn))
                {
                    cmd.Parameters.AddWithValue("@nom", personnel.nom);
                    cmd.Parameters.AddWithValue("@prenom", personnel.prenom);
                    cmd.Parameters.AddWithValue("@tel", personnel.tel);
                    cmd.Parameters.AddWithValue("@mail", personnel.mail);
                    cmd.Parameters.AddWithValue("@idservice", personnel.idservice);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void SupprimerPersonnel(int idpersonnel)
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM personnel WHERE idpersonnel = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idpersonnel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
