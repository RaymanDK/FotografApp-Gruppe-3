namespace Webservice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FotografAppContext : DbContext
    {
        public FotografAppContext()
            : base("name=FotografAppContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<TypeOfUser> TypeOfUser { get; set; }
        public virtual DbSet<TypesOfPhotograph> TypesOfPhotograph { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Pictures)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfUser>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.TypeOfUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypesOfPhotograph>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.TypesOfPhotograph)
                .HasForeignKey(e => e.TypeOfId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
