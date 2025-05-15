namespace DevLabs.Api.Interfaces;

public interface ICarChassiValidator
{
    Task<bool> CheckIfValidAsync(Guid id, CancellationToken cancelToken);
}