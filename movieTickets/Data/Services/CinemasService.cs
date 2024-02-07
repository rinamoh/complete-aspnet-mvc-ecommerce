using movieTickets.Data.Base;
using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService 
    {
        public CinemasService(AppDbContext context) : base(context)
        {
                
        }
    }
}
