using ExampleBlazorApp.Data;
using ExampleBlazorApp.Models;
using System.Collections.Immutable;

namespace ExampleBlazorApp.Services
{
    public class ProductService
    {
        private static ApplicationDbContext _context;

        public ProductService(ApplicationDbContext db)
        {
            _context = db;
        }

        //public static readonly List<Product> Products = new List<Product>()
        //{
        //    new()
        //    {
        //        Id = 1,
        //        Name = "All roads lead to Blazor Server",
        //        Description = "A tutorial book for Blazor Server technology",
        //        Price = 70
        //    },
        //    new()
        //    {
        //        Id = 2,
        //        Name = "All roads lead to Blazor WASM",
        //        Description = "A tutorial book for Blazor WASM technology.",
        //        Price = 70
        //    },
        //    new()
        //    {
        //        Id = 3,
        //        Name = "gRPC for Blazor WASM",
        //        Description = "A tutorial book for developing a backend for Blazor WASM technology.",
        //        Price = 100
        //    }
        //};

        public static List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
