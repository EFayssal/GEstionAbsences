using GestionAbsences.WinForms.dal;
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
    public partial class FormTouteAbsences: Form
    {
        public FormTouteAbsences()

        {
            InitializeComponent();
            ChargerToutesLesAbsences();
        }
        private void ChargerToutesLesAbsences()
        {
            var dal = new AbsenceDal();
            var absences = dal.GetAllAbsences(); // Cette méthode doit retourner toutes les absences
            dataGridViewAbsences.DataSource = absences.OrderByDescending(a => a.DateAbsence).ToList();
        }


        private void FormTouteAbsences_Load(object sender, EventArgs e)
        {

        }
    }
}
