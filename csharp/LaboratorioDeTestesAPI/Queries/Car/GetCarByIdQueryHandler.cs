using LaboratorioDeTestesAPI.Data;
using LaboratorioDeTestesAPI.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FudamentosTestes.Handlers;

internal sealed class GetCarByIdQueryHandler(ApiDbContext dbContext) : IRequestHandler<GetCarByIdQuery, CarDto?>
{
    public async Task<CarDto?> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
    {
        var car = await dbContext.Cars.SingleOrDefaultAsync(x => x.Id == request.CardId, cancellationToken: cancellationToken);
        return car is null ? null : new CarDto(car.Id, car.Name, car.Chassi);
    }
}