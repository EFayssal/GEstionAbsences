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
    public partial class FormModifierPersonnel: Form
    {
        private Personnel personnel;
        public FormModifierPersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
        }

        private void FormModifierPersonnel_Load(object sender, EventArgs e)
        {
            // Remplir la liste des services
            var dal = new ServiceDal();
            comboBoxService.DataSource = dal.GetAllServices();
            comboBoxService.DisplayMember = "Nom";
            comboBoxService.ValueMember = "Id";

            // Préremplir les champs
            txtNom.Text = personnel.nom;
            txtPrenom.Text = personnel.prenom;
            txtTel.Text = personnel.tel;
            txtMail.Text = personnel.mail;
            comboBoxService.SelectedValue = personnel.idservice;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
           string.IsNullOrWhiteSpace(txtPrenom.Text) ||
           string.IsNullOrWhiteSpace(txtTel.Text) ||
           string.IsNullOrWhiteSpace(txtMail.Text) ||
           comboBoxService.SelectedItem == null)
            {
                lblErreur.Text = "Tous les champs sont obligatoires.";
                return;
            }

            // Confirmation
            var result = MessageBox.Show(
                "Voulez-vous enregistrer les modifications apportées à ce personnel ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                personnel.nom = txtNom.Text;
                personnel.prenom = txtPrenom.Text;
                personnel.tel = txtTel.Text;
                personnel.mail = txtMail.Text;
                personnel.idservice = (int)comboBoxService.SelectedValue;

                var dal = new PersonnelDal();
                dal.ModifierPersonnel(personnel);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
    

