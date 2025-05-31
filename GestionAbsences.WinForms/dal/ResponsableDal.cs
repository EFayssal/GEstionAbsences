using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences.WinForms.dal
{
    public class ResponsableDal : DalBase
    {
        /// <summary>  
        /// Vérifie si le login et le mot de passe existent dans la base.  
        /// </summary>  
        public bool Authentifier(string login, string pwd)
        {
            // Correction: Utilisation de la propriété ConnectionString de DalBase
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = @pwd";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    return (long)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }

    
        }
