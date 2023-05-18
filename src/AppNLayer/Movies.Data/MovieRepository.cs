using Movies.Entities;

namespace Movies.Data
{
    public class MovieRepository
    {
        public List<Movie> GetAll()
        {
            var movies = new List<Movie>();
            for (int i = 1; i <= 15; i++)
            {
                movies.Add(new Movie()
                {
                    MovieId = i,
                    Name = $"Movie #{i}",
                    ImageUrl = string.Empty
                });
            }

            return movies;
        }
    }
}