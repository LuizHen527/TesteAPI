using Microsoft.EntityFrameworkCore;

namespace TesteAPI.Domains
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options) : base(options) 
        {
            
        }

        public DbSet<Product> Product { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.IdProduct);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    IdProduct = 1,
                    Name = "Leite",
                    Price = 4,
                }
                ) ;
        }
    }
}
