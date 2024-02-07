using movieTickets.Data.Base;
using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public class ProducersServices:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersServices(AppDbContext context) : base(context)
        {
                
        }
    }
}
