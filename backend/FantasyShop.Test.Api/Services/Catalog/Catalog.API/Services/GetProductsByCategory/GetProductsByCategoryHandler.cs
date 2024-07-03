namespace Catalog.API.Services.GetProductsByCategory;

public record GetProductsByCategoryQuery(string Category) : IQuery<GetProductsByCategoryResult>;
public record GetProductsByCategoryResult(IEnumerable<ProductDto> Products);

public class GetProductsByCategoryHandler(ProductDbContext context) : IQueryHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
{
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        var products = context.Products.Where(product => product.Category.Contains(query.Category));

        var productDtos = (await products.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>();

        return new GetProductsByCategoryResult(productDtos);
    }
}
