using DevLabs.Api.Exceptions;
using DevLabs.Api.Interfaces;

namespace DevLabs.Api.Services;

public class CarChassiValidatorService : ICarChassiValidator
{
    private readonly ICarRepository _repository;

    public CarChassiValidatorService(ICarRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<bool> CheckIfValidAsync(Guid id, CancellationToken cancelToken)
    {
        var isValidChassi = await _repository.CheckChassiExistsAsync(id, cancelToken);
                
        if(!isValidChassi)
            throw new InvalidChassiException($"Chassi [{id}] chassi inválido!");

        return true;
    }
}