using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteAPI.Domains
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid IdProduct {  get; set; } = Guid.NewGuid();

        [Column("Name", TypeName = "nvarchar(Max)")]
        public string? Name { get; set; }

        [Column("Price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } 
    }
}
