using LaboratorioDeTestesAPI.Data;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Handlers.Exceptions;
using LaboratorioDeTestesAPI.Interfaces;
using MediatR;

namespace FudamentosTestes.Handlers;

internal class AddCarCommandHandler(ICar carChassiValidatorService, ApiDbContext appDbContext)
    : IRequestHandler<AddCarCommand, CarDto>
{
    public async Task<CarDto> Handle(AddCarCommand request, CancellationToken cancellationToken)
    {
        // Generating Id
        var id = Guid.NewGuid();

        var isValidChassi = await carChassiValidatorService.CheckIfValidAsync(id, cancellationToken);

        if (!isValidChassi)
            throw new InvalidChassiException($"[{request.Nome}] chassi invalido!");

        var car = new Car(id, request.Nome);

        await appDbContext.Cars.AddAsync(car, cancellationToken);
        await appDbContext.SaveChangesAsync(cancellationToken);

        return new CarDto(car.Id, car.Name, car.Chassi);
    }
}