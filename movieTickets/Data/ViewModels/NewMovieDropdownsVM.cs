using movieTickets.Models;

namespace movieTickets.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer>();
            Cinemas =new List<Cinema>();
            Actors = new List<Actors>();
        }
        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }    
        public List<Actors> Actors { get; set; }
    }
}
