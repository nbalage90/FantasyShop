using Catalog.API.Models;

namespace Catalop.API.Models;

public class ProductDto
{
    public ProductDto()
    {

    }

    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public List<Guid> CategoryIds { get; set; } = new();
    public List<CategoryDto> Categories { get; set; } = new();
    public string Description { get; set; } = default!;
    public string Image { get; set; } = default!;
    public decimal Price { get; set; }
}
