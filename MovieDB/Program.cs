using MovieDB;
using MovieDB.Models;


//main program
bool choice;
Console.WriteLine("Welcome to BlockBuster! We offer a wide selection of movies!");
choice = GenreOrTitle();
string title = "";
string genre = "";

if (choice)
{
    Console.WriteLine("Please enter the title that you would like to search for.");
    title = Console.ReadLine().ToLower().Trim();
    Movie.SearchByTitle(title);
}
else
{
    Console.WriteLine("Please enter the genre that you would like to search for.");
    genre = Console.ReadLine().ToLower().Trim();
    Movie.SearchByGenre(genre);
}








//List<Movie> selection = new List<Movie>()
//{
//    new Movie()
//    {Title = "Jurassic Park",
//    Genre =  "Scifi"
//    },   
//    new Movie()
//    {Title = "Basket Case",
//    Genre =  "Horror"
//    },
//    new Movie()
//    {Title = "The Matrix",
//    Genre = "Scifi"
//    },
//    new Movie()
//    {Title = "The Godfather",
//    Genre = "Crime"
//    },
//    new Movie()
//    {Title = "The Faculty", 
//    Genre = "Horror"
//    },
//    new Movie()
//    {Title = "Friday The 13th",
//    Genre = "Horror"
//    },
//    new Movie()
//    {Title = "Minions: The Rise of Gru",
//    Genre ="Comedy"
//    },
//    new Movie()
//    {Title = "Forrest Gump",
//    Genre =  "Drama"
//    },
//    new Movie()
//    {Title = "Shallow Hal", 
//    Genre = "Comedy"
//    },
//    new Movie()
//    {Title = "Shrek", 
//    Genre = "Animated"
//    },
//    new Movie()
//    {
//        Title = "A Silent Voice", 
//        Genre = "Anime"
//    }
//};

//MovieAdder(selection);

//methods
//static void MovieAdder(List<Movie> movies)
//{
//    using (MovieDBContext context = new MovieDBContext())
//    {
//        for (int i = 0; i < movies.Count; i++)
//        {
//            context.Movies.Add(movies[i]);
//        }
//        context.SaveChanges();
//    }
//}

static bool GenreOrTitle()
{
    bool result;
    result = Validator.Validator.GetContinue("Would you like to by title or by genre?", "title", "genre");
    return result;
}






