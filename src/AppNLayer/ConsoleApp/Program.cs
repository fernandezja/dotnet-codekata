// See https://aka.ms/new-console-template for more information
using Movies.Business;

Console.WriteLine("App N-Layer");

Console.WriteLine("Movies");

var movieBusiness = new MovieBusiness();

var movies = movieBusiness.GetAll();

foreach (var m in movies)
{
    Console.WriteLine($" |_ {m.Name}");
}


Console.ReadKey();