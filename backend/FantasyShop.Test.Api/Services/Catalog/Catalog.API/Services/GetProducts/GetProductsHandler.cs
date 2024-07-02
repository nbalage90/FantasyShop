using Catalog.Data;
using Catalop.API.Models;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services.GetProducts;

public record GetProductsQuery(int? PageNumber = 1, int? PageSize = 10) : IRequest<GetProductsResult>;
public record GetProductsResult(IEnumerable<ProductDto> Products);

public class GetProductsHandler(ProductDbContext context) : IRequestHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var prodList = context.Products.AsQueryable();
        if (query.PageSize != null)
            prodList = prodList.Skip((query.PageNumber.Value - 1) * query.PageSize.Value)
                .Take(query.PageSize.Value);

        var products = (await prodList.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>();

        return new GetProductsResult(products);
    }
}
