namespace Catalog.Domain;
public class Category
{
    public Category()
    {
        this.Products = [];
    }

    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<Guid> ProductIds { get; set; } = [];
    public ICollection<Product> Products { get; set; }
}
