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
    
    public partial class Reservation
    {
        public int IdRes { get; set; }
        public int IdUser { get; set; }
        public int IdSalle { get; set; }
        public int Cli_IdUser { get; set; }
        public int IdClient { get; set; }
        public decimal MontantRes { get; set; }
        public string EtatRes { get; set; }
        public System.DateTime DatedebutRes { get; set; }
        public System.DateTime DatefinRes { get; set; }
        public bool IsvalidRes { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Salle Salle { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
