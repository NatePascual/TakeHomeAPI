using System.Linq.Expressions;

namespace TakeHome.API.Infrastructures.Interfaces.Generics
{
    public interface IReadRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
