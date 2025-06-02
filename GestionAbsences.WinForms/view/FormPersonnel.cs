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


namespace GestionAbsences.WinForms.view
{
    public partial class FormPersonnel: Form
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
    }
}
