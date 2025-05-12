using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Commands.Car
{
    public class AddCarCommand : IRequest<Entities.Car>
    {
        public CarDto CarDto { get; }

        public AddCarCommand(CarDto carDto)
        {
            CarDto = carDto;
        }
    }
}