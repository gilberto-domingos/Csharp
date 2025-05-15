using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Queries.Car;

internal record GetCarByIdQuery(Guid CardId) : IRequest<CarDto?>;