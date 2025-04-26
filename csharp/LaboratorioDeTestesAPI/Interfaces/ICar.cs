namespace LaboratorioDeTestesAPI.Interfaces;


public interface ICar
{
    Task<bool> CheckIfValidAsync(Guid id, CancellationToken cancelToken);
}