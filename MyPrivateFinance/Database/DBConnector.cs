using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyPrivateFinance
{
    public partial class DBConnector : DbContext
    {
        public DBConnector(): base("name=DBConnector")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payments>()
                .Property(e => e.Description)
                .IsFixedLength();
        }
    }
}
