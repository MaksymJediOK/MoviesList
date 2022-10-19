using Microsoft.EntityFrameworkCore;
using MoviesCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRepository
{
    public class GenreRepository
    {
        private readonly MoviesDbContext _ctx;
        public GenreRepository(MoviesDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Genre> GetGenres()
        {
            return _ctx.Genres.ToList();
        }

    }
}
  
