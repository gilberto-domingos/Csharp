using LaboratorioDeTestes.Entities;

public interface ICarRepository
{
    Task<bool> CheckChassiExistsAsync(Guid id, CancellationToken cancelToken);
    Task<Car> AddAsync(Car car);
    Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken);
}
