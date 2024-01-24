using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Details")]
        public string Description { get; set; }

        

        //relations
        public List<Movie> Movies { get; set; }
    }
}
