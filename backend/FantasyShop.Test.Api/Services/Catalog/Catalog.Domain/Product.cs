namespace Catalog.Domain;
public class Product
{
    public Product()
    {
        this.Categories = [];
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public required List<Guid> CategoryIds { get; set; } = [];
    public string? Description { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
}
