using GestionAbsences.WinForms.controller;
using GestionAbsences.WinForms.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAbsences.WinForms.dal;



namespace GestionAbsences.WinForms.view
{
    public partial class FormConnexion: Form
    {
        private readonly UtilisateurDal utilisateurDal = new UtilisateurDal();

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier les identifiants
            var utilisateur = utilisateurDal.GetUtilisateur(login, password);

            if (utilisateur != null)
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ouvrir le formulaire principal
                FormPersonnel formPersonnel = new FormPersonnel();
                formPersonnel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


