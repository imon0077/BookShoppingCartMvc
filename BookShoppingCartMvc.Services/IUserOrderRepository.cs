using BookShoppingCartMvc.Models;
namespace BookShoppingCartMvc.Services
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}