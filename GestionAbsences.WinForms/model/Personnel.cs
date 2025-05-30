namespace GestionAbsences.WinForms.Modele
{
    /// <summary>
    /// Repr�sente un membre du personnel.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Identifiant unique du personnel.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Nom du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Pr�nom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Num�ro de t�l�phone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Adresse mail du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Identifiant du service auquel appartient le personnel.
        /// </summary>
        public int IdService { get; set; }
    }
}
