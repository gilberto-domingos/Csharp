using MediatR;

namespace DevLabs.Api.Queries.Car;

public record ChassiValidadorQuery(int Chassi): IRequest<bool>;