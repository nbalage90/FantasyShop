using Carter;
using Mapster;
using MediatR;

namespace Catalog.API.Services.UpdateProduct;

public record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, string Image, decimal Price);
public record UpdateProductResponse(bool IsSuccess);

public class UpdateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPut("/products", async (UpdateProductRequest request, ISender sender) =>
        {
            var query = request.Adapt<UpdateProductQuery>();

            var result = await sender.Send(query);

            var response = result.Adapt<UpdateProductResponse>();

            return Results.Ok(response);
        });
    }
}
