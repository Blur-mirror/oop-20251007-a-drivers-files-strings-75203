using oop_20251007_a_drivers_files_strings_75203.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.RunDemos
{
    public static class MovieDriver
    {
        public static void Run()
        {
            Console.WriteLine("\nMovieDriver.Run() called. \n");
            ShowMovieDataFromRepository();

        }
        public static void ShowMovieData()
        {
            List<Movie> movies = new List<Movie>() 
            {
                new Movie("Inception", "Christopher Nolan", 2010, "Sci-Fi", 8.8),
                new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0),
                new Movie("Interstellar", "Christopher Nolan", 2014, "Sci-Fi", 8.6),
                new Movie("Parasite", "Bong Joon-ho", 2019, "Thriller", 8.5),
                new Movie("The Shawshank Redemption", "Frank Darabont", 1994, "Drama", 9.3)
            };

            // Display the list of movies
            Console.WriteLine("List of Movies:\n");

            foreach (var movie in movies)
            {
                // Each movie will use its ToString() method automatically
                Console.WriteLine(movie.ToString());
            }


        }

        public static void ShowMovieDataFromRepository()
        {
            // This method would interact with a MovieRepository class to fetch movie data
            // For demonstration, we'll assume such a repository exists and has a method GetAllMovies()
            var movies = Repositories.MovieRepository.GetAllMovies();
            Console.WriteLine("Movies from Repository:\n");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

    }
}
