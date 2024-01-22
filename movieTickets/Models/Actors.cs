using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Actors
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
    }
}
