namespace FileLogic
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GlossaryServiceModel : DbContext
    {
        public GlossaryServiceModel()
            : base("name=GlossaryAdminModel")
        {
        }

        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Word> Word { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Languages>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<Languages>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Languages)
                .HasForeignKey(e => e.MainLang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Languages>()
                .HasMany(e => e.Test1)
                .WithRequired(e => e.Languages1)
                .HasForeignKey(e => e.SecLang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Result)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Word)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Test)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
