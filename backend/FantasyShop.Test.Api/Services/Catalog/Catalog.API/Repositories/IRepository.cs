namespace Catalop.API.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAsync(int? pageSize, int? pageNumber, CancellationToken cancellationToken);
    Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<Guid> CreateAsync(string name, List<string> category, string description, string image, decimal price, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task<bool> UpdateAsync(Guid id, string name, List<string> category, string description, string image, decimal price, CancellationToken cancellationToken);
}
