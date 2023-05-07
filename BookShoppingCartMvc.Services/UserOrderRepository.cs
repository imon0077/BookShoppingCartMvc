using BookShoppingCartMvc.DAL;
using BookShoppingCartMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMvc.Services
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ICartRepository _cartRepo;

        public UserOrderRepository(ApplicationDbContext db, ICartRepository cartRepo)
        {
            _db = db;
            _cartRepo = cartRepo;
        }

        public async Task<IEnumerable<Order>> UserOrders()
        {
            var userId = _cartRepo.GetUserId();

            var orders = await _db.Orders
                                  .Include(x => x.OrderStatus)
                                  .Include(x => x.OrderDetail)
                                    .ThenInclude(x => x.Book)
                                        .ThenInclude(x => x.Genre)
                                  .Where(x => x.UserId == userId)
                                  .ToListAsync();

            return orders;
        }

    }
}
