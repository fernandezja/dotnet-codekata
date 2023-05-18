using Movies.Entities;

namespace Movies.Data
{
    public class MovieRepository
    {
        public List<Movie> GetAll()
        {
            List<Movie> movies = EmulateFromDbDB();

            return movies;
        }

        public List<Movie> Search(string stringToSearch)
        {
            List<Movie> movies = EmulateFromDbDB();

            var query = from m in movies
                        where m.Name.Contains(stringToSearch)
                        select m;

            return query.ToList();
        }

        private static List<Movie> EmulateFromDbDB()
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