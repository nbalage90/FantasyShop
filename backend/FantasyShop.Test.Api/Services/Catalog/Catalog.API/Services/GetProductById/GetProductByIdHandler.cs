using Catalop.API.Models;
using Catalop.API.Repositories;
using MediatR;

namespace Catalog.API.Services.GetProductById;

public record GetProductByIdQuery(Guid Id) : IRequest<GetProductByIdResult>;
public record GetProductByIdResult(ProductDto Product);

public class GetProductByIdHandler(IRepository<ProductDto> repository) : IRequestHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = await repository.GetByIdAsync(query.Id, cancellationToken);

        return new GetProductByIdResult(product);
    }
}
