using ExampleBlazorApp.Models;

namespace ExampleBlazorApp.Services
{
    public class CartService
    {
        public static List<ShoppingItem> SelectedItems { get; set; } = new List<ShoppingItem>();

        public static void RemoveFromCart(int productId)
        {
            SelectedItems.RemoveAll(x => x.Id == productId);
        }

        public void AddProductToCart(Product product)
        {
            if(ProductInCart(product) is false)
            {
                ShoppingItem item = new ShoppingItem();

                item.Product = product;
                item.PurchasePrice = product.Price;

                SelectedItems.Add(item);
            }
        }

        private bool ProductInCart(Product product)
        {
            foreach (ShoppingItem item in SelectedItems)
            {
                if (item.Product.Id == product.Id)
                {
                    item.Quantity++;
                    return true;
                }
            }
            return false;
        }
    }
}
