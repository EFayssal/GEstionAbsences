using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAbsences.WinForms.view;
using GestionAbsences.WinForms.dal;
using GestionAbsences.WinForms.Modele;


namespace GestionAbsences.WinForms.view
{
    public partial class FormPersonnel : Form
    {
        public FormPersonnel()
        {
            InitializeComponent();
        }

        private void FormPersonnel_Load(object sender, EventArgs e)
        {
            ChargerListePersonnel();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var formAjout = new FormAjoutPersonnel())
            {
                if (formAjout.ShowDialog() == DialogResult.OK)
                {
                    ChargerListePersonnel();
                }
            }
        }

        private void ChargerListePersonnel()
        {
            var dal = new PersonnelDal();
            var personnels = dal.GetAllPersonnel();
            DataGridView.DataSource = personnels;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.");
                return;
            }

            var result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce personnel ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Récupérer l'ID du personnel sélectionné
                var personnel = (Personnel)DataGridView.CurrentRow.DataBoundItem;
                var dal = new PersonnelDal();
                dal.SupprimerPersonnel(personnel.idpersonnel);

                // Rafraîchir la liste
                ChargerListePersonnel();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            {
                if (DataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un personnel à modifier.");
                    return;
                }

                var personnel = (Personnel)DataGridView.CurrentRow.DataBoundItem;
                using (var formModif = new FormModifierPersonnel(personnel))
                {
                    if (formModif.ShowDialog() == DialogResult.OK)
                    {
                        ChargerListePersonnel();
                    }
                }
            }
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée et qu'elle contient un objet Personnel
            if (DataGridView.CurrentRow == null || DataGridView.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.");
                return;
            }

            // Récupère le personnel sélectionné
            var personnel = (Personnel)DataGridView.CurrentRow.DataBoundItem;

            // Ouvre la fenêtre des absences pour ce personnel
            using (var formAbs = new FormAbsence(personnel))
            {
                formAbs.ShowDialog();
            }
        }

        private void btnAbsencesTous_Click(object sender, EventArgs e)
        {
            using (var formTouteAbs = new FormTouteAbsences())
            {
                formTouteAbs.ShowDialog();
            }
        }
    
    }
    
}
