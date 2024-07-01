using Catalop.API.Models;
using Catalop.API.Repositories;
using MediatR;

namespace Catalog.API.Services.CreateProduct;

public record CreateProductQuery(string Name, List<string> Category, string Description, string Image, decimal Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductHandler(IRepository<ProductDto> repository) : IRequestHandler<CreateProductQuery, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductQuery query, CancellationToken cancellationToken)
    {
        var newProductId = await repository.CreateAsync(
            query.Name,
            query.Category,
            query.Description,
            query.Image,
            query.Price,
            cancellationToken);

        return new CreateProductResult(newProductId);
    }
}
