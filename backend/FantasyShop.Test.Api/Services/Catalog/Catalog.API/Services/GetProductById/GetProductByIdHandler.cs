namespace Catalog.API.Services.GetProductById;

public record GetProductByIdQuery(Guid Id) : IQuery<GetProductByIdResult>;
public record GetProductByIdResult(ProductDto Product);

public class GetProductByIdHandler(CatalogDbContext context) : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = (await context.Products.AsQueryable().FirstOrDefaultAsync(product => product.Id == query.Id, cancellationToken)).Adapt<ProductDto>();

        if (product == null)
            throw new ProductNotFoundException(query.Id);

        return new GetProductByIdResult(product);
    }
}
