using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Interfaces
{
    public interface ICarRepository
    {
        Task<bool> CheckChassiExistsAsync(Guid id, CancellationToken cancelToken);
    }
}
