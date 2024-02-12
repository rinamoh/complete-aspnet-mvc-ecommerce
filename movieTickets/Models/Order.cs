using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }

        //relations with order item model

        public List<OrderItem> OrderItems { get; set;}



    }
}
