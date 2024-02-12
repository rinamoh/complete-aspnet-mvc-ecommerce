using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace movieTickets.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie {  get; set; }

        //relation with order model
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public  Order Order { get; set; }
    }
}
