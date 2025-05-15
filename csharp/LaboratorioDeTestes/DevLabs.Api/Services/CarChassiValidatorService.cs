using DevLabs.Api.Dtos;
using DevLabs.Api.Exceptions;
using DevLabs.Api.Interfaces;
using DevLabs.Api.Repositories;

namespace DevLabs.Api.Services;

public class CarChassiValidatorService : ICarChassiValidator
{
    private readonly ICarChassiValidatorRepository _repository;

    public CarChassiValidatorService(ICarChassiValidatorRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<bool> CheckIfValidAsync(int chassi, CancellationToken cancelToken)
    {
        var isValidChassi = await _repository.CheckIfValidAsync(chassi, cancelToken);

        if (!isValidChassi)
            throw new InvalidChassiException($"Chassi [{chassi}] inválido!");

        return true;
    }

}