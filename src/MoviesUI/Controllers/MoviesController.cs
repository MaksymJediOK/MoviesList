using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;
using System.Diagnostics;

namespace MoviesUI.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly MoviesDbContext dbContext;
        private readonly MoviesRepository.MoviesRepository _moviesRepository;
        public MoviesController(MoviesDbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        // GET: MovieController
        public ActionResult Index()
        {
            var MoviesWithEv = dbContext.Movies
                .Include(x => x.Genres)
                .Include(x => x.Directors)
                .ToList();

            return View(MoviesWithEv);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var movie = dbContext.Movies
                .Include(x => x.Directors)
                .Include(x => x.Actors)
                .Include(x => x.Genres)
                .FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Genres = new SelectList(dbContext.Genres.ToList());
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            //Genre newgenre = dbContext.Genres.FirstOrDefault(x => x.Id == genre.Id);
            //Movie newmovie = new Movie
            //{
            //    Title = movie.Title,
            //    Description = movie.Description,
            //    PosterPath = movie.PosterPath,
            //    Rating = movie.Rating,
            //    ReleaseYear = movie.ReleaseYear,
            //    Duration = movie.Duration,
            //    Genres = new List<Genre> { genre }
            //};
            dbContext.Add(movie);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Movies.Find(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Movies.Remove(dbContext.Movies.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
