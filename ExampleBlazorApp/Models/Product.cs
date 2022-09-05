using System.ComponentModel.DataAnnotations;

namespace ExampleBlazorApp.Models
{
    public class Product
    {
        public int Id { get; set; } = 0;

        [StringLength(30), Required]
        public string Name { get; set; } = String.Empty;
        
        [StringLength(255)]
        public string Description { get; set; } = String.Empty;

        [Range(0, 100.00)]
        public decimal Price { get; set; } = 0;
    }
}
