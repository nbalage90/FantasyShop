using BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(object id) : base($"Product with key of \'{id}\' was not found.")
    {
    }
}
