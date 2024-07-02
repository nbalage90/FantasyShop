using Catalog.Data;
using Catalop.API.Models;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services.GetProductsByCategory;

public record GetProductsByCategoryQuery(string Category) : IRequest<GetProductsByCategoryResult>;
public record GetProductsByCategoryResult(IEnumerable<ProductDto> Products);

public class GetProductsByCategoryHandler(ProductDbContext context) : IRequestHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
{
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        var products = context.Products.Where(product => product.Category.Contains(query.Category));

        var productDtos = (await products.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>();

        return new GetProductsByCategoryResult(productDtos);
    }
}
