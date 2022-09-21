using ExampleBlazorApp.Models;

namespace ExampleBlazorApp.Services
{
    public class CartService
    {
        public List<Product> SelectedItems { get; set; } = new List<Product>();

        public void AddProductToCart(int productId)
        {
            var product = ProductService.Products.First(p => p.Id == productId);

            if(SelectedItems.Contains(product) is false)
            {
                SelectedItems.Add(product);
            }
        }
    }
}
