using System.ComponentModel.DataAnnotations;

namespace ExampleBlazorApp.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        [Range(1, 9)]
        public int Quantity { get; set; } = 1;

        [Range(1, 100.00)]
        public decimal PurchasePrice { get; set; } = 0;
    }
}
