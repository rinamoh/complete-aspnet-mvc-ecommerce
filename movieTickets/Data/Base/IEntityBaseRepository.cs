using movieTickets.Models;
using System.Linq.Expressions;

namespace movieTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new() //it needs the ientitybase for the id ;)
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
