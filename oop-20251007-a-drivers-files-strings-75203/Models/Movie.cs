using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings_75203.Models
{
    public class Movie
    {
        // Attributes (Fields/Properties)
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Constructor to initialize the Movie object
        public Movie(string title, string director, int year, string genre, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        // Override ToString() to display movie details nicely
        public override string ToString()
        {
            return $"Title: {Title}\nDirector: {Director}\nYear: {Year}\nGenre: {Genre}\nRating: {Rating}/10\n";
        }
    }
}
