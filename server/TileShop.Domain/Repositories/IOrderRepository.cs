using TileShop.Domain.Entities;

namespace TileShop.Domain.Repositories;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<List<Order>> GetUserOrdersAsync(int userId);
}
