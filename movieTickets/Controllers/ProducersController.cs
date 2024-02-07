using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;
using movieTickets.Data.Services;
using movieTickets.Models;

namespace movieTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        //we can get the producers data asynchronously :)
        public async Task<IActionResult> Index()

        {
            var allProducers = await _service.GetAllAsync() ;
            return View(allProducers);
        }

        //Get action method to view the details of a producer using id
        //producers/details/id
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id) ;
            if (producerDetails == null) return View("Notfound");
            return View(producerDetails);
        }
        //create method for producers
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Biography")]Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //edit method for producers
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Notfound");
            return View(producerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Biography")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            if (id == producer.Id) //check if the id coming from the url is equal to the id from the producer
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
            
        }
        //delete method for producers
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
