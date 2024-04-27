using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TileShop.Application.Services.Interfaces;

namespace TileShop.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class OrdersController : BaseController
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUserOrders()
    {
        var orders = await _orderService.GetUserOrdersAsync(int.Parse(UserId));
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> DoCheckout()
    {
        var result = await _orderService.DoCheckoutAsync(int.Parse(UserId));
        return CreatedAtAction(nameof(DoCheckout), result);
    }
}
