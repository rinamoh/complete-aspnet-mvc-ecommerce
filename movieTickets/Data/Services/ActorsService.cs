using Microsoft.EntityFrameworkCore;
using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public  async Task AddAsync(Actors actors)
        {
          await _context.Actors.AddAsync(actors);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result); 
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actors>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actors> GetByIdAsync(int id)
        {
           var result=await _context.Actors.FirstOrDefaultAsync(n=> n.Id == id);
            return result;
        }

        public async Task<Actors> UpdateAsync(int id, Actors newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();  
            return newActor;
        }
    }
}
