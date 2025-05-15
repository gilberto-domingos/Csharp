namespace DevLabs.Api.Interfaces;

public interface ICarChassiValidator
{
    Task<bool> CheckIfValidAsync(int chassi, CancellationToken cancelToken);
}