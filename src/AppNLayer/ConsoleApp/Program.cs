// See https://aka.ms/new-console-template for more information
using Movies.Business;

Console.WriteLine("App N-Layer");

Console.WriteLine("Movies GetAll");

var movieBusiness = new MovieBusiness();

var movies = movieBusiness.GetAll();

foreach (var m in movies)
{
    Console.WriteLine($" |_ {m.Name}");
}


Console.WriteLine("Movies Search");

var textToSearch = "11";
var movies2 = movieBusiness.Search(textToSearch);

Console.WriteLine($" >> {movies.Count} movies with textToSearch: {textToSearch}");

foreach (var m in movies2)
{
    Console.WriteLine($" |_ {m.Name}");
}




Console.ReadKey();