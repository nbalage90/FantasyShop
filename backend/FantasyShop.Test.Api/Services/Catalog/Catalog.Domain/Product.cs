﻿namespace Catalog.Domain;
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public List<string> Category { get; set; } = [];
    public string Description { get; set; } = default!;
    public string Image { get; set; } = default!;
    public decimal Price { get; set; }
}
