using MoviesCore;

namespace MoviesRepository
{
    public class MoviesRepository
    {
        private readonly MoviesDbContext _ctx;

        public MoviesRepository(MoviesDbContext ctx)
        {
            _ctx = ctx; 
        }

        public List<Movie> GetAllMovies()
        {
            return  _ctx.Movies.ToList();
        }
    }
}
