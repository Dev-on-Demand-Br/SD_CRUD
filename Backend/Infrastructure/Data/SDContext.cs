using Microsoft.EntityFrameworkCore;
using SD.Domain.Models;

namespace SD.Infrastructure.Data {
    public class SDContext : DbContext {
        public SDContext(DbContextOptions<SDContext> options) : base(options) { }


        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<CategoryModel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CategoryModel>()
                .Property(c => c.Code)
                .IsRequired();

            modelBuilder.Entity<CategoryModel>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();



            modelBuilder.Entity<ProductModel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ProductModel>()
                .Property(x => x.Sku)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Description)
                .HasMaxLength(300)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Price)
                .HasPrecision(12, 2)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Stock)
                .IsRequired();


            modelBuilder.Entity<ProductModel>()
                .HasOne(c => c.Category)
                .WithMany(d => d.Products)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
