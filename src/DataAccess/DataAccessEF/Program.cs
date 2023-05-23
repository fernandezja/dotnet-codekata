
using DataAccess.Entities;
using DataAccessEF;

Console.WriteLine("Data Access with Entity Framework!");

var moviesCount = 0;

using (var context = new MoviesContext())
{
    moviesCount = context.Movies.Count();
}

Console.WriteLine($"Movies count: {moviesCount}");


using (var context = new MoviesContext())
{
    var query = from m in context.Movies
                where m.Name.Contains("Starwars")
                select new { NameMovie = m.Name };

    foreach (var item in query.ToList())
    {
        Console.WriteLine($"Movies: {item.NameMovie}");
    }
}


var movieStarwars2 = new Movie()
{
    Name = "Starwars 2",
    ImageUrl = "demo.jpg"
};

using (var context = new MoviesContext())
{
    context.Add(movieStarwars2);
    
    
    context.SaveChanges();

}


Console.WriteLine($"Fin...");
