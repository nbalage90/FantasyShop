using Catalog.API.Exceptions;
using Catalog.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services.UpdateProduct;

public record UpdateProductQuery(Guid Id, string Name, List<string> Category, string Description, string Image, decimal Price) : IRequest<UpdateProductResult>;
public record UpdateProductResult(bool IsSuccess);

public class UpdateProductHandler(ProductDbContext context) : IRequestHandler<UpdateProductQuery, UpdateProductResult>
{
    public async Task<UpdateProductResult> Handle(UpdateProductQuery query, CancellationToken cancellationToken)
    {
        bool isSuccess = true;

        var product = await context.Products.SingleOrDefaultAsync(product => product.Id == query.Id, cancellationToken);

        if (product == null)
            throw new ProductNotFoundException(query.Id);

        product.Name = query.Name;
        product.Category = query.Category;
        product.Description = query.Description;
        product.Image = query.Image;
        product.Price = query.Price;

        try
        {
            context.Update(product);
            await context.SaveChangesAsync(cancellationToken);
        }
        catch (ArgumentNullException)
        {
            isSuccess = false;
        }

        return new UpdateProductResult(isSuccess);
    }
}
