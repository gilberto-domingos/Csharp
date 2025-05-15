namespace DevLabs.Api.Repositories;

public interface ICarChassiValidatorRepository
{
    Task<bool> CheckIfValidAsync(int chassi, CancellationToken cancelToken);
}