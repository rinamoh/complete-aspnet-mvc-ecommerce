using Microsoft.EntityFrameworkCore;
using movieTickets.Data.Base;
using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actors>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context)
        {
            
        }
     
    }
}
