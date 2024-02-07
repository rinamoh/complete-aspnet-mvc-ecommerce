using movieTickets.Data.Base;
using movieTickets.Data.ViewModels;
using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues(); //define a new signiture 
        Task AddNewMovieAsync(NewMovieVM data);
    }
}
