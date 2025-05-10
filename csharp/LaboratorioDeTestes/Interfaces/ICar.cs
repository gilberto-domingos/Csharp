using LaboratorioDeTestes.Dtos;
using LaboratorioDeTestes.Entities;

namespace LaboratorioDeTestes.Interfaces
{
    public interface ICar
    {
        Task<bool> CheckIfValidAsync(Guid id, CancellationToken cancelToken);
        Task<Car> CreateAsync(CarDto carDto);
        Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken);
    }
}
