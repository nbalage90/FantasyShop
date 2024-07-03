namespace Catalog.API.Services.CreateProduct;

public record CreateProductRequest(string Name, List<string> Category, string Description, string Image, decimal Price);
public record CreateProductResponse(Guid Id);

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, ISender sender) =>
        {
            var query = request.Adapt<CreateProductCommand>();

            var result = await sender.Send(query);

            var response = result.Adapt<CreateProductResponse>();

            return Results.Ok(response);
        })
        .WithName("Create Product")
        .Produces<CreateProductResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Creates a new Product")
        .WithDescription("Creates a new Product");
    }
}
