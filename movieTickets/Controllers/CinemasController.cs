using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;
using movieTickets.Data.Services;
using movieTickets.Models;

namespace movieTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        //we can get the producers data asynchronously :)
        public async Task<IActionResult> Index()

        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //Get action method to view the details of a cinema using name
        //cimena/detail/
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("Notfound");
            return View(cinemaDetails);
        }
        //Create new cinema
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
        //edit method for cinema
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Notfound");
            return View(producerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
        }

        //delete method for cinemas
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Notfound");
            return View(producerDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Notfound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
