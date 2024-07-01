using Catalog.Data;
using Catalog.Domain;
using Catalop.API.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Catalop.API.Repositories;

public class ProductRepository(ProductDbContext context) : IRepository<ProductDto>
{
    private readonly ProductDbContext context = context;

    public async Task<Guid> CreateAsync(string name, List<string> category, string description, string image, decimal price, CancellationToken cancellationToken)
    {
        var newProductDto = new ProductDto
        {
            Name = name,
            Category = category,
            Description = description,
            Image = image,
            Price = price,
        };

        var newProduct = newProductDto.Adapt<Product>();

        await context.Products.AddAsync(newProduct, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return newProduct.Id;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await context.Products.SingleAsync(product => product.Id == id, cancellationToken);

        try
        {
            context.Remove(product);
            await context.SaveChangesAsync(cancellationToken);
        }
        catch (ArgumentNullException)
        {
            return false; // TODO: custom exception
        }

        return true;
    }

    public async Task<IEnumerable<ProductDto>> GetAsync(int? pageSize, int? pageNumber, CancellationToken cancellationToken)
    {
        var prodList = context.Products.AsQueryable();
        if (pageSize != null)
            prodList = prodList.Skip((pageNumber.Value - 1) * pageSize.Value)
                .Take(pageSize.Value);

        return (await prodList.ToListAsync(cancellationToken)).Adapt<IEnumerable<ProductDto>>();
    }

    public async Task<ProductDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return (await context.Products.AsQueryable().FirstOrDefaultAsync(product => product.Id == id, cancellationToken)).Adapt<ProductDto>();
    }

    public async Task<bool> UpdateAsync(Guid id, string name, List<string> category, string description, string image, decimal price, CancellationToken cancellationToken)
    {
        if (id == Guid.Empty)
            return false; // TODO: custom exception

        var product = await context.Products.SingleOrDefaultAsync(product => product.Id == id, cancellationToken);

        if (product is null)
            return false; // TODO: custom exception

        product.Name = name;
        product.Category = category;
        product.Description = description;
        product.Image = image;
        product.Price = price;

        try
        {
            context.Update(product);
            await context.SaveChangesAsync(cancellationToken);
        }
        catch (ArgumentNullException)
        {
            return false; // TODO: custom exception
        }

        return true;
    }
}
