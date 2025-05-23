using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;
using DevLabs.Api.Interfaces;
using DevLabs.Api.Repositories;
using Mapster;

namespace DevLabs.Api.Services
{
    internal sealed class CarService : ICar
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<Car> CreateAsync(CarDto carDto)
        {
            var car = carDto.Adapt<Car>();

            var createdCar = await _repository.AddAsync(car);
            return createdCar;
        }

        public async Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken)
        {
            return await _repository.GetByIdAsync(id, cancelToken);
        }
    }
}