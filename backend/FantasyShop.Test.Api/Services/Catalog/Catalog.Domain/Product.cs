namespace Catalog.Domain;
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public List<string> Category { get; set; } = [];
    public string? Description { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
}
