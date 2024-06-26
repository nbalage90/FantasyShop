namespace Catalop.API.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAsync(int? count = null);
    Task<T> GetByIdAsync(Guid id);
}
