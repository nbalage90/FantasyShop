namespace FantasyShop.Test.Api.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> Get(int? count = null);
    Task<T> GetById(Guid id);
}
