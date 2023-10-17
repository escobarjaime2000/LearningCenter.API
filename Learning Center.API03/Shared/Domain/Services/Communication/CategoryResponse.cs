using Learning_Center.API03.Learning.Domain.Models;

namespace Learning_Center.API03.Shared.Domain.Services.Communication;

public class CategoryResponse:BaseResponse<Category>
{
    public CategoryResponse(Category resource) : base(resource)
    {
    }

    public CategoryResponse(string message) : base(message)
    {
    }
}