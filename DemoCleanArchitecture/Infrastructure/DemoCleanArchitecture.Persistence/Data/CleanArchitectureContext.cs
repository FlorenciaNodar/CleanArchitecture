using DemoCleanArchitecture.Domain.Model;
using DemoCleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCleanArchitecture.Persistence.Data
{
    public partial class CleanArchitectureContext : DbContext
    {
        public CleanArchitectureContext()
        {
        }

        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Server=tcp:cleanarchitecturedemo.database.windows.net,1433;Initial Catalog=CleanArchitecture;Persist Security Info=False;User ID=sqladmin;Password=P@assword1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductType");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10);
            });
        }
    }
}
