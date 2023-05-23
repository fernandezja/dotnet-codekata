using DataAccessRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;

Console.WriteLine("Data Access with RepoDB!");

string connectionString =
            "Persist Security Info=True;Initial Catalog=Movies;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

GlobalConfiguration
    .Setup()
    .UseSqlServer();

//Movies
IEnumerable<Movie> movies;

//ORM
using (var connection = new SqlConnection(connectionString))
{
    movies = connection.QueryAll<Movie>();
}

var count = movies.Count();

Console.WriteLine($"Movies count: {count}");


//Query
IEnumerable<Movie> moviesStarwars;
using (var connection = new SqlConnection(connectionString))
{
    moviesStarwars = connection.Query<Movie>(m => m.Name.Contains("Starwars"));
}

Console.WriteLine($"Movies Starwars count: {moviesStarwars.Count()}");

Console.ReadKey();