namespace Catalog.API.Services.DeleteProduct;

public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;
public record DeleteProductResult(bool IsSuccess);

public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(product => product.Id).NotEmpty();
    }
}

public class DeleteProductHandler(CatalogDbContext context) : ICommandHandler<DeleteProductCommand, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        var product = await context.Products.SingleOrDefaultAsync(product => product.Id == command.Id, cancellationToken);

        if (product == null)
            throw new ProductNotFoundException(command.Id);

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
