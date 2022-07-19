using System;
using System.Collections.Generic;

namespace MovieDB.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }

        //methods
        //searching by genre
        public static void SearchByGenre(string genre)
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                List<Movie> matchingGenre = context.Movies.Where(m => m.Genre.ToLower().Contains(genre)).ToList();
                foreach (Movie movie in matchingGenre)
                {
                    Console.WriteLine($"{movie.Title} is a {movie.Genre} type of film.");
                }
            }
        }
        //searching by title
        public static void SearchByTitle(string title)
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                List<Movie> matchingTitle = context.Movies.Where(m => m.Title.ToLower().Contains(title)).ToList();
                foreach (Movie movie in matchingTitle)
                {
                    Console.WriteLine($"{movie.Title} is a {movie.Genre} type of film.");
                }
            }
        }

    }
}
