using Catalop.API.Models;
using Catalop.API.Repositories;
using MediatR;

namespace Catalog.API.Services.UpdateProduct;

public record UpdateProductQuery(Guid Id, string Name, List<string> Category, string Description, string Image, decimal Price) : IRequest<UpdateProductResult>;
public record UpdateProductResult(bool IsSuccess);

public class UpdateProductHandler(IRepository<ProductDto> repository) : IRequestHandler<UpdateProductQuery, UpdateProductResult>
{
    public async Task<UpdateProductResult> Handle(UpdateProductQuery query, CancellationToken cancellationToken)
    {
        var isSuccess = await repository.UpdateAsync(query.Id, query.Name, query.Category, query.Description, query.Image, query.Price, cancellationToken);

        return new UpdateProductResult(isSuccess);
    }
}
