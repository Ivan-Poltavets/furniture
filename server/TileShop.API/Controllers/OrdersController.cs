using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TileShop.API.Order.Responses;
using TileShop.Application.Services.Interfaces;
using TileShop.Domain.Dtos;

namespace TileShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : BaseController
{
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;

    public OrdersController(IOrderService orderService, IMapper mapper)
    {
        _orderService = orderService;
        _mapper = mapper;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetUserOrders()
    {
        var orders = await _orderService.GetUserOrdersAsync(int.Parse(UserId));
        return Ok(orders);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> DoCheckout()
    {
        var result = await _orderService.DoCheckoutAsync(int.Parse(UserId));
        return CreatedAtAction(nameof(DoCheckout), result);
    }

    [Authorize(Policy = "RequireOwner")]
    [HttpGet]
    [Route("average")]
    public IActionResult GetAverageOrderPrice()
    {
        var average = _orderService.GetAverageOrderPrice();
        return Ok(average);
    }

    [Authorize(Policy = "RequireOwner")]
    [HttpGet]
    [Route("total")]
    public IActionResult GetTotalOrder()
    {
        var total = _orderService.GetTotalOrder();
        return Ok(total);
    }

    [Authorize(Policy = "RequireOwner")]
    [HttpGet]
    [Route("count")]
    public IActionResult GetOrderCountByMonth()
    {
        var orders = _orderService.GetOrderCountForCurrentYearByMonth();
        return Ok(orders);
    }

    [Authorize(Policy = "RequireOwner")]
    [HttpGet]
    [Route("last")]
    public async Task<IActionResult> GetOrdersForLast30DaysAsync()
    {
        var orders = await _orderService.GetOrdersForLast30DaysAsync();
        var ordersResponse = _mapper.Map<List<OrderResponse>>(orders);
        
        var ordersData = JsonConvert.SerializeObject(ordersResponse, Formatting.Indented);
        var mimeType = "application/octet-stream";
        
        using(var memoryStream = new MemoryStream())
        {
            using(var streamWriter = new StreamWriter(memoryStream))
            {
                streamWriter.Write(ordersData);
                streamWriter.Flush();

                var fileContent = memoryStream.ToArray();
                return File(fileContent, mimeType, "orders.txt");
            }
        }
    }
}
