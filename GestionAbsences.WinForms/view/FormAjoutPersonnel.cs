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
using GestionAbsences.WinForms.dal;


namespace GestionAbsences.WinForms.view
{
    public partial class FormAjoutPersonnel : Form
    {
        public FormAjoutPersonnel()
        {
            InitializeComponent();
        }

        private void FormAjoutPersonnel_Load(object sender, EventArgs e)
        {
            var dal = new ServiceDal();
            comboBoxService.DataSource = dal.GetAllServices();
            comboBoxService.DisplayMember = "Nom";
            comboBoxService.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

            var personnel = new Personnel
            {
                nom = txtNom.Text,
                prenom = txtPrenom.Text,
                tel = txtTel.Text,
                mail = txtMail.Text,
                idservice = (int)comboBoxService.SelectedValue
            };

            var dal = new PersonnelDal();
            dal.AjouterPersonnel(personnel);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
