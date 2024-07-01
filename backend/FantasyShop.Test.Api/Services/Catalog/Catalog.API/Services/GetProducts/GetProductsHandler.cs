using Catalog.Domain;
using Catalop.API.Models;
using Catalop.API.Repositories;
using Mapster;
using MediatR;

namespace Catalog.API.Services.GetProducts;

public record GetProductsQuery(int? PageNumber = 1, int? PageSize = 10) : IRequest<GetProductsResult>;
public record GetProductsResult(IEnumerable<ProductDto> Products);

public class GetProductsHandler(IRepository<ProductDto> repository) : IRequestHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var products = await repository.GetAsync(query.PageSize, query.PageNumber, cancellationToken);

        return new GetProductsResult(products);
    }
}
