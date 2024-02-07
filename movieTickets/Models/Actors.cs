using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using movieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Actors:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display (Name ="Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "FullName is required")]
       
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Biography { get; set; }

        //relations
        [ValidateNever] //added because it wasn't letting me add actors with actors movie relations when adding an actor in the form
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
