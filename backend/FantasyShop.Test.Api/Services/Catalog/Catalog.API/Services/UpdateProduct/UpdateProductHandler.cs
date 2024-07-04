namespace Catalog.API.Services.UpdateProduct;

public record UpdateProductCommand(Guid Id, string Name, List<string> Category, string Description, string Image, decimal Price) : ICommand<UpdateProductResult>;
public record UpdateProductResult(bool IsSuccess);

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Category).NotEmpty();
        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price should be greater than 0.");
    }
}

public class UpdateProductHandler(ProductDbContext context) : ICommandHandler<UpdateProductCommand, UpdateProductResult>
{
    public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        bool isSuccess = true;

        var product = await context.Products.SingleOrDefaultAsync(product => product.Id == command.Id, cancellationToken);

        if (product == null)
            throw new ProductNotFoundException(command.Id);

        product.Name = command.Name;
        product.Category = command.Category;
        product.Description = command.Description;
        product.Image = command.Image;
        product.Price = command.Price;

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
