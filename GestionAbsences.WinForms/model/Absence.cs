using System;

namespace GestionAbsences.WinForms.Modele
{
    /// <summary>
    /// Représente une absence d'un membre du personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant du personnel concerné par l'absence.
        /// </summary>
        public int idpersonnel { get; set; }

        /// <summary>
        /// Date de début de l'absence.
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
        /// Obtient la date de début de l'absence.
        /// </summary>
        public DateTime DateAbsence => datedebut;
        public int idabsence { get; set; }
    }


}
