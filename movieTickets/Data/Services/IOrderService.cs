using movieTickets.Models;

namespace movieTickets.Data.Services
{
    public interface IOrderService
    {
        //add orders to db
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        //get orders from db
        Task <List<Order>> GetOdersByUserIdAndRoleAsync(string userId, string userRole);

    }
}
