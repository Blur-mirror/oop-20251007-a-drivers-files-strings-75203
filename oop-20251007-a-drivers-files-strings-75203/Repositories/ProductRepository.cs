using oop_20251007_a_drivers_files_strings_75203.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.Repositories
{
    public static class ProductRepository
    {
        // Returns a list of sample products
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "Laptop", "Electronics", 999.99, 12),
                new Product(2, "Gaming Mouse", "Accessories", 49.99, 50),
                new Product(3, "Headphones", "Audio", 89.99, 25),
                new Product(4, "Mechanical Keyboard", "Accessories", 129.99, 20),
                new Product(5, "Monitor", "Electronics", 199.99, 15)
            };

            return products;
        }
    }
}
