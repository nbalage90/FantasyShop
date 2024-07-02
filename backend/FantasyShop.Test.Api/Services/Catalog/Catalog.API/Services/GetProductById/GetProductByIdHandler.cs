using Catalog.API.Exceptions;
using Catalog.Data;
using Catalop.API.Models;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services.GetProductById;

public record GetProductByIdQuery(Guid Id) : IRequest<GetProductByIdResult>;
public record GetProductByIdResult(ProductDto Product);

public class GetProductByIdHandler(ProductDbContext context) : IRequestHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = (await context.Products.AsQueryable().FirstOrDefaultAsync(product => product.Id == query.Id, cancellationToken)).Adapt<ProductDto>();

        if (product == null)
            throw new ProductNotFoundException(query.Id);

        return new GetProductByIdResult(product);
    }
}
