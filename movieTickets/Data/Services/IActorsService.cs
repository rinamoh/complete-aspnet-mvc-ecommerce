using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actors>> GetAllAsync();
        Task<Actors> GetByIdAsync(int id);
        Task AddAsync(Actors actors);
       Task<Actors> UpdateAsync (int id, Actors newActor);
        Task DeleteAsync(int id);
    }
}
