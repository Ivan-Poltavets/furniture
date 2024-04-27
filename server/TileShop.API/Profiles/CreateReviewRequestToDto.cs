using AutoMapper;
using TileShop.API.Reviews.Requests;
using TileShop.Domain.Dtos;

namespace TileShop.API.Profiles;

public class CreateReviewRequestToDto : Profile
{
    public CreateReviewRequestToDto()
    {
        CreateMap<CreateReviewRequest, ReviewDto>();
    }
}
