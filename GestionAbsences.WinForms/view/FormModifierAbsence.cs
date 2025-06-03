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
    public partial class FormModifierAbsence: Form
    {
        private Absence absence;
        public FormModifierAbsence(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;
        }

        private void FormModifierAbsence_Load(object sender, EventArgs e)
        {
            // Remplir la liste des motifs
            comboBoxMotif.Items.AddRange(new string[] { "Maladie", "Congé", "RTT", "Autre" });
            // Préremplir les champs
            dateTimePickerDebut.Value = absence.datedebut;
            dateTimePickerFin.Value = absence.datefin;
            comboBoxMotif.SelectedIndex = absence.idmotif - 1; 
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";

            // 4a. Vérifier que tous les champs sont remplis
            if (comboBoxMotif.SelectedItem == null)
            {
                lblErreur.Text = "Veuillez sélectionner un motif.";
                return;
            }

            DateTime debut = dateTimePickerDebut.Value.Date;
            DateTime fin = dateTimePickerFin.Value.Date;

            // 4b. Vérifier cohérence des dates
            if (fin < debut)
            {
                lblErreur.Text = "La date de fin doit être postérieure à la date de début.";
                return;
            }

            // 4c. Vérifier chevauchement d'absence (hors celle en cours de modif)
            var dal = new AbsenceDal();
            if (dal.ExisteAbsenceDansPeriodeModif(absence.idabsence, absence.idpersonnel, debut, fin))
            {
                lblErreur.Text = "Une absence existe déjà sur cette période.";
                return;
            }

            // Confirmation
            var result = MessageBox.Show(
                "Voulez-vous enregistrer les modifications apportées à cette absence ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                absence.datedebut = debut;
                absence.datefin = fin;
                absence.idmotif = comboBoxMotif.SelectedIndex + 1; 

                dal.ModifierAbsence(absence);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
