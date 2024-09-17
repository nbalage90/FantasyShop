using Catalog.API.Models;

namespace Catalog.API.Services.GetCategories;

public record GetCategoriesQuery() : IQuery<GetCategoriesResult>;
public record GetCategoriesResult(IEnumerable<CategoryDto> Categories);

public class GetCategoriesHandler(CatalogDbContext context) : IQueryHandler<GetCategoriesQuery, GetCategoriesResult>
{
    public async Task<GetCategoriesResult> Handle(GetCategoriesQuery query, CancellationToken cancellationToken)
    {
        var categories = await context.Categories.ToListAsync(cancellationToken);
        var categoryDtos = categories.Adapt<IEnumerable<CategoryDto>>();
        return new GetCategoriesResult(categoryDtos);
    }
}
