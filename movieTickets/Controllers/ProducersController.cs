using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;

namespace movieTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        //we can get the producers data asynchronously :)
        public async Task<IActionResult> Index()

        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
