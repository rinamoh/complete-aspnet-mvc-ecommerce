using System.ComponentModel.DataAnnotations;

namespace movieTickets.Models
{
    public class ShoppingCartItem
    {
        [Key] 
        public int Id { get; set; }

        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; } //we are going to use it to clean up the db after an order goes through
    }
}
