using System;

namespace GestionAbsences.WinForms.Modele
{
    /// <summary>
    /// Repr�sente une absence d'un membre du personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant du personnel concern� par l'absence.
        /// </summary>
        public int idpersonnel { get; set; }

        /// <summary>
        /// Date de d�but de l'absence.
        /// </summary>
        public DateTime datedebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence.
        /// </summary>
        public DateTime datefin { get; set; }

        /// <summary>
        /// Identifiant du motif de l'absence.
        /// </summary>
        public int idmotif { get; set; }

        /// <summary>
        /// Obtient la date de d�but de l'absence.
        /// </summary>
        public DateTime DateAbsence => datedebut;
        public int idabsence { get; set; }
    }


}
