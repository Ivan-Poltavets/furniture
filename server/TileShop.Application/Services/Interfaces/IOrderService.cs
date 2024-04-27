using TileShop.Domain.Dtos;

namespace TileShop.Application.Services.Interfaces;

public interface IOrderService
{
    Task<List<OrderDto>> GetUserOrdersAsync(int userId);
    Task<OrderDto> DoCheckoutAsync(int userId);
}
