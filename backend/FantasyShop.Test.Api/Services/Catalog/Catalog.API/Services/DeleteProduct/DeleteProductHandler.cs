using Catalop.API.Models;
using Catalop.API.Repositories;
using MediatR;

namespace Catalog.API.Services.DeleteProduct;

public record DeleteProductQuery(Guid Id) : IRequest<DeleteProductResult>;
public record DeleteProductResult(bool IsSuccess);

public class DeleteProductHandler(IRepository<ProductDto> repository) : IRequestHandler<DeleteProductQuery, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductQuery query, CancellationToken cancellationToken)
    {
        var isSuccess = await repository.DeleteAsync(query.Id, cancellationToken);

        return new DeleteProductResult(isSuccess);
    }
}
