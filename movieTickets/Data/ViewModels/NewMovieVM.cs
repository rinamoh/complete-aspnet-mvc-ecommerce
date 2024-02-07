using movieTickets.Data.Base;
using movieTickets.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movieTickets.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie name")]
        [Required (ErrorMessage ="Name is Required")]
       
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Name = "Price in Birr")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is Required")]
        public string ImageURL { get; set; }

        [Display(Name = "StartDate")]
        [Required(ErrorMessage = "StartDate is Required")]
        public DateTime StartDate { get; set; }


        [Display(Name = "EndDate")]
        [Required(ErrorMessage = "EndDate is Required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Movie category is Required")]
        public MovieCategory MovieCategory { get; set; }

        //relations

        [Display(Name = "Select an actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is Required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Cinema is Required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Movie Producer is Required")]

        public int ProducerId { get; set; }
        

    }
}
