using oop_20251007_a_drivers_files_strings_75203.Models;
using oop_20251007_a_drivers_files_strings_75203.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.RunDemos
{
    public static class ProductDriver
    {
        public static void Run()
        {
            Console.WriteLine("ProductDriver.Run() called.\n");

            // Get product list from repository
            List<Product> products = ProductRepository.GetProducts();

            Console.WriteLine("List of Products:\n");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine("\nEnd of Product List.\n");
        }
    }
}
