using Catalog.Data;
using Catalop.API.Models;
using Mapster;

namespace Catalop.API.Repositories;

public class ProductRepository(ProductDbContext context) : IRepository<ProductDto>
{
    private readonly ProductDbContext context = context;

    public async Task<IEnumerable<ProductDto>> GetAsync(int? count = null)
    {
        var prodList = context.Products.AsQueryable();
        if (count != null)
            prodList = prodList.Take(count.Value);

        return prodList.ToList().Adapt<IEnumerable<ProductDto>>();
    }

    public async Task<ProductDto> GetByIdAsync(Guid id)
    {
        return context.Products.AsQueryable().FirstOrDefault(product => product.Id == id).Adapt<ProductDto>();
    }
}
