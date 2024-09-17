namespace Catalog.API.Services.GetProductsByCategory;

public record GetProductsByCategoryQuery(string CategoryName) : IQuery<GetProductsByCategoryResult>;
public record GetProductsByCategoryResult(IEnumerable<ProductDto> Products);

public class GetProductsByCategoryHandler(CatalogDbContext context) : IQueryHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
{
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        var categoryId = context.Categories.Single(category => category.Name == query.CategoryName).Id;
        var products = context.Products.Where(product => product.CategoryIds.Contains(categoryId));

        var productDtos = (await products.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>();

        return new GetProductsByCategoryResult(productDtos);
    }
}
