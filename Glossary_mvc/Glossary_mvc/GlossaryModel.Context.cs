﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Glossary_mvc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GlossaryModel : DbContext
    {
        public GlossaryModel()
            : base("name=GlossaryModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Word> Words { get; set; }
    }
}