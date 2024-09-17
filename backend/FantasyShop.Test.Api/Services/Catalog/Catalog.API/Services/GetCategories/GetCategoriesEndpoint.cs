using Catalog.API.Models;

namespace Catalog.API.Services.GetCategories;

//public record GetCategoriesRequest();
public record GetCategoriesResponse(IEnumerable<CategoryDto> Categories);

public class GetCategoriesEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/categories", async (ISender sender) =>
        {
            var result = await sender.Send(new GetCategoriesQuery());
            var response = result.Adapt<GetCategoriesResponse>();
            return Results.Ok(response);
        });
    }
}
