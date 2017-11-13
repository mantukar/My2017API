using Microsoft.EntityFrameworkCore;
using ProductsApi.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System;

namespace Products.Data
{
   public class ProductAPIContext:DbContext
    {

        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public ProductAPIContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelbuilder.Entity<Product>().ToTable("Product");
            modelbuilder.Entity<Product>().Property(s => s.Id).IsRequired();
            modelbuilder.Entity<Product>().Property(s => s.ProductCartDesc).IsRequired();
            modelbuilder.Entity<Product>().Property(s => s.ProductCartDesc).HasMaxLength(50).IsRequired();
            modelbuilder.Entity<Product>().Property(s => s.ProductStatus).HasDefaultValue(ProductStatus.Availble);
            

        }
    }
}
