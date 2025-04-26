using LaboratorioDeTestesAPI.Interfaces;

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
    }
}
