namespace GestionAbsences.WinForms.Modele
{
    /// <summary>
    /// Représente un membre du personnel.
    /// </summary>
    public class Personnel
    {
        public int idpersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int idservice { get; set; }
    }
}
