using Movies.Data;
using Movies.Entities;

namespace Movies.Business
{
    public class MovieBusiness
    {
        private MovieRepository _movieRepository;

        public MovieBusiness()
        {
            _movieRepository = new MovieRepository();
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}