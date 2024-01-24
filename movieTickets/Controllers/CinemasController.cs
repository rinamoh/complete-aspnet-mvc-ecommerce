using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;

namespace movieTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        //we can get the producers data asynchronously :)
        public async Task<IActionResult> Index()

        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
