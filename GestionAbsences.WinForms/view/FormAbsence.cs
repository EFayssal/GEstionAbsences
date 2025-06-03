using GestionAbsences.WinForms.dal;
using GestionAbsences.WinForms.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionAbsences.WinForms.view
{
    public partial class FormAbsence: Form
    {
        private Personnel personnel;

        public FormAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            if (personnel != null)
            {
                this.Text = $"Absences de {personnel.nom} {personnel.prenom}";
                ChargerAbsences(personnel.idpersonnel);
            }
            else
            {
                this.Text = "Absences de tout le personnel";
                // Handle the "all personnel" case appropriately.
            }
        }
        
        private void ChargerAbsencesTous()
        {
            var dal = new AbsenceDal();
            var absences = dal.GetAllAbsences(); // À implémenter dans AbsenceDal si besoin
            var absencesTriees = absences.OrderByDescending(a => a.DateAbsence).ToList();
            dataGridViewAbsences.DataSource = absencesTriees;
        }


        private void FormAbsences_Load(object sender, EventArgs e)
        {
            if (personnel == null)
            {
                MessageBox.Show("Aucun personnel sélectionné.");
                this.Close();
                return;
            }

            // Charger les absences du personnel
            var dal = new AbsenceDal();
            var absences = dal.GetAbsencesByPersonnel(personnel.idpersonnel); //
            dataGridViewAbsences.DataSource = absences;
        }
       

        // Ajout de la méthode ChargerAbsences
        private void ChargerAbsences(int idPersonnel)
        {
            var dal = new AbsenceDal();
            var absences = dal.GetAbsencesByPersonnel(idPersonnel);

            // Tri décroissant par date (la plus récente en premier)
            var absencesTriees = absences
                .OrderByDescending(a => a.DateAbsence)
                .ToList();

            dataGridViewAbsences.DataSource = absencesTriees;
        
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var formAjout = new FormAjoutAbsence(personnel))
            {
                if (formAjout.ShowDialog() == DialogResult.OK)
                {
                    ChargerAbsences(personnel.idpersonnel);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbsences.CurrentRow == null || dataGridViewAbsences.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.");
                return;
            }

            var result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cette absence ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Récupérer l'absence sélectionnée
                var absence = (Absence)dataGridViewAbsences.CurrentRow.DataBoundItem;
                var dal = new AbsenceDal();
                dal.SupprimerAbsence(absence.idabsence);

                // Rafraîchir la liste
                ChargerAbsences(personnel.idpersonnel);
            }
        }
    }
    
}
