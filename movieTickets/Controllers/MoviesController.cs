using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;

namespace movieTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        //we can get the producers data asynchronously :)
        public async Task<IActionResult> Index()

        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n=> n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
