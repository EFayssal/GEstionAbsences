using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GestionAbsences.WinForms.utils;


namespace GestionAbsences.WinForms.utils 
{
    /// <summary>
    /// Classe utilitaire pour hacher les mots de passe avec l'algorithme SHA-256.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Méthode pour hacher un mot de passe en utilisant SHA-256.
        /// </summary>
        /// <param name="password">Mot de passe à hacher.</param>
        /// <returns>Mot de passe haché sous forme de chaîne hexadécimale.</returns>
        public static string HashPassword(string password)
        {
            // Créer une instance de SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Construire une chaîne hexadécimale à partir des bytes
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convertir chaque byte en hexadécimal
                }

                return builder.ToString(); // Retourner le mot de passe haché
            }
        }
    }
}