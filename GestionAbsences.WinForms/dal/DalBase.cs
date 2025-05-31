using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionAbsences.WinForms.dal
{
    public class DalBase
    {
        /// <summary>
        /// Propriété pour récupérer la chaîne de connexion depuis App.config.
        /// </summary>
        protected string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
        
        }
    }
}