using GestionAbsences.WinForms.dal;
using GestionAbsences.WinForms.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences.WinForms.controller
{
    public class AuthentificationController
    {
        private readonly UtilisateurDal utilisateurDal = new UtilisateurDal();

        public Utilisateur SeConnecter(string login, string password)
        {
            return utilisateurDal.GetUtilisateur(login, password);
        }
    }
}