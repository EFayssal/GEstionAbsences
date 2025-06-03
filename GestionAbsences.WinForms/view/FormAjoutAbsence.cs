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

    public partial class FormAjoutAbsence: Form
    {
        private Personnel personnel;
        public FormAjoutAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
        }
        private void FormAjoutAbsence_Load(object sender, EventArgs e)
        {
            // Remplir la liste des motifs
            comboBoxMotif.Items.AddRange(new string[] { "Maladie", "Congé", "RTT", "Autre" });
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";

            // Vérification de la présence d'un personnel
            if (personnel == null)
            {
                lblErreur.Text = "Aucun personnel sélectionné. Impossible d'enregistrer l'absence.";
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

            // 4c. Vérifier chevauchement d'absence
            var dal = new AbsenceDal();
            if (dal.ExisteAbsenceDansPeriode(personnel.idpersonnel, debut, fin))
            {
                lblErreur.Text = "Une absence existe déjà sur cette période.";
                return;
            }

            // 4. Enregistrer l'absence
            var absence = new Absence
            {
                idpersonnel = personnel.idpersonnel,
                datedebut = debut,
                datefin = fin,
                idmotif = comboBoxMotif.SelectedIndex
            };
            dal.AjouterAbsence(absence);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
     

        }
    }
}
