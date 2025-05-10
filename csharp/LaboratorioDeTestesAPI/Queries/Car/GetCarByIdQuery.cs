using LaboratorioDeTestesAPI.Dtos;
using MediatR;

namespace FudamentosTestes.Handlers;

internal record GetCarByIdQuery(Guid CardId) : IRequest<CarDto?>;