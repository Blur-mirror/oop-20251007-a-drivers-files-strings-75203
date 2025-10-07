using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.Models
{
    public class Product
    {
        // 5 attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(int id, string name, string category, double price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }

        // ToString() for readable output
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Category: {Category}, Price: €{Price}, Stock: {Stock}";
        }
    }
}
