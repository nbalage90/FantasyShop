using Catalog.Data;
using Catalog.Domain;
using Catalop.API.Models;
using Mapster;
using MediatR;

namespace Catalog.API.Services.CreateProduct;

public record CreateProductQuery(string Name, List<string> Category, string Description, string Image, decimal Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductHandler(ProductDbContext context) : IRequestHandler<CreateProductQuery, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductQuery query, CancellationToken cancellationToken)
    {
        var newProductDto = new ProductDto
        {
            Name = query.Name,
            Category = query.Category,
            Description = query.Description,
            Image = query.Image,
            Price = query.Price,
        };

        var newProduct = newProductDto.Adapt<Product>();

        await context.Products.AddAsync(newProduct, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(newProductDto.Id);
    }
}
