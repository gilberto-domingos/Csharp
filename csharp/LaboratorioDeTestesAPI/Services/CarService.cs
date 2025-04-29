using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Interfaces;
using System;

namespace LaboratorioDeTestesAPI.Services
{
    internal sealed class CarChassiValidatorService : ICar
    {
        private readonly ICarRepository _repository;

        public CarChassiValidatorService(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CheckIfValidAsync(Guid id, CancellationToken cancelToken)
        {
            return await _repository.CheckChassiExistsAsync(id, cancelToken);
        }

        public async Task<Car> CreateAsync(CarDto carDto)
        {

            var car = new Car
            {
                Id = Guid.NewGuid(),
                Name = carDto.Name,
                Chassi = carDto.Chassi,

            };


            var createdCar = await _repository.AddAsync(car);
            return createdCar;
        }

        public async Task<Car?> GetByIdAsync(Guid id, CancellationToken cancelToken)
        {
            return await _repository.GetByIdAsync(id, cancelToken);
        }
    }
}
