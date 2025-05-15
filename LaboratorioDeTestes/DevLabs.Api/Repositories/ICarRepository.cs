using DevLabs.Api.Entities;

namespace DevLabs.Api.Repositories;
    
public interface ICarRepository
{
    Task<Car> AddAsync(Car car);
    Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken);
}
