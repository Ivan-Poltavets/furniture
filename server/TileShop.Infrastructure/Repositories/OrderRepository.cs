using Microsoft.EntityFrameworkCore;
using TileShop.Domain.Entities;
using TileShop.Domain.Repositories;

namespace TileShop.Infrastructure.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context)
        : base(context)
    {
        
    }

    public async Task<List<Order>> GetUserOrdersAsync(int userId)
    {
        var orders = await EntitySet
            .Where(order => order.UserId == userId)
            .Include(order => order.Details)
            .ThenInclude(details => details.Product)
            .OrderByDescending(order => order.CreatedDate)
            .ToListAsync();

        return orders;
    }
}
