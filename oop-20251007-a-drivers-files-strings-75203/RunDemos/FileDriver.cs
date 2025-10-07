using oop_20251007_a_drivers_files_strings_75203.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.RunDemos
{
    public static class FileDriver
    {
        public static void Run()
        {
            Console.WriteLine("\nFileDriver.Run() called.\n");
            RunFileDemo();


        }

        public static void RunFileDemo()
        {
            FileDriver.WriteToTextFile("../../../output/demo.txt", "This is a demo file.");
            FileDriver.WriteMoviesToFile("../../../output/movies.txt", new List<string>());

        }
        public static void WriteToTextFile(string filePath, string content)
        {
            Console.WriteLine("\nFileDriver.RunFileDemo() called.\n");
            string[] lines = { "First line", "Second line", "Third line" };
            string fileToWrite = "../../../output/demo.txt";
            File.WriteAllLines(fileToWrite, lines);
            Console.WriteLine($"\nWrote to file: {fileToWrite}\n");
        }


        public static void WriteMoviesToFile(string filePath, List<string> movies)
        {
            Console.WriteLine("\nFileDriver.WriteMoviesToFile() called.\n"); 
            String[] list = Repositories.MovieRepository.GetAllMovies().Select(m => m.ToString()).ToArray();
            string fileToWrite = "../../../output/movies.txt";
            File.WriteAllLines(fileToWrite, list);
            Console.WriteLine($"\nWrote to file: {fileToWrite}\n");


        }

        public static void WriteProductsToFile(List<Product> products)
        {
            Console.WriteLine("FileDriver.WriteProductsToFile() called.\n");

            string folderPath = "../../../output";
            string filePath = Path.Combine(folderPath, "products.txt");

            // Make sure directory exists
            Directory.CreateDirectory(folderPath);

            // Convert products to strings
            List<string> lines = new List<string>();
            foreach (var product in products)
            {
                lines.Add(product.ToString());
            }

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Products written to: {filePath}");
        }






    }
}
