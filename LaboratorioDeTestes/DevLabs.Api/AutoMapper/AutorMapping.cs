using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;
using Mapster;

namespace DevLabs.Api.Mappings;

public static class AutorMapping
{
    public static void Register()
    {
        TypeAdapterConfig<Autor, AutorCriarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Autor, AutorEditarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Autor, AutorVinculoDto>.NewConfig().TwoWays();
    }
}