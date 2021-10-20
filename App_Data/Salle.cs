//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet.Akotchaye.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salle()
        {
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int IdSalle { get; set; }
        public int IdUser { get; set; }
        public int IdGes { get; set; }
        public string NomSalle { get; set; }
        public int CapaciteSalle { get; set; }
        public decimal PrixSalle { get; set; }
        public string DescripSalle { get; set; }
        public bool IsActiveSalle { get; set; }
        public string EtatSalle { get; set; }
        public string AdrSalle { get; set; }
        public byte[] ImgSalle1 { get; set; }
        public byte[] ImgSalle2 { get; set; }
    
        public virtual Gestionnaire Gestionnaire { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}