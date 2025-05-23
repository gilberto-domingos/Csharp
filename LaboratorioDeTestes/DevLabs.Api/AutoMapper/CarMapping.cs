using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;
using Mapster;

namespace DevLabs.Api.Mappings;

public static class CarMapping
{
    public static void Register()
    {
        TypeAdapterConfig<Car, CarDto>.NewConfig().TwoWays();
    }
}