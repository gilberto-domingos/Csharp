using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;

namespace DevLabs.Api.Interfaces;
    public interface ICar
    {
        Task<Car> CreateAsync(CarDto carDto);
        Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken);
    }

