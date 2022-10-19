using MoviesCore;

namespace MoviesRepository
{
    public class MovieRepository
    {
        private readonly MoviesDbContext _ctx;

        public MovieRepository(MoviesDbContext ctx)
        {
            _ctx = ctx; 
        }

        public List<Movie> GetAllMovies()
        {
            return  _ctx.Movies.ToList();
        }

    }
}
