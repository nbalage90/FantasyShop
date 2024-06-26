using Catalog.Data;
using Catalop.API.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Catalop.API.Repositories;

public class ProductRepository(ProductDbContext context) : IRepository<ProductDto>
{
    private readonly ProductDbContext context = context;

    public async Task<IEnumerable<ProductDto>> GetAsync(int? count = null)
    {
        var prodList = context.Products.AsQueryable();
        if (count != null)
            prodList = prodList.Take(count.Value);

        return (await prodList.ToListAsync()).Adapt<IEnumerable<ProductDto>>();
    }

    public async Task<ProductDto> GetByIdAsync(Guid id)
    {
        return (await context.Products.AsQueryable().FirstOrDefaultAsync(product => product.Id == id)).Adapt<ProductDto>();
    }
}
