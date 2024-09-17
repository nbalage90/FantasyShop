using Catalog.API.Models;
using System.Collections;

namespace Catalog.API.Services.GetProducts;

public record GetProductsQuery(int? PageNumber = 1, int? PageSize = 10) : IQuery<GetProductsResult>;
public record GetProductsResult(IEnumerable<ProductDto> Products);

public class GetProductsHandler(CatalogDbContext context) : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var prodList = context.Products.AsQueryable();

        if (query.PageSize != null)
            prodList = prodList.Skip((query.PageNumber.Value - 1) * query.PageSize.Value)
                .Take(query.PageSize.Value);

        var products = (await prodList.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>().ToList();

        LoadCategories(products);

        return new GetProductsResult(products);
    }

    private void LoadCategories(IList<ProductDto> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
            var product = products[i];
            product.Categories = context.Categories.Where(c => product.CategoryIds.Contains(c.Id)).Adapt<IEnumerable<CategoryDto>>().ToList();
        }
    }
}
