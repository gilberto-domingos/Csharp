using DevLabs.Api.Commands.Car;
using DevLabs.Api.Interfaces;
using MediatR;

namespace DevLabs.Api.Handlers.Car
{
    public class AddCarCommandHandler : IRequestHandler<AddCarCommand, Entities.Car>
    {
        private readonly ICar _carService;

        public AddCarCommandHandler(ICar carService)
        {
            _carService = carService;   
        }

        public async Task<Entities.Car> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            return await _carService.CreateAsync(request.CarDto);
        }
    }
}