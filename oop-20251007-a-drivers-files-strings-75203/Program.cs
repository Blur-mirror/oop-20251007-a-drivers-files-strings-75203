using oop_20251007_a_drivers_files_strings_75203.Models;
using oop_20251007_a_drivers_files_strings_75203.Repositories;
using oop_20251007_a_drivers_files_strings_75203.RunDemos; 

Console.WriteLine($"Welcome to {AppData.AppName} v{AppData.AppVersion} by {AppData.AppAuthor}!");

AppDriver.Run();
MovieDriver.Run();
FileDriver.Run();
StringDriver.Run();



ProductDriver.Run();

// Write products to file
List<Product> products = ProductRepository.GetProducts();
FileDriver.WriteProductsToFile(products);

Console.WriteLine("\nProgram completed successfully.");
Console.ReadLine();
