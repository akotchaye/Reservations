﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GESRESEntities : DbContext
    {
        public GESRESEntities()
            : base("name=GESRESEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commercial> Commercial { get; set; }
        public virtual DbSet<Gestionnaire> Gestionnaire { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Salle> Salle { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
