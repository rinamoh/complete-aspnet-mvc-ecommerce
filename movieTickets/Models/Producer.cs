using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using movieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required (ErrorMessage ="Picture is required")]
        
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Biography { get; set; }

        //relations
        [ValidateNever] // added becasue the creation of producers wasn't working , the create button wasn't redirecting to the list page
        public List<Movie> Movies { get; set; }
    }
}
