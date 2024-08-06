using Microsoft.EntityFrameworkCore;

namespace TesteAPI.Domains
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {

        }
        public ProductContext (DbContextOptions<ProductContext> options) : base(options) 
        {
            
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NOTE07-SALA19\\SQLEXPRESS; Initial Catalog=TesteDb; user id=sa; password=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
