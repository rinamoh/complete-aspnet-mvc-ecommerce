using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Actors
    {
        [Key]
        public int Id { get; set; }

        [Display (Name ="Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Biography { get; set; }

        //relations
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
