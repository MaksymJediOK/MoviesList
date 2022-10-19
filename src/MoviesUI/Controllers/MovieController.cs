using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;

namespace MoviesUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly MoviesDbContext dbContext;
        private readonly MovieRepository _moviesRepository;
        public MovieController(MoviesDbContext dbContext)
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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


    }
}
