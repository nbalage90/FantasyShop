using System.Diagnostics.CodeAnalysis;

namespace Catalog.API.Models;

public class CategoryDto : IEquatable<CategoryDto>, IEqualityComparer<CategoryDto>
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    public bool Equals(CategoryDto? other)
    {
        return this.Name == other?.Name;
    }

    public bool Equals(CategoryDto? x, CategoryDto? y)
    {
        return x?.Name == y?.Name;
    }

    public int GetHashCode([DisallowNull] CategoryDto obj)
    {
        return obj.Id.GetHashCode();
    }

    public override bool Equals(object obj) => Equals(obj as CategoryDto);

    public override int GetHashCode()
    {
        return GetHashCode(this);
    }
}
