using Catalog.Domain;

namespace Catalog.API.Services.CreateProduct;

public record CreateProductCommand(string Name, List<Guid> Categories, string Description, string Image, decimal Price) : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Name).NotEmpty();
        RuleFor(product => product.Categories).NotEmpty();
        RuleFor(product => product.Price).GreaterThan(0).WithMessage("Price should be greater than 0.");
    }
}

public class CreateProductHandler(CatalogDbContext context) : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var newProductDto = new ProductDto
        {
            Name = command.Name,
            CategoryIds = command.Categories,
            Description = command.Description,
            Image = command.Image,
            Price = command.Price,
        };

        var newProduct = newProductDto.Adapt<Product>();

        await context.Products.AddAsync(newProduct, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(newProduct.Id);
    }
}
