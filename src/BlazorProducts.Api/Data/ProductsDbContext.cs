using BlazorProducts.Api.Data.EntityConfigurations;
using BlazorProducts.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorProducts.Api.Data
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    }
}
