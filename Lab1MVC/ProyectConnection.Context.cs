﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1MVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Proyecto1LenguajesB53953Entities : DbContext
    {
        public Proyecto1LenguajesB53953Entities()
            : base("name=Proyecto1LenguajesB53953Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<App_User> App_User { get; set; }
        public virtual DbSet<Canton> Canton { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Experienced> Experienced { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
