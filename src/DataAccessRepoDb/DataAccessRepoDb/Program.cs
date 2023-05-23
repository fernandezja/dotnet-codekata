using DataAccessRepoDb.Entities;
using Microsoft.Data.SqlClient;
using RepoDb;
using System;
using System.Diagnostics.Metrics;

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


long count2;
using (var connection = new SqlConnection(connectionString))
{
    var sql = "SELECT COUNT(*) FROM [dbo].[Movie];";
    count2 = connection.ExecuteScalar<long>(sql);
}


Console.WriteLine($"Movies  count 2: {count2}");


//1: Insertar 10mil peliculas (o entidades de su negocio)
//Ejemplo "pelicula 123456789"

//Actualizar solo peliculas que terminan en "666" con "(XX)"
//"Pelicula ...666 (X)"
//Ejemplo 
//  ANTES: Pelicula 666  >>  Pelicula 666 (X)
//  ANTES: Pelicula 1666  >> Pelicula 1666 (X)
//  ANTES: Pelicula 2666  >> Pelicula 2666 (X)


Console.ReadKey();