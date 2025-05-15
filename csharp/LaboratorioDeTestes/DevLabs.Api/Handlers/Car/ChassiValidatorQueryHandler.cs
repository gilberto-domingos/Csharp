using DevLabs.Api.Interfaces;
using DevLabs.Api.Queries.Car;
using MediatR;

namespace DevLabs.Api.Handlers.Car
{
    public class ChassiValidatorQueryHandler : IRequestHandler<ChassiValidadorQuery, bool>
    {
        private readonly ICarChassiValidator _validatorService;

        public ChassiValidatorQueryHandler(ICarChassiValidator validatorService)
        {
            _validatorService = validatorService;
        }

        public async Task<bool> Handle(ChassiValidadorQuery request, CancellationToken cancellationToken)
        {
            return await _validatorService.CheckIfValidAsync(request.Chassi, cancellationToken);
        }
    }
}
