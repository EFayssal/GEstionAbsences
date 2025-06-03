using GestionAbsences.WinForms.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace GestionAbsences.WinForms.dal
{
    public class AbsenceDal
    {
        private const string ConnectionString = "server=localhost;database=gestion_absences;uid=resp_app;pwd=1234;";

        public List<Absence> GetAbsencesByPersonnel(int idpersonnel)
        {
            var absences = new List<Absence>();
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM absence WHERE idpersonnel = @idpersonnel";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            absences.Add(new Absence
                            {
                                idpersonnel = reader.GetInt32("idpersonnel"),
                                datedebut = reader.GetDateTime("datedebut"),
                                datefin = reader.GetDateTime("datefin"),
                                idmotif = reader.GetInt32("idmotif")
                            });
                        }
                    }
                }
            }
            return absences;
        }
        public void AjouterAbsence(Absence absence)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @debut, @fin, @motif)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", absence.idpersonnel);
                    cmd.Parameters.AddWithValue("@debut", absence.datedebut);
                    cmd.Parameters.AddWithValue("@fin", absence.datefin);
                    cmd.Parameters.AddWithValue("@motif", absence.idmotif);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Vérifie s'il existe déjà une absence sur la période
        public bool ExisteAbsenceDansPeriode(int idpersonnel, DateTime debut, DateTime fin)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM absence 
                         WHERE idpersonnel = @idpersonnel 
                         AND (datedebut <= @fin AND datefin >= @debut)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@debut", debut);
                    cmd.Parameters.AddWithValue("@fin", fin);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public List<Absence> GetAllAbsences()
        {
            var absences = new List<Absence>();
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM absence";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            absences.Add(new Absence
                            {
                                idpersonnel = reader.GetInt32("idpersonnel"),
                                datedebut = reader.GetDateTime("datedebut"),
                                datefin = reader.GetDateTime("datefin"),
                                idmotif = reader.GetInt32("idmotif")
                            });
                        }
                    }
                }
            }
            return absences;
        }
    }
}