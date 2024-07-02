using Catalog.API.Exceptions;
using Catalog.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services.DeleteProduct;

public record DeleteProductQuery(Guid Id) : IRequest<DeleteProductResult>;
public record DeleteProductResult(bool IsSuccess);

public class DeleteProductHandler(ProductDbContext context) : IRequestHandler<DeleteProductQuery, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductQuery query, CancellationToken cancellationToken)
    {
        var product = await context.Products.SingleOrDefaultAsync(product => product.Id == query.Id, cancellationToken);

        if (product == null)
            throw new ProductNotFoundException(query.Id);

        bool isSuccess;

        try
        {
            context.Remove(product);
            await context.SaveChangesAsync(cancellationToken);
            isSuccess = true;
        }
        catch (ArgumentNullException)
        {
            isSuccess = false; // TODO: custom exception
        }

        return new DeleteProductResult(isSuccess);
    }
}
